﻿using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
using PureCloudPlatform.Client.V2.Extensions.Notifications;
using PureCloudPlatform.Client.V2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PureCloudPlatform.Client.V2.Tests
{
    [Timeout(70 * 1000)]
    public class SdkTests
    {
        private bool stop;

        string clientId = Environment.GetEnvironmentVariable("PURECLOUD_CLIENT_ID");
        string clientSecret = Environment.GetEnvironmentVariable("PURECLOUD_CLIENT_SECRET");
        string environment = Environment.GetEnvironmentVariable("PURECLOUD_ENVIRONMENT");

        UsersApi usersApi = new UsersApi();
        PresenceApi presenceApi = new PresenceApi();

        string userId;
        string userEmail;
        string userName = ".NET SDK Tester";
        string userDepartment = "Ministry of Testing";
        string userProfileSkill = "Testmaster";
        string busyPresenceId = "31fe3bac-dea6-44b7-bed7-47f91660a1a0";
        string availablePresenceId = "6a3af858-942f-489d-9700-5f9bcdcdae9b";

        public SdkTests()
        {
        }

        [Test, Order(0)]
        public void TraceBasicInformation()
        {
            Console.WriteLine($"PURECLOUD_ENVIRONMENT={environment}");
            Assert.IsNotEmpty(environment);
            Assert.IsNotNull(environment);

            Console.WriteLine($"PURECLOUD_CLIENT_ID={clientId}");
            Assert.IsNotEmpty(clientId);
            Assert.IsNotNull(clientId);

            Assert.IsNotEmpty(clientSecret);
            Assert.IsNotNull(clientSecret);

            userEmail = $"{Guid.NewGuid()}@{environment}";
            Console.WriteLine($"userEmail={userEmail}");
        }

        [Test, Order(1)]
        public void Authenticate()
        {
            PureCloudRegionHosts? region = getRegion(environment);
                if(region == null){ //Returned in the case of default value
                PureCloudPlatform.Client.V2.Client.Configuration.Default.ApiClient.setBasePath("https://api." + environment);
            }
            else {
                PureCloudRegionHosts regionval = region.GetValueOrDefault();
                PureCloudPlatform.Client.V2.Client.Configuration.Default.ApiClient.setBasePath(regionval);
            }
           
            PureCloudPlatform.Client.V2.Client.Configuration.Default.ApiClient.PostToken(clientId, clientSecret);

            Assert.IsNotEmpty(PureCloudPlatform.Client.V2.Client.Configuration.Default.AccessToken);
        }

        [Test, Order(2)]
        public void CreateUser()
        {
            var newUser = new CreateUser()
            {
                Name = userName,
                Email = userEmail,
                Password = Guid.NewGuid() + "!@#$1234asdfASDF"
            };

            var user = usersApi.PostUsersWithHttpInfo(newUser);

            userId = user.Data.Id;
            Assert.AreEqual(user.Data.Name, userName);
            Assert.AreEqual(user.Data.Email, userEmail);

            Console.WriteLine($"CorrelationId for PostUsersWithHttpInfo {user.CorrelationId}");
            Console.WriteLine($"Version for PostUsersWithHttpInfo {user.Data.Version}");
            Console.WriteLine($"Created user with ID {userId}");
        }

        [Test, Order(3)]
        public void UpdateUser()
        {
            var updateUser = new UpdateUser()
            {
                Department = userDepartment,
                Version = 1
            };

            var user = usersApi.PatchUser(userId, updateUser);

            Assert.AreEqual(user.Id, userId);
            Assert.AreEqual(user.Name, userName);
            Assert.AreEqual(user.Email, userEmail);
            Assert.AreEqual(user.Department, userDepartment);
        }

        [Test, Order(4)]
        public void SetProfileSkills()
        {
            var skills = usersApi.PutUserProfileskillsWithHttpInfo(userId, new List<string>() { userProfileSkill });

            Assert.AreEqual(skills.Data.Count, 1);
            Assert.AreEqual(skills.Data[0], userProfileSkill);
            Console.WriteLine($"CorrelationId for PutUserProfileskillsWithHttpInfo {skills.CorrelationId}");
        }

        [Test, Order(5)]
        public void TestNotifications()
        {
            var handler = new NotificationHandler();

            // Start the handler inside of the task to block this test until the notifications come in
            var tcs = new TaskCompletionSource<bool>();
            var busyReceived = false;
            var availableReceived = false;
            Task.Factory.StartNew(() =>
            {
                handler.NotificationReceived += (data) =>
                {
                    try
                    {
                        if (data.GetType() == typeof(NotificationData<PresenceEventUserPresence>))
                        {
                            var presence = (NotificationData<PresenceEventUserPresence>)data;

                            // Check to see what we got
                            if (presence.EventBody.PresenceDefinition.Id == availablePresenceId) availableReceived = true;
                            if (presence.EventBody.PresenceDefinition.Id == busyPresenceId) busyReceived = true;

                            // Complete the async task
                            if (busyReceived && availableReceived) tcs.SetResult(true);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Suppress this error that happens occasionally:
                        // An attempt was made to transition a task to a final state when it had already completed.
                    } 
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                };
            });

            // Register topic
            handler.AddSubscription($"v2.users.{userId}.presence", typeof(PresenceEventUserPresence));

            // Change presences
            presenceApi.PatchUserPresence(userId, "PURECLOUD", new UserPresence() { PresenceDefinition = new PresenceDefinition(busyPresenceId) });
            presenceApi.PatchUserPresence(userId, "PURECLOUD", new UserPresence() { PresenceDefinition = new PresenceDefinition(availablePresenceId) });

            // The getter for Result will block until the task has completed
            var result = tcs.Task.Result;

            // Assert that both worked
            Assert.AreEqual(busyReceived, true);
            Assert.AreEqual(availableReceived, true);
        }


        [Test, Retry(2), Order(6)]
        public void GetUser()
        {
                Thread.Sleep(6000);
                var user = usersApi.GetUserWithHttpInfo(userId, new List<string>() { "profileSkills" }, null, null);
                Assert.AreEqual(user.Data.Id, userId);
                Assert.AreEqual(user.Data.Name, userName);
                Assert.AreEqual(user.Data.Email, userEmail);
                Assert.AreEqual(user.Data.Department, userDepartment);
                Console.WriteLine($"CorrelationId for GetUserWithHttpInfo {user.CorrelationId}");
                Console.WriteLine($"Version for GetUserWithHttpInfo {user.Data.Version}");
                // Commented out until the issue with APIs to send the latest Version of the User is fixed.
                // Assert.IsNotNull(user.Data.ProfileSkills);
                // Assert.AreEqual(user.Data.ProfileSkills.Count, 1);
                // Assert.AreEqual(user.Data.ProfileSkills[0], userProfileSkill);
        }

        [Test, Order(7)]
        public void DeleteUser()
        {
            usersApi.DeleteUser(userId);
        }



        [SetUp]
        public void SetUp()
        {
            if (stop)
            {
                Assert.Inconclusive("Previous test failed");
            }
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                stop = true;
            }
        }
        public Nullable<PureCloudRegionHosts> getRegion(String str = "http://api.mypurecloud.com"){
            switch(str){
                case "mypurecloud.com":
                 return PureCloudRegionHosts.us_east_1;
                case "mypurecloud.ie":
                  return PureCloudRegionHosts.eu_west_1;
                case "mypurecloud.de":
                 return PureCloudRegionHosts.eu_central_1;
                case "mypurecloud.jp":
                 return PureCloudRegionHosts.ap_northeast_1;
                case "mypurecloud.com.au":
                 return PureCloudRegionHosts.ap_southeast_1;
                case "usw2.pure.cloud":
                 return PureCloudRegionHosts.us_west_2;
                case "cac1.pure.cloud":
                 return PureCloudRegionHosts.ca_central_1;
                case "apne2.pure.cloud":
                 return PureCloudRegionHosts.ap_northeast_2;
                case "euw2.pure.cloud":
                 return PureCloudRegionHosts.eu_west_2;
                case "aps1.pure.cloud":
                 return PureCloudRegionHosts.ap_south_1;
                case "use2.us-gov-pure.cloud":
                 return PureCloudRegionHosts.us_east_2;
                default:
                 Console.WriteLine("Value does not exist in enum using default val");
                 return null;
            }
        }
    }
}

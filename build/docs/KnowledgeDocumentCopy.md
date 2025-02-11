---
title: KnowledgeDocumentCopy
---
## ININ.PureCloudApi.Model.KnowledgeDocumentCopy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DocumentVariationId** | **string** | The variation of the document whose content was copied. | |
| **DocumentVersionId** | **string** | The version of the document whose content was copied. | |
| **SearchId** | **string** | The search that surfaced the document whose content was copied. | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the document. | [optional] |
| **SessionId** | **string** | Knowledge session ID. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContext**](KnowledgeConversationContext.html) | Conversation context information, if the document content is copied in the context of a conversation. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication.html) | The client application in which the document content was copied. | |
{: class="table table-striped"}



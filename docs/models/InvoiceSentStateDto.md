# PowerOfficeGoV2.Model.InvoiceSentStateDto
Represents the sent status of a sales order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DueDate** | **DateOnly** | The actual due date of the invoice or credit note. | [optional] [readonly] 
**Id** | **Guid** | The identifier of a sales order, outgoing invoice or outgoing credit note. | [optional] [readonly] 
**InvoiceDeliveryType** | **InvoiceDeliveryType** |  | [optional] 
**InvoiceNo** | **long** | The invoice number in number format. Available only for sent and posted invoices. | [optional] [readonly] 
**IsInvoiceBeingProcessed** | **bool** | A flag indicating whether the send request was successfully queued.  Will be true while the invoice is in transit.  After the invoice is delivered to the customer, IsInvoiceBeingProcessed will be set to false. | [optional] [readonly] 
**LastErrorMessage** | **string** | If invoice delivery fails this property will contain the last error message. | [optional] [readonly] 
**SentDateTimeOffset** | **DateTime** | The date this sales order was invoiced using Go. Will only be set if the order was successfully invoiced.  For integrations using the createAndSendInvoice request, this property having a value will confirm the delivery.  To retrieve any further invoice information, the OutgoingInvoices reporting endpoint should be used. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Model.SendInvoiceRequestPostDto
Post DTO for sending an invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeliveryType** | **SendInvoiceDeliveryType** |  | [optional] 
**EmailAddress** | **string** | The e-mail address used for delivery by e-mail.  If not set in the request, the customers default invoice email address will be used.  Email address will be used as a fallback delivery method and should be provided when using DeliveryType Auto. | [optional] 
**OverrideDueDate** | **DateTimeOffset** | Override the due date of the invoice.  If not set, the due date will be determined by the payment term of the sales order. | [optional] 
**VoucherDate** | **DateTimeOffset** | The date the invoice voucher will get. If not provided, the voucher date will be set to the current date.  This represents the date of the voucher and the document date of the invoice (ie. the invoice date). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


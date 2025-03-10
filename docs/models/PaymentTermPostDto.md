# PowerOfficeGoV2.Model.PaymentTermPostDto
DTO for creating payment terms.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreditDays** | **int** | The number of credit days for the payment term.  This define the number of days from an invoice is sent until it is due paid, if a sales order is invoiced using this payment term. | 
**IsActive** | **bool** | Value indicating whether this payment term is active. | [optional] 
**IsDefault** | **bool** | A value indicating if this payment term is the standard payment term set on the client.  Customers and sales orders will default inherit the standard payment term from the client invoice settings. | [optional] 
**Name** | **string** | The name of the payment term.  Max length is 128 characters. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


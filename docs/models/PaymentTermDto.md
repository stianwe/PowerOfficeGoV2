# PowerOfficeGoV2.Model.PaymentTermDto
The payment terms on the client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp of the created date of the payment term. UTC time. | [optional] [readonly] 
**CreditDays** | **int** | The number of credit days for the payment term.  This define the number of days from an invoice is sent until it is due paid, if a sales order is invoiced using this payment term. | [optional] 
**Id** | **long** | The identifier of the payment term.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited or deleted (PATCH or DELETE). | [optional] [readonly] 
**IsActive** | **bool** | Value indicating whether this payment term is active. | [optional] 
**IsDefault** | **bool** | A value indicating if this payment term is the standard payment term set on the client.  Customers and sales orders will default inherit the standard payment term from the client invoice settings. | [optional] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp of the last changed date of the payment term. UTC time. | [optional] [readonly] 
**Name** | **string** | The name of the payment term.  Max length is 128 characters. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


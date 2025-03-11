# PowerOfficeGoV2.Model.ClientPostDto
The available properties for the client organization settings, when creating new clients

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminUserId** | **Guid** | The identifier of the user that will be the client subscription administrator.  This user will automatically be added to the client as an administrator. | 
**MailAddress** | [**AddressPostDto**](AddressPostDto.md) |  | 
**ClientName** | **string** | The name of the client. | 
**ConversionDate** | **DateTimeOffset** | The start date of processing in Go.  The start day will always be set as the first day of the month provided, in the year provided.  The conversion date is the date the client started using Go.  Transactions can only be posted on or after this date.  The date can also be used to identify the date of the start-balance in Go, which will be this date -1 day.  If not set, the conversion date will default to January of the current year. | [optional] 
**FinancialYearEndMonth** | **Months** |  | [optional] 
**IsVatRegistered** | **bool** | Information on whether this this client is registered for Value Added Tax (VAT, norwegian: mva-registrert).  If false, vat is not applied to outgoing invoices. | [optional] 
**LegalName** | **string** | The legal name of the client.  The legal name is the formal name, and might differ from the marketing name. | 
**OrganizationNumber** | **string** | The organization number of the client. | 
**TemplateClientId** | **Guid** | The unique identifier of the template client to be used, if applicable.  If set, the new client will inherit the setup of general ledger accounts, activities, roles and Altinn settings.  If not provided, a standard Go template is used for the new client. | [optional] 
**UseVatCompensation** | **bool** | Information on whether this client are entitled to and uses vat compensation.  If true, vat codes with first letter notation K can be used when relevant for the client. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


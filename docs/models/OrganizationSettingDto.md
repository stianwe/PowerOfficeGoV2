# PowerOfficeGoV2.Model.OrganizationSettingDto
Properties related to Organization Settings in PowerOffice Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**DeliveryAddress** | [**Address**](Address.md) |  | [optional] 
**EmailAddress** | **string** | The e-mail address registered for the client. | [optional] [readonly] 
**Id** | **Guid** | The unique id the client have in PowerOffice Go. | [optional] [readonly] 
**InvoiceInboxEhf** | **bool** | Indicates whether the client is registered in ELMA and can receive incoming invoices by EHF. | [optional] [readonly] 
**InvoiceInboxEmail** | **bool** | Indicates whether the client have an e-mail set for receiving invoices by e-mail directly to the client. | [optional] [readonly] 
**InvoiceInboxEmailAddress** | **string** | The voucher e-mail of the client, if set.  Used only if invoiceInboxEmail is true.  This e-mail can be used to send vouchers (supplier invoices etc) to the client.  Often used by suppliers, if they are unable to send EHF invoices to this client.  For a client in production the address will always be in the form @faktura.poweroffice.net. | [optional] [readonly] 
**IsAgricultureClient** | **bool** | Indicates whether this client is an agriculture client and therefore uses NIBIO&#39;s agricultural chart of accounts requiring agricultural department on it&#39;s accounts. | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp of the last change. Last changed will update when the settings are created, or whenever the settings are changed. | [optional] [readonly] 
**LegalName** | **string** | The legal name of the client. The legal name is the formal name, and might differ from the marketing name. | [optional] [readonly] 
**MailAddress** | [**Address**](Address.md) |  | [optional] 
**MailAddressIsDeliveryAddress** | **bool** | A property indicating whether the client have set the delivery address equal to the mail address. If so, the content of the property deliveryAddress can be ignored. | [optional] [readonly] 
**Name** | **string** | The name of the client. | [optional] [readonly] 
**OrganizationNumber** | **string** | The organization number of the client. | [optional] [readonly] 
**PhoneNumber** | **string** | The phone number registered on the client. | [optional] [readonly] 
**WebsiteUrl** | **string** | The website url registered on the client. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


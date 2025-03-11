# PowerOfficeGoV2.Model.SupplierPostDto
The supplier post DTO contains only properties relevant to a supplier-object in Go that can be altered directly via POST-method in API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactGroupIds** | **List&lt;long&gt;** | The contact group ids the current contact is part of, or sets contact group id you want to add this contact to. | [optional] 
**CurrencyCode** | **string** | The standard currency code for the supplier.  Currencies active on the client can be queried using the AccountingSettings service.  Currency codes follow the ISO4217 standard.  Defaults to *NOK*. | [optional] 
**DateOfBirth** | **DateTimeOffset** | The date of birth of the supplier.   Relevant only if the supplier is a person (when isPerson is true). | [optional] 
**EmailAddress** | **string** | The (general) e-mail address registered for the supplier.  This field is validated for typos in POST/PATCH calls. | [optional] 
**ExternalImportReference** | **string** | The external import reference.  This field is not available in the GUI, but can be used by the integrating party to reference the external system.  The field must be unique within each class of Contacts (unique for customers, suppliers or employees).  Max length 50 characters. | [optional] 
**ExternalNumber** | **long** | The external number.  This field can be used to reference the supplier number in the external system, if the supplier numbers are not kept in 1:1 sync between Go and the external system.  The field is available in the GUI with the name \&quot;External Code\&quot;.  The field must be unique within each class of Contacts (unique for customers, suppliers or employees).  Note that in file imports to Go (including file imports using the ImportFile endpoint), this number has precedence over the supplier number.  I.e. when importing incoming invoices using a file, with the supplier number 20000 set in the file, the import will choose the supplier with ExternalNumber 20000 over the supplier with Number 20000. This is the case for file imports only. | [optional] 
**FirstName** | **string** | The first name of the supplier.   Relevant and required if the supplier is a person (i.e. isPerson is true) | [optional] 
**IsArchived** | **bool** | A value indicating whether this contact entity is/should be archived (set inactive)  Cannot be set if the contact have ledger balances (as either a customer or as a supplier). | [optional] 
**IsPerson** | **bool** | A value indicating whether this supplier is a person.  The setting apply to the contact entity, and is used to differentiate persons from companies.  If set true, the firstName and lastName should be set.  The default setting is false if not provided. | [optional] 
**LastName** | **string** | The last name of the supplier.  Relevant and required if the supplier is a person (i.e. isPerson is true) | [optional] 
**LegalName** | **string** | The legal name of the supplier.  The legal name is the official registered name of the company, as opposed to the name which might be a marketing name.  Relevant only if the supplier is a company (i.e. isPerson is false) | [optional] 
**MailAddress** | [**ContactAddressPostDto**](ContactAddressPostDto.md) |  | [optional] 
**Name** | **string** | The name of the supplier.  Relevant and required if the supplier is a company (i.e. isPerson is false) | [optional] 
**Number** | **long** | The supplier number.  The number will also represent the supplier ledger account, used for supplier ledger transactions.  When creating new suppliers and setting the number (as opposed to letting Go assign the next available number if left blank), the number must be within range of the supplier ledger numberseries that exist on the client in Go. | [optional] 
**OrganizationNumber** | **string** | The organization number of the supplier.  Relevant for suppliers that are companies (i.e. isPerson is false). | [optional] 
**Payout** | **bool** | A flag indicating whether invoices or credit notes from this supplier should be paid using remittance.  Default true, and if true a remittance draft will be created when voucher are posted in the journal entry. | [optional] 
**PhoneNumber** | **string** | The phone number of the supplier. | [optional] 
**SubLedgerNumberSeriesId** | **Guid** | The Id of the sub-ledger series this supplier belong in.  Relevant if the client have multiple supplier sub-ledger series, and if so highly relevant in POST calls if the integrating party does not set Number but lets Go assign the next available Number.  In such cases, Go will create the supplier in the default sub-ledger series, unless this property is set. | [optional] 
**WebsiteUrl** | **string** | The url to the suppliers website. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


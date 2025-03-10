# PowerOfficeGoV2.Model.VatSettingsDto
The Vat Settings DTO contains all properties relevant to VAT settings in

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlternativeVatPeriod** | **VatPeriodType** |  | [optional] 
**AlternativeVatReturnFromYear** | **int** | The year the client wants to start reporting additional vat returns. Relevant only if ReportAlternativeVatReturn is true. | [optional] [readonly] 
**AlternativeVatReturnType** | **VatReturnType** |  | [optional] 
**IsVatRegistered** | **bool** | Information on whether this this client is registered for Value Added Tax (VAT, norwegian: mva-registrert). If false, vat is not applied to outgoing invoices. | [optional] [readonly] 
**ReportAlternativeVatReturn** | **bool** | Information on whether this client report additional vat return for some departments. | [optional] [readonly] 
**ReportVatReturnManually** | **bool** | Information on whether this client report vat returns manually. True if the client are obliged to submit more than one type of vat return, are jointly registered or shall deliver vat return for vat compensation or reverse tax liability. | [optional] [readonly] 
**RoundingAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**RoundingAccountId** | **long** | The identifier of the rounding account number. | [optional] [readonly] 
**RoundingAccountNo** | **long** | The account used if rounding need to be posted when the principal vat report is sent.  When sending vat reports, the system vat accounts are emptied, but the account balances might have decimal precision and the vat reports do not.  If so, the rounding difference is posted to the rounding account. | [optional] [readonly] 
**UseVatCompensation** | **bool** | Information on whether this client are entitled to and uses vat compensation. If true, vat codes with first letter notation K can be used when relevant for the client. | [optional] [readonly] 
**VatAlternativeGrouping** | **VatAlternativeGrouping** |  | [optional] 
**VatNumber** | **string** | The vat number of the client. The vat number will equal the organization number for norwegian clients, but will relevant in vat terms only if the property isVatRegistered is true. | [optional] [readonly] 
**VatPeriod** | **VatPeriodType** |  | [optional] 
**VatReturnType** | **VatReturnType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


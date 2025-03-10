# PowerOfficeGoV2.Model.ClientBankAccountDto
Data transfer object for the client bank account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccountNumber** | **string** | The bank account number. | 
**BicSwift** | **string** | The BIC Swift code of the bank. | 
**CountryCode** | **string** | The ISO 3166-1 alfa-2 country code (two characters). | 
**ActiveIncomingPaymentService** | **bool** | A value indicating whether an incoming payment service integration is active on this bank account (typically an OCR service). | [optional] [readonly] 
**ActiveOutgoingPaymentServices** | **bool** | A value indicating whether an outgoing payment service (remittance service) integration is active on this bank account. | [optional] [readonly] 
**AgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**AllowOverdraft** | **bool** | A value indicating whether this bank account can be overdrawn (Norwegian: Kassekreditt). | [optional] 
**BankName** | **string** | The name of the bank. | [optional] 
**CreatedDateTimeOffset** | **DateTime** | The timestamp of the created date of the client bank account. UTC time. | [optional] [readonly] 
**CurrencyCode** | **string** | The standard code of the currency associated with the client bank account. | [optional] 
**GeneralLedgerAccountId** | **long** | The identifier of the general ledger account this bank account is associated with. | [optional] 
**GeneralLedgerAccountNo** | **long** | The general ledger account this bank account is associated with. | [optional] [readonly] 
**Id** | **long** | The identifier of the client bank account. This identifier is unique and assigned by PowerOffice Go when a new entity is saved. | [optional] [readonly] 
**IsActive** | **bool** | A value indicating whether this bank account is active. Inactive bank accounts disable the usage of that bank account in the GUI. | [optional] 
**IsClientTrustAccount** | **bool** | A value indicating whether this is a bank account containing client trust funds (example use cases: real estate brokers, lawyers). | [optional] 
**IsPrimaryAccount** | **bool** | A value indicating whether this is the primary account for the clients day to day operations (Norwegian: Driftskonto). | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp of the last change of the client bank account. UTC time. | [optional] [readonly] 
**OverdraftLimit** | **double** | The overdraft limit for the bank account, if set. Available only for bank accounts with overdraft enabled. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


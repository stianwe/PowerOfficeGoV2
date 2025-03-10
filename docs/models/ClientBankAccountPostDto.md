# PowerOfficeGoV2.Model.ClientBankAccountPostDto
Properties for creating a client bank account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccountNumber** | **string** | The bank account number. | 
**BicSwift** | **string** | The BIC Swift code of the bank. | 
**CountryCode** | **string** | The ISO 3166-1 alfa-2 country code (two characters). | 
**GeneralLedgerAccountId** | **long** | The identifier of the general ledger account this bank account is associated with. | 
**AllowOverdraft** | **bool** | A value indicating whether this bank account can be overdrawn (Norwegian: Kassekreditt). | [optional] 
**BankName** | **string** | The name of the bank. | [optional] 
**CurrencyCode** | **string** | The standard code of the currency associated with the client bank account. | 
**IsActive** | **bool** | A value indicating whether this bank account is active. Inactive bank accounts disable the usage of that bank account in the GUI. | [optional] 
**IsClientTrustAccount** | **bool** | A value indicating whether this is a bank account containing client trust funds (example use cases: real estate brokers, lawyers). | [optional] 
**OverdraftLimit** | **double** | The overdraft limit for the bank account, if set. Available only for bank accounts with overdraft enabled. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


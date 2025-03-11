# PowerOfficeGoV2.Model.FinancialSettingsDto
Financial settings on a client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConversionDate** | **DateTimeOffset** | The start date of processing in Go. This is the date the client started using Go. Transactions can only be posted on or after this date. The date can also be used to identify the date of the startbalance in Go, which will be this date -1 day | [optional] [readonly] 
**CurrencyCode** | **string** | The standard code of the currency the client use. As of now, only NOK is supported and this property will allways return NOK | [optional] [readonly] 
**CurrencyGainsAccountId** | **long** | The general ledger account id of the account used for posting currency gains (agio). More information of accounts can be retrieved using the GeneralLedgerAccounts endpoint. | [optional] [readonly] 
**CurrencyGainsAccountNo** | **long** | The general ledger account code of the account used for posting currency gains (agio). More information of accounts can be retrieved using the GeneralLedgerAccounts endpoint. | [optional] [readonly] 
**CurrencyLossAccountId** | **long** | The general ledger account id of the account used for posting currency losses (disagio). More information of accounts can be retrieved using the GeneralLedgerAccounts endpoint. | [optional] [readonly] 
**CurrencyLossAccountNo** | **long** | The general ledger account code of the account used for posting currency losses (disagio). More information of accounts can be retrieved using the GeneralLedgerAccounts endpoint. | [optional] [readonly] 
**FinancialYearEndMonth** | **Months** |  | [optional] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The last changed timestamp. Last changed will update when the settings are created, or whenever the settings are changed. | [optional] [readonly] 
**UseTrustAccountManagement** | **bool** | A value indication whether the client use the trust account management functionality in Go.  Default to false, as the funcionality is optional for law firms, brokers and other firms subject of trust accounts.  If true, the client have dedicated trust bank accounts, and use projects in account transactions. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


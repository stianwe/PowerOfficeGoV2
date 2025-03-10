# PowerOfficeGoV2.Model.TrialBalanceLineDto
TrialBalanceLine representing the balance on a General Ledger Account/> (Norwegian: Saldobalanse).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long** | The general ledger account id. The chart of accounts used on the client can be queried using the service GeneralLedgerAccount. | [optional] [readonly] 
**AccountName** | **string** | The name of the general ledger account. The chart of accounts used on the client can be queried using the service GeneralLedgerAccount. | [optional] [readonly] 
**AccountNo** | **long** | The general ledger account number. The chart of accounts used on the client can be queried using the service GeneralLedgerAccount. | [optional] [readonly] 
**AgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**Balance** | **double** | The balance amount for the Date provided. The balance includes transactions on that date. This amount is in the clients local currency. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


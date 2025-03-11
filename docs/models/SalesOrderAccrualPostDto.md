# PowerOfficeGoV2.Model.SalesOrderAccrualPostDto
Accrual (Norwegian: Periodisering) for sales order line

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BalanceAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**BalanceAccountId** | **long** | The account id of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).  Note that if BalanceAccountNo is set as well in the request, BalanceAccountId takes precedence and BalanceAccountNo is ignored. | [optional] 
**BalanceAccountNo** | **long** | The account number of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).  Note that if BalanceAccountId is set as well in the request, BalanceAccountId takes precedence and BalanceAccountNo is ignored. | [optional] 
**FromDate** | **DateTimeOffset** | The start date of the accrual. | [optional] 
**IsActive** | **bool** | Value indicating whether the accrual is active or not. | [optional] 
**ResultAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**ResultAccountId** | **long** | The account id of the result account used for the posting of the accrued revenue  (norwegian: resultatkonto benyttet for periodiseringen).  Note that if ResultAccountNo is set as well in the request, ResultAccountId takes precedence and ResultAccountNo is ignored. | [optional] 
**ResultAccountNo** | **long** | The account number of the result account used for the posting of the accrued revenue  (norwegian: resultatkonto benyttet for periodiseringen).  Note that if ResultAccountId is set as well in the request, ResultAccountId takes precedence and ResultAccountNo is ignored. | [optional] 
**ToDate** | **DateTimeOffset** | The end date of the accrual. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


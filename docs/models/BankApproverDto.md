# PowerOfficeGoV2.Model.BankApproverDto
Data transfer object for the bank approver.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccountId** | **long** | The identifier of the client bank account. | [optional] [readonly] 
**BankAccountNumber** | **string** | The client bank account number. | [optional] [readonly] 
**FromDate** | **DateOnly** | From date, inclusive.  The user will have access to approval on the account from this date. | [optional] [readonly] 
**Id** | **long** | The identifier of this bank approver (Bank Warrant). | [optional] [readonly] 
**IsActiveApprover** | **bool** | Indicates whether the user is an active approver for the bank account. | [optional] [readonly] 
**ToDate** | **DateOnly** | To date, inclusive.  The user will have access to approval on the account until and including this date.  Afterwards, the user is deactivated on the client. | [optional] [readonly] 
**UserId** | **Guid** | The identifier of the user. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


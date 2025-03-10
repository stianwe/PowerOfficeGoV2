# PowerOfficeGoV2.Model.BankApproverPostDto
Data transfer object for the bank approver POST method.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccountId** | **long** | The identifier of the bank account. | 
**UserId** | **Guid** | The identifier of the user. | 
**FromDate** | **DateOnly** | From date, inclusive.  The user will have access to approval on the account from this date. | [optional] 
**ToDate** | **DateOnly** | To date, inclusive.  The user will have access to approval on the account until and including this date.  Afterwards, the user is deactivated on the client. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


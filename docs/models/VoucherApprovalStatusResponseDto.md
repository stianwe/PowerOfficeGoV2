# PowerOfficeGoV2.Model.VoucherApprovalStatusResponseDto
Dto for available information returned after successfully posting a status update.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InApprovalWorkflow** | **bool** | Property indicating whether the journal entry voucher is sent to approval and is in the approval workflow. If true, the voucher cannot be deleted | [optional] 
**IsPosted** | **bool** | Property indicating whether the journal entry voucher is posted. If true, the voucher is posted an cannot be deleted via api or edited by a user in the GUI. If false, the voucher is unposted | [optional] 
**VoucherId** | **Guid** | A value that uniquely identifies the voucher. The Id is assigned by Go when the entry is created, and will persist when/if the voucher is posted. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


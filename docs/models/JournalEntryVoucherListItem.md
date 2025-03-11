# PowerOfficeGoV2.Model.JournalEntryVoucherListItem
Properties of journal entry vouchers list item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp of when the voucher object was created. | [optional] [readonly] 
**Id** | **Guid** | A value that uniquely identifies this voucher.  The Id is assigned by Go when the entry is created, and will persist when/if the voucher is posted. | [optional] [readonly] 
**InApprovalWorkflow** | **bool** | Indicates whether the journal entry voucher is sent to approval and is in the approval workflow.  If true, the voucher cannot be deleted. | [optional] [readonly] 
**IsCreatedByCurrentIntegration** | **bool** | Indicates whether the querying integration created the journal entry voucher, in which case the value is true. | [optional] [readonly] 
**IsPosted** | **bool** | Indicates whether the journal entry voucher is posted. If true, the voucher is posted an cannot be deleted via api or edited by a user in the GUI.  If false, the voucher is unposted.  If true, the voucher cannot be deleted. | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp of the last change of voucher. | [optional] [readonly] 
**OriginatedFromEhf** | **bool** | Indicates whether the journal entry voucher was received by EHF. If true, the journal entry voucher have an EHF XML file. | [optional] [readonly] 
**VoucherType** | **VoucherType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


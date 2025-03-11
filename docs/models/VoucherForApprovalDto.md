# PowerOfficeGoV2.Model.VoucherForApprovalDto
Dto for available information when listing vouchers ready for handling by integration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalVoucherType** | **ApprovalVoucherType** |  | [optional] 
**AvailableFromDateTimeOffset** | **DateTimeOffset** | The timestamp of when the voucher was made available to the integrating party. | [optional] [readonly] 
**Id** | **Guid** | A value that uniquely identifies this voucher.  The Id is assigned by Go when the entry is created, and will persist when/if the voucher is posted. | [optional] [readonly] 
**OriginatedFromEhf** | **bool** | A value indicating whether the voucher was received to Go by EHF. If true, the voucher have an xml file associated with it. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


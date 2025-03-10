# PowerOfficeGoV2.Model.VoucherDocumentationDto
A lightweight object of available voucher documentation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasEhf** | **bool** | Indicates whether there is an EHF (Electronic Trade Format) attached to the voucher. | [optional] [readonly] 
**HasImages** | **bool** | Indicates whether there are images attached to the voucher. | [optional] [readonly] 
**HasPdf** | **bool** | Indicates whether there is an PDF (Portable Document Format) attached to the voucher. | [optional] [readonly] 
**HasSalesOrderAttachments** | **bool** | Indicates whether there is sales order attachments on the voucher.  Note that this is only relevant for OutgoingInvoice and OutgoingCreditNote.  Use attachments-endpoint under SalesOrders to get the attachments. | [optional] [readonly] 
**IsImported** | **bool** | Indicates whether the voucher has been created by an integration via API.  We only allow adding documentation to imported vouchers. | [optional] 
**VoucherId** | **Guid** | The identifier of the voucher the documentation belongs to. | [optional] [readonly] 
**VoucherNo** | **long** | The voucher number. | [optional] [readonly] 
**VoucherType** | **VoucherType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


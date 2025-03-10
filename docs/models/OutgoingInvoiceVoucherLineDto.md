# PowerOfficeGoV2.Model.OutgoingInvoiceVoucherLineDto
properties available in an outgoing invoice voucher line

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long** | The id of the general ledger account for the line. | [optional] 
**Accrual** | [**AccrualBase1**](AccrualBase1.md) |  | [optional] 
**CurrencyAmount** | **double** | The amount on the line, in the currency specified by the currency code of the voucher. | [optional] 
**DepartmentId** | **long** | The department id of the line. | [optional] 
**Description** | **string** | The description of the line. | [optional] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the line. | [optional] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the line. | [optional] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the line. | [optional] 
**LocationId** | **long** | The id of the location dimension associated with the line. | [optional] 
**ProductId** | **long** | The product id associated with the line. | [optional] 
**ProjectId** | **long** | The id of the project associated with the line. | [optional] 
**Quantity** | **double** | The quantity dimension set on the line. | [optional] 
**QuantityOrdered** | **double** | The quantity ordered by the customer. | [optional] 
**UnitOfMeasureType** | **UnitOfMeasureType** |  | [optional] 
**VatId** | **int** | The id of the vat code used on the line. | [optional] 
**VatReturnSpecification** | **VatReturnSpecification** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


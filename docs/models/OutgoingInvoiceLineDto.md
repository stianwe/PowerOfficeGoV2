# PowerOfficeGoV2.Model.OutgoingInvoiceLineDto
Outgoing-invoice / Credit-note Line

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long** | The general ledger account id this invoice line was posted to. | [optional] [readonly] 
**AccountNo** | **long** | The general ledger account code this invoice line was posted to. | [optional] [readonly] 
**AgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**Allowance** | **double** | The percent of allowance/discount or allowance charge for this invoice line.  The value is between -1000 and 100 (reflects as -1000% or 100% in the GUI).  Negative percentage means the line is set with allowance charge.  Positive percentage means the line is set up with discount/allowance. | [optional] [readonly] 
**DepartmentCode** | **string** | The code of the department this invoice line is associated with. | [optional] [readonly] 
**DepartmentId** | **long** | The id of the department this invoice line is associated with. | [optional] [readonly] 
**Description** | **string** | The description set on this invoice line. | [optional] [readonly] 
**Dim1Code** | **string** | The code of the dimension 1 associated with this invoice line. | [optional] [readonly] 
**Dim1Id** | **long** | The id of the dimension 1 associated with this invoice line. | [optional] [readonly] 
**Dim2Code** | **string** | The code of the dimension 2 associated with this invoice line. | [optional] [readonly] 
**Dim2Id** | **long** | The id of the dimension 2 associated with this invoice line. | [optional] [readonly] 
**Dim3Code** | **string** | The code of the dimension 3 associated with this invoice line. | [optional] [readonly] 
**Dim3Id** | **long** | The id of the dimension 3 associated with this invoice line. | [optional] [readonly] 
**ExternalImportReference** | **string** | The external import reference for this invoice line.  This property can be set by integrations posting vouchers in Go or creating sales orders (invoice drafts), in order to reference the external system&#39;s invoice line and ensure a duplicate check (only one instance of the reference can exist within each invoice object).  Can be used to correlate/duplicate check transaction. | [optional] [readonly] 
**Id** | **long** | The identifier of this invoice line.  The id is assigned by Go when the invoice is created.  Note that on the line level, the invoice lines do not correspond with the sales order lines, if the invoice was an sales order created in Go.  This is because the lines are recreated in the process of sending and posting the information when an order is transformed to an invoice. | [optional] [readonly] 
**IsAccrued** | **bool** | Value indicating whether the net posted amount was accrued over time when the invoice voucher was posted in Go. If true, the accrual transactions is best retrieved by getting the accounttransactions of invoice voucher. | [optional] [readonly] 
**LineType** | **VoucherLineType** |  | [optional] 
**LocationCode** | **string** | The code of the location dimension associated with this invoice line. | [optional] [readonly] 
**LocationId** | **long** | The id of the location dimension associated with this invoice line. | [optional] [readonly] 
**NetAmount** | **double** | The net amount of this invoice line (vat exclusive).  This amount is presented in the currency used on the invoice (the currency given by the currencyCode). | [optional] [readonly] 
**NetPostedAmount** | **double** | The net posted amount of this invoice line (vat exclusive).  This amount is always presented in the client currency (NOK).  Will correspond with the netAmount and the normalized currencyExchangeRate of the invoice. | [optional] [readonly] 
**ProductCode** | **string** | The code of the product associated with this invoice line. | [optional] [readonly] 
**ProductId** | **long** | The id of the product associated with this invoice line. | [optional] [readonly] 
**ProductUnitCost** | **double** | The cost per unit of the product associated with this invoice line. | [optional] [readonly] 
**ProductUnitPrice** | **double** | The sales price per unit of the product associated with this invoice line. | [optional] [readonly] 
**ProjectCode** | **string** | The project code associated with this invoice line. | [optional] [readonly] 
**ProjectId** | **long** | The project id associated with is invoice line. | [optional] [readonly] 
**Quantity** | **double** | The quantity of this invoice line. | [optional] [readonly] 
**SellersReferenceEmployeeId** | **long** | The id of the employee set as the seller reference. | [optional] [readonly] 
**SellersReferenceEmployeeNo** | **long** | The number of the employee set as the seller reference. | [optional] [readonly] 
**SortOrder** | **int** | The sort order of the line.  Sort order start at 0.  The first line as viewed from the GUI, will have sortOrder &#x3D; 0. | [optional] [readonly] 
**TotalAmount** | **double** | The total amount of this invoice line (VAT inclusive).  This amount is presented in the currency used on the invoice (the currency given by the currencyCode). | [optional] [readonly] 
**TotalPostedAmount** | **double** | The total posted amount of this invoice line (VAT inclusive).  This amount is always presented in the client currency (NOK).  Will correspond with the totalAmount and the normalized currencyExchangeRate. | [optional] [readonly] 
**UnitOfMeasureCode** | **UnitOfMeasureType** |  | [optional] 
**VatAmount** | **double** | The VAT amount of this invoice line. | [optional] [readonly] 
**VatCode** | **string** | The VAT code used on this invoice line.  Standard codes in Go is based on the SAF-T standard. | [optional] [readonly] 
**VatId** | **int** | The VAT id for the VAT code used on this invoice line. | [optional] [readonly] 
**VatRate** | **double** | The VAT rate for the VAT code used on this invoice line. | [optional] [readonly] 
**VatReturnSpecification** | **VatReturnSpecification** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


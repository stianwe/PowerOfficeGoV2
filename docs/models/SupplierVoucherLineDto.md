# PowerOfficeGoV2.Model.SupplierVoucherLineDto
A supplier voucher line.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accrual** | [**AccrualBase**](AccrualBase.md) |  | [optional] 
**AgricultureDetails** | [**AgricultureDetails**](AgricultureDetails.md) |  | [optional] 
**CreatedDateTimeOffset** | **DateTime** | The timestamp of when the line was created. | [optional] [readonly] 
**CreditAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**CreditAccountId** | **long** | The id of the general ledger account or the subledger account to post the credit amount. | [optional] 
**CreditAccountType** | **AccountType** |  | [optional] 
**CreditContactId** | **long** | The contact ID of the credit account, relevant if CreditAccountId is set to a sub-ledger account. | [optional] [readonly] 
**CreditVatId** | **int** | The id of the vat code used for the credit entry. | [optional] 
**CreditVatReturnSpecification** | **VatReturnSpecification** |  | [optional] 
**CurrencyAmount** | **double** | The amount on the line, in the currency specified by the currency code of the voucher or the currency of the voucher line if available.  Gross amounts should be provided, along with the relevant vat code. | [optional] 
**DebitAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**DebitAccountId** | **long** | The id of the general ledger account or the subledger account to post the debit amount. | [optional] 
**DebitAccountType** | **AccountType** |  | [optional] 
**DebitContactId** | **long** | The contact ID of the debit account, relevant if DebitAccountId is set to a sub-ledger account. | [optional] [readonly] 
**DebitVatId** | **int** | The id of the vat code used for the debit entry. | [optional] 
**DebitVatReturnSpecification** | **VatReturnSpecification** |  | [optional] 
**DepartmentId** | **long** | The department Id. Will inherit department id from the voucher head if not specifically set on the line.  Department Id &#x3D; -1 means no department.  Departments can be queried and identified using the Department service. | [optional] 
**Description** | **string** | The description of the voucher line. | [optional] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the line.  Will inherit dim1Id from the voucher head if not specifically set on the line.  Dim1Id &#x3D; -1 means no dimension 1. | [optional] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the line.  Will inherit dim2Id from the voucher head if not specifically set on the line.  Dim2Id &#x3D; -1 means no dimension 2. | [optional] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the line.  Will inherit dim1Id from the voucher head if not specifically set on the line.  Dim3Id &#x3D; -1 means no dimension 3. | [optional] 
**Id** | **long** | A value that uniquely identifies this journal entry voucher line.  The Id is assigned by Go when the entry is created. | [optional] [readonly] 
**ItemDescription** | **string** | The suppliers item description, as stated in the ehf xml. Only available if the voucher was received by ehf, and  the ehf coding \&quot;itemize by product\&quot; is in use. | [optional] [readonly] 
**ItemName** | **string** | The suppliers item name, as stated in the ehf xml. Only available if the voucher was received by ehf, and the  ehf coding \&quot;itemize by product\&quot; is in use. | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp of the last change of the line. | [optional] [readonly] 
**LocationId** | **long** | The id of the location dimension associated with the line.  Will inherit locationId from the voucher head if not specifically set on the line.  LocationId &#x3D; -1 means no location. | [optional] 
**ProductId** | **long** | The product id associated with the line. | [optional] 
**ProjectId** | **long** | The id of the project associated with the line.  Will inherit projectId from the voucher head if not specifically set on the line.  ProjectId &#x3D; -1 means no project. | [optional] 
**Quantity** | **double** | The quantity dimension set on the line.  Usually associated with the product set on the line.  If the client is an agriculture client, the quantity is associated with the unit1 of the general ledger account. | [optional] 
**Quantity2** | **double** | The quantity2 dimension set on the line.  Relevant only for agriculture clients, where the quantity2 is associated with the unit2 of the general ledger account. | [optional] 
**SellersItemIdentification** | **string** | The suppliers item identification, as stated in the ehf xml. Only available if the voucher was received by ehf,  and the ehf coding \&quot;itemize by product\&quot; is in use. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


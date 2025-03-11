# PowerOfficeGoV2.Model.ManualVoucherLinePostDto
The lines of the manual voucher to be posted

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PostingDate** | **DateTimeOffset** | The posting date.  This is the date of effect in the accounting system for the Amount and CurrencyAmount (also the currency  conversion date used by Go if the currency rate was not set explicit when posted).  Always present on transactions. | 
**AccountId** | **long** | The id of the general ledger account or the subledger account to post the amount. | 
**CurrencyAmount** | **double** | The amount on the line, in the currency specified by the currency code of the voucher or the currency of the voucher line if available.  Gross amounts should be provided, along with the relevant vat code. The amount must be a positive or negative number not 0. | [optional] 
**CurrencyCode** | **string** | The currency code of the voucher line. Will inherit the currency code of the voucher head if not set.  The line currency amounts will be determined in the currency specified on the line. Currencies active on the  client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard. | [optional] 
**CurrencyExchangeRate** | **double** | The normalized currency exchange rate. Always base 1.                Relevant to set if the voucher line have a foreign currency with a specific currency exchange rate.  If not set, the field will inherit the rate in Go for the posting date set. The rates in Go are retrieved  from ECB via api. | [optional] 
**CustomMatchingReference** | **string** | The custom matching reference of the line. This property may be used for matching purposes on sub-ledger  accounts, where entries posted with a CustomMatchingReference will be matched immediately with existing entries  in the sub-ledger that have the same CustomMatchingReference and opposite amount (unless existing entries are  already matched out). | [optional] 
**DepartmentId** | **long** | The department Id. | [optional] 
**Description** | **string** | The description of the voucher line. | [optional] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the line. | [optional] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the line. | [optional] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the line. | [optional] 
**ExternalLineReference** | **string** | The external line reference associated with the line. This property can only be set using the api, in order  to reference the external system&#39;s line. Can be used to correlate/duplicate check transactions. | [optional] 
**LocationId** | **long** | The id of the location dimension associated with the line. | [optional] 
**ProductId** | **long** | The product id associated with the line. | [optional] 
**ProjectId** | **long** | The id of the project associated with the line. | [optional] 
**Quantity** | **double** | The quantity dimension set on the line.  Usually associated with the product set on the line.  If the client is an agriculture client, the quantity is associated with the unit1 of the general ledger account. | [optional] 
**Quantity2** | **double** | The quantity2 dimension set on the line.  Relevant only for agriculture clients, where the quantity2 is associated with the unit2 of the general ledger account. | [optional] 
**VatId** | **int** | The id of the vat code used for the credit entry. | 
**VatReturnSpecification** | **VatReturnSpecification** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


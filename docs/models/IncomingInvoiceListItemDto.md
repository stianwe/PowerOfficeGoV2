# PowerOfficeGoV2.Model.IncomingInvoiceListItemDto
Represents an incoming invoice list item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | **double** | The balance of the supplier ledger entry this invoice is related to (remaining amount to be paid), in the client currency.  If balance is greater than totalPostedAmount, the entry will have a match in the supplier ledger with at least one other entry with the opposite amount, and those entries will share the same matchId. If the balance is zero, the invoice is considered paid in the GUI. | [optional] [readonly] 
**BalanceLastChangedDateTimeOffset** | **DateTime** | The timestamp of the last change of the balance property.  This reflect the last changed timestamp of the supplier ledger entry this invoice relates to, and the match state of the sub-ledger entry.  Using this property as filtering is one way of retrieving the payment status of invoices. | [optional] [readonly] 
**Cid** | **string** | The cid number (norwegian: KID), if present. | [optional] [readonly] 
**ContractNo** | **string** | The contract number, if set on the invoice. | [optional] [readonly] 
**CreatedDateTimeOffset** | **DateTime** | The created timestamp of the invoice voucher. | [optional] [readonly] 
**CurrencyCode** | **string** | The standard currency code for the invoice. Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard. Defaults to *NOK*. | [optional] [readonly] 
**CurrencyExchangeRate** | **double** | The normalized currency exchange rate. Always base 1. | [optional] [readonly] 
**CustomMatchingReference** | **string** | The custom matching reference, if set. This property will only have value on entries created through the API or Import with CustomMatchingReference specified. This property is used for matching purposes in the supplier subledger account, where entries posted with a CustomMatchingReference will be matched immediately with existing entries in the subledger that have the same CustomMatchingReference and opposite amount (unless existing entries are already matched out). | [optional] [readonly] 
**DepartmentCode** | **string** | The code of the department for the invoice, if set. Note that this is the department set in the header of the invoice. The invoice costlines might specify other departments or no department. | [optional] 
**DepartmentId** | **long** | The id of the department, if departmentCode is set on the invoice. | [optional] 
**Dim1Code** | **string** | The code of the dimension 1 associated with the invoice, if set. Note that this is the dimension 1 set in the header of the invoice. The invoice costlines might specify other dimension 1 values or no dimension 1. Dimension 1-3 are customizable dimensions that can be defined and queried using the CustomDimension and CustomDimensionValue serivces. | [optional] [readonly] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the invoice, if dim1Code is set. | [optional] [readonly] 
**Dim2Code** | **string** | The code of the dimension 2 associated with the invoice. Note that this is the dimension 2 set in the header of the invoice. The invoice costlines might specify other dimension 2 values or no dimension 2. Dimension 1-3 are customizable dimensions that can be defined and queried using the CustomDimension and CustomDimensionValue serivces. | [optional] [readonly] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the invoice, if dim2Code is set. | [optional] [readonly] 
**Dim3Code** | **string** | The code of the dimension 3 associated with the invoice. Note that this is the dimension 3 set in the header of the invoice. The invoice costlines might specify other dimension 3 values or no dimension 3. Dimension 1-3 are customizable dimensions that can be defined and queried using the CustomDimension and CustomDimensionValue serivces. | [optional] [readonly] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the invoice, if dim3Code is set. | [optional] [readonly] 
**DueDate** | **DateOnly** | The due date of the invoice. | [optional] [readonly] 
**ExternalImportReference** | **string** | The ExternalImportReference, if set. This property can be set by integrations posting vouchers to Go, in order to reference the external system and ensure a duplicate check (only one instance of the reference can exist for the object type).  Can be used to correlate/duplicate check transactions.  Max 50 characters. | [optional] [readonly] 
**Id** | **Guid** | The identifier of the invoice and the posted voucher. The id is assigned by Go when the voucher is created, and is shared by all transactions within the same voucher (transactions have unique id&#39;s, but share the same property voucherId). | [optional] [readonly] 
**InvoiceNo** | **string** | The invoice number of the invoice. | [optional] [readonly] 
**IsReversed** | **bool** | Gets a flag indicating whether the invoice voucher have been reversed. If true, the invoice voucher have been reversed with a reversal voucher (nullifying the invoice voucher), and the invoice number can be reused. Only possible to reverse an invoice voucher using the IncomingInvoiceVoucher api, and only by the integration that created the invoice voucher originally using this api. | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** |     The timestamp of the last change of the invoice.  For posted invoices, no direct invoice information or related account transactions can change, so this property can be expected to be equal to the CreatedDateTimeOffset property. | [optional] [readonly] 
**LocationCode** | **string** | The code of the location dimension associated with the invoice.  Note that this is the location set in the header of the invoice. The invoice lines might specify other location values or no location. | [optional] [readonly] 
**LocationId** | **long** | The id of the location dimension associated with the invoice. | [optional] [readonly] 
**MatchId** | **long** | The match id of the supplier ledger entry this invoice relate to, if present. Available if the invoice have a match with other supplier ledger entries - typically payment transactions. Can be used with the SupplierLedger endpoint to retrive the matched transactions. | [optional] [readonly] 
**NetAmount** | **double** | The net amount of the invoice (vat exclusive). This amount is presented in the currency used on the invoice (the currency given by the currencyCode). | [optional] [readonly] 
**NetPostedAmount** | **double** | The net posted amount of the invoice (vat exclusive). This amount is always presented in the client currency (NOK). Will correspond with the netAmount and the normalized currencyExchangeRate. | [optional] [readonly] 
**ProjectCode** | **string** | The project code, if set on the invoice. Note that this is the project set in the header of the invoice. The invoice costlines might specify other projects or no project. Projects can be queried and identified using the Project service.  Max 50 characters. | [optional] [readonly] 
**ProjectId** | **long** | The project id, if projectCode is set. Projects can be queried and identified using the Project service. | [optional] [readonly] 
**PurchaseOrderReference** | **string** | The purchase order reference, if set. The property can be used to reference purchase order placed to the supplier. | [optional] [readonly] 
**RelatedInvoiceNo** | **string** | The related invoice number. Can be available on supplier credit notes. If available, this property will reference the original invoice being credited. | [optional] [readonly] 
**SupplierId** | **long** | The identifier of the supplier this invoice is related to. | [optional] [readonly] 
**SupplierNo** | **long** | The supplier number for the supplier this invoice relates to. Suppliers can be queried and identified using the Supplier service. | [optional] [readonly] 
**TotalAmount** | **double** | The total amount of the invoice (vat inclusive). This amount is presented in the currency used on the invoice (the currency given by the currencyCode). | [optional] [readonly] 
**TotalPostedAmount** | **double** | The total posted amount of the invoice (vat inclusive). This amount is always presented in the client currency (NOK). Will correspond with the totalAmount and the normalized currencyExchangeRate. | [optional] [readonly] 
**VoucherDate** | **DateOnly** | The date of the invoice voucher. This represents the date of the voucher and the document date of the invoice. | [optional] [readonly] 
**VoucherNo** | **long** | The voucher number of the invoice voucher. This is the voucher number assigned by Go when the voucher was posted.  Voucher numbers are assigned by Go in sequence.  Always present on invoices. | [optional] [readonly] 
**VoucherType** | **IncomingVoucherType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


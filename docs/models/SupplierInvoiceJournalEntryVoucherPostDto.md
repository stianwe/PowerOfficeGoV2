# PowerOfficeGoV2.Model.SupplierInvoiceJournalEntryVoucherPostDto
Properties available for creating a journal entry supplier invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cid** | **string** | The cid number (norwegian: KID), if applicable to the voucher. | [optional] 
**ClientBankAccountId** | **long** | The identifier of the client bank account used for payment/remittance.  Relevant if payout is true. If not set, the default client bank account will be used for any remittance. | [optional] 
**Comment** | **string** | Optional comment that will be shown in the journal entry history in Go.  Only new vouchers will get the comment as part of the initial history.  It is thus not possible to change the comment later, and it will not be returned in API-calls.  The comment text should be human-readable. If necessary, use newline characters (\\n) to format the text for better readability | [optional] 
**ContractNo** | **string** | The contract number of the supplier invoice. | [optional] 
**CurrencyAmount** | **double** | The total amount of the supplier voucher, in the currency specified by the currency code of the voucher. | [optional] 
**CurrencyCode** | **string** | The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard. | 
**CurrencyExchangeRate** | **double** | The normalized currency exchange rate.  Always base 1.  Relevant to set if the voucher have a foreign currency with a specific currency exchange rate.  If not set, the field will inherit the rate in Go for the voucher date set.  The rates in Go are retrieved from ECB via API. | [optional] 
**CurrencyRegistryCode** | **CurrencyRegistryCode** |  | [optional] 
**CurrencyRegistryText** | **string** | The currency registry text of the supplier invoice. | [optional] 
**DepartmentId** | **long** | The department Id of the voucher header.  The lines will inherit the department from the voucher head if not specified on the lines.  Departments can be queried and identified using the Department service. | [optional] 
**Description** | **string** | The description field of the voucher header. | [optional] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the voucher header.  The lines will inherit the dim1 from the voucher head if not specified on the lines. | [optional] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the voucher header.  The lines will inherit the dim2 from the voucher head if not specified on the lines. | [optional] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the voucher header.  The lines will inherit the dim3 from the voucher head if not specified on the lines. | [optional] 
**DueDate** | **DateTimeOffset** | The due date of the supplier invoice (i.e. when it is due paid).  Must be greater or equal to the voucher date. | [optional] 
**InvoiceNo** | **string** | The invoice number of the supplier invoice. | 
**LocationId** | **long** | The id of the location dimension associated with the voucher header.  The lines will inherit the location from the voucher head if not specified on the lines. | [optional] 
**PaymentDate** | **DateTimeOffset** | The suggested payment date if this voucher is to be subject of remittance.  Relevant if payout is set true.  If not set in POST or PATCH operations, the field will default to the due date of supplier invoices and the voucher date of supplier credit notes.  To remove any value from PaymentDate in PATCH, both PaymentDate and DueDate must be removed. | [optional] 
**PaymentOnHold** | **bool** | Property indicating whether the voucher remittance should be on hold.  Default false, and if true a remittance draft will be created when the voucher is posted, but with no payment date suggested - rather the state &#39;on hold&#39;. | [optional] 
**Payout** | **bool** | Property indicating whether the voucher should be paid using remittance.  Default true, and if true a remittance draft will be created when the voucher is posted. | [optional] 
**ProjectId** | **long** | The id of the project associated with the voucher header.  The lines will inherit the project from the voucher head if not specified on the lines. | [optional] 
**PurchaseOrderReference** | **string** | The purchase order reference. The property can be used to reference purchase order placed to the supplier. | [optional] 
**SupplierAccountId** | **long** | The id of the supplier subledger account. | [optional] 
**SupplierBankAccountId** | **long** | The identifier of the supplier bank account associated with the voucher. | [optional] 
**SupplierVoucherLines** | [**List&lt;SupplierVoucherLineDto&gt;**](SupplierVoucherLineDto.md) | The lines of the supplier invoice. | [optional] 
**VoucherDate** | **DateTimeOffset** | The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


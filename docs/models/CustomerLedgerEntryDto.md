# PowerOfficeGoV2.Model.CustomerLedgerEntryDto
Customer ledger entry DTO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **double** | The posted amount of the entry. Amount is always presented in the client currency.  Always present on transactions. | [optional] [readonly] 
**Balance** | **double** | The balance of the entry (remaining amount to be paid), in the client currency on the date (openItems) / toDate (statement).  If balance is less than amount, the entry will have a match with at least one other entry with the opposite amount, and those entries will share the same matchId. | [optional] [readonly] 
**Cid** | **string** | The cid number (norwegian: KID), if present.  Entries with the opposite amounts and the same cid will be matched on the sub-ledger account, if the client use cid and the items are not already matched out. | [optional] [readonly] 
**CreatedDateTimeOffset** | **DateTimeOffset** | The created timestamp.  This is the timestamp the transaction was created, and may differ from the timestamp of accounting effect for the transaction (ie the property PostingDate).  Always present on transactions. | [optional] [readonly] 
**CreatedFromImportJournalId** | **Guid** | The created from import journal identifier, if present.  Provided if this account transaction has been created in Go by an import. | [optional] [readonly] 
**CurrencyAmount** | **double** | The currency amount. Differs from Amount if the transaction was posted with a currency other than the client currency. | [optional] [readonly] 
**CurrencyCode** | **string** | The currency code. Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard. | [optional] [readonly] 
**CustomMatchingReference** | **string** | The custom matching reference set on the transaction. This property will only have value on entries created through the API or Import with CustomMatchingReference specified.  This property is used for matching purposes, where entries posted with a CustomMatchingReference will be matched immediately with existing entries in the sub-ledger that have the same CustomMatchingReference and opposite amount (unless existing entries are already matched out). | [optional] [readonly] 
**CustomerAccountNo** | **long** | The customer account number this sub-ledger entry is posted on.  CustomerAccountNo will also represent the Customer number.  Customers can be queried and identified using the Customer service. | [optional] [readonly] 
**CustomerExternalNo** | **long** | The external number of the customer of this sub-ledger entry.  An external number set on the customer is often used to reference the customer number in the external system, if the customer numbers are not kept in 1:1 sync between Go and the external system.  The field is available in the GUI with the name External Code.  Customers can be queried and identified using the Customer service. | [optional] [readonly] 
**CustomerId** | **long** | The id of the customer of this sub-ledger entry.  Customers can be queried and identified using the Customer service. | [optional] [readonly] 
**CustomerName** | **string** | The name of the customer of this sub-ledger entry.  Customers can be queried and identified using the Customer service. | [optional] [readonly] 
**DepartmentCode** | **string** | The department code. Available if the transaction was posted with department.  Departments can be queried and identified using the Department service. | [optional] [readonly] 
**DepartmentId** | **long** | The department id. Available if the transaction was posted with department.  Departments can be queried and identified using the Department service. | [optional] [readonly] 
**Dim1Code** | **string** | The code of the dimension 1 associated with the entry.  Dimension 1-3 are customizable dimensions that can be defined and queried using the CustomDimension- and CustomDimensionValue-services. | [optional] [readonly] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the account transaction. | [optional] [readonly] 
**Dim2Code** | **string** | The code of the dimension 2 associated with the account transaction.  Dimension 1-3 are customizable dimensions that can be defined and queried using the CustomDimension- and CustomDimensionValue-services. | [optional] [readonly] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the account transaction. | [optional] [readonly] 
**Dim3Code** | **string** | The code of the dimension 3 associated with the account transaction.  Dimension 1-3 are customizable dimensions that can be defined and queried using the CustomDimension- and CustomDimensionValue-services. | [optional] [readonly] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the account transaction. | [optional] [readonly] 
**DueDate** | **DateTimeOffset** | The due date of the entry. Relevant only for voucher types OutgoingInvoice and OutgoingCreditNote. The date represent when the amount is due to be paid by the customer. | [optional] 
**ExternalImportReference** | **string** | The ExternalImportReference, if set.  This property can be set by integrations posting vouchers in Go, in order to reference the external system and ensure a duplicate check when posting the voucher to Go (only one instance of the reference can exist).  Can be used to correlate/duplicate check transaction. | [optional] [readonly] 
**Id** | **long** | A value that uniquely identifies this (ledger) entry. The Id is assigned by Go when the transactions is posted in Go.  Always present on transactions. | [optional] [readonly] 
**InvoiceNo** | **string** | The invoice number, if the entry is an entry with the voucher type OutgoingInvoice or OutgoingCreditNote. | [optional] [readonly] 
**IsCreatedByCurrentIntegration** | **bool** | A value indicating whether this ledger entry is created by the integration currently communicating with the API.  Will be true for all entries that are created by the same integration user (same Application Key) as the integration currently authorized.  Can be used in filtering if only the current integration&#39;s entries are relevant to report (in simplified queries of payment status of invoices, for instance). | [optional] [readonly] 
**IsWriteOff** | **bool** | A value indicating whether this entry was created by the write off functionality in Go.  Such entries are not payments, but an accounting routine writing off an open item. | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp of the last change of this entry.  The accounting entry in itself cannot change, but the match state of the sub-ledger entry might change.  Using last changed filtering is one way of retrieving new matched items and as such the payment status of invoices. | [optional] [readonly] 
**LocationCode** | **string** | The code of the location dimension associated with the entry, if set. | [optional] [readonly] 
**LocationId** | **long** | The id of the location dimension associated with the entry, if location code is set. | [optional] [readonly] 
**MatchId** | **long** | The match identifier on the entry, if it is matched with one or more other entries. All sub-ledger entries that are matched together share the same matchId. | [optional] [readonly] 
**PaidFromBankAccount** | **string** | The bank account code the OCR payment was paid from.  Only present on entries of vouchertype incomingOcrGiro. | [optional] [readonly] 
**PostingDate** | **DateTimeOffset** | The posting date.  This is the date of effect in the accounting system for the Amount and CurrencyAmount (also the currency conversion date used by Go if the currency rate was not set explicit when posted).  Always present on transactions. | [optional] [readonly] 
**ProjectCode** | **string** | The project code. Available if the transaction was posted with project.  Projects can be queried and identified using the Project service. | [optional] [readonly] 
**ProjectId** | **long** | The project id. Available if the transaction was posted with project.  Projects can be queried and identified using the Project service. | [optional] [readonly] 
**VoucherDate** | **DateTimeOffset** | The date of the voucher.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for the voucher.  Always present on transactions. | [optional] [readonly] 
**VoucherId** | **Guid** | The voucher identifier.  The Id is assigned by Go when the voucher is created, and is shared by all transactions within the same voucher.  Always present on transactions. | [optional] [readonly] 
**VoucherNo** | **long** | The voucher number.  This is the voucher number assigned by Go when the voucher was posted.  Voucher numbers are assigned by Go in sequence.  Always present on transactions. | [optional] [readonly] 
**VoucherType** | **VoucherType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


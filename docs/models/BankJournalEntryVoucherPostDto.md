# PowerOfficeGoV2.Model.BankJournalEntryVoucherPostDto
Dto for posting bank journal entry voucher

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankJournalLines** | [**List&lt;BankJournalEntryVoucherLinePostDto&gt;**](BankJournalEntryVoucherLinePostDto.md) | The lines of the bank journal | [optional] 
**Comment** | **string** | Optional comment that will be shown in the journal entry history in Go.  Only new vouchers will get the comment as part of the initial history.  It is thus not possible to change the comment later, and it will not be returned in API-calls.  The comment text should be human-readable. If necessary, use newline characters (\\n) to format the text for better readability | [optional] 
**CurrencyCode** | **string** | The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard. | 
**DepartmentId** | **long** | The department Id of the voucher header.  The lines will inherit the department from the voucher head if not specified on the lines.  Departments can be queried and identified using the Department service. | [optional] 
**Description** | **string** | The description field of the voucher header. | [optional] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the voucher header.  The lines will inherit the dim1 from the voucher head if not specified on the lines. | [optional] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the voucher header.  The lines will inherit the dim2 from the voucher head if not specified on the lines. | [optional] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the voucher header.  The lines will inherit the dim3 from the voucher head if not specified on the lines. | [optional] 
**LocationId** | **long** | The id of the location dimension associated with the voucher header.  The lines will inherit the location from the voucher head if not specified on the lines. | [optional] 
**ProjectId** | **long** | The id of the project associated with the voucher header.  The lines will inherit the project from the voucher head if not specified on the lines. | [optional] 
**VoucherDate** | **DateTimeOffset** | The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


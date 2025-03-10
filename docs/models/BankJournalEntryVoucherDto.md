# PowerOfficeGoV2.Model.BankJournalEntryVoucherDto
Dto representing properties available on bank journal voucher.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankVoucherLines** | [**List&lt;BankJournalEntryVoucherLineDto&gt;**](BankJournalEntryVoucherLineDto.md) | The lines of the bank journal voucher | [optional] 
**CurrencyCode** | **string** | The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard. | [optional] 
**DepartmentId** | **long** | The department Id of the voucher header.  The lines will inherit the department from the voucher head if not specified on the lines.  Departments can be queried and identified using the Department service. | [optional] 
**Description** | **string** | The description field of the voucher header. | [optional] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the voucher header.  The lines will inherit the dim1 from the voucher head if not specified on the lines. | [optional] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the voucher header.  The lines will inherit the dim2 from the voucher head if not specified on the lines. | [optional] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the voucher header.  The lines will inherit the dim3 from the voucher head if not specified on the lines. | [optional] 
**Id** | **Guid** | A value that uniquely identifies this voucher.  The Id is assigned by Go when the entry is created, and will persist when/if the voucher is posted. | [optional] [readonly] 
**LocationId** | **long** | The id of the location dimension associated with the voucher header.  The lines will inherit the location from the voucher head if not specified on the lines. | [optional] 
**Pages** | [**List&lt;VoucherPage&gt;**](VoucherPage.md) | A collection of voucher pages associated with this voucher. | [optional] [readonly] 
**ProjectId** | **long** | The id of the project associated with the voucher header.  The lines will inherit the project from the voucher head if not specified on the lines. | [optional] 
**VoucherDate** | **DateOnly** | The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


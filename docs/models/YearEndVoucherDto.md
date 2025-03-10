# PowerOfficeGoV2.Model.YearEndVoucherDto
DTO for year end voucher type

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDateTimeOffset** | **DateTime** | The timestamp the year end voucher entity was created. | [optional] [readonly] 
**CurrencyCode** | **string** | The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard. | [optional] 
**Description** | **string** | The description field of the voucher header. | [optional] 
**ExternalImportReference** | **string** | The external import reference associated with the voucher. This property can be set by integrations creating  vouchers, in order to reference the external system and ensure a duplicate check (only one instance of the  reference can exist on the client). Can be used to correlate/duplicate check transactions. Guid&#39;s are  recommended, or other unique references. This property is only available using the api (not visible in the user  interface) | [optional] 
**Id** | **Guid** | A value that uniquely identifies this voucher. The Id is assigned by Go when the entry is created | [optional] [readonly] 
**ImportedVoucherNo** | **long** | The external voucher number. Can be used to reference the voucher number in the external system. The external  voucher number is visible in Go in various reports. | [optional] 
**IsReversed** | **bool** | Value indicating whether this voucher has been reversed. | [optional] [readonly] 
**SaftBatchId** | **string** | The SAF-T batch id. This is the ID of the batch in the system that transferred the voucher. Should be set if  this voucher is a batch voucher containing the entries of multiple vouchers in the external system. When this  voucher is exported to SAF-T, this property is transactions BatchID in the SAF-T file. The external systems  SAF-T export should set the same BatchId on all the transactions that are included in this Voucher to ensure  audit trail. Max length 35 characters. | [optional] 
**SaftSourceId** | **string** | The SAF-T source id. This is the ID of the system that generated the voucher. When this voucher is exported to  SAF-T, this property is mapped on the transactions SourceID in the SAF-T file. If the creating system is  required to export it&#39;s own SAF-T file, this source id should correspond with the SystemID in the SAF-T file of  the external system to ensure an audit trail. Max length is 35 characters. | [optional] 
**VoucherDate** | **DateOnly** | The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher. | [optional] 
**VoucherLines** | [**List&lt;YearEndVoucherLineDto&gt;**](YearEndVoucherLineDto.md) | The lines of the year end voucher | [optional] 
**VoucherNo** | **long** | The voucher number. This is the voucher number assigned by Go when the voucher was posted. Voucher numbers are  assigned by Go in sequence. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


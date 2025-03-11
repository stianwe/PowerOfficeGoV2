# PowerOfficeGoV2.Model.OutgoingInvoiceVoucherDto
properties available when posting an outgoing invoice voucher

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cid** | **string** | The cid number (norwegian: KID), if applicable to the outgoing invoice voucher. | [optional] 
**ContractNo** | **string** | The contract number reference of the outgoing invoice, if applicable. | [optional] 
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp of when the voucher object was created.. | [optional] [readonly] 
**CurrencyAmount** | **double** | The total amount of the outgoing voucher, in the currency specified by the currency code of the voucher. | [optional] 
**CurrencyCode** | **string** | The currency code of the outgoing invoice. | [optional] 
**CurrencyExchangeRate** | **double** | The normalized currency exchange rate. | [optional] 
**CustomMatchingReference** | **string** | The custom matching reference of the customer sub-ledger transaction. | [optional] 
**CustomerAccountId** | **long** | The id of the customer sub-ledger account. | [optional] 
**CustomerReference** | **string** | The customer reference (i.e. buyers reference) of the outgoing invoice. | [optional] 
**DeliveryAddress1** | **string** | The primary delivery address as it was set when the invoice was delivered. | [optional] 
**DeliveryAddress2** | **string** | The secondary delivery address as it was set when the invoice was delivered. | [optional] 
**DeliveryAddressCity** | **string** | The delivery address city as it was set when the invoice was delivered. | [optional] 
**DeliveryAddressCountryCode** | **string** | The delivery address country code as it was set when the invoice was delivered. | [optional] 
**DeliveryAddressZipCode** | **string** | The delivery address zip code as it was set when the invoice was delivered. | [optional] 
**DeliveryDate** | **DateTimeOffset** | The delivery date of the goods/services sold. | [optional] 
**DeliveryTermId** | **long** | The id of the delivery term associated with the outgoing credit note. | [optional] 
**DepartmentId** | **long** | The department Id of the voucher header and the customer sub-ledger transaction. Departments can be queried and identified using the Department service. | [optional] 
**Description** | **string** | The description of the customer sub-ledger transaction. | [optional] 
**Dim1Id** | **long** | The id of the dimension 1 associated with the voucher header and the customer sub-ledger transaction. | [optional] 
**Dim2Id** | **long** | The id of the dimension 2 associated with the voucher header and the customer sub-ledger transaction. | [optional] 
**Dim3Id** | **long** | The id of the dimension 3 associated with the voucher header and the customer sub-ledger transaction. | [optional] 
**DueDate** | **DateTimeOffset** | The due date of the outgoing invoice. | [optional] 
**ExternalImportReference** | **string** | The external import reference associated with the voucher.  This property can be set by integrations creating vouchers, in order to reference the external system and ensure  a duplicate check (only one instance of the reference can exist on the client). Can be used to correlate/duplicate  check transactions. Guid&#39;s are recommended, or other unique references. This property is only available using  the api (not visible in the user interface) | [optional] 
**Id** | **Guid** | A value that uniquely identifies this voucher. The Id is assigned by PowerOffice when the entry is created | [optional] [readonly] 
**ImportedOrderNo** | **long** | The imported order number. Can be used to reference the order number in the external system. The imported order  number is visible on the invoice reports in the PowerOffice GUI. | [optional] 
**ImportedVoucherNo** | **long** | The external voucher number. Can be used to reference the voucher number in the external system.  The external voucher number is visible in PowerOffice in various reports. | [optional] 
**InvoiceNo** | **string** | The invoice number of the outgoing invoice (invoice to a customer). Required property and must be unique for the client. | [optional] 
**IsReversed** | **bool** | Value indicating whether this voucher has been reversed. If an outgoing invoice voucher is reversed, the  invoiceNo and externalImportReference properties can be reused on a new voucher | [optional] 
**LocationId** | **long** | The id of the location dimension associated with the voucher header and the customer sub-ledger transaction. | [optional] 
**OutgoingInvoiceLines** | [**List&lt;OutgoingInvoiceVoucherLineDto&gt;**](OutgoingInvoiceVoucherLineDto.md) | outgoing invoice voucher lines | [optional] 
**ProjectId** | **long** | The id of the project associated with the voucher header and the customer sub-ledger. | [optional] 
**PurchaseOrderReference** | **string** | The purchase order reference. The property can be used to reference purchase orders placed by the customer. | [optional] 
**SaftSourceId** | **string** | The SAF-T source id. This is the ID of the system that generated the voucher. When this voucher is exported to  SAF-T, this property is mapped on the transactions SourceID in the SAF-T file. If the creating system is  required to export its own SAF-T file, this source id should correspond with the SystemID in the SAF-T file of  the external system to ensure an audit trail. Max length is 35 characters. | [optional] 
**SalesPersonEmployeeId** | **long** | The (employee) id of the sales person associated with the outgoing credit note. | [optional] 
**VoucherDate** | **DateTimeOffset** | The voucher date. This represents the date of the voucher, the posting date and the document date of the  outgoing invoice (invoice date). | [optional] 
**VoucherNo** | **long** | The voucher number. This is the voucher number assigned by PowerOffice when the voucher was posted. Voucher  numbers are assigned in sequence. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


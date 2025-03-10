# PowerOfficeGoV2.Model.SubLedgerNumberSeriesDto
The subledger number series DTO contains all properties relevant to subledger number series.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromInclusive** | **long** | The minimum number the subledger accounts in this series can have | [optional] [readonly] 
**GeneralLedgerAccountId** | **long** | The underlying general ledger account ID of the subledger series. | [optional] [readonly] 
**GeneralLedgerAccountNo** | **long** | The underlying general ledger account code of this subledger series.  Subledger transactions in Go will be posted using the subledger number, but the overall accounting effect will be on this underlying account.  More information of accounts can be retrieved using the GeneralLedgerAccount service. | [optional] [readonly] 
**Id** | **Guid** | The unique identifier of the subledger number series. | [optional] [readonly] 
**IsClientTrust** | **bool** | The value indicating whether this number series is used by accounts that contain client trust funds.  Client trust accounts are accounts where realtors or lawyers, for instance, handles their clients&#39; money.  Can be true if the client have the FinancialSettings.UseTrustAccountManagement set true. | [optional] [readonly] 
**IsDefault** | **bool** | The value indicating whether this instance is the default number series for that subledger numberSeriesType. | [optional] [readonly] 
**Name** | **string** | The name of the subledger number series. | [optional] [readonly] 
**SubLedgerNumberSeriesType** | **SubLedgerNumberSeriesType** |  | [optional] 
**ToInclusive** | **long** | The maximum number the subledger accounts in this series can have. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


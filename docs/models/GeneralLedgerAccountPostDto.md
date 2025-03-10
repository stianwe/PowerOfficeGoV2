# PowerOfficeGoV2.Model.GeneralLedgerAccountPostDto
The General Ledger Account Post DTO contains only properties relevant to a general ledger account in Go that can be altered directly via POST-method in API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountNo** | **long** | The number of the account. | 
**AgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**CurrencyCode** | **string** | The standard code of the currency associated with the account. | [optional] 
**DepartmentCode** | **string** | The code of the department associated with the account. | [optional] 
**DepartmentId** | **long** | The id of the department associated with the account. | [optional] 
**IsActive** | **bool** | Value indicating whether this account is active.  Accounts that are not active will not be available for users in the journal entry GUI. | 
**IsDepartmentRequired** | **bool** | Value indicating whether department is a required property to set on transactions on this account. | [optional] 
**IsProjectRequired** | **bool** | Value indicating whether project is a required property to set on transactions on this account. | [optional] 
**IsVatCodeLocked** | **bool** | Value indicating whether the account is locked to a VAT code. If true, only VatCode can be used on transactions on this account. | [optional] 
**Name** | **string** | The name of the account. | 
**Unit1** | **UnitOfMeasureType** |  | [optional] 
**Unit2** | **UnitOfMeasureType** |  | [optional] 
**VatCode** | **string** | The VAT code associated with the account. VatCode or VatCodeId must be supplied.  Standard codes in Go is based on the SAF-T standard.  Codes and any custom codes can be queried and identified using the VatCode service. | [optional] 
**VatCodeId** | **int** | The id of the VAT Code associated with the account.  VatCode or VatCodeId must be supplied when creating a general ledger account. | [optional] 
**VatReturnSpecification** | **VatReturnSpecification** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


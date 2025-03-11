# PowerOfficeGoV2.Model.SalaryLineDto
The salary line DTO contains all properties relevant to a salary line in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long** | The identifier of the account this salary line should be posted on.  Sub-ledger accounts can also be referenced in this field.  If not set, the account from the pay item will be used.  If set, any account set on the pay item will be overridden for this given salary line. | [optional] 
**Amount** | **double** | The amount of the salary line, in the client currency.  The relevance of setting amount depend on the pay item set.  For a pay item with a quantity and rate, the quantity and rate should be provided as drivers, and the system will calculate the amount. | [optional] 
**CarListPrice** | **double** | The list price of the car, in the client currency.  Relevant only for pay items with free car/work car processing types, where the list price is required. | [optional] 
**CarRegistrationDate** | **DateTimeOffset** | The registration date of the car.  Relevant to set only for certain pay items with car/work car related processing types. | [optional] 
**CarRegistrationNo** | **string** | The registration number of the car.  Relevant to set only for certain pay items with car/work car related processing types. | [optional] 
**Cid** | **string** | The CID number (norwegian: KID), relevant if UseRemittance and SupplierBankAccountId is set.  Only relevant to set for pay items with the following processing types: TradeUnionDeduction and AttachmentOfEarnings. | [optional] 
**Comment** | **string** | A comment to the salary line.  Will be shown on the employee payslip if set. | [optional] 
**CommuterPersonType** | **CommuterPersonType** |  | [optional] 
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp when the salary line entity was created. | [optional] [readonly] 
**DeductionType** | **DeductionType** |  | [optional] 
**DepartmentId** | **long** | The department identifier.  Relevant to set if the salary line should be posted with a given department dimension.  If not set, the department will inherit the department set on the employee if/when the salary line is included in a payroll. | [optional] 
**EmployeeId** | **long** | The identifier of the employee this salary line concerns. | [optional] 
**ExternalImportReference** | **string** | The external import reference.  This property can be set by integrations in order to reference the external system and ensure a duplicate check when posting the salary line to Go (only one instance of the reference can exist).  Can be used to correlate/duplicate check salary lines. | [optional] 
**FromDate** | **DateTimeOffset** | The from-date.  Relevant to set only for certain pay items that have deduction processing types, and if the deduction is relevant only for a certain time period. | [optional] 
**HomeWorkKilometers** | **double** | The number of kilometers driven between home and work.  Relevant only for pay items with the processing type FreeCarOutsideStandardRule. | [optional] 
**Id** | **long** | The identifier of the salary line. | [optional] [readonly] 
**IncomeYear** | **int** | The income year.  Relevant only for pay items with certain processing types, such as holiday pay. | [optional] 
**IsCarPool** | **bool** | Value indicating whether this his salary line relate to a car-pool or not.  Only relevant to set for pay items with the processing type FreeCarStandardRule or FreeCarOther.  With these two processing types, either car-pool or car registration number must be set.  Defaults to false if not set. | [optional] 
**IsDeletedByUser** | **bool** | Value indicating whether this instance have been soft-deleted by a user in Go. | [optional] [readonly] 
**IsLocked** | **bool** | Value indicating whether this instance is locked in Go.  Salary lines that have been added to a payroll in Go will have this property set true, and the lines cannot be altered by the integration if locked.  Salary lines are also marked as locked if they have been soft-deleted by a user in Go. | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp when the salary line entity was updated. | [optional] [readonly] 
**MaxAmount** | **double** | The maximum amount when calculating trade union deduction.  Relevant only for pay items with the processing type TradeUnionDeduction. | [optional] 
**MemberNo** | **string** | The member number of the trade union or pension scheme.  Relevant only for pay items with the following processing types: TradeUnionDeduction, PensionDeduction or PensionDeductionUnlimited. | [optional] 
**MinAmount** | **double** | The minimum amount when calculating trade union deduction.  Relevant only for pay items with the processing type TradeUnionDeduction. | [optional] 
**Number** | **int** | The number field.  Only relevant for pay items with certain processing types that require an input of the number of times an event have occurred.  For example the number of journeys for a commuter, if the processing type is CommuterWithNumberOfJourneys. | [optional] 
**OppositeAccountId** | **long** | The identifier of the opposite account this salary line should be posted on.  Sub-ledger accounts can also be referenced in this field.  If not set, the opposite account from the pay item will be used.  If set, any opposite account set on the pay item will be overridden for this given salary line. | [optional] 
**PayItemId** | **Guid** | The identifier of the pay item. | [optional] 
**PrivateDrivenKilometers** | **double** | The number of kilometers driven with private use.  Relevant only for pay items with the processing type FreeCarOutsideStandardRule or WorkCarKilometers. | [optional] 
**ProjectId** | **long** | The project identifier.  Relevant to set if the salary line should be posted with a given project dimension. | [optional] 
**Quantity** | **double** | The quantity of the salary line.  The relevance of setting quantity and the interpretation of unit depend on the pay item set.  For a pay items defined with a quantity related processing types, the quantity should be provided as the driver. | [optional] 
**Rate** | **double** | The rate of the salary line.  The relevance of setting rate depend on the pay item set.  For pay items defined with a variable rate, the rate should be provided as the driver.  For pay items with fixed rates, the rate is usually set on the pay item and will be overridden if set on a salary line.  Also note that hourly wage rates are usually calculated form the employment salary, and not needed to set on salary lines as the system automatically calculates the rate on the payroll. | [optional] 
**StartAmount** | **double** | The start amount of the salary line deduction, in the client currency.  Relevant only for pay items with the following deduction processing types: DeductionWithBalance, AttachmentOfEarnings and AttachmentOfEarningsTax.  If not set on a salary line with a pay item of one of these processing types, the deduction will repeat until stopped.  If set, the deduction will run until the start amount is fully covered. | [optional] 
**SupplierAccountId** | **long** | The identifier of the supplier sub-ledger account to post deductions.  Only relevant to set for pay items with the following processing types: TradeUnionDeduction and AttachmentOfEarnings. | [optional] 
**SupplierBankAccountId** | **long** | The identifier of the supplier bank account.  Relevant only if UseRemittance is true, and for pay items with the following processing types: TradeUnionDeduction and AttachmentOfEarnings. | [optional] 
**TaxRule** | **TaxRuleType** |  | [optional] 
**ToDate** | **DateTimeOffset** | The to-date.  Relevant to set only for certain pay items that have deduction processing types, and if the deduction is relevant only for a certain time period. | [optional] 
**UseRemittance** | **bool** | Value indicating whether to use remittance or not.  Only relevant to set for pay items with the following processing types: TradeUnionDeduction and AttachmentOfEarnings.  Defaults to false if not set. | [optional] 
**VatCodeId** | **int** | The VAT code identifier.  Relevant to set if the salary line is set with a pay item that have a processing type related to expense refund subject of VAT. | [optional] 
**WorkDriveExceedsKilometerLimit** | **bool** | Value indicating whether this his salary line relate to work drive that exceeds the kilometer limit or not.  Relevant only for pay items with the processing type FreeCarStandardRule.  Default to false if not set. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


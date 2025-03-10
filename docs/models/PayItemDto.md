# PowerOfficeGoV2.Model.PayItemDto
The pay item DTO contains all properties relevant to a pay item in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long** | The Id of the general ledger account used, if the posting type is set to general ledger account. | [optional] [readonly] 
**Benefit** | **BenefitType** |  | [optional] 
**BenefitDescription** | **BenefitDescriptionType** |  | [optional] 
**Code** | **string** | The code of the pay item. | [optional] [readonly] 
**CreatedDateTimeOffset** | **DateTime** | The timestamp the pay item entity was created. | [optional] [readonly] 
**DeductionPayItemId** | **Guid** | The identifier of the separate pay item this instance is linked to,  if this pay item instance have a processing type that link to a deduction pay item. | [optional] [readonly] 
**EarnedContinentalShelf** | **bool** | The continental shelf reporting of the pay item.  Null if no continental shelf reporting is relevant for the pay item (benefit), and it should not be reported to Altinn.  True if the benefit is earned on continental shelf.  False if the benefit is not earned on continental shelf. | [optional] [readonly] 
**EarnedSupportVessel** | **bool** | Defines the support vessel reporting type of the pay item.   The support vessel reporting of the pay item.   Null if no support vessel reporting is relevant for the pay item (benefit), and it should not be reported to Altinn.   True if the benefit is earned on support vessel.   False if the benefit is not earned on support vessel. | [optional] [readonly] 
**EarningsCountryCode** | **string** | The earnings country code, relevant if report earnings country is to be reported on this pay item.  ISO 3166-1 alfa-2 country code (two characters). | [optional] [readonly] 
**EmployerContributionBasis** | **bool** | Value indicating whether this pay item should be included in the calculation of employer&#39;s contribution. | [optional] [readonly] 
**FnoReporting** | **FnoReportingType** |  | [optional] 
**FullTaxOnHalfTaxPayrolls** | **bool** | Value indicating whether this pay item should calculate ordinary tax when used in a half tax payroll. | [optional] [readonly] 
**HolidayPayBasis** | **bool** | Value indicating whether this pay item should be included in the calculation of holiday pay. | [optional] [readonly] 
**Id** | **Guid** | The identifier of the pay item. | [optional] [readonly] 
**IncludeInIncomeReport** | **bool** | Value indicating whether this pay item should be included in the income reporting. | [optional] [readonly] 
**IsActive** | **bool** | Value indicating whether this instance is active.  Inactive pay items disable the usage of that pay item on salary lines. | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp of the last change of the pay item. | [optional] [readonly] 
**Name** | **string** | The name of the pay item. | [optional] [readonly] 
**OppositeAccountId** | **long** | The id of the general ledger account to post opposite transaction. | [optional] [readonly] 
**PensionBasis** | **bool** | Value indicating whether this pay item should be included in the calculation of pension. | [optional] [readonly] 
**Percentage** | **double** | The percentage, relevant for pay items with percentage processing type.  Examples: A value of 50 reflect as 50% in the GUI, and a value of -50 reflect as -50% in the GUI.  Example of use case: Pay item for 50% overtime will have 150 set, in order to calculate the correct hourly wage when used. | [optional] [readonly] 
**PostingType** | **PostingType** |  | [optional] 
**ProcessingType** | **ProcessingType** |  | [optional] 
**Rate** | **double** | The rate for of the pay item, relevant if the processing type include a fixed rate.  Rates set on the pay item will be overridden if a rate is set on the salary line using the pay item. | [optional] [readonly] 
**RoundingPrecision** | **RoundingPrecisionType** |  | [optional] 
**SpecialIncomeCondition** | **SpecialIncomeConditionType** |  | [optional] 
**TaxCountryCode** | **string** | The tax country code, relevant if tax country is to be reported on this pay item.  ISO 3166-1 alfa-2 country code (two characters). | [optional] [readonly] 
**TaxDeduction** | **TaxDeductionType** |  | [optional] 
**TradeUnionBasis** | **bool** | Value indicating whether this pay item should be included in the calculation of trade union basis. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


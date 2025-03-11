# PowerOfficeGoV2.Model.EmploymentPostDto
The Employment post DTO contains properties relevant to creating a new employment relationship object in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmploymentForm** | **EmploymentFormType** |  | 
**EmploymentSpecification** | **EmploymentSpecificationType** |  | [optional] 
**EmploymentType** | **EmploymentType** |  | 
**EndDate** | **DateTimeOffset** | The end date of the employment. | [optional] 
**EndDateReason** | **EndDateReasonType** |  | [optional] 
**EnterpriseId** | **long** | The identifier of the enterprise for the employment. | 
**FullTimeHoursPerWeek** | **double** | The number of hours that would represent full time week of employment. | 
**IsDefault** | **bool** | Indicates if the employment is the default employment for the employee. | 
**ProfessionCode** | **string** | The profession code of the employment.  The code follow SSB&#39;s STYRK-98 standard with 7 digits. | 
**ReportingId** | **string** | The id of the employment that will be reported.  Can be set to match the id of the previous payroll system.  If not set, Go will assign an id. | [optional] 
**StartDate** | **DateTimeOffset** | The start date of the employment. | 
**TaxCountryCode** | **string** | The ISO 3166-1 alfa-2 country code (two characters).  Can only be set to Finland (FI) or Sweden (SE) if employment specification is set to cross border commuter. | [optional] 
**TaxRule** | **TaxRuleType** |  | [optional] 
**WorkingHoursArrangement** | **WorkingHoursArrangementType** |  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


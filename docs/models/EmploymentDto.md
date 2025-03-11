# PowerOfficeGoV2.Model.EmploymentDto
The Employment DTO contains properties relevant to an employment relationship object in Go.  Will only contain line count for salary-, fixed salary-, leave-, layout- and percentage of full time employment lines.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp when the employment entity was created. | [optional] [readonly] 
**EmployeeId** | **long** | The identifier of the employee the employment belongs to. | [optional] [readonly] 
**EmploymentForm** | **EmploymentFormType** |  | [optional] 
**EmploymentSpecification** | **EmploymentSpecificationType** |  | [optional] 
**EmploymentType** | **EmploymentType** |  | [optional] 
**EndDate** | **DateTimeOffset** | The end date of the employment. | [optional] 
**EndDateReason** | **EndDateReasonType** |  | [optional] 
**EndedAndReported** | **bool** | True when the employment is ended and the reporting (a-melding) is done and finalized.  If true, the employment will not be included in future reporting (a-melding). | [optional] [readonly] 
**EnterpriseId** | **long** | The identifier of the enterprise for the employment. | [optional] 
**FixedSalaryCount** | **long** | The number of fixed salary lines on this employment. | [optional] [readonly] 
**FtePercentageCount** | **long** | The number of full-time equivalent (FTE) percentage lines on this employment. | [optional] [readonly] 
**FullTimeHoursPerWeek** | **double** | The number of hours that would represent full time week of employment. | [optional] 
**Id** | **long** | The id of the employment (employment relationship). | [optional] [readonly] 
**IsDefault** | **bool** | Indicates if the employment is the default employment for the employee. | [optional] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp when the employment entity was last changed. | [optional] [readonly] 
**LayoffCount** | **long** | The number of layoff lines on this employment. | [optional] [readonly] 
**LeaveCount** | **long** | The number of leave lines on this employment. | [optional] [readonly] 
**ProfessionCode** | **string** | The profession code of the employment.  The code follow SSB&#39;s STYRK-98 standard with 7 digits. | [optional] 
**ProfessionTitle** | **string** | The profession title of the employment.  Is directly connected to the profession code. | [optional] [readonly] 
**ReportingId** | **string** | The id of the employment that will be reported.  Can be set to match the id of the previous payroll system.  If not set, Go will assign an id. | [optional] 
**SalaryCount** | **long** | The number of salary lines on this employment. | [optional] [readonly] 
**StartDate** | **DateTimeOffset** | The start date of the employment. | [optional] 
**TaxCountryCode** | **string** | The ISO 3166-1 alfa-2 country code (two characters).  Can only be set to Finland (FI) or Sweden (SE) if employment specification is set to cross border commuter. | [optional] 
**TaxRule** | **TaxRuleType** |  | [optional] 
**WorkingHoursArrangement** | **WorkingHoursArrangementType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


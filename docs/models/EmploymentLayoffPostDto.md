# PowerOfficeGoV2.Model.EmploymentLayoffPostDto
The Employment Layoff post DTO contains all properties relevant to creating a new layoff (line) on an employment relationship object in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdjustFixedWage** | **bool** | Value indicating whether the fixed wage should be adjusted by the layoff percentage.  If true then this layoff percentage will be used to adjust the fixed wage. | [optional] 
**EndDate** | **DateOnly** | The end date of the layoff. | [optional] 
**EndedAndReported** | **bool** | Value is set true if and when the layoff is ended and the reporting (a-melding) is done and finalized.  If true, the layoff will not be included in future reporting (a-melding). | [optional] 
**ExcludeEmployeeFromPayroll** | **bool** | Value is set true if the employee should be excluded from payroll&#39;s while the layoff is active. | [optional] 
**LayoffPercentage** | **double** | The percentage of layoff absence.  100 represent fully absent,  50 represent 50% absence from the current employment. | 
**ReportingId** | **string** | The id of the layoff that will be reported.  If not set, Go will assign an id.  Not to be confused with the Id property. | [optional] 
**StartDate** | **DateOnly** | The start date of the layoff. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


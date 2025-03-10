# PowerOfficeGoV2.Model.EmploymentLeaveDto
The Employment Leave DTO contains properties relevant to a leave (line) on an employment relationship object in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdjustFixedWage** | **bool** | Value indicating whether the fixed wage should be adjusted by the leave percentage.  If true then this leave percentage will be used to adjust the fixed wage. | [optional] 
**CreatedDateTimeOffset** | **DateTime** | The timestamp when the employment leave entity was created. | [optional] [readonly] 
**EmployeeId** | **long** | The identifier of the employee the employment belongs to. | [optional] [readonly] 
**EmploymentId** | **long** | The id of the employment (employment relationship) the leave line belongs to. | [optional] [readonly] 
**EndDate** | **DateOnly** | The end date of the leave. | [optional] 
**EndedAndReported** | **bool** | Value is set true if and when the leave is ended and the reporting (a-melding) is done and finalized.  If true, the leave will not be included in future reporting (a-melding). | [optional] 
**ExcludeEmployeeFromPayroll** | **bool** | Value is set true if the employee should be excluded from payroll&#39;s while the leave is active. | [optional] 
**Id** | **Guid** | The id of the employment leave (line). | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp when the employment leave entity was last changed. | [optional] [readonly] 
**LeavePercentage** | **double** | The percentage of leave of absence.  100 represent fully absent,  50 represent 50% absence from the current employment. | [optional] 
**ReportingId** | **string** | The id of the leave that will be reported.   If not set, Go will assign an id.   Not to be confused with the Id property. | [optional] 
**StartDate** | **DateOnly** | The start date of the leave. | [optional] 
**TypeOfLeave** | **LeaveType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


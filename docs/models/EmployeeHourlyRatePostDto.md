# PowerOfficeGoV2.Model.EmployeeHourlyRatePostDto
The Employee Hourly Rate post DTO contains properties relevant to creating a new \"EmployeeTimeHourlyRates\" object in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillableRate** | **double** | The billable hourly rate for timetransactions registered with billable activities for this employee.  Must be a positive number.  Note that a hierarchy exist in Go for timetracking price settings of billable rates. | [optional] 
**CostRate** | **double** | The hourly cost rate for timetransactions registered for this employee.  Must be a positive number.  This cost rate have no direct relation to payroll settings, and is primarily used for reporting purposes on timetracking entries. | [optional] 
**ValidFromDate** | **DateOnly** | The date from which this rate is to be used from. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


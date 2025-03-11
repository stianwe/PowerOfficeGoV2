# PowerOfficeGoV2.Model.EmployeeHourlyRateDto
The Employee Hourly Rate DTO contains properties relevant to a \"EmployeeTimeHourlyRates\" object in Go

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillableRate** | **double** | The billable hourly rate for timetransactions registered with billable activities for this employee.  Must be a positive number.  Note that a hierarchy exist in Go for timetracking price settings of billable rates. | [optional] 
**CostRate** | **double** | The hourly cost rate for timetransactions registered for this employee.  Must be a positive number.  This cost rate have no direct relation to payroll settings, and is primarily used for reporting purposes on timetracking entries. | [optional] 
**Id** | **long** | The identifier of the employee hourly rates.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited (PATCH), deleted (DELETE) or retrieved specifically (GET). | [optional] [readonly] 
**ValidFromDate** | **DateTimeOffset** | The date from which this rate is to be used from. | [optional] 
**ValidToDate** | **DateTimeOffset** | The date from which this rate is no longer in use. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


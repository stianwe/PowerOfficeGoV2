# PowerOfficeGoV2.Model.EmploymentSalaryDto
The Employment Salary DTO contains properties relevant to a salary (line) on an employment relationship object in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnnualSalary** | **double** | The annual salary of the employment salary.  Only relevant for fixed wage salary. | [optional] 
**CreatedDateTimeOffset** | **DateTime** | The timestamp when the employment salary entity was created. | [optional] [readonly] 
**EmployeeId** | **long** | The identifier of the employee the employment belongs to. | [optional] [readonly] 
**EmploymentId** | **long** | The id of the employment (employment relationship) the salary line belongs to. | [optional] [readonly] 
**FromDate** | **DateOnly** | The from-date for the effect of the employment salary. | [optional] 
**HourlyRate** | **double** | The hourly rate of the employment salary.  Relevant to set for hourly wage salary and commission salary.  For fixed wage salary, the hourly rate is automatically calculated if null, but can be overridden.  The calculation is based on the full time hours per week property on the employment general information, multiplied by 52 weeks.  Relevant for fixed wage in terms of overtime/extra hours, for instance. | [optional] 
**Id** | **long** | The id of the employment salary (line). | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp when the employment salary entity was last changed. | [optional] [readonly] 
**RemunerationType** | **SalaryRemunerationType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Model.EmploymentSalaryPostDto
The Employment Salary post DTO contains all properties relevant to creating a new salary (line) on an employment relationship object in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnnualSalary** | **double** | The annual salary of the employment salary.  Only relevant for fixed wage salary. | [optional] 
**FromDate** | **DateTimeOffset** | The from-date for the effect of the employment salary. | 
**HourlyRate** | **double** | The hourly rate of the employment salary.  Relevant to set for hourly wage salary and commission salary.  For fixed wage salary, the hourly rate is automatically calculated if null, but can be overridden.  The calculation is based on the full time hours per week property on the employment general information, multiplied by 52 weeks.  Relevant for fixed wage in terms of overtime/extra hours, for instance. | [optional] 
**RemunerationType** | **SalaryRemunerationType** |  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


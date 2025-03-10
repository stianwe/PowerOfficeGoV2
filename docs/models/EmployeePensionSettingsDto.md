# PowerOfficeGoV2.Model.EmployeePensionSettingsDto
The Employee pension settings DTO contains properties relevant for pension settings on an employee in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FnoStatus** | **FnoStatusType** |  | [optional] 
**FnoStatusPercentage** | **int** | The percentage related to the FNO status that is reported. | [optional] 
**HoursPerYearFno** | **int** | The number of hours per year for a full time employment, in terms of FNO reporting.  If null, the general payroll settings is used. | [optional] 
**IncludeInFnoPensionReport** | **bool** | Property indicating whether the employee should be included in the FNO pension reporting. | [optional] 
**IsReceivingAfp** | **bool** | Property indicating whether the employee is receiving AFP (in terms of FNO pension report). | [optional] 
**IsUnfitForWork** | **bool** | Property indicating whether the employee is unfit for work (in terms of FNO pension report). | [optional] 
**PensionAgeFno** | **int** | The pension age in terms of FNO reporting.  If null, the general payroll settings is used. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


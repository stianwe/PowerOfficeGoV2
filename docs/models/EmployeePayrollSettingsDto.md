# PowerOfficeGoV2.Model.EmployeePayrollSettingsDto
The Employee payroll settings DTO contains properties relevant for payroll settings on an employee in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HolidayPayAbove60Percentage** | **double** | The holiday pay percentage above 60 years for this employee.  If null, the general payroll settings will be used.  Note that only 1 decimal is allowed, if more than 1 decimal is provided, the value will be rounded to nearest 1 decimal. | [optional] 
**HolidayPayPercentage** | **double** | The holiday pay percentage for the employee.  If null, the general payroll settings will be used.  Note that only 1 decimal is allowed, if more than 1 decimal is provided, the value will be rounded to nearest 1 decimal. | [optional] 
**LimitHolidayPayAbove60To6G** | **bool** | Property indicating whether holiday pay above 60 years is limited to 6G for the employee.  If null, the general payroll settings will be used. | [optional] 
**NumberOfHolidays** | **int** | The number of holidays for the employee.  If null, the general payroll settings will be used. | [optional] 
**NumberOfHolidaysAbove60** | **int** | The number of holidays above 60 years for the employee.  If null, the general payroll settings will be used. | [optional] 
**OmitECOnHolidayPayProvision** | **bool** | Property indicating whether employer contribution should be used or not for holiday pay provisions for this employee.  The typical case to set true, is for foreign employees subject of a foreign social security legislation. | [optional] 
**PayslipDeliveryType** | **PayslipDeliveryType** |  | [optional] 
**PayslipEmailAddress** | **string** | The e-mail address of the employee that the payslip will be sent to.  Relevant only if the payslip type is set to e-mail and app.  If this property is null, the general e-mail address of the employee will be used if payslips are delivered by e-mail. | [optional] 
**PayslipLanguageType** | **PayslipLanguageType** |  | [optional] 
**RemunerationPeriodType** | **RemunerationPeriodType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


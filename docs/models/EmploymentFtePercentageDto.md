# PowerOfficeGoV2.Model.EmploymentFtePercentageDto
The Employment full-time equivalent (FTE) percentage DTO contains properties relevant to a FTE percentage (line) on an employment relationship object in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp when the employment FTE percentage entity was created. | [optional] [readonly] 
**EmployeeId** | **long** | The identifier of the employee the employment belongs to. | [optional] [readonly] 
**EmploymentId** | **long** | The id of the employment (employment relationship) the FTE percentage line belongs to. | [optional] [readonly] 
**FromDate** | **DateTimeOffset** | The from-date for the effect of the employment full-time equivalent (FTE) percentage. | [optional] 
**FtePercentage** | **double** | The percentage of full-time equivalent (FTE) employment.  The value should be between 0 and 100 (reflects as 0% or 100% in the GUI). | [optional] 
**Id** | **long** | The id of the employment FTE percentage (line). | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp when the employment FTE percentage entity was last changed. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


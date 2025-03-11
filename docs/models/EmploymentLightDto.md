# PowerOfficeGoV2.Model.EmploymentLightDto
The Employment Light DTO contains properties relevant to an employment relationship object in Go.  It is a lightweight (slimmed down) version of the Employment DTO, and therefore contains fewer properties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp when the employment entity was created. | [optional] [readonly] 
**EmployeeId** | **long** | The identifier of the employee the employment belongs to. | [optional] [readonly] 
**EmploymentForm** | **EmploymentFormType** |  | [optional] 
**EndDate** | **DateTimeOffset** | The end date of the employment. | [optional] [readonly] 
**EnterpriseId** | **long** | The identifier of the enterprise for the employment. | [optional] [readonly] 
**Id** | **long** | The id of the employment (employment relationship). | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp when the employment entity was last changed. | [optional] [readonly] 
**StartDate** | **DateTimeOffset** | The start date of the employment. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


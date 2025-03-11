# PowerOfficeGoV2.Model.DepartmentDto
DTO for Department read operations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the department. | [optional] 
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp the department entity was created. | [optional] [readonly] 
**CreatedFromImportJournalId** | **Guid** | The created from import journal identifier (guid). If the department was created from an import, this property will contain the Id of the Import that created this entity. | [optional] [readonly] 
**Id** | **long** | The identifier of the department. | [optional] [readonly] 
**IsActive** | **bool** | Value indicating whether this instance is active.  Inactive departments disable the usage of that departments in the GUI.  Defaults to false. | [optional] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp of the last change of the department. | [optional] [readonly] 
**ManagerEmployeeId** | **long** | The employee id of the manager of the department. | [optional] [readonly] 
**ManagerEmployeeNo** | **long** | The employee number of the manager of the department. | [optional] [readonly] 
**Name** | **string** | The name of the department | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


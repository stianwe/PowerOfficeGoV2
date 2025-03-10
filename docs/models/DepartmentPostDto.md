# PowerOfficeGoV2.Model.DepartmentPostDto
DTO for creating department.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the department. | [optional] 
**IsActive** | **bool** | Value indicating whether this instance is active.  Inactive departments disable the usage of that departments in the GUI.  Defaults to false. | [optional] 
**ManagerEmployeeId** | **long** | The employee id of the manager of the department. | [optional] 
**ManagerEmployeeNo** | **long** | The employee number of the manager of the department.  Note that if ManagerEmployeeId is set as well in the request, ManagerEmployeeId takes precedence and ManagerEmployeeNo is ignored. | [optional] 
**Name** | **string** | The name of the department | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


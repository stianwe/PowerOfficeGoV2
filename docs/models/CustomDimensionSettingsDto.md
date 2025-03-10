# PowerOfficeGoV2.Model.CustomDimensionSettingsDto
DTO for CustomDimensionSettings, used for getting the client settings of the custom dimensions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsActive** | **bool** | A value indicating whether this dimension ordinal is active and in use. Inactive sets disable the usage of that custom dimension set in the GUI. | [optional] [readonly] 
**Name** | **string** | The the name of the custom dimension set of the given ordinal.  Provide information that indicate what the dimension set is used for. An example could be a client that has defined Dim1 to be \&quot;Machines\&quot;, where custom dimension values of Dim1 are the machine registration codes. | [optional] [readonly] 
**Ordinal** | **int** | The custom dimension set ordinal (1&#x3D;Dim1, 2&#x3D;Dim3, 3&#x3D;Dim3). | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


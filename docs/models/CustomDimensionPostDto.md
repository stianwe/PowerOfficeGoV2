# PowerOfficeGoV2.Model.CustomDimensionPostDto
DTO for creating a CustomDimension.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ordinal** | **int** | The custom dimension ordinal, providing information on which of the available custom dimension sets this custom dimension belong to (1&#x3D;Dim1, 2&#x3D;Dim3, 3&#x3D;Dim3). | 
**Code** | **string** | The code of the custom dimension. The code must be unique for each ordinal (within dim1, dim2 and dim3 respectively).  Go will assign a code automatically, if not provided. | [optional] 
**ExternalImportReference** | **string** | The external import reference. This field is not available in the GUI, but can be used by the integrating party to reference the external system.  The field must be unique within each set of custom dimension (unique for dim1, dim2 or dim3).  Any integration with access can set the field (and change it). | [optional] 
**IsActive** | **bool** | A value indicating whether this instance is active. Inactive custom dimensions disable the usage of that custom dimension in the GUI. | [optional] 
**Name** | **string** | The name of the custom dimension | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


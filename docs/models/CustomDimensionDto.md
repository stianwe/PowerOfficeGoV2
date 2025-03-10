# PowerOfficeGoV2.Model.CustomDimensionDto
DTO for CustomDimensions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the custom dimension. The code must be unique for each ordinal (within dim1, dim2 and dim3 respectively).  Go will assign a code automatically, if not provided. | [optional] 
**CreatedDateTimeOffset** | **DateTime** | The timestamp of the created date of the custom dimension. UTC time. | [optional] [readonly] 
**CreatedFromImportJournalId** | **Guid** | The created from import journal identifier, if present. Provided if this custom dimension was been created in Go by an import. | [optional] [readonly] 
**ExternalImportReference** | **string** | The external import reference. This field is not available in the GUI, but can be used by the integrating party to reference the external system.  The field must be unique within each set of custom dimension (unique for dim1, dim2 or dim3).  Any integration with access can set the field (and change it). | [optional] 
**Id** | **long** | The identifier of the custom dimension.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited or deleted (PATCH or DELETE). | [optional] [readonly] 
**IsActive** | **bool** | A value indicating whether this instance is active. Inactive custom dimensions disable the usage of that custom dimension in the GUI. | [optional] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp of the last change of the custom dimension. UTC time. | [optional] [readonly] 
**Name** | **string** | The name of the custom dimension | [optional] 
**Ordinal** | **int** | The custom dimension ordinal, providing information on which of the available custom dimension sets this custom dimension belong to (1&#x3D;Dim1, 2&#x3D;Dim3, 3&#x3D;Dim3). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Model.LocationDto
DTO for Location.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the location. | [optional] 
**CreatedDateTimeOffset** | **DateTime** | The timestamp of the created date of the location. | [optional] [readonly] 
**Id** | **long** | The identifier of the location. This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited or deleted (PATCH or DELETE). | [optional] [readonly] 
**IsActive** | **bool** | A value indicating whether this instance is active. Inactive locations disable the usage of that locations in the GUI. Defaults to false. | [optional] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp of the last change of the location. | [optional] [readonly] 
**Name** | **string** | The name of the location | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


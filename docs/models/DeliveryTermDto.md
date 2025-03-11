# PowerOfficeGoV2.Model.DeliveryTermDto
The delivery terms on the client

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDateTimeOffset** | **DateTimeOffset** | The timestamp of the created date of the delivery term. UTC time. | [optional] [readonly] 
**Id** | **long** | The identifier of the delivery term. This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited or deleted (PATCH or DELETE). | [optional] [readonly] 
**IsDefault** | **bool** | A value indicating if this delivery term is the standard delivery term set on the client.  Customers and sales orders will default inherit the standard delivery term from the client invoice settings.  Defaults to false. | [optional] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp of the last changed date of the delivery term. UTC time. | [optional] [readonly] 
**Name** | **string** | Gets or sets the name of the delivery term. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


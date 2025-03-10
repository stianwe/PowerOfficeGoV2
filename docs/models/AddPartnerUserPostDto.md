# PowerOfficeGoV2.Model.AddPartnerUserPostDto
The available properties for adding a partner user to a client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessRoleId** | **Guid** | The access role id the user should have on the client. | 
**PartnerUserId** | **Guid** | The existing partner user that should be added to the client. | 
**FromDate** | **DateOnly** | From date, inclusive.  The user will have access to the client from this date. | [optional] 
**ToDate** | **DateOnly** | To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


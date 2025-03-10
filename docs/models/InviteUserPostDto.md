# PowerOfficeGoV2.Model.InviteUserPostDto
The available properties when inviting users to Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessRoleId** | **Guid** | The access role id the user have on the client. | 
**EmailAddress** | **string** | The e-mail address of the user. | 
**FirstName** | **string** | The first name of the user. | 
**FromDate** | **DateOnly** | From date, inclusive.  The user will have access to the client from this date.  If not set, the user will have access from the day the user accept the invitation. | [optional] 
**InviteAsEmployee** | **bool** | Indicates whether the user should be added as an employee on the client.  If true, an employee object will be created and linked to the user after the invitation is accepted. | [optional] 
**LastName** | **string** | The last name of the user. | 
**ToDate** | **DateOnly** | To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client.  If not set, the user will have no time restricted access. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


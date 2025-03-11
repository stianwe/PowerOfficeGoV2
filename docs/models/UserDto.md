# PowerOfficeGoV2.Model.UserDto
The available properties for users in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessRoleId** | **Guid** | The access role id the user have on the client.  Note: Administrator Role always has id: aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa | [optional] [readonly] 
**EmailAddress** | **string** | The e-mail address of the user. | [optional] [readonly] 
**FirstName** | **string** | The first name of the user. | [optional] [readonly] 
**FromDate** | **DateTimeOffset** | From date, inclusive.  The user will have access to the client from this date.  If null, the from date is undefined. | [optional] [readonly] 
**Id** | **Guid** | The identifier of the user.  This identifier is unique and assigned by PowerOffice Go when a new user is created.  Will be empty (null) if the user is invited and has not yet accepted. (Status &#x3D; InvitePending) | [optional] [readonly] 
**LastName** | **string** | The last name of the user. | [optional] [readonly] 
**Status** | **UserStatus** |  | [optional] 
**ToDate** | **DateTimeOffset** | To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client.  If null, the to date is undefined and unrestricted. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Model.InitiateOnboardingPostDto
The initiate onboarding post DTO contains properties necessary for initiating the onboarding processes in GO.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationKey** | **Guid** | The applicationkey, representing the integrated application that is to be onboarded on client(s).  Must be set in the POST call initiating the onboarding. | [optional] 
**ClientOrganizationNo** | **string** | The organization number of the PowerOffice Go client that are to onboard the integrated application.  If set, only this client will be presented to the user that must authorize the integration.  If not set, the user will be presented a list of all clients the user have acccess to onboard, enabling onboarding of multiple clients in one process. | [optional] 
**RedirectUri** | **string** | The redirect uri we will route to if the user successfully authorize onboarding on client(s).  The uri need to be whitelisted by the api team before use, and this must be done separately for the demo and production environments.  The system validate the domain, sub-domain and path used, but any parameters beyond that are ignored (and as such, any \&quot;?to&#x3D;\&quot; variants can be used as the integrating party see fit).  The uri can be set to localhost in test phases. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


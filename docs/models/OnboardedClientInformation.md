# PowerOfficeGoV2.Model.OnboardedClientInformation
Contains information about the onboarded client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientKey** | **Guid** | The clientkey for the specific client.  This key is a secret, and must be stored and handled as such.  The clientkey is unique per instance of a client integration - i.e. unique per client.  Please refer to our documentation for all the details on the client credentials grant flow. | [optional] [readonly] 
**ClientName** | **string** | The name of the client that onboarded the integrated application. | [optional] [readonly] 
**ClientOrganizationNumber** | **string** | The organization number of the client that onboarded the integrated application and the related clientkey. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


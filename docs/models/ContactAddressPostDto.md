# PowerOfficeGoV2.Model.ContactAddressPostDto
The contact address post DTO contains all properties relevant to creating a new address object in Go.  Address representing a physical location.  Includes external code for reference in external systems.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The first (main) address line. | [optional] 
**AddressLine2** | **string** | The second address line. | [optional] 
**City** | **string** | The city. | 
**CountryCode** | **string** | The ISO 3166-1 alfa-2 country code (two characters).  Defaults to \&quot;NO\&quot; if not set. | [optional] 
**ExternalCode** | **string** | The external code  This field is not available in the GUI, but can be used by the integrating party to reference the address in the external system.  The field must be unique (for each address). | [optional] 
**ZipCode** | **string** | The zip code (postal code). | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


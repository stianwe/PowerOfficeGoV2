# PowerOfficeGoV2.Model.ContactAddressDto
The contact address DTO contains all properties relevant to an address object in Go.  Address representing a physical location.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The first (main) address line. | [optional] 
**AddressLine2** | **string** | The second address line. | [optional] 
**City** | **string** | The city. | [optional] 
**CountryCode** | **string** | The ISO 3166-1 alfa-2 country code (two characters).  Defaults to \&quot;NO\&quot; if not set. | [optional] 
**ExternalCode** | **string** | The external code  This field is not available in the GUI, but can be used by the integrating party to reference the address in the external system.  The field must be unique (for each address). | [optional] 
**Id** | **long** | The identifier of the address.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited (PATCH), deleted (DELETE) or retrieved specifically (GET). | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The last changed timestamp of this address. | [optional] [readonly] 
**ZipCode** | **string** | The zip code (postal code). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


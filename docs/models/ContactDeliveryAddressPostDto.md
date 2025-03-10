# PowerOfficeGoV2.Model.ContactDeliveryAddressPostDto
Properties for creating a contact delivery address.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The first (main) address line. | [optional] 
**AddressLine2** | **string** | The second address line. | [optional] 
**City** | **string** | The city. | 
**CountryCode** | **string** | The ISO 3166-1 alfa-2 country code (two characters).  Defaults to \&quot;NO\&quot; if not set. | [optional] 
**ExternalCode** | **string** | The external code  This field is not available in the GUI, but can be used by the integrating party to reference the address in the external system.  The field must be unique (for each address). | [optional] 
**IsPrimary** | **bool** | A value indicating whether this delivery address is the primary delivery address for this contact.  Sales orders created, will default inherit the primary delivery address of the customer, if not overridden.  The first delivery address created for a contact will automatically be set as primary. | [optional] 
**ZipCode** | **string** | The zip code (postal code). | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


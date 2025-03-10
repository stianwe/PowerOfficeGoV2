# PowerOfficeGoV2.Model.ContactPersonPostDto
Properties for creating a new contact person.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailAddress** | **string** | The e-mail address registered for the contact person.  This field is validated for typos in POST/PATCH calls. | [optional] 
**ExternalCode** | **string** | The external code. This field is not available in the GUI,  but can be used by the integrating party to reference the contact  person in the external system. The field must be unique (for each contact person). | [optional] 
**FirstName** | **string** | The first name of the contact person. | 
**IsActive** | **bool** | A value indicating whether this instance is active. Inactive contact persons disable the usage of that in the GUI. | [optional] 
**IsDefault** | **bool** | A bool indicating whether this contact person is the default contact person. | [optional] 
**LastName** | **string** | The last name of the contact person. | 
**MailAddress** | [**AddressPostDto**](AddressPostDto.md) |  | [optional] 
**PhoneNumber** | **string** | The phone number of the contact person. | [optional] 
**Title** | **string** | The title of the contact person. This might for instance be the job title of the person. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


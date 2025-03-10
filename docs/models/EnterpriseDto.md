# PowerOfficeGoV2.Model.EnterpriseDto
Enterprises available on the client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDateTimeOffset** | **DateTime** | Gets the timestamp the enterprise entity was created. | [optional] [readonly] 
**EmployerContributionRule** | **EmployerContributionRule** |  | [optional] 
**EmployerContributionZone** | **EmployerContributionZone** |  | [optional] 
**EnterpriseNo** | **string** | The enterprise number. | [optional] [readonly] 
**Id** | **long** | The identifier of the enterprise. | [optional] [readonly] 
**IsDefault** | **bool** | Indicates if this is the default enterprise.  New employments will be assigned to the default enterprise if not set when employments are created | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp the enterprise was last changed. | [optional] [readonly] 
**MailAddress** | [**AddressDto**](AddressDto.md) |  | [optional] 
**Municipality** | **string** | The number of the municipality this enterprise belong to. | [optional] [readonly] 
**Name** | **string** | The name of the enterprise. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


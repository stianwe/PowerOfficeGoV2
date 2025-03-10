# PowerOfficeGoV2.Model.BrandingThemeDto
The branding themes on the client. Branding themes hold a set of templates for various documents, such as invoices, reminders, quotes etc.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the branding theme. | [optional] [readonly] 
**CreatedDateTimeOffset** | **DateTime** | The timestamp of the created date of the branding theme. UTC time. | [optional] [readonly] 
**Id** | **long** | The identifier of the branding theme. This identifier is unique and assigned by PowerOffice Go when a new entity is saved. | [optional] [readonly] 
**IsDefault** | **bool** | A value indicating if this branding theme is the standard branding theme set on the client.  Customers, projects and sales orders will default inherit the standard branding theme if not overridden. | [optional] [readonly] 
**LanguageCode** | **string** | The language code of the branding theme. | [optional] [readonly] 
**LastChangedDateTimeOffset** | **DateTime** | The timestamp of the last changed date of the branding theme. UTC time. | [optional] [readonly] 
**Name** | **string** | The name of the branding theme. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


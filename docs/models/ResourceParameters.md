# PowerOfficeGoV2.Model.ResourceParameters
Structure containing various resource-filter options

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fields** | **string** | Define desired fields that should be returned in Json (All fields by default). | [optional] 
**MaxPageSize** | **int** | The maximum amount of objects that can be return in a Page (20 000 by default). | [optional] [readonly] 
**OrderBy** | **string** | Define fields to order by, and if it should order asc (default) or desc. | [optional] 
**PageNumber** | **int** | The desired page to return. | [optional] 
**PageSize** | **int** | The amount of objects to return in a Page (5000 by default). Not allowed to be larger than MaxPageSize. | [optional] 
**UseDatabaseValidation** | **bool** | If set to true, all relevant filter-values will be validated against the database. NOTE: This will make the api-call much slower, but only for the initial request, as the validation-results are cached. Useful for debugging/support purposes. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


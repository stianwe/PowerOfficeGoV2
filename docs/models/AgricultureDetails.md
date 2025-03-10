# PowerOfficeGoV2.Model.AgricultureDetails
Additional agriculture product related information that needs to be stored to be able to report on it

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgriculturalIndustryCode** | **int** | Gets or sets the agricultural industry code (driftsgrein) | [optional] 
**IsMainProductLine** | **bool** | Whether the posting info comes from a line that is a main product line (not only additions related to a product) | [optional] 
**ProductAdditionSubtractionCode** | **int** | Product addition or subtraction (Produkt tillegg trekk) | [optional] 
**ProductAnimalId** | **string** | The ID of the animal (Dyre-id) | [optional] 
**ProductChassisId** | **string** | VIN / Chassis number 17-digits according to iso | [optional] 
**ProductCode** | **int** | Product code according to Landbrukets dataflyt, can differ from product code voucher line | [optional] 
**ProductDateOfBirth** | **DateOnly** | Date of birth of the animal, required when information is related to live cattle | [optional] 
**ProductDetailCode** | **int** | Product detail code | [optional] 
**ProductEcological** | **bool** | Whether a product is ecological or not | [optional] 
**ProductGender** | **LivestockGender** |  | [optional] 
**ProductGtinNumber** | **string** | Global unit trade number | [optional] 
**ProductHasForestCertificationCode** | **bool** | Flag whether the forestry product is environmentally certified (Miljøsertifisert) | [optional] 
**ProductMachineType** | **string** | Type of machinery | [optional] 
**ProductQualityCode** | **int** | The product quality code (Produktkvalitet) | [optional] 
**ProductRacialCode** | **string** | The race of the animal, required on sale of live animals | [optional] 
**ProductRegistrationId** | **string** | Registration number | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


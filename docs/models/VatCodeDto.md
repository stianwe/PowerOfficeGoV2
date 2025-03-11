# PowerOfficeGoV2.Model.VatCodeDto
The VAT code DTO contains all properties relevant to VAT codes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseVatCodeId** | **long** | The standard vat id the custom vat code is based upon. Relevant only for custom vat codes. | [optional] 
**Code** | **string** | The vat code. Go use standard SAF-T codes by default. Any custom codes, will have a notation with the letter C first.  Codes used specifically for vat compensation, are marked with the letter K first (relevant only if the client uses vat compensation, ie the VatSetting &#39;useVatCompensation&#39; set true). | [optional] [readonly] 
**Description** | **string** | The description of the vat code. | [optional] [readonly] 
**Id** | **long** | The unique identifier of the vat code | [optional] [readonly] 
**IsActive** | **bool** | The value indicating whether this vat code is active | [optional] [readonly] 
**IsCustom** | **bool** | The value indicating whether this vat code is custom created. The code will have the letter C in the notation if true. | [optional] [readonly] 
**Name** | **string** | the name of the vat code. | [optional] [readonly] 
**Rate** | **double** | The rate of the vat code. This is a value between 0 and 1. 0 representing 0 % vat and 1 representing 100 % vat. | [optional] [readonly] 
**ValidFrom** | **DateTimeOffset** | The date this vat code is active from, inclusive. | [optional] [readonly] 
**ValidTo** | **DateTimeOffset** | The date this vat code expires. Inclusive. | [optional] [readonly] 
**VatBasisRatio** | **double** | The vat basis ratio. Relevant for custom codes in mixed vat conditions (Norwegian: Forholdsmessig fradrag MVA). This is a value between 0 and 1, with 0 representing 0% vat basis ratio and 1 representing 100% vat basis ratio.  Example: A net amount of 1000 NOK with 50% vat basis ratio and 25% vat rate, will have the vat amount calculated as: 1000 x 0.5 x 0.25 &#x3D; 125 NOK | [optional] [readonly] 
**VatBasisRatioValidFrom** | **DateTimeOffset** | The date this vat basis ratio is active from.  If no vat basis ratio is set, this date will default to the vat code valid from date. | [optional] [readonly] 
**VatBasisRatios** | [**List&lt;VatBasisRatios&gt;**](VatBasisRatios.md) | A collection of VatBasisRatios for a custom vat code. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


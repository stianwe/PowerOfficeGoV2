# PowerOfficeGoV2.Model.ContactBankAccountDto
Properties of a contact bank account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccountNumber** | **string** | The bank account number | [optional] 
**BankCode** | **string** | The bank code. Only applicable and used for countries that does not support bicSwift. | [optional] 
**BicSwift** | **string** | The BIC/SWIFT code. | [optional] 
**ContactId** | **long** | The identifier of the contact (customer/employee/supplier) this bank account is for. | [optional] [readonly] 
**CountryCode** | **string** | The ISO 3166-1 alfa-2 country code. Default is NO. | [optional] 
**CreateDateTimeOffset** | **DateTimeOffset** | The timestamp of the created date of the contact bank account. UTC time. | [optional] [readonly] 
**Id** | **long** | The identifier of the contact bank account. | [optional] [readonly] 
**IsActive** | **bool** | A value indicating whether this bank account is active. | [optional] 
**LastChangedDateTimeOffset** | **DateTimeOffset** | The timestamp of the last change of the contact bank account. UTC time. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


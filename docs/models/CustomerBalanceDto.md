# PowerOfficeGoV2.Model.CustomerBalanceDto
Represents a customer balance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | **double** | The current total balance of the customer, as of the date (inclusive) provided in the query. | [optional] [readonly] 
**CustomerAccountNo** | **long** | The customer account number for the related balance.  CustomerAccountNo will also represent the Customer number.  Customers can be queried and identified using the Customer service. | [optional] [readonly] 
**CustomerExternalNo** | **long** | The external number of the customer for the related balance, if set on the Customer entity.  An external number set on the customer is often used to reference the customer number in the external system, if the customer numbers are not kept in 1:1 sync between Go and the external system.  The field is available in the GUI with the name External Code. | [optional] [readonly] 
**CustomerId** | **long** | The identifier of the customer this balance is related to.  Customers can be queried and identified using the Customer service. | [optional] [readonly] 
**CustomerName** | **string** | The name of the customer for the related balance.  Customers can be queried and identified using the Customer service. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


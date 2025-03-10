# PowerOfficeGoV2.Model.SupplierBalanceDto
Represents a supplier balance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | **double** | The current total balance of the supplier, as of the date (inclusive) provided in the query. | [optional] [readonly] 
**SupplierAccountNo** | **long** | The supplier account number for the related balance.  SupplierAccountNo will also represent the Supplier number.  Suppliers can be queried and identified using the Supplier service. | [optional] [readonly] 
**SupplierExternalNo** | **long** | The external number of the supplier for the related balance, if set on the Supplier entity.  An external number set on the supplier is often used to reference the supplier number in the external system, if the supplier numbers are not kept in 1:1 sync between Go and the external system.  The field is available in the GUI with the name External Code. | [optional] [readonly] 
**SupplierId** | **long** | The identifier of the supplier this balance is related to.  Suppliers can be queried and identified using the Supplier service. | [optional] [readonly] 
**SupplierName** | **string** | The name of the supplier for the related balance.  Suppliers can be queried and identified using the Supplier service. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


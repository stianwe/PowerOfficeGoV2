# PowerOfficeGoV2.Model.ProductPostDto
The product post DTO contains only properties relevant to a product-object in Go that can be altered directly via POST-method in API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the product. | [optional] 
**Description** | **string** | The description of the product. | [optional] 
**Gtin** | **string** | The GTIN (Global trade item number) of the product. | [optional] 
**IsArchived** | **bool** | Value indicating whether the product is archived (set inactive).  Default is false.  Archived products will be unavailable for usage in the GUI. | [optional] 
**IsStockItem** | **bool** | Value indicating whether the product stock on hand can be registered.  If false, the stock on hand cannot be set and the stock fields will not be visible in the GUI. | [optional] 
**Name** | **string** | The name of the product. | 
**OptionalSalesAccount** | **long** | The code of the optional sales account of the product.  The optional sales account is the account the sale will be posted to, if the product is included on a sales order line that is invoiced, and that sales order line is set to trigger the use of the optional sales account.  If null, the product will inherit the optional sales account from the product group or the general sales settings on the client (in that order).  The concept of sales accounts is also explained in the common workflow articles.  Note that if OptionalSalesAccountId is set as well in the request, OptionalSalesAccountId takes precedence and OptionalSalesAccount is ignored. | [optional] 
**OptionalSalesAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**OptionalSalesAccountId** | **long** | The id of the optional sales account of the product.  The optional sales account is the account the sale will be posted to, if the product is included on a sales order line that is invoiced, and that sales order line is set to trigger the use of the optional sales account.  If null, the product will inherit the optional sales account from the product group or the general sales settings on the client (in that order).  The concept of sales accounts is also explained in the common workflow articles. | [optional] 
**ProductGroupCode** | **string** | The code of the product group this product belong to.  If not provided, the product will be placed in the default product group.  Note that if ProductGroupId is set as well in the request, ProductGroupId takes precedence and ProductGroupCode is ignored. | [optional] 
**ProductGroupId** | **long** | The id of the product group this product belong to.  If not provided, the product will be placed in the default product group. | [optional] 
**ProductType** | **ProductType** |  | [optional] 
**StandardSalesAccount** | **long** | The code of the standard sales account of the product.  The standard sales account is the default account the sale will be posted to if the product is included on a sales order line that is invoiced.  If null, the product will inherit the standard sales account from the product group or the general sales settings on the client (in that order).  The concept of sales accounts is also explained in the common workflow articles.  Note that if StandardSalesAccountId is set as well in the request, StandardSalesAccountId takes precedence and StandardSalesAccount is ignored. | [optional] 
**StandardSalesAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**StandardSalesAccountId** | **long** | The id of the standard sales account of the product.  The standard sales account is the default account the sale will be posted to if the product is included on a sales order line that is invoiced.  If null, the product will inherit the standard sales account from the product group or the general sales settings on the client (in that order).  The concept of sales accounts is also explained in the common workflow articles. | [optional] 
**StockOnHand** | **double** | The number of products in stock.  Might differ from the available stock if confirmed sales orders exists, thus reserving a portion of the stock. | [optional] 
**UnitCost** | **double** | The cost per unit of the product.  If null, the product will inherit the unit cost from the product group. | [optional] 
**UnitOfMeasureCode** | **UnitOfMeasureType** |  | [optional] 
**UnitPrice** | **double** | The sales price per unit of the product.  If null, the product will inherit the unit price from the product group. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


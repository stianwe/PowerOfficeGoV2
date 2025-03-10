# PowerOfficeGoV2.Model.ProductGroupPostDto
DTO for creating a ProductGroup.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the product group. | [optional] 
**Description** | **string** | The description of the product group. | [optional] 
**IsArchived** | **bool** | Value indicating whether the product group is archived (set inactive).  Default is false.  Archived product groups will be unavailable for usage in the GUI. | [optional] 
**Name** | **string** | The name of the product group. | [optional] 
**OptionalSalesAccount** | **long** | The code of the optional sales account of the product group.  Products assigned to this product group will inherit the optional sales account from the group, if not set/overridden on the product object.  The optional sales account is the account the sale will be posted to, if the product is included on a sales order line that is invoiced, and that sales order line is set to trigger the use of the optional sales account.  If null, the product group will inherit the optional sales account from the the general sales settings on the client.  The concept of sales accounts is also explained in the common workflow articles.  Note that if OptionalSalesAccountId is set as well in the request, OptionalSalesAccountId takes precedence and OptionalSalesAccount is ignored. | [optional] 
**OptionalSalesAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**OptionalSalesAccountId** | **long** | The id of the optional sales account of the product group.  Products assigned to this product group will inherit the optional sales account from the group, if not set/overridden on the product object.  The optional sales account is the account the sale will be posted to, if the product is included on a sales order line that is invoiced, and that sales order line is set to trigger the use of the optional sales account.  If null, the product group will inherit the optional sales account from the the general sales settings on the client. | [optional] 
**ProductType** | **ProductType** |  | [optional] 
**StandardSalesAccount** | **long** | The code of the standard sales account of the product group.  Products assigned to this product group will inherit the standard sales account from the group, if not set/overridden on the product object.  The standard sales account is the default account the sale will be posted to if the product is included on a sales order line that is invoiced.  If null, the product group will inherit the standard sales account from the general sales settings on the client.  The concept of sales accounts is also explained in the common workflow articles.  Note that if StandardSalesAccountId is set as well in the request, StandardSalesAccountId takes precedence and StandardSalesAccount is ignored. | [optional] 
**StandardSalesAccountAgricultureDepartment** | **AgricultureDepartment** |  | [optional] 
**StandardSalesAccountId** | **long** | The id of the standard sales account of the product group.  Products assigned to this product group will inherit the standard sales account from the group, if not set/overridden on the product object.  The standard sales account is the default account the sale will be posted to if the product is included on a sales order line that is invoiced.  If null, the product group will inherit the standard sales account from the general sales settings on the client. | [optional] 
**UnitCost** | **double** | The cost per unit of the product group.  Products assigned to this group will inherit the unitCost from the group, if not set/overridden on the product object. | [optional] 
**UnitOfMeasureCode** | **UnitOfMeasureType** |  | [optional] 
**UnitPrice** | **double** | The sales price per unit of the product group.  Products assigned to this group will inherit the unitPrice from the group, if not set/overridden on the product object. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


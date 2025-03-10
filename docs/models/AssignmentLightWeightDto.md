# PowerOfficeGoV2.Model.AssignmentLightWeightDto
The available properties for the Quality Assignment Light DTO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManagerSubledgerAccountId** | **long** | The identifier of the employee subledger account, identifying the employee set as the assignment manager for this quality assignment. Employees can be queried and identified using the Employees endpoint | 
**AgreementSignedDate** | **DateTime** | The date the assignment agreement was signed. | [optional] [readonly] 
**AssociateSubledgerAccountId** | **long** | The identifier of the employee subledger account, identifying the employee set as the assignment associate for this quality assignment. If null, this property inherit from the assignment manager property. Employees can be queried and identified using the Employees endpoint | [optional] [readonly] 
**CurrentAgreementDate** | **DateTime** | The current date of the quality assignment agreement. | [optional] [readonly] 
**CustomerContactPersonId** | **long** | The id of the customer&#39;s contact person associated with the quality assignment. Contact persons can be queried and identified using the ContactPersons endpoint. | [optional] [readonly] 
**CustomerSubledgerAccountId** | **long** | The id of the customer subledger account, identifying the customer associated with the quality assignment. Customers can be queried and identified using the Customers endpoint. | [optional] [readonly] 
**Description** | **string** | The description of the quality assignment. | [optional] [readonly] 
**EndDate** | **DateTime** | The start date of the quality assignment. Date is inclusive. | [optional] [readonly] 
**Id** | **long** | The identifier of the quality assignment entity. The id is assigned by Go when the assignment entity is created. | [optional] [readonly] 
**KeyAccountManagerSubledgerAccountId** | **long** | The identifier of the employee subledger account, identifying the employee set as the key account manager for this quality assignment. If null, this property inherit from the assignment manager property. Employees can be queried and identified using the Employees endpoint | [optional] [readonly] 
**PayrollManagerSubledgerAccountId** | **long** | The identifier of the employee subledger account, identifying the employee set as the assignment payroll manager for this quality assignment. If null, this property inherit from the assignment manager property. Employees can be queried and identified using the Employees endpoint | [optional] [readonly] 
**ProjectId** | **long** | The id of the project associated with the quality assignment. Projects can be queried and identified using the Project endpoint. | [optional] [readonly] 
**RevisionDate** | **DateTime** | The date of the last revision of the assignment. | [optional] [readonly] 
**StartDate** | **DateTime** | The start date of the quality assignment. Date is inclusive. | [optional] [readonly] 
**Status** | **AssignmentAgreementStatus** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


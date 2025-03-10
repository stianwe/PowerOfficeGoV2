# PowerOfficeGoV2.Model.AssignmentGeneralDto
The available properties for the Quality Assignment General DTO in Go

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgreementSignedDate** | **DateOnly** | The date the assignment agreement was signed. | [optional] 
**AssociateSubledgerAccountId** | **long** | The identifier of the employee subledger account, identifying the employee set as the assignment associate for this quality assignment. If null, this property inherit from the assignment manager property. Employees can be queried and identified using the Employees endpoint | [optional] 
**AuditingCompanyId** | **long** | The id of the audit company. Relevant only the customer is subject for audit, ie. AuditStatus is &#39;Yes&#39; | [optional] 
**AuditorId** | **long** | The id of the auditor. Relevant only the customer is subject for audit, ie. AuditStatus is &#39;Yes&#39; | [optional] 
**CurrentAgreementDate** | **DateOnly** | The current date of the quality assignment agreement. | [optional] 
**CustomerContactPersonId** | **long** | The id of the customer&#39;s contact person associated with the quality assignment. Contact persons can be queried and identified using the ContactPersons endpoint. | [optional] 
**CustomerSubledgerAccountId** | **long** | The id of the customer subledger account, identifying the customer associated with the quality assignment. Customers can be queried and identified using the Customers endpoint. | [optional] 
**Description** | **string** | The description of the quality assignment. | [optional] 
**EndDate** | **DateOnly** | The start date of the quality assignment. Date is inclusive. | [optional] 
**Id** | **long** | The identifier of the quality assignment entity. The id is assigned by Go when the assignment entity is created. | [optional] [readonly] 
**KeyAccountManagerSubledgerAccountId** | **long** | The identifier of the employee subledger account, identifying the employee set as the key account manager for this quality assignment. If null, this property inherit from the assignment manager property. Employees can be queried and identified using the Employees endpoint | [optional] 
**ManagerSubledgerAccountId** | **long** | The identifier of the employee subledger account, identifying the employee set as the assignment manager for this quality assignment. Employees can be queried and identified using the Employees endpoint | [optional] 
**NoticePeriod** | **int** | The notice period, in months, if the agreement should be resigned.  Must be a positive integer between 1 and 24. | [optional] 
**PayrollManagerSubledgerAccountId** | **long** | The identifier of the employee subledger account, identifying the employee set as the assignment payroll manager for this quality assignment. If null, this property inherit from the assignment manager property. Employees can be queried and identified using the Employees endpoint | [optional] 
**ProjectId** | **long** | The id of the project associated with the quality assignment. Projects can be queried and identified using the Project endpoint. | [optional] 
**PurposeForContact** | **string** | A description of the purpose for contact. | [optional] 
**ReasonForContact** | **string** | A description of the reason for contact. | [optional] 
**RevisionDate** | **DateOnly** | The date of the last revision of the assignment. | [optional] 
**StartDate** | **DateOnly** | The start date of the quality assignment. Date is inclusive. | [optional] 
**Status** | **AssignmentAgreementStatus** |  | [optional] 
**SubjectToAudit** | **SubjectToAuditType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


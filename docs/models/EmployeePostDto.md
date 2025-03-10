# PowerOfficeGoV2.Model.EmployeePostDto
The Employee post DTO contains properties relevant to creating a new employee object in Go.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactGroupIds** | **List&lt;long&gt;** | The contact group ids the current contact is part of, or sets contact group id you want to add this contact to. | [optional] 
**DateOfBirth** | **DateOnly** | The date of birth of the employee. | [optional] 
**DepartmentCode** | **string** | The code of the department this employee is associated with.  The department entity must exist in Go in order to set the code.  Note that if DepartmentId is set as well in the request, DepartmentId takes precedence and DepartmentCode is ignored. | [optional] 
**DepartmentId** | **long** | The id of the department this employee is associated with.  Use the Departments endpoint to retrieve and/or create departments. | [optional] 
**EmailAddress** | **string** | The (general) e-mail address registered for the employee. | [optional] 
**EndDate** | **DateOnly** | The end date of the employment of this employee.  Note that this field has no relation to the employment entity that is reported (a-melding). | [optional] 
**ExternalImportReference** | **string** | The external import reference of the employee.  This field is not available in the GUI, but can be used by the integrating party to reference the external system.  The field must be unique within each class of Contacts (unique for customers, suppliers or employees).  Max length 50 characters. | [optional] 
**ExternalNumber** | **long** | The external number of the employee.  This field can be used to reference the employee number in the external system, if the employee numbers are not kept in 1:1 sync between Go and the external system.  The field is available in the GUI with the name \&quot;External Code\&quot;.  The field must be unique within each class of Contacts (unique for customers, suppliers or employees).  Note that in file imports to Go (including file imports using the ImportFile endpoint), this number has precedence over the employee number. I.e. when importing vouchers with employee sub-ledger entries using a file, with the employee number 1 set in the file, the import will choose the employee with ExternalNumber 1 over the employee with Number 1. This is the case for file imports only. | [optional] 
**FirstName** | **string** | The first name of the employee.  Required when creating new employees (POST operations). | 
**Gender** | **Gender** |  | [optional] 
**HiredDate** | **DateOnly** | The date the employee was hired. | [optional] 
**InternationalIdCountryCode** | **string** | The ISO 3166-1 alfa-2 country code (Two characters).  Relevant (and required) only if InternationalIdReportToAltinn is set to true. | [optional] 
**InternationalIdNumber** | **string** | The international Id number. For privacy reasons queries returns &#39;hidden&#39; if this field has a value and null if it&#39;s empty.  Access to retrieving the value must be granted by the api team by a special privilege (which also grant access to SSN and gender).  Relevant (and required) only if InternationalIdReportToAltinn is set to true. | [optional] 
**InternationalIdReportToAltinn** | **bool** | Value indicating whether International ID should be reported to Altinn (Related to tax card and payroll reporting). | [optional] 
**InternationalIdType** | **InternationalIdType** |  | [optional] 
**IsArchived** | **bool** | Value indicating whether this contact entity is/should be archived (set inactive).  Cannot be set if the contact have ledger balances (as either an employee, a customer or as a supplier). | [optional] 
**JobTitle** | **string** | The job title of the employee. | [optional] 
**LastName** | **string** | The last name of the employee.  Required when creating new employees (POST operations). | 
**LocationCode** | **string** | The code of the location this employee is associated with.  The location entity must exist in order to set this property.  Note that if LocationId is set as well in the request, LocationId takes precedence and LocationCode is ignored. | [optional] 
**LocationId** | **long** | The id of the location this employee is associated with.  Use the Locations endpoint to retrieve and/or create locations. | [optional] 
**MailAddress** | [**ContactAddressPostDto**](ContactAddressPostDto.md) |  | [optional] 
**ManagerEmployeeId** | **long** | The employee id of the manager of the employee. | [optional] 
**ManagerEmployeeNo** | **long** | The employee number of the manager of the employee.  Note that if ManagerEmployeeId is set as well in the request, ManagerEmployeeId takes precedence and ManagerEmployeeNo is ignored. | [optional] 
**NationalIdNumber** | **string** | The (Norwegian) national identity number (also called Social Security Number) or D-number.  For privacy reasons queries returns &#39;hidden&#39; if this field has a value and null if empty.  Access to retrieving the value must be granted by the api team by a special privilege (which also grant access to InternationalId and gender).  Note that the number is validated for the correct syntax when set. | [optional] 
**Number** | **long** | The number of the employee.  The number will also represent the employee ledger account, used for employee ledger transactions.  When creating new employees and setting the number (as opposed to letting Go assign the next available number if left blank), the number must be within range of the employee legder numberseries that exist on the client in Go. | [optional] 
**PhoneNumber** | **string** | The phone number of the employee. | [optional] 
**StartDate** | **DateOnly** | The start date of the employment of this employee.  Note that this field has no relation to the employment entity that is reported (a-melding). | [optional] 
**SubLedgerNumberSeriesId** | **Guid** | The Id of the subledgerseries this employee belong in.  Relevant if the client have multiple employee subledger series, and if so highly relevant in POST calls if the integrating party does not set Number but lets Go assign the next available Number.  In such cases, Go will create the employee in the default subledger series, unless this property is set. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Model.InvoiceDeliveryType
Invoice delivery type specifying how an outgoing invoice should or will be delivered to a customer.<p>Members:</p><ul><li><i>PdfByEmail</i> - Invoice will be delivered as email with PDF as attachment.                 Can only be used if the customer have an e-mail address registered (either eMailAddress or invoiceEmailAddress).</li><li><i>Print</i> - Invoice will be printed and delivered physically.                 \"Sending\" the invoice in Go will generate a PDF for download and print.</li><li><i>EHF</i> - Invoice will be delivered over EHF.                 Can only be set if the customers organizationNumber is set and the number is registered in ELMA.</li><li><i>AvtaleGiro</i> - Invoice will be delivered over AvtaleGiro.                 Cannot be set directly (set by the customer in an external process).</li><li><i>External</i> - Invoice will be prepared for delivery over an external third party integration.                 Can only be set if the client have such an integration active.</li><li><i>Efaktura</i> - Invoice will be delivered by Efaktura.                 Cannot be set directly (set by the customer on an external process).</li><li><i>Factoring</i> - The invoice will be prepared for delivered over an external third party factoring integration.                 Can only be set if the client have such an integration active.</li></ul>

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


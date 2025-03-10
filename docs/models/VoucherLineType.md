# PowerOfficeGoV2.Model.VoucherLineType
Enum defining what kind of line the voucher line on a (outgoing) voucher is.<p>Members:</p><ul><li><i>Normal</i> - A normal (sales) line with a product and an account transaction</li><li><i>Text</i> - A text line, no account transaction</li><li><i>Summary</i> - A summary or subtotal line.                 Will summarize total hours from lines with the unit of measure type hours and/or total amounts, for the lines placed above this line.                 No account transaction</li><li><i>InvoiceFee</i> - A line with the invoice fee, if invoice fee is used on this client.                 Will have an account transaction.</li><li><i>TotalHours</i> - A summary line of the hours.                 Will summarize total hours from lines with the unit of measure type hours, for the lines that are placed above this line.                 No account transaction.</li></ul>

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


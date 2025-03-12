using System.Linq;
using PowerOfficeGoV2.Model;

namespace PowerOfficeGoV2.Extensions;

/// <summary>
/// Extension methods for mapping between Dtos
/// </summary>
public static class MapperExtensions
{
    /// <summary>
    /// Converts the given <see cref="SupplierInvoiceJournalEntryVoucherDto"/> to a <see cref="SupplierInvoiceJournalEntryVoucherPostDto"/>
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static SupplierInvoiceJournalEntryVoucherPostDto ToPost(this SupplierInvoiceJournalEntryVoucherDto source)
        => new(
            source.CidOption,
            source.ClientBankAccountIdOption,
            default,
            source.ContractNoOption,
            source.CurrencyAmountOption,
            source.CurrencyCodeOption,
            source.CurrencyExchangeRateOption,
            source.CurrencyRegistryCodeOption,
            source.CurrencyRegistryTextOption,
            source.DepartmentIdOption,
            source.DescriptionOption,
            source.Dim1IdOption,
            source.Dim2IdOption,
            source.Dim3IdOption,
            source.DueDateOption,
            source.InvoiceNoOption,
            source.LocationIdOption,
            source.PaymentDateOption,
            source.PaymentOnHoldOption,
            source.PayoutOption,
            source.ProjectIdOption,
            source.PurchaseOrderReferenceOption,
            source.SupplierAccountIdOption,
            source.SupplierBankAccountIdOption,
            source.SupplierVoucherLinesOption,
            source.VoucherDateOption);

    /// <summary>
    /// Converts the given <see cref="SupplierCreditNoteJournalEntryVoucherDto"/> to a <see cref="SupplierCreditNoteJournalEntryVoucherPostDto"/>
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static SupplierCreditNoteJournalEntryVoucherPostDto ToPost(this SupplierCreditNoteJournalEntryVoucherDto source)
        => new(
            source.AppliesInvoiceIdOption,
            source.AppliesInvoiceNoOption,
            source.CidOption,
            source.ClientBankAccountIdOption,
            default,
            source.CreditNoteNoOption,
            source.CurrencyAmountOption,
            source.CurrencyCodeOption,
            source.CurrencyExchangeRateOption,
            source.CurrencyRegistryCodeOption,
            source.CurrencyRegistryTextOption,
            source.DepartmentIdOption,
            source.DescriptionOption,
            source.Dim1IdOption,
            source.Dim2IdOption,
            source.Dim3IdOption,
            source.LocationIdOption,
            source.PaymentDateOption,
            source.PaymentOnHoldOption,
            source.PayoutOption,
            source.ProjectIdOption,
            source.SupplierAccountIdOption,
            source.SupplierBankAccountIdOption,
            source.SupplierVoucherLinesOption,
            source.VoucherDateOption);

    /// <summary>
    /// Converts the given <see cref="ManualJournalEntryVoucherDto"/> to a <see cref="ManualJournalEntryVoucherPostDto"/>
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static ManualJournalEntryVoucherPostDto ToPost(this ManualJournalEntryVoucherDto source)
        => new(
            default,
            source.CurrencyCodeOption,
            source.DepartmentIdOption,
            source.DescriptionOption,
            source.Dim1IdOption,
            source.Dim2IdOption,
            source.Dim3IdOption,
            source.LocationIdOption,
            source.ManualVoucherLines?.Select(line => line.ToPost()).ToList());

    /// <summary>
    /// Converts the given <see cref="ManualJournalEntryVoucherLineDto"/> to a <see cref="ManualJournalEntryVoucherLinePostDto"/>
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static ManualJournalEntryVoucherLinePostDto ToPost(this ManualJournalEntryVoucherLineDto source)
        => new(
            source.AccrualOption,
            source.AgricultureDetailsOption,
            source.CreditAccountIdOption,
            source.CreditVatIdOption,
            source.CreditVatReturnSpecificationOption,
            source.CurrencyAmountOption,
            source.CurrencyCodeOption,
            source.CurrencyExchangeRateOption,
            source.DebitAccountIdOption,
            source.DebitVatIdOption,
            source.DebitVatReturnSpecificationOption,
            source.DepartmentIdOption,
            source.DescriptionOption,
            source.Dim1IdOption,
            source.Dim2IdOption,
            source.Dim3IdOption,
            source.LocationIdOption,
            source.PostingDateOption,
            source.ProductIdOption,
            source.ProjectIdOption,
            source.QuantityOption,
            source.Quantity2Option);

    /// <summary>
    /// Converts the given <see cref="BankJournalEntryVoucherDto"/> to a <see cref="BankJournalEntryVoucherPostDto"/>
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static BankJournalEntryVoucherPostDto ToPost(this BankJournalEntryVoucherDto source)
        => new(
            source.BankVoucherLines?.Select(line => line.ToPost()).ToList(),
            default,
            source.CurrencyCodeOption,
            source.DepartmentIdOption,
            source.DescriptionOption,
            source.Dim1IdOption,
            source.Dim2IdOption,
            source.Dim3IdOption,
            source.LocationIdOption,
            source.ProjectIdOption,
            source.VoucherDateOption);

    /// <summary>
    /// Converts the given <see cref="BankJournalEntryVoucherLineDto"/> to a <see cref="BankJournalEntryVoucherLinePostDto"/>
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static BankJournalEntryVoucherLinePostDto ToPost(this BankJournalEntryVoucherLineDto source)
        => new(
            source.AccrualOption,
            source.AgricultureDetailsOption,
            source.CreditAccountIdOption,
            source.CreditVatIdOption,
            source.CreditVatReturnSpecificationOption,
            source.CurrencyAmountOption,
            source.CurrencyCodeOption,
            source.CurrencyExchangeRateOption,
            source.DebitAccountIdOption,
            source.DebitVatIdOption,
            source.DebitVatReturnSpecificationOption,
            source.DepartmentIdOption,
            source.DescriptionOption,
            source.Dim1IdOption,
            source.Dim2IdOption,
            source.Dim3IdOption,
            source.InvoiceNoOption,
            source.LocationIdOption,
            source.PostingDateOption,
            source.ProductIdOption,
            source.ProjectIdOption,
            source.QuantityOption,
            source.Quantity2Option);
}
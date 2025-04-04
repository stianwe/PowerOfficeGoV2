// <auto-generated>
/*
 * merged spec
 *
 * merged spec
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using PowerOfficeGoV2.Client;

namespace PowerOfficeGoV2.Model
{
    /// <summary>
    /// The lines of the manual voucher to be posted
    /// </summary>
    public partial class ManualVoucherLinePostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualVoucherLinePostDto" /> class.
        /// </summary>
        /// <param name="postingDate">The posting date.  This is the date of effect in the accounting system for the Amount and CurrencyAmount (also the currency  conversion date used by Go if the currency rate was not set explicit when posted).  Always present on transactions.</param>
        /// <param name="accountId">The id of the general ledger account or the subledger account to post the amount.</param>
        /// <param name="currencyAmount">The amount on the line, in the currency specified by the currency code of the voucher or the currency of the voucher line if available.  Gross amounts should be provided, along with the relevant vat code. The amount must be a positive or negative number not 0.</param>
        /// <param name="currencyCode">The currency code of the voucher line. Will inherit the currency code of the voucher head if not set.  The line currency amounts will be determined in the currency specified on the line. Currencies active on the  client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.</param>
        /// <param name="currencyExchangeRate">The normalized currency exchange rate. Always base 1.                Relevant to set if the voucher line have a foreign currency with a specific currency exchange rate.  If not set, the field will inherit the rate in Go for the posting date set. The rates in Go are retrieved  from ECB via api.</param>
        /// <param name="customMatchingReference">The custom matching reference of the line. This property may be used for matching purposes on sub-ledger  accounts, where entries posted with a CustomMatchingReference will be matched immediately with existing entries  in the sub-ledger that have the same CustomMatchingReference and opposite amount (unless existing entries are  already matched out).</param>
        /// <param name="departmentId">The department Id.</param>
        /// <param name="description">The description of the voucher line.</param>
        /// <param name="dim1Id">The id of the dimension 1 associated with the line.</param>
        /// <param name="dim2Id">The id of the dimension 2 associated with the line.</param>
        /// <param name="dim3Id">The id of the dimension 3 associated with the line.</param>
        /// <param name="externalLineReference">The external line reference associated with the line. This property can only be set using the api, in order  to reference the external system&#39;s line. Can be used to correlate/duplicate check transactions.</param>
        /// <param name="locationId">The id of the location dimension associated with the line.</param>
        /// <param name="productId">The product id associated with the line.</param>
        /// <param name="projectId">The id of the project associated with the line.</param>
        /// <param name="quantity">The quantity dimension set on the line.  Usually associated with the product set on the line.  If the client is an agriculture client, the quantity is associated with the unit1 of the general ledger account.</param>
        /// <param name="quantity2">The quantity2 dimension set on the line.  Relevant only for agriculture clients, where the quantity2 is associated with the unit2 of the general ledger account.</param>
        /// <param name="vatId">The id of the vat code used for the credit entry.</param>
        /// <param name="vatReturnSpecification">vatReturnSpecification</param>
        [JsonConstructor]
        public ManualVoucherLinePostDto(DateTimeOffset postingDate, long? accountId = default, Option<double?> currencyAmount = default, Option<string?> currencyCode = default, Option<double?> currencyExchangeRate = default, Option<string?> customMatchingReference = default, Option<long?> departmentId = default, Option<string?> description = default, Option<long?> dim1Id = default, Option<long?> dim2Id = default, Option<long?> dim3Id = default, Option<string?> externalLineReference = default, Option<long?> locationId = default, Option<long?> productId = default, Option<long?> projectId = default, Option<double?> quantity = default, Option<double?> quantity2 = default, int? vatId = default, Option<VatReturnSpecification?> vatReturnSpecification = default)
        {
            PostingDate = postingDate;
            AccountId = accountId;
            CurrencyAmountOption = currencyAmount;
            CurrencyCodeOption = currencyCode;
            CurrencyExchangeRateOption = currencyExchangeRate;
            CustomMatchingReferenceOption = customMatchingReference;
            DepartmentIdOption = departmentId;
            DescriptionOption = description;
            Dim1IdOption = dim1Id;
            Dim2IdOption = dim2Id;
            Dim3IdOption = dim3Id;
            ExternalLineReferenceOption = externalLineReference;
            LocationIdOption = locationId;
            ProductIdOption = productId;
            ProjectIdOption = projectId;
            QuantityOption = quantity;
            Quantity2Option = quantity2;
            VatId = vatId;
            VatReturnSpecificationOption = vatReturnSpecification;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of VatReturnSpecification
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<VatReturnSpecification?> VatReturnSpecificationOption { get; private set; }

        /// <summary>
        /// Gets or Sets VatReturnSpecification
        /// </summary>
        [JsonPropertyName("VatReturnSpecification")]
        public VatReturnSpecification? VatReturnSpecification { get { return this.VatReturnSpecificationOption; } set { this.VatReturnSpecificationOption = new(value); } }

        /// <summary>
        /// The posting date.  This is the date of effect in the accounting system for the Amount and CurrencyAmount (also the currency  conversion date used by Go if the currency rate was not set explicit when posted).  Always present on transactions.
        /// </summary>
        /// <value>The posting date.  This is the date of effect in the accounting system for the Amount and CurrencyAmount (also the currency  conversion date used by Go if the currency rate was not set explicit when posted).  Always present on transactions.</value>
        /* <example>Tue Sep 28 02:00:00 CEST 2021</example> */
        [JsonPropertyName("PostingDate")]
        public DateTimeOffset PostingDate { get; set; }

        /// <summary>
        /// The id of the general ledger account or the subledger account to post the amount.
        /// </summary>
        /// <value>The id of the general ledger account or the subledger account to post the amount.</value>
        /* <example>12345</example> */
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// Used to track the state of CurrencyAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> CurrencyAmountOption { get; private set; }

        /// <summary>
        /// The amount on the line, in the currency specified by the currency code of the voucher or the currency of the voucher line if available.  Gross amounts should be provided, along with the relevant vat code. The amount must be a positive or negative number not 0.
        /// </summary>
        /// <value>The amount on the line, in the currency specified by the currency code of the voucher or the currency of the voucher line if available.  Gross amounts should be provided, along with the relevant vat code. The amount must be a positive or negative number not 0.</value>
        /* <example>69420</example> */
        [JsonPropertyName("CurrencyAmount")]
        public double? CurrencyAmount { get { return this.CurrencyAmountOption; } set { this.CurrencyAmountOption = new(value); } }

        /// <summary>
        /// Used to track the state of CurrencyCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CurrencyCodeOption { get; private set; }

        /// <summary>
        /// The currency code of the voucher line. Will inherit the currency code of the voucher head if not set.  The line currency amounts will be determined in the currency specified on the line. Currencies active on the  client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.
        /// </summary>
        /// <value>The currency code of the voucher line. Will inherit the currency code of the voucher head if not set.  The line currency amounts will be determined in the currency specified on the line. Currencies active on the  client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.</value>
        /* <example>USD</example> */
        [JsonPropertyName("CurrencyCode")]
        public string? CurrencyCode { get { return this.CurrencyCodeOption; } set { this.CurrencyCodeOption = new(value); } }

        /// <summary>
        /// Used to track the state of CurrencyExchangeRate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> CurrencyExchangeRateOption { get; private set; }

        /// <summary>
        /// The normalized currency exchange rate. Always base 1.                Relevant to set if the voucher line have a foreign currency with a specific currency exchange rate.  If not set, the field will inherit the rate in Go for the posting date set. The rates in Go are retrieved  from ECB via api.
        /// </summary>
        /// <value>The normalized currency exchange rate. Always base 1.                Relevant to set if the voucher line have a foreign currency with a specific currency exchange rate.  If not set, the field will inherit the rate in Go for the posting date set. The rates in Go are retrieved  from ECB via api.</value>
        /* <example>10.78</example> */
        [JsonPropertyName("CurrencyExchangeRate")]
        public double? CurrencyExchangeRate { get { return this.CurrencyExchangeRateOption; } set { this.CurrencyExchangeRateOption = new(value); } }

        /// <summary>
        /// Used to track the state of CustomMatchingReference
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CustomMatchingReferenceOption { get; private set; }

        /// <summary>
        /// The custom matching reference of the line. This property may be used for matching purposes on sub-ledger  accounts, where entries posted with a CustomMatchingReference will be matched immediately with existing entries  in the sub-ledger that have the same CustomMatchingReference and opposite amount (unless existing entries are  already matched out).
        /// </summary>
        /// <value>The custom matching reference of the line. This property may be used for matching purposes on sub-ledger  accounts, where entries posted with a CustomMatchingReference will be matched immediately with existing entries  in the sub-ledger that have the same CustomMatchingReference and opposite amount (unless existing entries are  already matched out).</value>
        /* <example>123ABC</example> */
        [JsonPropertyName("CustomMatchingReference")]
        public string? CustomMatchingReference { get { return this.CustomMatchingReferenceOption; } set { this.CustomMatchingReferenceOption = new(value); } }

        /// <summary>
        /// Used to track the state of DepartmentId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> DepartmentIdOption { get; private set; }

        /// <summary>
        /// The department Id.
        /// </summary>
        /// <value>The department Id.</value>
        /* <example>12345</example> */
        [JsonPropertyName("DepartmentId")]
        public long? DepartmentId { get { return this.DepartmentIdOption; } set { this.DepartmentIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; private set; }

        /// <summary>
        /// The description of the voucher line.
        /// </summary>
        /// <value>The description of the voucher line.</value>
        /* <example>Hello accounting world!</example> */
        [JsonPropertyName("Description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Dim1Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> Dim1IdOption { get; private set; }

        /// <summary>
        /// The id of the dimension 1 associated with the line.
        /// </summary>
        /// <value>The id of the dimension 1 associated with the line.</value>
        /* <example>12345</example> */
        [JsonPropertyName("Dim1Id")]
        public long? Dim1Id { get { return this.Dim1IdOption; } set { this.Dim1IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Dim2Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> Dim2IdOption { get; private set; }

        /// <summary>
        /// The id of the dimension 2 associated with the line.
        /// </summary>
        /// <value>The id of the dimension 2 associated with the line.</value>
        /* <example>12345</example> */
        [JsonPropertyName("Dim2Id")]
        public long? Dim2Id { get { return this.Dim2IdOption; } set { this.Dim2IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Dim3Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> Dim3IdOption { get; private set; }

        /// <summary>
        /// The id of the dimension 3 associated with the line.
        /// </summary>
        /// <value>The id of the dimension 3 associated with the line.</value>
        /* <example>12345</example> */
        [JsonPropertyName("Dim3Id")]
        public long? Dim3Id { get { return this.Dim3IdOption; } set { this.Dim3IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExternalLineReference
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ExternalLineReferenceOption { get; private set; }

        /// <summary>
        /// The external line reference associated with the line. This property can only be set using the api, in order  to reference the external system&#39;s line. Can be used to correlate/duplicate check transactions.
        /// </summary>
        /// <value>The external line reference associated with the line. This property can only be set using the api, in order  to reference the external system&#39;s line. Can be used to correlate/duplicate check transactions.</value>
        /* <example>123ABC</example> */
        [JsonPropertyName("ExternalLineReference")]
        public string? ExternalLineReference { get { return this.ExternalLineReferenceOption; } set { this.ExternalLineReferenceOption = new(value); } }

        /// <summary>
        /// Used to track the state of LocationId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> LocationIdOption { get; private set; }

        /// <summary>
        /// The id of the location dimension associated with the line.
        /// </summary>
        /// <value>The id of the location dimension associated with the line.</value>
        /* <example>12345</example> */
        [JsonPropertyName("LocationId")]
        public long? LocationId { get { return this.LocationIdOption; } set { this.LocationIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ProductId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ProductIdOption { get; private set; }

        /// <summary>
        /// The product id associated with the line.
        /// </summary>
        /// <value>The product id associated with the line.</value>
        /* <example>12345</example> */
        [JsonPropertyName("ProductId")]
        public long? ProductId { get { return this.ProductIdOption; } set { this.ProductIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ProjectId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ProjectIdOption { get; private set; }

        /// <summary>
        /// The id of the project associated with the line.
        /// </summary>
        /// <value>The id of the project associated with the line.</value>
        /* <example>12345</example> */
        [JsonPropertyName("ProjectId")]
        public long? ProjectId { get { return this.ProjectIdOption; } set { this.ProjectIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Quantity
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> QuantityOption { get; private set; }

        /// <summary>
        /// The quantity dimension set on the line.  Usually associated with the product set on the line.  If the client is an agriculture client, the quantity is associated with the unit1 of the general ledger account.
        /// </summary>
        /// <value>The quantity dimension set on the line.  Usually associated with the product set on the line.  If the client is an agriculture client, the quantity is associated with the unit1 of the general ledger account.</value>
        /* <example>100</example> */
        [JsonPropertyName("Quantity")]
        public double? Quantity { get { return this.QuantityOption; } set { this.QuantityOption = new(value); } }

        /// <summary>
        /// Used to track the state of Quantity2
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> Quantity2Option { get; private set; }

        /// <summary>
        /// The quantity2 dimension set on the line.  Relevant only for agriculture clients, where the quantity2 is associated with the unit2 of the general ledger account.
        /// </summary>
        /// <value>The quantity2 dimension set on the line.  Relevant only for agriculture clients, where the quantity2 is associated with the unit2 of the general ledger account.</value>
        /* <example>200</example> */
        [JsonPropertyName("Quantity2")]
        public double? Quantity2 { get { return this.Quantity2Option; } set { this.Quantity2Option = new(value); } }

        /// <summary>
        /// The id of the vat code used for the credit entry.
        /// </summary>
        /// <value>The id of the vat code used for the credit entry.</value>
        /* <example>12345</example> */
        [JsonPropertyName("VatId")]
        public int? VatId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManualVoucherLinePostDto {\n");
            sb.Append("  PostingDate: ").Append(PostingDate).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CurrencyAmount: ").Append(CurrencyAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyExchangeRate: ").Append(CurrencyExchangeRate).Append("\n");
            sb.Append("  CustomMatchingReference: ").Append(CustomMatchingReference).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Dim1Id: ").Append(Dim1Id).Append("\n");
            sb.Append("  Dim2Id: ").Append(Dim2Id).Append("\n");
            sb.Append("  Dim3Id: ").Append(Dim3Id).Append("\n");
            sb.Append("  ExternalLineReference: ").Append(ExternalLineReference).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Quantity2: ").Append(Quantity2).Append("\n");
            sb.Append("  VatId: ").Append(VatId).Append("\n");
            sb.Append("  VatReturnSpecification: ").Append(VatReturnSpecification).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ManualVoucherLinePostDto" />
    /// </summary>
    public class ManualVoucherLinePostDtoJsonConverter : JsonConverter<ManualVoucherLinePostDto>
    {
        /// <summary>
        /// The format to use to serialize PostingDate
        /// </summary>
        public static string PostingDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="ManualVoucherLinePostDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ManualVoucherLinePostDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTimeOffset?> postingDate = default;
            Option<long?> accountId = default;
            Option<double?> currencyAmount = default;
            Option<string?> currencyCode = default;
            Option<double?> currencyExchangeRate = default;
            Option<string?> customMatchingReference = default;
            Option<long?> departmentId = default;
            Option<string?> description = default;
            Option<long?> dim1Id = default;
            Option<long?> dim2Id = default;
            Option<long?> dim3Id = default;
            Option<string?> externalLineReference = default;
            Option<long?> locationId = default;
            Option<long?> productId = default;
            Option<long?> projectId = default;
            Option<double?> quantity = default;
            Option<double?> quantity2 = default;
            Option<int?> vatId = default;
            Option<VatReturnSpecification?> vatReturnSpecification = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "PostingDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                postingDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "AccountId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                accountId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "CurrencyAmount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                currencyAmount = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "CurrencyCode":
                            currencyCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "CurrencyExchangeRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                currencyExchangeRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "CustomMatchingReference":
                            customMatchingReference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "DepartmentId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                departmentId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "Description":
                            description = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Dim1Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dim1Id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "Dim2Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dim2Id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "Dim3Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dim3Id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "ExternalLineReference":
                            externalLineReference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "LocationId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                locationId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "ProductId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                productId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "ProjectId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                projectId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "Quantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "Quantity2":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity2 = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "VatId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                vatId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "VatReturnSpecification":
                            string? vatReturnSpecificationRawValue = utf8JsonReader.GetString();
                            if (vatReturnSpecificationRawValue != null)
                                vatReturnSpecification = new Option<VatReturnSpecification?>(VatReturnSpecificationValueConverter.FromStringOrDefault(vatReturnSpecificationRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!postingDate.IsSet)
                throw new ArgumentException("Property is required for class ManualVoucherLinePostDto.", nameof(postingDate));

            if (!accountId.IsSet)
                throw new ArgumentException("Property is required for class ManualVoucherLinePostDto.", nameof(accountId));

            if (!vatId.IsSet)
                throw new ArgumentException("Property is required for class ManualVoucherLinePostDto.", nameof(vatId));

            if (postingDate.IsSet && postingDate.Value == null)
                throw new ArgumentNullException(nameof(postingDate), "Property is not nullable for class ManualVoucherLinePostDto.");

            if (currencyAmount.IsSet && currencyAmount.Value == null)
                throw new ArgumentNullException(nameof(currencyAmount), "Property is not nullable for class ManualVoucherLinePostDto.");

            return new ManualVoucherLinePostDto(postingDate.Value!.Value!, accountId.Value!, currencyAmount, currencyCode, currencyExchangeRate, customMatchingReference, departmentId, description, dim1Id, dim2Id, dim3Id, externalLineReference, locationId, productId, projectId, quantity, quantity2, vatId.Value!, vatReturnSpecification);
        }

        /// <summary>
        /// Serializes a <see cref="ManualVoucherLinePostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="manualVoucherLinePostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ManualVoucherLinePostDto manualVoucherLinePostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, manualVoucherLinePostDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ManualVoucherLinePostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="manualVoucherLinePostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ManualVoucherLinePostDto manualVoucherLinePostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("PostingDate", manualVoucherLinePostDto.PostingDate.ToString(PostingDateFormat));

            if (manualVoucherLinePostDto.AccountId != null)
                writer.WriteNumber("AccountId", manualVoucherLinePostDto.AccountId.Value);
            else
                writer.WriteNull("AccountId");

            if (manualVoucherLinePostDto.CurrencyAmountOption.IsSet)
                writer.WriteNumber("CurrencyAmount", manualVoucherLinePostDto.CurrencyAmountOption.Value!.Value);

            if (manualVoucherLinePostDto.CurrencyCodeOption.IsSet)
                if (manualVoucherLinePostDto.CurrencyCodeOption.Value != null)
                    writer.WriteString("CurrencyCode", manualVoucherLinePostDto.CurrencyCode);
                else
                    writer.WriteNull("CurrencyCode");

            if (manualVoucherLinePostDto.CurrencyExchangeRateOption.IsSet)
                if (manualVoucherLinePostDto.CurrencyExchangeRateOption.Value != null)
                    writer.WriteNumber("CurrencyExchangeRate", manualVoucherLinePostDto.CurrencyExchangeRateOption.Value!.Value);
                else
                    writer.WriteNull("CurrencyExchangeRate");

            if (manualVoucherLinePostDto.CustomMatchingReferenceOption.IsSet)
                if (manualVoucherLinePostDto.CustomMatchingReferenceOption.Value != null)
                    writer.WriteString("CustomMatchingReference", manualVoucherLinePostDto.CustomMatchingReference);
                else
                    writer.WriteNull("CustomMatchingReference");

            if (manualVoucherLinePostDto.DepartmentIdOption.IsSet)
                if (manualVoucherLinePostDto.DepartmentIdOption.Value != null)
                    writer.WriteNumber("DepartmentId", manualVoucherLinePostDto.DepartmentIdOption.Value!.Value);
                else
                    writer.WriteNull("DepartmentId");

            if (manualVoucherLinePostDto.DescriptionOption.IsSet)
                if (manualVoucherLinePostDto.DescriptionOption.Value != null)
                    writer.WriteString("Description", manualVoucherLinePostDto.Description);
                else
                    writer.WriteNull("Description");

            if (manualVoucherLinePostDto.Dim1IdOption.IsSet)
                if (manualVoucherLinePostDto.Dim1IdOption.Value != null)
                    writer.WriteNumber("Dim1Id", manualVoucherLinePostDto.Dim1IdOption.Value!.Value);
                else
                    writer.WriteNull("Dim1Id");

            if (manualVoucherLinePostDto.Dim2IdOption.IsSet)
                if (manualVoucherLinePostDto.Dim2IdOption.Value != null)
                    writer.WriteNumber("Dim2Id", manualVoucherLinePostDto.Dim2IdOption.Value!.Value);
                else
                    writer.WriteNull("Dim2Id");

            if (manualVoucherLinePostDto.Dim3IdOption.IsSet)
                if (manualVoucherLinePostDto.Dim3IdOption.Value != null)
                    writer.WriteNumber("Dim3Id", manualVoucherLinePostDto.Dim3IdOption.Value!.Value);
                else
                    writer.WriteNull("Dim3Id");

            if (manualVoucherLinePostDto.ExternalLineReferenceOption.IsSet)
                if (manualVoucherLinePostDto.ExternalLineReferenceOption.Value != null)
                    writer.WriteString("ExternalLineReference", manualVoucherLinePostDto.ExternalLineReference);
                else
                    writer.WriteNull("ExternalLineReference");

            if (manualVoucherLinePostDto.LocationIdOption.IsSet)
                if (manualVoucherLinePostDto.LocationIdOption.Value != null)
                    writer.WriteNumber("LocationId", manualVoucherLinePostDto.LocationIdOption.Value!.Value);
                else
                    writer.WriteNull("LocationId");

            if (manualVoucherLinePostDto.ProductIdOption.IsSet)
                if (manualVoucherLinePostDto.ProductIdOption.Value != null)
                    writer.WriteNumber("ProductId", manualVoucherLinePostDto.ProductIdOption.Value!.Value);
                else
                    writer.WriteNull("ProductId");

            if (manualVoucherLinePostDto.ProjectIdOption.IsSet)
                if (manualVoucherLinePostDto.ProjectIdOption.Value != null)
                    writer.WriteNumber("ProjectId", manualVoucherLinePostDto.ProjectIdOption.Value!.Value);
                else
                    writer.WriteNull("ProjectId");

            if (manualVoucherLinePostDto.QuantityOption.IsSet)
                if (manualVoucherLinePostDto.QuantityOption.Value != null)
                    writer.WriteNumber("Quantity", manualVoucherLinePostDto.QuantityOption.Value!.Value);
                else
                    writer.WriteNull("Quantity");

            if (manualVoucherLinePostDto.Quantity2Option.IsSet)
                if (manualVoucherLinePostDto.Quantity2Option.Value != null)
                    writer.WriteNumber("Quantity2", manualVoucherLinePostDto.Quantity2Option.Value!.Value);
                else
                    writer.WriteNull("Quantity2");

            if (manualVoucherLinePostDto.VatId != null)
                writer.WriteNumber("VatId", manualVoucherLinePostDto.VatId.Value);
            else
                writer.WriteNull("VatId");

            if (manualVoucherLinePostDto.VatReturnSpecificationOption.IsSet)
                if (manualVoucherLinePostDto.VatReturnSpecificationOption!.Value != null)
                {
                    var vatReturnSpecificationRawValue = VatReturnSpecificationValueConverter.ToJsonValue(manualVoucherLinePostDto.VatReturnSpecificationOption.Value!.Value);
                    writer.WriteString("VatReturnSpecification", vatReturnSpecificationRawValue);
                }
                else
                    writer.WriteNull("VatReturnSpecification");
        }
    }
}

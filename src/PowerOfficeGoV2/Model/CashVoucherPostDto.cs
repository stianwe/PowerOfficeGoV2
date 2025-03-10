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
    /// Dto for cash bank voucher type
    /// </summary>
    public partial class CashVoucherPostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashVoucherPostDto" /> class.
        /// </summary>
        /// <param name="voucherDate">The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher.</param>
        /// <param name="currencyCode">The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.</param>
        /// <param name="description">The description field of the voucher header.</param>
        /// <param name="externalImportReference">The external import reference associated with the voucher. This property can be set by integrations creating  vouchers, in order to reference the external system and ensure a duplicate check (only one instance of the  reference can exist on the client). Can be used to correlate/duplicate check transactions. Guid&#39;s are  recommended, or other unique references. This property is only available using the api (not visible in the user  interface)</param>
        /// <param name="importedVoucherNo">The external voucher number. Can be used to reference the voucher number in the external system. The external  voucher number is visible in Go in various reports.</param>
        /// <param name="saftBatchId">The SAF-T batch id. This is the ID of the batch in the system that transferred the voucher. Should be set if  this voucher is a batch voucher containing the entries of multiple vouchers in the external system. When this  voucher is exported to SAF-T, this property is transactions BatchID in the SAF-T file. The external systems  SAF-T export should set the same BatchId on all the transactions that are included in this Voucher to ensure  audit trail. Max length 35 characters.</param>
        /// <param name="saftSourceId">The SAF-T source id. This is the ID of the system that generated the voucher. When this voucher is exported to  SAF-T, this property is mapped on the transactions SourceID in the SAF-T file. If the creating system is  required to export it&#39;s own SAF-T file, this source id should correspond with the SystemID in the SAF-T file of  the external system to ensure an audit trail. Max length is 35 characters.</param>
        /// <param name="voucherLines">The lines of the cash voucher to be posted</param>
        [JsonConstructor]
        public CashVoucherPostDto(DateOnly voucherDate, string? currencyCode = default, Option<string?> description = default, Option<string?> externalImportReference = default, Option<long?> importedVoucherNo = default, Option<string?> saftBatchId = default, Option<string?> saftSourceId = default, Option<List<CashVoucherLinePostDto>?> voucherLines = default)
        {
            VoucherDate = voucherDate;
            CurrencyCode = currencyCode;
            DescriptionOption = description;
            ExternalImportReferenceOption = externalImportReference;
            ImportedVoucherNoOption = importedVoucherNo;
            SaftBatchIdOption = saftBatchId;
            SaftSourceIdOption = saftSourceId;
            VoucherLinesOption = voucherLines;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher.
        /// </summary>
        /// <value>The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher.</value>
        /* <example>Wed Mar 20 01:00:00 CET 2024</example> */
        [JsonPropertyName("VoucherDate")]
        public DateOnly VoucherDate { get; set; }

        /// <summary>
        /// The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.
        /// </summary>
        /// <value>The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.</value>
        /* <example>EUR</example> */
        [JsonPropertyName("CurrencyCode")]
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; private set; }

        /// <summary>
        /// The description field of the voucher header.
        /// </summary>
        /// <value>The description field of the voucher header.</value>
        /* <example>My first voucher description</example> */
        [JsonPropertyName("Description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExternalImportReference
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ExternalImportReferenceOption { get; private set; }

        /// <summary>
        /// The external import reference associated with the voucher. This property can be set by integrations creating  vouchers, in order to reference the external system and ensure a duplicate check (only one instance of the  reference can exist on the client). Can be used to correlate/duplicate check transactions. Guid&#39;s are  recommended, or other unique references. This property is only available using the api (not visible in the user  interface)
        /// </summary>
        /// <value>The external import reference associated with the voucher. This property can be set by integrations creating  vouchers, in order to reference the external system and ensure a duplicate check (only one instance of the  reference can exist on the client). Can be used to correlate/duplicate check transactions. Guid&#39;s are  recommended, or other unique references. This property is only available using the api (not visible in the user  interface)</value>
        /* <example>123abc</example> */
        [JsonPropertyName("ExternalImportReference")]
        public string? ExternalImportReference { get { return this.ExternalImportReferenceOption; } set { this.ExternalImportReferenceOption = new(value); } }

        /// <summary>
        /// Used to track the state of ImportedVoucherNo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ImportedVoucherNoOption { get; private set; }

        /// <summary>
        /// The external voucher number. Can be used to reference the voucher number in the external system. The external  voucher number is visible in Go in various reports.
        /// </summary>
        /// <value>The external voucher number. Can be used to reference the voucher number in the external system. The external  voucher number is visible in Go in various reports.</value>
        /* <example>23145</example> */
        [JsonPropertyName("ImportedVoucherNo")]
        public long? ImportedVoucherNo { get { return this.ImportedVoucherNoOption; } set { this.ImportedVoucherNoOption = new(value); } }

        /// <summary>
        /// Used to track the state of SaftBatchId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SaftBatchIdOption { get; private set; }

        /// <summary>
        /// The SAF-T batch id. This is the ID of the batch in the system that transferred the voucher. Should be set if  this voucher is a batch voucher containing the entries of multiple vouchers in the external system. When this  voucher is exported to SAF-T, this property is transactions BatchID in the SAF-T file. The external systems  SAF-T export should set the same BatchId on all the transactions that are included in this Voucher to ensure  audit trail. Max length 35 characters.
        /// </summary>
        /// <value>The SAF-T batch id. This is the ID of the batch in the system that transferred the voucher. Should be set if  this voucher is a batch voucher containing the entries of multiple vouchers in the external system. When this  voucher is exported to SAF-T, this property is transactions BatchID in the SAF-T file. The external systems  SAF-T export should set the same BatchId on all the transactions that are included in this Voucher to ensure  audit trail. Max length 35 characters.</value>
        /* <example>12312</example> */
        [JsonPropertyName("SaftBatchId")]
        public string? SaftBatchId { get { return this.SaftBatchIdOption; } set { this.SaftBatchIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of SaftSourceId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SaftSourceIdOption { get; private set; }

        /// <summary>
        /// The SAF-T source id. This is the ID of the system that generated the voucher. When this voucher is exported to  SAF-T, this property is mapped on the transactions SourceID in the SAF-T file. If the creating system is  required to export it&#39;s own SAF-T file, this source id should correspond with the SystemID in the SAF-T file of  the external system to ensure an audit trail. Max length is 35 characters.
        /// </summary>
        /// <value>The SAF-T source id. This is the ID of the system that generated the voucher. When this voucher is exported to  SAF-T, this property is mapped on the transactions SourceID in the SAF-T file. If the creating system is  required to export it&#39;s own SAF-T file, this source id should correspond with the SystemID in the SAF-T file of  the external system to ensure an audit trail. Max length is 35 characters.</value>
        /* <example>System_123</example> */
        [JsonPropertyName("SaftSourceId")]
        public string? SaftSourceId { get { return this.SaftSourceIdOption; } set { this.SaftSourceIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of VoucherLines
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<CashVoucherLinePostDto>?> VoucherLinesOption { get; private set; }

        /// <summary>
        /// The lines of the cash voucher to be posted
        /// </summary>
        /// <value>The lines of the cash voucher to be posted</value>
        [JsonPropertyName("VoucherLines")]
        public List<CashVoucherLinePostDto>? VoucherLines { get { return this.VoucherLinesOption; } set { this.VoucherLinesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashVoucherPostDto {\n");
            sb.Append("  VoucherDate: ").Append(VoucherDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalImportReference: ").Append(ExternalImportReference).Append("\n");
            sb.Append("  ImportedVoucherNo: ").Append(ImportedVoucherNo).Append("\n");
            sb.Append("  SaftBatchId: ").Append(SaftBatchId).Append("\n");
            sb.Append("  SaftSourceId: ").Append(SaftSourceId).Append("\n");
            sb.Append("  VoucherLines: ").Append(VoucherLines).Append("\n");
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
            // CurrencyCode (string) maxLength
            if (this.CurrencyCode != null && this.CurrencyCode.Length > 3)
            {
                yield return new ValidationResult("Invalid value for CurrencyCode, length must be less than 3.", new [] { "CurrencyCode" });
            }

            // CurrencyCode (string) minLength
            if (this.CurrencyCode != null && this.CurrencyCode.Length < 0)
            {
                yield return new ValidationResult("Invalid value for CurrencyCode, length must be greater than 0.", new [] { "CurrencyCode" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CashVoucherPostDto" />
    /// </summary>
    public class CashVoucherPostDtoJsonConverter : JsonConverter<CashVoucherPostDto>
    {
        /// <summary>
        /// The format to use to serialize VoucherDate
        /// </summary>
        public static string VoucherDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="CashVoucherPostDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CashVoucherPostDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateOnly?> voucherDate = default;
            Option<string?> currencyCode = default;
            Option<string?> description = default;
            Option<string?> externalImportReference = default;
            Option<long?> importedVoucherNo = default;
            Option<string?> saftBatchId = default;
            Option<string?> saftSourceId = default;
            Option<List<CashVoucherLinePostDto>?> voucherLines = default;

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
                        case "VoucherDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                voucherDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "CurrencyCode":
                            currencyCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Description":
                            description = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "ExternalImportReference":
                            externalImportReference = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "ImportedVoucherNo":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                importedVoucherNo = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "SaftBatchId":
                            saftBatchId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "SaftSourceId":
                            saftSourceId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "VoucherLines":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                voucherLines = new Option<List<CashVoucherLinePostDto>?>(JsonSerializer.Deserialize<List<CashVoucherLinePostDto>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!voucherDate.IsSet)
                throw new ArgumentException("Property is required for class CashVoucherPostDto.", nameof(voucherDate));

            if (!currencyCode.IsSet)
                throw new ArgumentException("Property is required for class CashVoucherPostDto.", nameof(currencyCode));

            if (voucherDate.IsSet && voucherDate.Value == null)
                throw new ArgumentNullException(nameof(voucherDate), "Property is not nullable for class CashVoucherPostDto.");

            return new CashVoucherPostDto(voucherDate.Value!.Value!, currencyCode.Value!, description, externalImportReference, importedVoucherNo, saftBatchId, saftSourceId, voucherLines);
        }

        /// <summary>
        /// Serializes a <see cref="CashVoucherPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cashVoucherPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CashVoucherPostDto cashVoucherPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, cashVoucherPostDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CashVoucherPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cashVoucherPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CashVoucherPostDto cashVoucherPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("VoucherDate", cashVoucherPostDto.VoucherDate.ToString(VoucherDateFormat));

            if (cashVoucherPostDto.CurrencyCode != null)
                writer.WriteString("CurrencyCode", cashVoucherPostDto.CurrencyCode);
            else
                writer.WriteNull("CurrencyCode");

            if (cashVoucherPostDto.DescriptionOption.IsSet)
                if (cashVoucherPostDto.DescriptionOption.Value != null)
                    writer.WriteString("Description", cashVoucherPostDto.Description);
                else
                    writer.WriteNull("Description");

            if (cashVoucherPostDto.ExternalImportReferenceOption.IsSet)
                if (cashVoucherPostDto.ExternalImportReferenceOption.Value != null)
                    writer.WriteString("ExternalImportReference", cashVoucherPostDto.ExternalImportReference);
                else
                    writer.WriteNull("ExternalImportReference");

            if (cashVoucherPostDto.ImportedVoucherNoOption.IsSet)
                if (cashVoucherPostDto.ImportedVoucherNoOption.Value != null)
                    writer.WriteNumber("ImportedVoucherNo", cashVoucherPostDto.ImportedVoucherNoOption.Value!.Value);
                else
                    writer.WriteNull("ImportedVoucherNo");

            if (cashVoucherPostDto.SaftBatchIdOption.IsSet)
                if (cashVoucherPostDto.SaftBatchIdOption.Value != null)
                    writer.WriteString("SaftBatchId", cashVoucherPostDto.SaftBatchId);
                else
                    writer.WriteNull("SaftBatchId");

            if (cashVoucherPostDto.SaftSourceIdOption.IsSet)
                if (cashVoucherPostDto.SaftSourceIdOption.Value != null)
                    writer.WriteString("SaftSourceId", cashVoucherPostDto.SaftSourceId);
                else
                    writer.WriteNull("SaftSourceId");

            if (cashVoucherPostDto.VoucherLinesOption.IsSet)
                if (cashVoucherPostDto.VoucherLinesOption.Value != null)
                {
                    writer.WritePropertyName("VoucherLines");
                    JsonSerializer.Serialize(writer, cashVoucherPostDto.VoucherLines, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("VoucherLines");
        }
    }
}

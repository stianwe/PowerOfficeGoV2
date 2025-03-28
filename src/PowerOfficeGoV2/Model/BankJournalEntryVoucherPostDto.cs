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
    /// Dto for posting bank journal entry voucher
    /// </summary>
    public partial class BankJournalEntryVoucherPostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankJournalEntryVoucherPostDto" /> class.
        /// </summary>
        /// <param name="bankJournalLines">The lines of the bank journal</param>
        /// <param name="comment">Optional comment that will be shown in the journal entry history in Go.  Only new vouchers will get the comment as part of the initial history.  It is thus not possible to change the comment later, and it will not be returned in API-calls.  The comment text should be human-readable. If necessary, use newline characters (\\n) to format the text for better readability</param>
        /// <param name="currencyCode">The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.</param>
        /// <param name="departmentId">The department Id of the voucher header.  The lines will inherit the department from the voucher head if not specified on the lines.  Departments can be queried and identified using the Department service.</param>
        /// <param name="description">The description field of the voucher header.</param>
        /// <param name="dim1Id">The id of the dimension 1 associated with the voucher header.  The lines will inherit the dim1 from the voucher head if not specified on the lines.</param>
        /// <param name="dim2Id">The id of the dimension 2 associated with the voucher header.  The lines will inherit the dim2 from the voucher head if not specified on the lines.</param>
        /// <param name="dim3Id">The id of the dimension 3 associated with the voucher header.  The lines will inherit the dim3 from the voucher head if not specified on the lines.</param>
        /// <param name="locationId">The id of the location dimension associated with the voucher header.  The lines will inherit the location from the voucher head if not specified on the lines.</param>
        /// <param name="projectId">The id of the project associated with the voucher header.  The lines will inherit the project from the voucher head if not specified on the lines.</param>
        /// <param name="voucherDate">The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher.</param>
        [JsonConstructor]
        public BankJournalEntryVoucherPostDto(Option<List<BankJournalEntryVoucherLinePostDto>?> bankJournalLines = default, Option<string?> comment = default, string? currencyCode = default, Option<long?> departmentId = default, Option<string?> description = default, Option<long?> dim1Id = default, Option<long?> dim2Id = default, Option<long?> dim3Id = default, Option<long?> locationId = default, Option<long?> projectId = default, DateTimeOffset? voucherDate = default)
        {
            BankJournalLinesOption = bankJournalLines;
            CommentOption = comment;
            CurrencyCode = currencyCode;
            DepartmentIdOption = departmentId;
            DescriptionOption = description;
            Dim1IdOption = dim1Id;
            Dim2IdOption = dim2Id;
            Dim3IdOption = dim3Id;
            LocationIdOption = locationId;
            ProjectIdOption = projectId;
            VoucherDate = voucherDate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BankJournalLines
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<BankJournalEntryVoucherLinePostDto>?> BankJournalLinesOption { get; private set; }

        /// <summary>
        /// The lines of the bank journal
        /// </summary>
        /// <value>The lines of the bank journal</value>
        [JsonPropertyName("BankJournalLines")]
        public List<BankJournalEntryVoucherLinePostDto>? BankJournalLines { get { return this.BankJournalLinesOption; } set { this.BankJournalLinesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Comment
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CommentOption { get; private set; }

        /// <summary>
        /// Optional comment that will be shown in the journal entry history in Go.  Only new vouchers will get the comment as part of the initial history.  It is thus not possible to change the comment later, and it will not be returned in API-calls.  The comment text should be human-readable. If necessary, use newline characters (\\n) to format the text for better readability
        /// </summary>
        /// <value>Optional comment that will be shown in the journal entry history in Go.  Only new vouchers will get the comment as part of the initial history.  It is thus not possible to change the comment later, and it will not be returned in API-calls.  The comment text should be human-readable. If necessary, use newline characters (\\n) to format the text for better readability</value>
        /* <example>My first bank journal comment.</example> */
        [JsonPropertyName("Comment")]
        public string? Comment { get { return this.CommentOption; } set { this.CommentOption = new(value); } }

        /// <summary>
        /// The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.
        /// </summary>
        /// <value>The currency code of the voucher header.  The line amounts will default be determined in the currency specified in the header.  For some voucher types, different currency codes can be set on the line level, thus overriding the currency of the head.  Currencies active on the client can be queried using the AccountingSettings service. Currency codes follow the ISO4217 standard.</value>
        /* <example>EUR</example> */
        [JsonPropertyName("CurrencyCode")]
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Used to track the state of DepartmentId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> DepartmentIdOption { get; private set; }

        /// <summary>
        /// The department Id of the voucher header.  The lines will inherit the department from the voucher head if not specified on the lines.  Departments can be queried and identified using the Department service.
        /// </summary>
        /// <value>The department Id of the voucher header.  The lines will inherit the department from the voucher head if not specified on the lines.  Departments can be queried and identified using the Department service.</value>
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
        /// The description field of the voucher header.
        /// </summary>
        /// <value>The description field of the voucher header.</value>
        /* <example>My first voucher description</example> */
        [JsonPropertyName("Description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Dim1Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> Dim1IdOption { get; private set; }

        /// <summary>
        /// The id of the dimension 1 associated with the voucher header.  The lines will inherit the dim1 from the voucher head if not specified on the lines.
        /// </summary>
        /// <value>The id of the dimension 1 associated with the voucher header.  The lines will inherit the dim1 from the voucher head if not specified on the lines.</value>
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
        /// The id of the dimension 2 associated with the voucher header.  The lines will inherit the dim2 from the voucher head if not specified on the lines.
        /// </summary>
        /// <value>The id of the dimension 2 associated with the voucher header.  The lines will inherit the dim2 from the voucher head if not specified on the lines.</value>
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
        /// The id of the dimension 3 associated with the voucher header.  The lines will inherit the dim3 from the voucher head if not specified on the lines.
        /// </summary>
        /// <value>The id of the dimension 3 associated with the voucher header.  The lines will inherit the dim3 from the voucher head if not specified on the lines.</value>
        /* <example>12345</example> */
        [JsonPropertyName("Dim3Id")]
        public long? Dim3Id { get { return this.Dim3IdOption; } set { this.Dim3IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of LocationId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> LocationIdOption { get; private set; }

        /// <summary>
        /// The id of the location dimension associated with the voucher header.  The lines will inherit the location from the voucher head if not specified on the lines.
        /// </summary>
        /// <value>The id of the location dimension associated with the voucher header.  The lines will inherit the location from the voucher head if not specified on the lines.</value>
        /* <example>12345</example> */
        [JsonPropertyName("LocationId")]
        public long? LocationId { get { return this.LocationIdOption; } set { this.LocationIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ProjectId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ProjectIdOption { get; private set; }

        /// <summary>
        /// The id of the project associated with the voucher header.  The lines will inherit the project from the voucher head if not specified on the lines.
        /// </summary>
        /// <value>The id of the project associated with the voucher header.  The lines will inherit the project from the voucher head if not specified on the lines.</value>
        /* <example>12345</example> */
        [JsonPropertyName("ProjectId")]
        public long? ProjectId { get { return this.ProjectIdOption; } set { this.ProjectIdOption = new(value); } }

        /// <summary>
        /// The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher.
        /// </summary>
        /// <value>The voucher date.  This represents the date of the voucher, the document date of an invoice for instance,  and may differ from the transaction dates for lines the voucher, depending on the type of voucher.</value>
        /* <example>Wed Mar 20 01:00:00 CET 2024</example> */
        [JsonPropertyName("VoucherDate")]
        public DateTimeOffset? VoucherDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankJournalEntryVoucherPostDto {\n");
            sb.Append("  BankJournalLines: ").Append(BankJournalLines).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Dim1Id: ").Append(Dim1Id).Append("\n");
            sb.Append("  Dim2Id: ").Append(Dim2Id).Append("\n");
            sb.Append("  Dim3Id: ").Append(Dim3Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  VoucherDate: ").Append(VoucherDate).Append("\n");
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
            // Comment (string) maxLength
            if (this.Comment != null && this.Comment.Length > 1000)
            {
                yield return new ValidationResult("Invalid value for Comment, length must be less than 1000.", new [] { "Comment" });
            }

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
    /// A Json converter for type <see cref="BankJournalEntryVoucherPostDto" />
    /// </summary>
    public class BankJournalEntryVoucherPostDtoJsonConverter : JsonConverter<BankJournalEntryVoucherPostDto>
    {
        /// <summary>
        /// The format to use to serialize VoucherDate
        /// </summary>
        public static string VoucherDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="BankJournalEntryVoucherPostDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BankJournalEntryVoucherPostDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<BankJournalEntryVoucherLinePostDto>?> bankJournalLines = default;
            Option<string?> comment = default;
            Option<string?> currencyCode = default;
            Option<long?> departmentId = default;
            Option<string?> description = default;
            Option<long?> dim1Id = default;
            Option<long?> dim2Id = default;
            Option<long?> dim3Id = default;
            Option<long?> locationId = default;
            Option<long?> projectId = default;
            Option<DateTimeOffset?> voucherDate = default;

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
                        case "BankJournalLines":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                bankJournalLines = new Option<List<BankJournalEntryVoucherLinePostDto>?>(JsonSerializer.Deserialize<List<BankJournalEntryVoucherLinePostDto>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "Comment":
                            comment = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "CurrencyCode":
                            currencyCode = new Option<string?>(utf8JsonReader.GetString());
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
                        case "LocationId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                locationId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "ProjectId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                projectId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "VoucherDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                voucherDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!currencyCode.IsSet)
                throw new ArgumentException("Property is required for class BankJournalEntryVoucherPostDto.", nameof(currencyCode));

            if (!voucherDate.IsSet)
                throw new ArgumentException("Property is required for class BankJournalEntryVoucherPostDto.", nameof(voucherDate));

            return new BankJournalEntryVoucherPostDto(bankJournalLines, comment, currencyCode.Value!, departmentId, description, dim1Id, dim2Id, dim3Id, locationId, projectId, voucherDate.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="BankJournalEntryVoucherPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bankJournalEntryVoucherPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BankJournalEntryVoucherPostDto bankJournalEntryVoucherPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bankJournalEntryVoucherPostDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BankJournalEntryVoucherPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bankJournalEntryVoucherPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BankJournalEntryVoucherPostDto bankJournalEntryVoucherPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (bankJournalEntryVoucherPostDto.BankJournalLinesOption.IsSet)
                if (bankJournalEntryVoucherPostDto.BankJournalLinesOption.Value != null)
                {
                    writer.WritePropertyName("BankJournalLines");
                    JsonSerializer.Serialize(writer, bankJournalEntryVoucherPostDto.BankJournalLines, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("BankJournalLines");
            if (bankJournalEntryVoucherPostDto.CommentOption.IsSet)
                if (bankJournalEntryVoucherPostDto.CommentOption.Value != null)
                    writer.WriteString("Comment", bankJournalEntryVoucherPostDto.Comment);
                else
                    writer.WriteNull("Comment");

            if (bankJournalEntryVoucherPostDto.CurrencyCode != null)
                writer.WriteString("CurrencyCode", bankJournalEntryVoucherPostDto.CurrencyCode);
            else
                writer.WriteNull("CurrencyCode");

            if (bankJournalEntryVoucherPostDto.DepartmentIdOption.IsSet)
                if (bankJournalEntryVoucherPostDto.DepartmentIdOption.Value != null)
                    writer.WriteNumber("DepartmentId", bankJournalEntryVoucherPostDto.DepartmentIdOption.Value!.Value);
                else
                    writer.WriteNull("DepartmentId");

            if (bankJournalEntryVoucherPostDto.DescriptionOption.IsSet)
                if (bankJournalEntryVoucherPostDto.DescriptionOption.Value != null)
                    writer.WriteString("Description", bankJournalEntryVoucherPostDto.Description);
                else
                    writer.WriteNull("Description");

            if (bankJournalEntryVoucherPostDto.Dim1IdOption.IsSet)
                if (bankJournalEntryVoucherPostDto.Dim1IdOption.Value != null)
                    writer.WriteNumber("Dim1Id", bankJournalEntryVoucherPostDto.Dim1IdOption.Value!.Value);
                else
                    writer.WriteNull("Dim1Id");

            if (bankJournalEntryVoucherPostDto.Dim2IdOption.IsSet)
                if (bankJournalEntryVoucherPostDto.Dim2IdOption.Value != null)
                    writer.WriteNumber("Dim2Id", bankJournalEntryVoucherPostDto.Dim2IdOption.Value!.Value);
                else
                    writer.WriteNull("Dim2Id");

            if (bankJournalEntryVoucherPostDto.Dim3IdOption.IsSet)
                if (bankJournalEntryVoucherPostDto.Dim3IdOption.Value != null)
                    writer.WriteNumber("Dim3Id", bankJournalEntryVoucherPostDto.Dim3IdOption.Value!.Value);
                else
                    writer.WriteNull("Dim3Id");

            if (bankJournalEntryVoucherPostDto.LocationIdOption.IsSet)
                if (bankJournalEntryVoucherPostDto.LocationIdOption.Value != null)
                    writer.WriteNumber("LocationId", bankJournalEntryVoucherPostDto.LocationIdOption.Value!.Value);
                else
                    writer.WriteNull("LocationId");

            if (bankJournalEntryVoucherPostDto.ProjectIdOption.IsSet)
                if (bankJournalEntryVoucherPostDto.ProjectIdOption.Value != null)
                    writer.WriteNumber("ProjectId", bankJournalEntryVoucherPostDto.ProjectIdOption.Value!.Value);
                else
                    writer.WriteNull("ProjectId");

            if (bankJournalEntryVoucherPostDto.VoucherDate != null)
                writer.WriteString("VoucherDate", bankJournalEntryVoucherPostDto.VoucherDate.Value.ToString(VoucherDateFormat));
            else
                writer.WriteNull("VoucherDate");
        }
    }
}

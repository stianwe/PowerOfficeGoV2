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
    /// Represents the sent status of a sales order.
    /// </summary>
    public partial class InvoiceSentStateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSentStateDto" /> class.
        /// </summary>
        /// <param name="dueDate">The actual due date of the invoice or credit note.</param>
        /// <param name="id">The identifier of a sales order, outgoing invoice or outgoing credit note.</param>
        /// <param name="invoiceDeliveryType">invoiceDeliveryType</param>
        /// <param name="invoiceNo">The invoice number in number format. Available only for sent and posted invoices.</param>
        /// <param name="isInvoiceBeingProcessed">A flag indicating whether the send request was successfully queued.  Will be true while the invoice is in transit.  After the invoice is delivered to the customer, IsInvoiceBeingProcessed will be set to false.</param>
        /// <param name="lastErrorMessage">If invoice delivery fails this property will contain the last error message.</param>
        /// <param name="sentDateTimeOffset">The date this sales order was invoiced using Go. Will only be set if the order was successfully invoiced.  For integrations using the createAndSendInvoice request, this property having a value will confirm the delivery.  To retrieve any further invoice information, the OutgoingInvoices reporting endpoint should be used.</param>
        [JsonConstructor]
        public InvoiceSentStateDto(Option<DateOnly?> dueDate = default, Option<Guid?> id = default, Option<InvoiceDeliveryType?> invoiceDeliveryType = default, Option<long?> invoiceNo = default, Option<bool?> isInvoiceBeingProcessed = default, Option<string?> lastErrorMessage = default, Option<DateTime?> sentDateTimeOffset = default)
        {
            DueDateOption = dueDate;
            IdOption = id;
            InvoiceDeliveryTypeOption = invoiceDeliveryType;
            InvoiceNoOption = invoiceNo;
            IsInvoiceBeingProcessedOption = isInvoiceBeingProcessed;
            LastErrorMessageOption = lastErrorMessage;
            SentDateTimeOffsetOption = sentDateTimeOffset;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of InvoiceDeliveryType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<InvoiceDeliveryType?> InvoiceDeliveryTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets InvoiceDeliveryType
        /// </summary>
        [JsonPropertyName("InvoiceDeliveryType")]
        public InvoiceDeliveryType? InvoiceDeliveryType { get { return this.InvoiceDeliveryTypeOption; } set { this.InvoiceDeliveryTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of DueDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> DueDateOption { get; }

        /// <summary>
        /// The actual due date of the invoice or credit note.
        /// </summary>
        /// <value>The actual due date of the invoice or credit note.</value>
        /* <example>Mon Sep 16 02:00:00 CEST 2024</example> */
        [JsonPropertyName("DueDate")]
        public DateOnly? DueDate { get { return this.DueDateOption; } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> IdOption { get; }

        /// <summary>
        /// The identifier of a sales order, outgoing invoice or outgoing credit note.
        /// </summary>
        /// <value>The identifier of a sales order, outgoing invoice or outgoing credit note.</value>
        /* <example>af290c8f-b54f-4a0a-998b-0bf879bf1bf7</example> */
        [JsonPropertyName("Id")]
        public Guid? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of InvoiceNo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> InvoiceNoOption { get; }

        /// <summary>
        /// The invoice number in number format. Available only for sent and posted invoices.
        /// </summary>
        /// <value>The invoice number in number format. Available only for sent and posted invoices.</value>
        /* <example>10003</example> */
        [JsonPropertyName("InvoiceNo")]
        public long? InvoiceNo { get { return this.InvoiceNoOption; } }

        /// <summary>
        /// Used to track the state of IsInvoiceBeingProcessed
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsInvoiceBeingProcessedOption { get; }

        /// <summary>
        /// A flag indicating whether the send request was successfully queued.  Will be true while the invoice is in transit.  After the invoice is delivered to the customer, IsInvoiceBeingProcessed will be set to false.
        /// </summary>
        /// <value>A flag indicating whether the send request was successfully queued.  Will be true while the invoice is in transit.  After the invoice is delivered to the customer, IsInvoiceBeingProcessed will be set to false.</value>
        /* <example>false</example> */
        [JsonPropertyName("IsInvoiceBeingProcessed")]
        public bool? IsInvoiceBeingProcessed { get { return this.IsInvoiceBeingProcessedOption; } }

        /// <summary>
        /// Used to track the state of LastErrorMessage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LastErrorMessageOption { get; }

        /// <summary>
        /// If invoice delivery fails this property will contain the last error message.
        /// </summary>
        /// <value>If invoice delivery fails this property will contain the last error message.</value>
        /* <example>ABC AS no longer support the receival of EHF invoice</example> */
        [JsonPropertyName("LastErrorMessage")]
        public string? LastErrorMessage { get { return this.LastErrorMessageOption; } }

        /// <summary>
        /// Used to track the state of SentDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> SentDateTimeOffsetOption { get; }

        /// <summary>
        /// The date this sales order was invoiced using Go. Will only be set if the order was successfully invoiced.  For integrations using the createAndSendInvoice request, this property having a value will confirm the delivery.  To retrieve any further invoice information, the OutgoingInvoices reporting endpoint should be used.
        /// </summary>
        /// <value>The date this sales order was invoiced using Go. Will only be set if the order was successfully invoiced.  For integrations using the createAndSendInvoice request, this property having a value will confirm the delivery.  To retrieve any further invoice information, the OutgoingInvoices reporting endpoint should be used.</value>
        /* <example>2024-09-03T11:35:00.867447600Z</example> */
        [JsonPropertyName("SentDateTimeOffset")]
        public DateTime? SentDateTimeOffset { get { return this.SentDateTimeOffsetOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceSentStateDto {\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceDeliveryType: ").Append(InvoiceDeliveryType).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  IsInvoiceBeingProcessed: ").Append(IsInvoiceBeingProcessed).Append("\n");
            sb.Append("  LastErrorMessage: ").Append(LastErrorMessage).Append("\n");
            sb.Append("  SentDateTimeOffset: ").Append(SentDateTimeOffset).Append("\n");
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
    /// A Json converter for type <see cref="InvoiceSentStateDto" />
    /// </summary>
    public class InvoiceSentStateDtoJsonConverter : JsonConverter<InvoiceSentStateDto>
    {
        /// <summary>
        /// The format to use to serialize DueDate
        /// </summary>
        public static string DueDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize SentDateTimeOffset
        /// </summary>
        public static string SentDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="InvoiceSentStateDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InvoiceSentStateDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateOnly?> dueDate = default;
            Option<Guid?> id = default;
            Option<InvoiceDeliveryType?> invoiceDeliveryType = default;
            Option<long?> invoiceNo = default;
            Option<bool?> isInvoiceBeingProcessed = default;
            Option<string?> lastErrorMessage = default;
            Option<DateTime?> sentDateTimeOffset = default;

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
                        case "DueDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dueDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "InvoiceDeliveryType":
                            string? invoiceDeliveryTypeRawValue = utf8JsonReader.GetString();
                            if (invoiceDeliveryTypeRawValue != null)
                                invoiceDeliveryType = new Option<InvoiceDeliveryType?>(InvoiceDeliveryTypeValueConverter.FromStringOrDefault(invoiceDeliveryTypeRawValue));
                            break;
                        case "InvoiceNo":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                invoiceNo = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "IsInvoiceBeingProcessed":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isInvoiceBeingProcessed = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "LastErrorMessage":
                            lastErrorMessage = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "SentDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sentDateTimeOffset = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class InvoiceSentStateDto.");

            return new InvoiceSentStateDto(dueDate, id, invoiceDeliveryType, invoiceNo, isInvoiceBeingProcessed, lastErrorMessage, sentDateTimeOffset);
        }

        /// <summary>
        /// Serializes a <see cref="InvoiceSentStateDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="invoiceSentStateDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InvoiceSentStateDto invoiceSentStateDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, invoiceSentStateDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InvoiceSentStateDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="invoiceSentStateDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InvoiceSentStateDto invoiceSentStateDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (invoiceSentStateDto.DueDateOption.IsSet)
                if (invoiceSentStateDto.DueDateOption.Value != null)
                    writer.WriteString("DueDate", invoiceSentStateDto.DueDateOption.Value!.Value.ToString(DueDateFormat));
                else
                    writer.WriteNull("DueDate");

            if (invoiceSentStateDto.IdOption.IsSet)
                writer.WriteString("Id", invoiceSentStateDto.IdOption.Value!.Value);

            if (invoiceSentStateDto.InvoiceDeliveryTypeOption.IsSet)
                if (invoiceSentStateDto.InvoiceDeliveryTypeOption!.Value != null)
                {
                    var invoiceDeliveryTypeRawValue = InvoiceDeliveryTypeValueConverter.ToJsonValue(invoiceSentStateDto.InvoiceDeliveryTypeOption.Value!.Value);
                    writer.WriteString("InvoiceDeliveryType", invoiceDeliveryTypeRawValue);
                }
                else
                    writer.WriteNull("InvoiceDeliveryType");
            if (invoiceSentStateDto.InvoiceNoOption.IsSet)
                if (invoiceSentStateDto.InvoiceNoOption.Value != null)
                    writer.WriteNumber("InvoiceNo", invoiceSentStateDto.InvoiceNoOption.Value!.Value);
                else
                    writer.WriteNull("InvoiceNo");

            if (invoiceSentStateDto.IsInvoiceBeingProcessedOption.IsSet)
                if (invoiceSentStateDto.IsInvoiceBeingProcessedOption.Value != null)
                    writer.WriteBoolean("IsInvoiceBeingProcessed", invoiceSentStateDto.IsInvoiceBeingProcessedOption.Value!.Value);
                else
                    writer.WriteNull("IsInvoiceBeingProcessed");

            if (invoiceSentStateDto.LastErrorMessageOption.IsSet)
                if (invoiceSentStateDto.LastErrorMessageOption.Value != null)
                    writer.WriteString("LastErrorMessage", invoiceSentStateDto.LastErrorMessage);
                else
                    writer.WriteNull("LastErrorMessage");

            if (invoiceSentStateDto.SentDateTimeOffsetOption.IsSet)
                if (invoiceSentStateDto.SentDateTimeOffsetOption.Value != null)
                    writer.WriteString("SentDateTimeOffset", invoiceSentStateDto.SentDateTimeOffsetOption.Value!.Value.ToString(SentDateTimeOffsetFormat));
                else
                    writer.WriteNull("SentDateTimeOffset");
        }
    }
}

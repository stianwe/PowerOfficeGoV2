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
    /// Represents the status of a sales order.
    /// </summary>
    public partial class SendInvoiceRequestDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendInvoiceRequestDto" /> class.
        /// </summary>
        /// <param name="deliveryType">deliveryType</param>
        /// <param name="emailAddress">The e-mail address used for delivery by e-mail.  If not set in the request, the customers default invoice email address will be used.  Email address will be used as a fallback delivery method and should be provided when using DeliveryType Auto.</param>
        /// <param name="id">The id of the sales order.</param>
        /// <param name="overrideDueDate">Override the due date of the invoice.  If not set, the due date will be determined by the payment term of the sales order.</param>
        /// <param name="voucherDate">The date the invoice voucher will get. If not provided, the voucher date will be set to the current date.  This represents the date of the voucher and the document date of the invoice (ie. the invoice date).</param>
        [JsonConstructor]
        public SendInvoiceRequestDto(Option<SendInvoiceDeliveryType?> deliveryType = default, Option<string?> emailAddress = default, Option<Guid?> id = default, Option<DateTimeOffset?> overrideDueDate = default, Option<DateTimeOffset?> voucherDate = default)
        {
            DeliveryTypeOption = deliveryType;
            EmailAddressOption = emailAddress;
            IdOption = id;
            OverrideDueDateOption = overrideDueDate;
            VoucherDateOption = voucherDate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of DeliveryType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SendInvoiceDeliveryType?> DeliveryTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets DeliveryType
        /// </summary>
        [JsonPropertyName("DeliveryType")]
        public SendInvoiceDeliveryType? DeliveryType { get { return this.DeliveryTypeOption; } set { this.DeliveryTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of EmailAddress
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EmailAddressOption { get; private set; }

        /// <summary>
        /// The e-mail address used for delivery by e-mail.  If not set in the request, the customers default invoice email address will be used.  Email address will be used as a fallback delivery method and should be provided when using DeliveryType Auto.
        /// </summary>
        /// <value>The e-mail address used for delivery by e-mail.  If not set in the request, the customers default invoice email address will be used.  Email address will be used as a fallback delivery method and should be provided when using DeliveryType Auto.</value>
        /* <example>invoice@example.com</example> */
        [JsonPropertyName("EmailAddress")]
        public string? EmailAddress { get { return this.EmailAddressOption; } set { this.EmailAddressOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> IdOption { get; }

        /// <summary>
        /// The id of the sales order.
        /// </summary>
        /// <value>The id of the sales order.</value>
        /* <example>689f466d-a3f6-4c92-89d0-509d4a506919</example> */
        [JsonPropertyName("Id")]
        public Guid? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of OverrideDueDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> OverrideDueDateOption { get; private set; }

        /// <summary>
        /// Override the due date of the invoice.  If not set, the due date will be determined by the payment term of the sales order.
        /// </summary>
        /// <value>Override the due date of the invoice.  If not set, the due date will be determined by the payment term of the sales order.</value>
        /* <example>Mon Sep 23 02:00:00 CEST 2024</example> */
        [JsonPropertyName("OverrideDueDate")]
        public DateTimeOffset? OverrideDueDate { get { return this.OverrideDueDateOption; } set { this.OverrideDueDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of VoucherDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> VoucherDateOption { get; private set; }

        /// <summary>
        /// The date the invoice voucher will get. If not provided, the voucher date will be set to the current date.  This represents the date of the voucher and the document date of the invoice (ie. the invoice date).
        /// </summary>
        /// <value>The date the invoice voucher will get. If not provided, the voucher date will be set to the current date.  This represents the date of the voucher and the document date of the invoice (ie. the invoice date).</value>
        /* <example>Thu Aug 29 02:00:00 CEST 2024</example> */
        [JsonPropertyName("VoucherDate")]
        public DateTimeOffset? VoucherDate { get { return this.VoucherDateOption; } set { this.VoucherDateOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendInvoiceRequestDto {\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OverrideDueDate: ").Append(OverrideDueDate).Append("\n");
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
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="SendInvoiceRequestDto" />
    /// </summary>
    public class SendInvoiceRequestDtoJsonConverter : JsonConverter<SendInvoiceRequestDto>
    {
        /// <summary>
        /// The format to use to serialize OverrideDueDate
        /// </summary>
        public static string OverrideDueDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize VoucherDate
        /// </summary>
        public static string VoucherDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="SendInvoiceRequestDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SendInvoiceRequestDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<SendInvoiceDeliveryType?> deliveryType = default;
            Option<string?> emailAddress = default;
            Option<Guid?> id = default;
            Option<DateTimeOffset?> overrideDueDate = default;
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
                        case "DeliveryType":
                            string? deliveryTypeRawValue = utf8JsonReader.GetString();
                            if (deliveryTypeRawValue != null)
                                deliveryType = new Option<SendInvoiceDeliveryType?>(SendInvoiceDeliveryTypeValueConverter.FromStringOrDefault(deliveryTypeRawValue));
                            break;
                        case "EmailAddress":
                            emailAddress = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "OverrideDueDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                overrideDueDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
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

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class SendInvoiceRequestDto.");

            return new SendInvoiceRequestDto(deliveryType, emailAddress, id, overrideDueDate, voucherDate);
        }

        /// <summary>
        /// Serializes a <see cref="SendInvoiceRequestDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sendInvoiceRequestDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SendInvoiceRequestDto sendInvoiceRequestDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, sendInvoiceRequestDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SendInvoiceRequestDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sendInvoiceRequestDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SendInvoiceRequestDto sendInvoiceRequestDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (sendInvoiceRequestDto.DeliveryTypeOption.IsSet)
                if (sendInvoiceRequestDto.DeliveryTypeOption!.Value != null)
                {
                    var deliveryTypeRawValue = SendInvoiceDeliveryTypeValueConverter.ToJsonValue(sendInvoiceRequestDto.DeliveryTypeOption.Value!.Value);
                    writer.WriteString("DeliveryType", deliveryTypeRawValue);
                }
                else
                    writer.WriteNull("DeliveryType");
            if (sendInvoiceRequestDto.EmailAddressOption.IsSet)
                if (sendInvoiceRequestDto.EmailAddressOption.Value != null)
                    writer.WriteString("EmailAddress", sendInvoiceRequestDto.EmailAddress);
                else
                    writer.WriteNull("EmailAddress");

            if (sendInvoiceRequestDto.IdOption.IsSet)
                writer.WriteString("Id", sendInvoiceRequestDto.IdOption.Value!.Value);

            if (sendInvoiceRequestDto.OverrideDueDateOption.IsSet)
                if (sendInvoiceRequestDto.OverrideDueDateOption.Value != null)
                    writer.WriteString("OverrideDueDate", sendInvoiceRequestDto.OverrideDueDateOption.Value!.Value.ToString(OverrideDueDateFormat));
                else
                    writer.WriteNull("OverrideDueDate");

            if (sendInvoiceRequestDto.VoucherDateOption.IsSet)
                if (sendInvoiceRequestDto.VoucherDateOption.Value != null)
                    writer.WriteString("VoucherDate", sendInvoiceRequestDto.VoucherDateOption.Value!.Value.ToString(VoucherDateFormat));
                else
                    writer.WriteNull("VoucherDate");
        }
    }
}

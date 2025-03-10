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
    /// The payment terms on the client.
    /// </summary>
    public partial class PaymentTermDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTermDto" /> class.
        /// </summary>
        /// <param name="createdDateTimeOffset">The timestamp of the created date of the payment term. UTC time.</param>
        /// <param name="creditDays">The number of credit days for the payment term.  This define the number of days from an invoice is sent until it is due paid, if a sales order is invoiced using this payment term.</param>
        /// <param name="id">The identifier of the payment term.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited or deleted (PATCH or DELETE).</param>
        /// <param name="isActive">Value indicating whether this payment term is active.</param>
        /// <param name="isDefault">A value indicating if this payment term is the standard payment term set on the client.  Customers and sales orders will default inherit the standard payment term from the client invoice settings.</param>
        /// <param name="lastChangedDateTimeOffset">The timestamp of the last changed date of the payment term. UTC time.</param>
        /// <param name="name">The name of the payment term.  Max length is 128 characters.</param>
        [JsonConstructor]
        public PaymentTermDto(Option<DateTime?> createdDateTimeOffset = default, Option<int?> creditDays = default, Option<long?> id = default, Option<bool?> isActive = default, Option<bool?> isDefault = default, Option<DateTime?> lastChangedDateTimeOffset = default, Option<string?> name = default)
        {
            CreatedDateTimeOffsetOption = createdDateTimeOffset;
            CreditDaysOption = creditDays;
            IdOption = id;
            IsActiveOption = isActive;
            IsDefaultOption = isDefault;
            LastChangedDateTimeOffsetOption = lastChangedDateTimeOffset;
            NameOption = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CreatedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreatedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp of the created date of the payment term. UTC time.
        /// </summary>
        /// <value>The timestamp of the created date of the payment term. UTC time.</value>
        /* <example>2023-05-19T08:51:00.123456700Z</example> */
        [JsonPropertyName("CreatedDateTimeOffset")]
        public DateTime? CreatedDateTimeOffset { get { return this.CreatedDateTimeOffsetOption; } }

        /// <summary>
        /// Used to track the state of CreditDays
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> CreditDaysOption { get; private set; }

        /// <summary>
        /// The number of credit days for the payment term.  This define the number of days from an invoice is sent until it is due paid, if a sales order is invoiced using this payment term.
        /// </summary>
        /// <value>The number of credit days for the payment term.  This define the number of days from an invoice is sent until it is due paid, if a sales order is invoiced using this payment term.</value>
        /* <example>14</example> */
        [JsonPropertyName("CreditDays")]
        public int? CreditDays { get { return this.CreditDaysOption; } set { this.CreditDaysOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; }

        /// <summary>
        /// The identifier of the payment term.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited or deleted (PATCH or DELETE).
        /// </summary>
        /// <value>The identifier of the payment term.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited or deleted (PATCH or DELETE).</value>
        /* <example>1234</example> */
        [JsonPropertyName("Id")]
        public long? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of IsActive
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsActiveOption { get; private set; }

        /// <summary>
        /// Value indicating whether this payment term is active.
        /// </summary>
        /// <value>Value indicating whether this payment term is active.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get { return this.IsActiveOption; } set { this.IsActiveOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsDefault
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsDefaultOption { get; private set; }

        /// <summary>
        /// A value indicating if this payment term is the standard payment term set on the client.  Customers and sales orders will default inherit the standard payment term from the client invoice settings.
        /// </summary>
        /// <value>A value indicating if this payment term is the standard payment term set on the client.  Customers and sales orders will default inherit the standard payment term from the client invoice settings.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsDefault")]
        public bool? IsDefault { get { return this.IsDefaultOption; } set { this.IsDefaultOption = new(value); } }

        /// <summary>
        /// Used to track the state of LastChangedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastChangedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp of the last changed date of the payment term. UTC time.
        /// </summary>
        /// <value>The timestamp of the last changed date of the payment term. UTC time.</value>
        /* <example>2023-05-19T08:52:00.123456700Z</example> */
        [JsonPropertyName("LastChangedDateTimeOffset")]
        public DateTime? LastChangedDateTimeOffset { get { return this.LastChangedDateTimeOffsetOption; } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// The name of the payment term.  Max length is 128 characters.
        /// </summary>
        /// <value>The name of the payment term.  Max length is 128 characters.</value>
        /* <example>14 days</example> */
        [JsonPropertyName("Name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTermDto {\n");
            sb.Append("  CreatedDateTimeOffset: ").Append(CreatedDateTimeOffset).Append("\n");
            sb.Append("  CreditDays: ").Append(CreditDays).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  LastChangedDateTimeOffset: ").Append(LastChangedDateTimeOffset).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 128)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PaymentTermDto" />
    /// </summary>
    public class PaymentTermDtoJsonConverter : JsonConverter<PaymentTermDto>
    {
        /// <summary>
        /// The format to use to serialize CreatedDateTimeOffset
        /// </summary>
        public static string CreatedDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize LastChangedDateTimeOffset
        /// </summary>
        public static string LastChangedDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="PaymentTermDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PaymentTermDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> createdDateTimeOffset = default;
            Option<int?> creditDays = default;
            Option<long?> id = default;
            Option<bool?> isActive = default;
            Option<bool?> isDefault = default;
            Option<DateTime?> lastChangedDateTimeOffset = default;
            Option<string?> name = default;

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
                        case "CreatedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdDateTimeOffset = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "CreditDays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                creditDays = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "IsDefault":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isDefault = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "LastChangedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastChangedDateTimeOffset = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "Name":
                            name = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createdDateTimeOffset.IsSet && createdDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(createdDateTimeOffset), "Property is not nullable for class PaymentTermDto.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PaymentTermDto.");

            if (lastChangedDateTimeOffset.IsSet && lastChangedDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(lastChangedDateTimeOffset), "Property is not nullable for class PaymentTermDto.");

            return new PaymentTermDto(createdDateTimeOffset, creditDays, id, isActive, isDefault, lastChangedDateTimeOffset, name);
        }

        /// <summary>
        /// Serializes a <see cref="PaymentTermDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paymentTermDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PaymentTermDto paymentTermDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, paymentTermDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PaymentTermDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paymentTermDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PaymentTermDto paymentTermDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (paymentTermDto.CreatedDateTimeOffsetOption.IsSet)
                writer.WriteString("CreatedDateTimeOffset", paymentTermDto.CreatedDateTimeOffsetOption.Value!.Value.ToString(CreatedDateTimeOffsetFormat));

            if (paymentTermDto.CreditDaysOption.IsSet)
                if (paymentTermDto.CreditDaysOption.Value != null)
                    writer.WriteNumber("CreditDays", paymentTermDto.CreditDaysOption.Value!.Value);
                else
                    writer.WriteNull("CreditDays");

            if (paymentTermDto.IdOption.IsSet)
                writer.WriteNumber("Id", paymentTermDto.IdOption.Value!.Value);

            if (paymentTermDto.IsActiveOption.IsSet)
                if (paymentTermDto.IsActiveOption.Value != null)
                    writer.WriteBoolean("IsActive", paymentTermDto.IsActiveOption.Value!.Value);
                else
                    writer.WriteNull("IsActive");

            if (paymentTermDto.IsDefaultOption.IsSet)
                if (paymentTermDto.IsDefaultOption.Value != null)
                    writer.WriteBoolean("IsDefault", paymentTermDto.IsDefaultOption.Value!.Value);
                else
                    writer.WriteNull("IsDefault");

            if (paymentTermDto.LastChangedDateTimeOffsetOption.IsSet)
                writer.WriteString("LastChangedDateTimeOffset", paymentTermDto.LastChangedDateTimeOffsetOption.Value!.Value.ToString(LastChangedDateTimeOffsetFormat));

            if (paymentTermDto.NameOption.IsSet)
                if (paymentTermDto.NameOption.Value != null)
                    writer.WriteString("Name", paymentTermDto.Name);
                else
                    writer.WriteNull("Name");
        }
    }
}

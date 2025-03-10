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
    /// DTO for creating payment terms.
    /// </summary>
    public partial class PaymentTermPostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTermPostDto" /> class.
        /// </summary>
        /// <param name="creditDays">The number of credit days for the payment term.  This define the number of days from an invoice is sent until it is due paid, if a sales order is invoiced using this payment term.</param>
        /// <param name="isActive">Value indicating whether this payment term is active.</param>
        /// <param name="isDefault">A value indicating if this payment term is the standard payment term set on the client.  Customers and sales orders will default inherit the standard payment term from the client invoice settings.</param>
        /// <param name="name">The name of the payment term.  Max length is 128 characters.</param>
        [JsonConstructor]
        public PaymentTermPostDto(int? creditDays = default, Option<bool?> isActive = default, Option<bool?> isDefault = default, string? name = default)
        {
            CreditDays = creditDays;
            IsActiveOption = isActive;
            IsDefaultOption = isDefault;
            Name = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The number of credit days for the payment term.  This define the number of days from an invoice is sent until it is due paid, if a sales order is invoiced using this payment term.
        /// </summary>
        /// <value>The number of credit days for the payment term.  This define the number of days from an invoice is sent until it is due paid, if a sales order is invoiced using this payment term.</value>
        /* <example>14</example> */
        [JsonPropertyName("CreditDays")]
        public int? CreditDays { get; set; }

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
        /// The name of the payment term.  Max length is 128 characters.
        /// </summary>
        /// <value>The name of the payment term.  Max length is 128 characters.</value>
        /* <example>14 days</example> */
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTermPostDto {\n");
            sb.Append("  CreditDays: ").Append(CreditDays).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
    /// A Json converter for type <see cref="PaymentTermPostDto" />
    /// </summary>
    public class PaymentTermPostDtoJsonConverter : JsonConverter<PaymentTermPostDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="PaymentTermPostDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PaymentTermPostDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> creditDays = default;
            Option<bool?> isActive = default;
            Option<bool?> isDefault = default;
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
                        case "CreditDays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                creditDays = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "IsDefault":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isDefault = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "Name":
                            name = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!creditDays.IsSet)
                throw new ArgumentException("Property is required for class PaymentTermPostDto.", nameof(creditDays));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class PaymentTermPostDto.", nameof(name));

            return new PaymentTermPostDto(creditDays.Value!, isActive, isDefault, name.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PaymentTermPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paymentTermPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PaymentTermPostDto paymentTermPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, paymentTermPostDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PaymentTermPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paymentTermPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PaymentTermPostDto paymentTermPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (paymentTermPostDto.CreditDays != null)
                writer.WriteNumber("CreditDays", paymentTermPostDto.CreditDays.Value);
            else
                writer.WriteNull("CreditDays");

            if (paymentTermPostDto.IsActiveOption.IsSet)
                if (paymentTermPostDto.IsActiveOption.Value != null)
                    writer.WriteBoolean("IsActive", paymentTermPostDto.IsActiveOption.Value!.Value);
                else
                    writer.WriteNull("IsActive");

            if (paymentTermPostDto.IsDefaultOption.IsSet)
                if (paymentTermPostDto.IsDefaultOption.Value != null)
                    writer.WriteBoolean("IsDefault", paymentTermPostDto.IsDefaultOption.Value!.Value);
                else
                    writer.WriteNull("IsDefault");

            if (paymentTermPostDto.Name != null)
                writer.WriteString("Name", paymentTermPostDto.Name);
            else
                writer.WriteNull("Name");
        }
    }
}

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
    /// The currencies active for GUI operations.
    /// </summary>
    public partial class CurrencyDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyDto" /> class.
        /// </summary>
        /// <param name="code">Currency code.</param>
        /// <param name="isActive">Value indication if this currency is active for this client.</param>
        /// <param name="notation">English notation of the currency name.</param>
        [JsonConstructor]
        internal CurrencyDto(Option<string?> code = default, Option<bool?> isActive = default, Option<string?> notation = default)
        {
            CodeOption = code;
            IsActiveOption = isActive;
            NotationOption = notation;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CodeOption { get; }

        /// <summary>
        /// Currency code.
        /// </summary>
        /// <value>Currency code.</value>
        [JsonPropertyName("Code")]
        public string? Code { get { return this.CodeOption; } }

        /// <summary>
        /// Used to track the state of IsActive
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsActiveOption { get; }

        /// <summary>
        /// Value indication if this currency is active for this client.
        /// </summary>
        /// <value>Value indication if this currency is active for this client.</value>
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get { return this.IsActiveOption; } }

        /// <summary>
        /// Used to track the state of Notation
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NotationOption { get; }

        /// <summary>
        /// English notation of the currency name.
        /// </summary>
        /// <value>English notation of the currency name.</value>
        [JsonPropertyName("Notation")]
        public string? Notation { get { return this.NotationOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CurrencyDto {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Notation: ").Append(Notation).Append("\n");
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
    /// A Json converter for type <see cref="CurrencyDto" />
    /// </summary>
    public class CurrencyDtoJsonConverter : JsonConverter<CurrencyDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="CurrencyDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CurrencyDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> code = default;
            Option<bool?> isActive = default;
            Option<string?> notation = default;

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
                        case "Code":
                            code = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "Notation":
                            notation = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new CurrencyDto(code, isActive, notation);
        }

        /// <summary>
        /// Serializes a <see cref="CurrencyDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="currencyDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CurrencyDto currencyDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, currencyDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CurrencyDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="currencyDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CurrencyDto currencyDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (currencyDto.CodeOption.IsSet)
                if (currencyDto.CodeOption.Value != null)
                    writer.WriteString("Code", currencyDto.Code);
                else
                    writer.WriteNull("Code");

            if (currencyDto.IsActiveOption.IsSet)
                if (currencyDto.IsActiveOption.Value != null)
                    writer.WriteBoolean("IsActive", currencyDto.IsActiveOption.Value!.Value);
                else
                    writer.WriteNull("IsActive");

            if (currencyDto.NotationOption.IsSet)
                if (currencyDto.NotationOption.Value != null)
                    writer.WriteString("Notation", currencyDto.Notation);
                else
                    writer.WriteNull("Notation");
        }
    }
}

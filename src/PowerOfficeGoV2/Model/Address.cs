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
    /// Address representing a physical location.
    /// </summary>
    public partial class Address : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="addressLine1">The first (main) address line.</param>
        /// <param name="addressLine2">The second address line.</param>
        /// <param name="city">The city.</param>
        /// <param name="countryCode">The ISO 3166-1 alfa-2 country code (two characters).  Defaults to \&quot;NO\&quot; if not set.</param>
        /// <param name="zipCode">The zip code (postal code).</param>
        [JsonConstructor]
        public Address(Option<string?> addressLine1 = default, Option<string?> addressLine2 = default, Option<string?> city = default, Option<string?> countryCode = default, Option<string?> zipCode = default)
        {
            AddressLine1Option = addressLine1;
            AddressLine2Option = addressLine2;
            CityOption = city;
            CountryCodeOption = countryCode;
            ZipCodeOption = zipCode;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of AddressLine1
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AddressLine1Option { get; private set; }

        /// <summary>
        /// The first (main) address line.
        /// </summary>
        /// <value>The first (main) address line.</value>
        /* <example>Postboks 404</example> */
        [JsonPropertyName("AddressLine1")]
        public string? AddressLine1 { get { return this.AddressLine1Option; } set { this.AddressLine1Option = new(value); } }

        /// <summary>
        /// Used to track the state of AddressLine2
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AddressLine2Option { get; private set; }

        /// <summary>
        /// The second address line.
        /// </summary>
        /// <value>The second address line.</value>
        /* <example>Att: Ola Nordmann</example> */
        [JsonPropertyName("AddressLine2")]
        public string? AddressLine2 { get { return this.AddressLine2Option; } set { this.AddressLine2Option = new(value); } }

        /// <summary>
        /// Used to track the state of City
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CityOption { get; private set; }

        /// <summary>
        /// The city.
        /// </summary>
        /// <value>The city.</value>
        /* <example>Oslo</example> */
        [JsonPropertyName("City")]
        public string? City { get { return this.CityOption; } set { this.CityOption = new(value); } }

        /// <summary>
        /// Used to track the state of CountryCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryCodeOption { get; private set; }

        /// <summary>
        /// The ISO 3166-1 alfa-2 country code (two characters).  Defaults to \&quot;NO\&quot; if not set.
        /// </summary>
        /// <value>The ISO 3166-1 alfa-2 country code (two characters).  Defaults to \&quot;NO\&quot; if not set.</value>
        /* <example>NO</example> */
        [JsonPropertyName("CountryCode")]
        public string? CountryCode { get { return this.CountryCodeOption; } set { this.CountryCodeOption = new(value); } }

        /// <summary>
        /// Used to track the state of ZipCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ZipCodeOption { get; private set; }

        /// <summary>
        /// The zip code (postal code).
        /// </summary>
        /// <value>The zip code (postal code).</value>
        /* <example>0161</example> */
        [JsonPropertyName("ZipCode")]
        public string? ZipCode { get { return this.ZipCodeOption; } set { this.ZipCodeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
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
            // AddressLine1 (string) maxLength
            if (this.AddressLine1 != null && this.AddressLine1.Length > 200)
            {
                yield return new ValidationResult("Invalid value for AddressLine1, length must be less than 200.", new [] { "AddressLine1" });
            }

            // AddressLine2 (string) maxLength
            if (this.AddressLine2 != null && this.AddressLine2.Length > 200)
            {
                yield return new ValidationResult("Invalid value for AddressLine2, length must be less than 200.", new [] { "AddressLine2" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 100)
            {
                yield return new ValidationResult("Invalid value for City, length must be less than 100.", new [] { "City" });
            }

            // ZipCode (string) maxLength
            if (this.ZipCode != null && this.ZipCode.Length > 50)
            {
                yield return new ValidationResult("Invalid value for ZipCode, length must be less than 50.", new [] { "ZipCode" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Address" />
    /// </summary>
    public class AddressJsonConverter : JsonConverter<Address>
    {
        /// <summary>
        /// Deserializes json to <see cref="Address" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Address Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> addressLine1 = default;
            Option<string?> addressLine2 = default;
            Option<string?> city = default;
            Option<string?> countryCode = default;
            Option<string?> zipCode = default;

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
                        case "AddressLine1":
                            addressLine1 = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "AddressLine2":
                            addressLine2 = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "City":
                            city = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "CountryCode":
                            countryCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "ZipCode":
                            zipCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new Address(addressLine1, addressLine2, city, countryCode, zipCode);
        }

        /// <summary>
        /// Serializes a <see cref="Address" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="address"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Address address, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, address, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Address" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="address"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Address address, JsonSerializerOptions jsonSerializerOptions)
        {
            if (address.AddressLine1Option.IsSet)
                if (address.AddressLine1Option.Value != null)
                    writer.WriteString("AddressLine1", address.AddressLine1);
                else
                    writer.WriteNull("AddressLine1");

            if (address.AddressLine2Option.IsSet)
                if (address.AddressLine2Option.Value != null)
                    writer.WriteString("AddressLine2", address.AddressLine2);
                else
                    writer.WriteNull("AddressLine2");

            if (address.CityOption.IsSet)
                if (address.CityOption.Value != null)
                    writer.WriteString("City", address.City);
                else
                    writer.WriteNull("City");

            if (address.CountryCodeOption.IsSet)
                if (address.CountryCodeOption.Value != null)
                    writer.WriteString("CountryCode", address.CountryCode);
                else
                    writer.WriteNull("CountryCode");

            if (address.ZipCodeOption.IsSet)
                if (address.ZipCodeOption.Value != null)
                    writer.WriteString("ZipCode", address.ZipCode);
                else
                    writer.WriteNull("ZipCode");
        }
    }
}

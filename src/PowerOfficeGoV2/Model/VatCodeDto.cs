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
    /// The VAT code DTO contains all properties relevant to VAT codes.
    /// </summary>
    public partial class VatCodeDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VatCodeDto" /> class.
        /// </summary>
        /// <param name="baseVatCodeId">The standard vat id the custom vat code is based upon. Relevant only for custom vat codes.</param>
        /// <param name="code">The vat code. Go use standard SAF-T codes by default. Any custom codes, will have a notation with the letter C first.  Codes used specifically for vat compensation, are marked with the letter K first (relevant only if the client uses vat compensation, ie the VatSetting &#39;useVatCompensation&#39; set true).</param>
        /// <param name="description">The description of the vat code.</param>
        /// <param name="id">The unique identifier of the vat code</param>
        /// <param name="isActive">The value indicating whether this vat code is active</param>
        /// <param name="isCustom">The value indicating whether this vat code is custom created. The code will have the letter C in the notation if true.</param>
        /// <param name="name">the name of the vat code.</param>
        /// <param name="rate">The rate of the vat code. This is a value between 0 and 1. 0 representing 0 % vat and 1 representing 100 % vat.</param>
        /// <param name="validFrom">The date this vat code is active from, inclusive.</param>
        /// <param name="validTo">The date this vat code expires. Inclusive.</param>
        /// <param name="vatBasisRatio">The vat basis ratio. Relevant for custom codes in mixed vat conditions (Norwegian: Forholdsmessig fradrag MVA). This is a value between 0 and 1, with 0 representing 0% vat basis ratio and 1 representing 100% vat basis ratio.  Example: A net amount of 1000 NOK with 50% vat basis ratio and 25% vat rate, will have the vat amount calculated as: 1000 x 0.5 x 0.25 &#x3D; 125 NOK</param>
        /// <param name="vatBasisRatioValidFrom">The date this vat basis ratio is active from.  If no vat basis ratio is set, this date will default to the vat code valid from date.</param>
        /// <param name="vatBasisRatios">A collection of VatBasisRatios for a custom vat code.</param>
        [JsonConstructor]
        public VatCodeDto(Option<long?> baseVatCodeId = default, Option<string?> code = default, Option<string?> description = default, Option<long?> id = default, Option<bool?> isActive = default, Option<bool?> isCustom = default, Option<string?> name = default, Option<double?> rate = default, Option<DateTimeOffset?> validFrom = default, Option<DateTimeOffset?> validTo = default, Option<double?> vatBasisRatio = default, Option<DateTimeOffset?> vatBasisRatioValidFrom = default, Option<List<VatBasisRatios>?> vatBasisRatios = default)
        {
            BaseVatCodeIdOption = baseVatCodeId;
            CodeOption = code;
            DescriptionOption = description;
            IdOption = id;
            IsActiveOption = isActive;
            IsCustomOption = isCustom;
            NameOption = name;
            RateOption = rate;
            ValidFromOption = validFrom;
            ValidToOption = validTo;
            VatBasisRatioOption = vatBasisRatio;
            VatBasisRatioValidFromOption = vatBasisRatioValidFrom;
            VatBasisRatiosOption = vatBasisRatios;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BaseVatCodeId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> BaseVatCodeIdOption { get; private set; }

        /// <summary>
        /// The standard vat id the custom vat code is based upon. Relevant only for custom vat codes.
        /// </summary>
        /// <value>The standard vat id the custom vat code is based upon. Relevant only for custom vat codes.</value>
        /* <example>13</example> */
        [JsonPropertyName("BaseVatCodeId")]
        public long? BaseVatCodeId { get { return this.BaseVatCodeIdOption; } set { this.BaseVatCodeIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CodeOption { get; }

        /// <summary>
        /// The vat code. Go use standard SAF-T codes by default. Any custom codes, will have a notation with the letter C first.  Codes used specifically for vat compensation, are marked with the letter K first (relevant only if the client uses vat compensation, ie the VatSetting &#39;useVatCompensation&#39; set true).
        /// </summary>
        /// <value>The vat code. Go use standard SAF-T codes by default. Any custom codes, will have a notation with the letter C first.  Codes used specifically for vat compensation, are marked with the letter K first (relevant only if the client uses vat compensation, ie the VatSetting &#39;useVatCompensation&#39; set true).</value>
        /* <example>3</example> */
        [JsonPropertyName("Code")]
        public string? Code { get { return this.CodeOption; } }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; }

        /// <summary>
        /// The description of the vat code.
        /// </summary>
        /// <value>The description of the vat code.</value>
        /* <example>Utgående mva</example> */
        [JsonPropertyName("Description")]
        public string? Description { get { return this.DescriptionOption; } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; }

        /// <summary>
        /// The unique identifier of the vat code
        /// </summary>
        /// <value>The unique identifier of the vat code</value>
        /* <example>201600</example> */
        [JsonPropertyName("Id")]
        public long? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of IsActive
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsActiveOption { get; }

        /// <summary>
        /// The value indicating whether this vat code is active
        /// </summary>
        /// <value>The value indicating whether this vat code is active</value>
        /* <example>false</example> */
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get { return this.IsActiveOption; } }

        /// <summary>
        /// Used to track the state of IsCustom
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsCustomOption { get; }

        /// <summary>
        /// The value indicating whether this vat code is custom created. The code will have the letter C in the notation if true.
        /// </summary>
        /// <value>The value indicating whether this vat code is custom created. The code will have the letter C in the notation if true.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsCustom")]
        public bool? IsCustom { get { return this.IsCustomOption; } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; }

        /// <summary>
        /// the name of the vat code.
        /// </summary>
        /// <value>the name of the vat code.</value>
        /* <example>Utgående mva høy sats</example> */
        [JsonPropertyName("Name")]
        public string? Name { get { return this.NameOption; } }

        /// <summary>
        /// Used to track the state of Rate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> RateOption { get; }

        /// <summary>
        /// The rate of the vat code. This is a value between 0 and 1. 0 representing 0 % vat and 1 representing 100 % vat.
        /// </summary>
        /// <value>The rate of the vat code. This is a value between 0 and 1. 0 representing 0 % vat and 1 representing 100 % vat.</value>
        /* <example>0.25</example> */
        [JsonPropertyName("Rate")]
        public double? Rate { get { return this.RateOption; } }

        /// <summary>
        /// Used to track the state of ValidFrom
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> ValidFromOption { get; }

        /// <summary>
        /// The date this vat code is active from, inclusive.
        /// </summary>
        /// <value>The date this vat code is active from, inclusive.</value>
        /* <example>Fri Jul 01 02:00:00 CEST 2022</example> */
        [JsonPropertyName("ValidFrom")]
        public DateTimeOffset? ValidFrom { get { return this.ValidFromOption; } }

        /// <summary>
        /// Used to track the state of ValidTo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> ValidToOption { get; }

        /// <summary>
        /// The date this vat code expires. Inclusive.
        /// </summary>
        /// <value>The date this vat code expires. Inclusive.</value>
        /* <example>Sat Dec 31 01:00:00 CET 2022</example> */
        [JsonPropertyName("ValidTo")]
        public DateTimeOffset? ValidTo { get { return this.ValidToOption; } }

        /// <summary>
        /// Used to track the state of VatBasisRatio
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> VatBasisRatioOption { get; }

        /// <summary>
        /// The vat basis ratio. Relevant for custom codes in mixed vat conditions (Norwegian: Forholdsmessig fradrag MVA). This is a value between 0 and 1, with 0 representing 0% vat basis ratio and 1 representing 100% vat basis ratio.  Example: A net amount of 1000 NOK with 50% vat basis ratio and 25% vat rate, will have the vat amount calculated as: 1000 x 0.5 x 0.25 &#x3D; 125 NOK
        /// </summary>
        /// <value>The vat basis ratio. Relevant for custom codes in mixed vat conditions (Norwegian: Forholdsmessig fradrag MVA). This is a value between 0 and 1, with 0 representing 0% vat basis ratio and 1 representing 100% vat basis ratio.  Example: A net amount of 1000 NOK with 50% vat basis ratio and 25% vat rate, will have the vat amount calculated as: 1000 x 0.5 x 0.25 &#x3D; 125 NOK</value>
        /* <example>0.5</example> */
        [JsonPropertyName("VatBasisRatio")]
        public double? VatBasisRatio { get { return this.VatBasisRatioOption; } }

        /// <summary>
        /// Used to track the state of VatBasisRatioValidFrom
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> VatBasisRatioValidFromOption { get; }

        /// <summary>
        /// The date this vat basis ratio is active from.  If no vat basis ratio is set, this date will default to the vat code valid from date.
        /// </summary>
        /// <value>The date this vat basis ratio is active from.  If no vat basis ratio is set, this date will default to the vat code valid from date.</value>
        [JsonPropertyName("VatBasisRatioValidFrom")]
        public DateTimeOffset? VatBasisRatioValidFrom { get { return this.VatBasisRatioValidFromOption; } }

        /// <summary>
        /// Used to track the state of VatBasisRatios
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<VatBasisRatios>?> VatBasisRatiosOption { get; }

        /// <summary>
        /// A collection of VatBasisRatios for a custom vat code.
        /// </summary>
        /// <value>A collection of VatBasisRatios for a custom vat code.</value>
        [JsonPropertyName("VatBasisRatios")]
        public List<VatBasisRatios>? VatBasisRatios { get { return this.VatBasisRatiosOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VatCodeDto {\n");
            sb.Append("  BaseVatCodeId: ").Append(BaseVatCodeId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsCustom: ").Append(IsCustom).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
            sb.Append("  VatBasisRatio: ").Append(VatBasisRatio).Append("\n");
            sb.Append("  VatBasisRatioValidFrom: ").Append(VatBasisRatioValidFrom).Append("\n");
            sb.Append("  VatBasisRatios: ").Append(VatBasisRatios).Append("\n");
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
    /// A Json converter for type <see cref="VatCodeDto" />
    /// </summary>
    public class VatCodeDtoJsonConverter : JsonConverter<VatCodeDto>
    {
        /// <summary>
        /// The format to use to serialize ValidFrom
        /// </summary>
        public static string ValidFromFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize ValidTo
        /// </summary>
        public static string ValidToFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize VatBasisRatioValidFrom
        /// </summary>
        public static string VatBasisRatioValidFromFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="VatCodeDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override VatCodeDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> baseVatCodeId = default;
            Option<string?> code = default;
            Option<string?> description = default;
            Option<long?> id = default;
            Option<bool?> isActive = default;
            Option<bool?> isCustom = default;
            Option<string?> name = default;
            Option<double?> rate = default;
            Option<DateTimeOffset?> validFrom = default;
            Option<DateTimeOffset?> validTo = default;
            Option<double?> vatBasisRatio = default;
            Option<DateTimeOffset?> vatBasisRatioValidFrom = default;
            Option<List<VatBasisRatios>?> vatBasisRatios = default;

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
                        case "BaseVatCodeId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                baseVatCodeId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "Code":
                            code = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Description":
                            description = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "IsCustom":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isCustom = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "Name":
                            name = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Rate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "ValidFrom":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                validFrom = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "ValidTo":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                validTo = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "VatBasisRatio":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                vatBasisRatio = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "VatBasisRatioValidFrom":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                vatBasisRatioValidFrom = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "VatBasisRatios":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                vatBasisRatios = new Option<List<VatBasisRatios>?>(JsonSerializer.Deserialize<List<VatBasisRatios>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class VatCodeDto.");

            if (rate.IsSet && rate.Value == null)
                throw new ArgumentNullException(nameof(rate), "Property is not nullable for class VatCodeDto.");

            if (validFrom.IsSet && validFrom.Value == null)
                throw new ArgumentNullException(nameof(validFrom), "Property is not nullable for class VatCodeDto.");

            return new VatCodeDto(baseVatCodeId, code, description, id, isActive, isCustom, name, rate, validFrom, validTo, vatBasisRatio, vatBasisRatioValidFrom, vatBasisRatios);
        }

        /// <summary>
        /// Serializes a <see cref="VatCodeDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="vatCodeDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, VatCodeDto vatCodeDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, vatCodeDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="VatCodeDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="vatCodeDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, VatCodeDto vatCodeDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (vatCodeDto.BaseVatCodeIdOption.IsSet)
                if (vatCodeDto.BaseVatCodeIdOption.Value != null)
                    writer.WriteNumber("BaseVatCodeId", vatCodeDto.BaseVatCodeIdOption.Value!.Value);
                else
                    writer.WriteNull("BaseVatCodeId");

            if (vatCodeDto.CodeOption.IsSet)
                if (vatCodeDto.CodeOption.Value != null)
                    writer.WriteString("Code", vatCodeDto.Code);
                else
                    writer.WriteNull("Code");

            if (vatCodeDto.DescriptionOption.IsSet)
                if (vatCodeDto.DescriptionOption.Value != null)
                    writer.WriteString("Description", vatCodeDto.Description);
                else
                    writer.WriteNull("Description");

            if (vatCodeDto.IdOption.IsSet)
                writer.WriteNumber("Id", vatCodeDto.IdOption.Value!.Value);

            if (vatCodeDto.IsActiveOption.IsSet)
                if (vatCodeDto.IsActiveOption.Value != null)
                    writer.WriteBoolean("IsActive", vatCodeDto.IsActiveOption.Value!.Value);
                else
                    writer.WriteNull("IsActive");

            if (vatCodeDto.IsCustomOption.IsSet)
                if (vatCodeDto.IsCustomOption.Value != null)
                    writer.WriteBoolean("IsCustom", vatCodeDto.IsCustomOption.Value!.Value);
                else
                    writer.WriteNull("IsCustom");

            if (vatCodeDto.NameOption.IsSet)
                if (vatCodeDto.NameOption.Value != null)
                    writer.WriteString("Name", vatCodeDto.Name);
                else
                    writer.WriteNull("Name");

            if (vatCodeDto.RateOption.IsSet)
                writer.WriteNumber("Rate", vatCodeDto.RateOption.Value!.Value);

            if (vatCodeDto.ValidFromOption.IsSet)
                writer.WriteString("ValidFrom", vatCodeDto.ValidFromOption.Value!.Value.ToString(ValidFromFormat));

            if (vatCodeDto.ValidToOption.IsSet)
                if (vatCodeDto.ValidToOption.Value != null)
                    writer.WriteString("ValidTo", vatCodeDto.ValidToOption.Value!.Value.ToString(ValidToFormat));
                else
                    writer.WriteNull("ValidTo");

            if (vatCodeDto.VatBasisRatioOption.IsSet)
                if (vatCodeDto.VatBasisRatioOption.Value != null)
                    writer.WriteNumber("VatBasisRatio", vatCodeDto.VatBasisRatioOption.Value!.Value);
                else
                    writer.WriteNull("VatBasisRatio");

            if (vatCodeDto.VatBasisRatioValidFromOption.IsSet)
                if (vatCodeDto.VatBasisRatioValidFromOption.Value != null)
                    writer.WriteString("VatBasisRatioValidFrom", vatCodeDto.VatBasisRatioValidFromOption.Value!.Value.ToString(VatBasisRatioValidFromFormat));
                else
                    writer.WriteNull("VatBasisRatioValidFrom");

            if (vatCodeDto.VatBasisRatiosOption.IsSet)
                if (vatCodeDto.VatBasisRatiosOption.Value != null)
                {
                    writer.WritePropertyName("VatBasisRatios");
                    JsonSerializer.Serialize(writer, vatCodeDto.VatBasisRatios, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("VatBasisRatios");
        }
    }
}

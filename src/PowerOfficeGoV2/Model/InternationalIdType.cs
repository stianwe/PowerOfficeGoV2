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
    /// Specified the type of international ID&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;PassportNumber&lt;/i&gt; - Passport number&lt;/li&gt;&lt;li&gt;&lt;i&gt;NationalIdentityNumber&lt;/i&gt; - National identity number (Social Security Number)&lt;/li&gt;&lt;li&gt;&lt;i&gt;TaxIdentificationNumber&lt;/i&gt; - Tax identification number&lt;/li&gt;&lt;li&gt;&lt;i&gt;ValueAddedTaxIdentificationNumber&lt;/i&gt; - Value added tax identification number&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>Specified the type of international ID&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;PassportNumber&lt;/i&gt; - Passport number&lt;/li&gt;&lt;li&gt;&lt;i&gt;NationalIdentityNumber&lt;/i&gt; - National identity number (Social Security Number)&lt;/li&gt;&lt;li&gt;&lt;i&gt;TaxIdentificationNumber&lt;/i&gt; - Tax identification number&lt;/li&gt;&lt;li&gt;&lt;i&gt;ValueAddedTaxIdentificationNumber&lt;/i&gt; - Value added tax identification number&lt;/li&gt;&lt;/ul&gt;</value>
    public enum InternationalIdType
    {
        /// <summary>
        /// Enum PassportNumber for value: PassportNumber
        /// </summary>
        PassportNumber = 1,

        /// <summary>
        /// Enum NationalIdentityNumber for value: NationalIdentityNumber
        /// </summary>
        NationalIdentityNumber = 2,

        /// <summary>
        /// Enum TaxIdentificationNumber for value: TaxIdentificationNumber
        /// </summary>
        TaxIdentificationNumber = 3,

        /// <summary>
        /// Enum ValueAddedTaxIdentificationNumber for value: ValueAddedTaxIdentificationNumber
        /// </summary>
        ValueAddedTaxIdentificationNumber = 4
    }

    /// <summary>
    /// Converts <see cref="InternationalIdType"/> to and from the JSON value
    /// </summary>
    public static class InternationalIdTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="InternationalIdType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static InternationalIdType FromString(string value)
        {
            if (value.Equals("PassportNumber"))
                return InternationalIdType.PassportNumber;

            if (value.Equals("NationalIdentityNumber"))
                return InternationalIdType.NationalIdentityNumber;

            if (value.Equals("TaxIdentificationNumber"))
                return InternationalIdType.TaxIdentificationNumber;

            if (value.Equals("ValueAddedTaxIdentificationNumber"))
                return InternationalIdType.ValueAddedTaxIdentificationNumber;

            throw new NotImplementedException($"Could not convert value to type InternationalIdType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="InternationalIdType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static InternationalIdType? FromStringOrDefault(string value)
        {
            if (value.Equals("PassportNumber"))
                return InternationalIdType.PassportNumber;

            if (value.Equals("NationalIdentityNumber"))
                return InternationalIdType.NationalIdentityNumber;

            if (value.Equals("TaxIdentificationNumber"))
                return InternationalIdType.TaxIdentificationNumber;

            if (value.Equals("ValueAddedTaxIdentificationNumber"))
                return InternationalIdType.ValueAddedTaxIdentificationNumber;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="InternationalIdType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(InternationalIdType value)
        {
            if (value == InternationalIdType.PassportNumber)
                return "PassportNumber";

            if (value == InternationalIdType.NationalIdentityNumber)
                return "NationalIdentityNumber";

            if (value == InternationalIdType.TaxIdentificationNumber)
                return "TaxIdentificationNumber";

            if (value == InternationalIdType.ValueAddedTaxIdentificationNumber)
                return "ValueAddedTaxIdentificationNumber";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="InternationalIdType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class InternationalIdTypeJsonConverter : JsonConverter<InternationalIdType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override InternationalIdType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            InternationalIdType? result = rawValue == null
                ? null
                : InternationalIdTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the InternationalIdType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="internationalIdType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, InternationalIdType internationalIdType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(internationalIdType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="InternationalIdType"/>
    /// </summary>
    public class InternationalIdTypeNullableJsonConverter : JsonConverter<InternationalIdType?>
    {
        /// <summary>
        /// Returns a InternationalIdType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override InternationalIdType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            InternationalIdType? result = rawValue == null
                ? null
                : InternationalIdTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="internationalIdType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, InternationalIdType? internationalIdType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(internationalIdType?.ToString() ?? "null");
        }
    }
}

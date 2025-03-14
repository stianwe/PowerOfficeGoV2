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
    /// Enum defining the commuter person type.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;ForeignCommuterWithTaxCardWithoutStandardDeduction&lt;/i&gt; - Foreign commuter with tax card, without standard deduction.&lt;/li&gt;&lt;li&gt;&lt;i&gt;ForeignerWithResidenceInNorway&lt;/i&gt; - Foreign commuter with residence in Norway.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>Enum defining the commuter person type.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;ForeignCommuterWithTaxCardWithoutStandardDeduction&lt;/i&gt; - Foreign commuter with tax card, without standard deduction.&lt;/li&gt;&lt;li&gt;&lt;i&gt;ForeignerWithResidenceInNorway&lt;/i&gt; - Foreign commuter with residence in Norway.&lt;/li&gt;&lt;/ul&gt;</value>
    public enum CommuterPersonType
    {
        /// <summary>
        /// Enum ForeignCommuterWithTaxCardWithoutStandardDeduction for value: ForeignCommuterWithTaxCardWithoutStandardDeduction
        /// </summary>
        ForeignCommuterWithTaxCardWithoutStandardDeduction = 1,

        /// <summary>
        /// Enum ForeignerWithResidenceInNorway for value: ForeignerWithResidenceInNorway
        /// </summary>
        ForeignerWithResidenceInNorway = 2
    }

    /// <summary>
    /// Converts <see cref="CommuterPersonType"/> to and from the JSON value
    /// </summary>
    public static class CommuterPersonTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="CommuterPersonType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CommuterPersonType FromString(string value)
        {
            if (value.Equals("ForeignCommuterWithTaxCardWithoutStandardDeduction"))
                return CommuterPersonType.ForeignCommuterWithTaxCardWithoutStandardDeduction;

            if (value.Equals("ForeignerWithResidenceInNorway"))
                return CommuterPersonType.ForeignerWithResidenceInNorway;

            throw new NotImplementedException($"Could not convert value to type CommuterPersonType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="CommuterPersonType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CommuterPersonType? FromStringOrDefault(string value)
        {
            if (value.Equals("ForeignCommuterWithTaxCardWithoutStandardDeduction"))
                return CommuterPersonType.ForeignCommuterWithTaxCardWithoutStandardDeduction;

            if (value.Equals("ForeignerWithResidenceInNorway"))
                return CommuterPersonType.ForeignerWithResidenceInNorway;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="CommuterPersonType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(CommuterPersonType value)
        {
            if (value == CommuterPersonType.ForeignCommuterWithTaxCardWithoutStandardDeduction)
                return "ForeignCommuterWithTaxCardWithoutStandardDeduction";

            if (value == CommuterPersonType.ForeignerWithResidenceInNorway)
                return "ForeignerWithResidenceInNorway";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CommuterPersonType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class CommuterPersonTypeJsonConverter : JsonConverter<CommuterPersonType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override CommuterPersonType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            CommuterPersonType? result = rawValue == null
                ? null
                : CommuterPersonTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the CommuterPersonType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commuterPersonType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, CommuterPersonType commuterPersonType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(commuterPersonType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CommuterPersonType"/>
    /// </summary>
    public class CommuterPersonTypeNullableJsonConverter : JsonConverter<CommuterPersonType?>
    {
        /// <summary>
        /// Returns a CommuterPersonType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override CommuterPersonType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            CommuterPersonType? result = rawValue == null
                ? null
                : CommuterPersonTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commuterPersonType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, CommuterPersonType? commuterPersonType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(commuterPersonType?.ToString() ?? "null");
        }
    }
}

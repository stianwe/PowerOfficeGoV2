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
    /// What the alternative vat return reporting is grouped by, if the client use alternative vat reporting.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;Department&lt;/i&gt; - Group the alternative vat reporting by departments&lt;/li&gt;&lt;li&gt;&lt;i&gt;AgricultureDepartment&lt;/i&gt; - Group the alternative vat reporting by agriculture departments&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>What the alternative vat return reporting is grouped by, if the client use alternative vat reporting.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;Department&lt;/i&gt; - Group the alternative vat reporting by departments&lt;/li&gt;&lt;li&gt;&lt;i&gt;AgricultureDepartment&lt;/i&gt; - Group the alternative vat reporting by agriculture departments&lt;/li&gt;&lt;/ul&gt;</value>
    public enum VatAlternativeGrouping
    {
        /// <summary>
        /// Enum Department for value: Department
        /// </summary>
        Department = 1,

        /// <summary>
        /// Enum AgricultureDepartment for value: AgricultureDepartment
        /// </summary>
        AgricultureDepartment = 2
    }

    /// <summary>
    /// Converts <see cref="VatAlternativeGrouping"/> to and from the JSON value
    /// </summary>
    public static class VatAlternativeGroupingValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="VatAlternativeGrouping"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VatAlternativeGrouping FromString(string value)
        {
            if (value.Equals("Department"))
                return VatAlternativeGrouping.Department;

            if (value.Equals("AgricultureDepartment"))
                return VatAlternativeGrouping.AgricultureDepartment;

            throw new NotImplementedException($"Could not convert value to type VatAlternativeGrouping: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="VatAlternativeGrouping"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VatAlternativeGrouping? FromStringOrDefault(string value)
        {
            if (value.Equals("Department"))
                return VatAlternativeGrouping.Department;

            if (value.Equals("AgricultureDepartment"))
                return VatAlternativeGrouping.AgricultureDepartment;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="VatAlternativeGrouping"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(VatAlternativeGrouping value)
        {
            if (value == VatAlternativeGrouping.Department)
                return "Department";

            if (value == VatAlternativeGrouping.AgricultureDepartment)
                return "AgricultureDepartment";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="VatAlternativeGrouping"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class VatAlternativeGroupingJsonConverter : JsonConverter<VatAlternativeGrouping>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override VatAlternativeGrouping Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            VatAlternativeGrouping? result = rawValue == null
                ? null
                : VatAlternativeGroupingValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the VatAlternativeGrouping to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="vatAlternativeGrouping"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, VatAlternativeGrouping vatAlternativeGrouping, JsonSerializerOptions options)
        {
            writer.WriteStringValue(vatAlternativeGrouping.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="VatAlternativeGrouping"/>
    /// </summary>
    public class VatAlternativeGroupingNullableJsonConverter : JsonConverter<VatAlternativeGrouping?>
    {
        /// <summary>
        /// Returns a VatAlternativeGrouping from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override VatAlternativeGrouping? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            VatAlternativeGrouping? result = rawValue == null
                ? null
                : VatAlternativeGroupingValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="vatAlternativeGrouping"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, VatAlternativeGrouping? vatAlternativeGrouping, JsonSerializerOptions options)
        {
            writer.WriteStringValue(vatAlternativeGrouping?.ToString() ?? "null");
        }
    }
}

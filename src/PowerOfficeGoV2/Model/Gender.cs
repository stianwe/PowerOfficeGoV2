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
    /// Available genders for contacts in Go&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;Male&lt;/i&gt; - Male gender&lt;/li&gt;&lt;li&gt;&lt;i&gt;Female&lt;/i&gt; - Female gender&lt;/li&gt;&lt;li&gt;&lt;i&gt;Hidden&lt;/i&gt; - Gender is hidden due to access limitation&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>Available genders for contacts in Go&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;Male&lt;/i&gt; - Male gender&lt;/li&gt;&lt;li&gt;&lt;i&gt;Female&lt;/i&gt; - Female gender&lt;/li&gt;&lt;li&gt;&lt;i&gt;Hidden&lt;/i&gt; - Gender is hidden due to access limitation&lt;/li&gt;&lt;/ul&gt;</value>
    public enum Gender
    {
        /// <summary>
        /// Enum Male for value: Male
        /// </summary>
        Male = 1,

        /// <summary>
        /// Enum Female for value: Female
        /// </summary>
        Female = 2,

        /// <summary>
        /// Enum Hidden for value: Hidden
        /// </summary>
        Hidden = 3
    }

    /// <summary>
    /// Converts <see cref="Gender"/> to and from the JSON value
    /// </summary>
    public static class GenderValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="Gender"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Gender FromString(string value)
        {
            if (value.Equals("Male"))
                return Gender.Male;

            if (value.Equals("Female"))
                return Gender.Female;

            if (value.Equals("Hidden"))
                return Gender.Hidden;

            throw new NotImplementedException($"Could not convert value to type Gender: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="Gender"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Gender? FromStringOrDefault(string value)
        {
            if (value.Equals("Male"))
                return Gender.Male;

            if (value.Equals("Female"))
                return Gender.Female;

            if (value.Equals("Hidden"))
                return Gender.Hidden;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="Gender"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(Gender value)
        {
            if (value == Gender.Male)
                return "Male";

            if (value == Gender.Female)
                return "Female";

            if (value == Gender.Hidden)
                return "Hidden";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Gender"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class GenderJsonConverter : JsonConverter<Gender>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override Gender Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            Gender? result = rawValue == null
                ? null
                : GenderValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the Gender to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gender"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, Gender gender, JsonSerializerOptions options)
        {
            writer.WriteStringValue(gender.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Gender"/>
    /// </summary>
    public class GenderNullableJsonConverter : JsonConverter<Gender?>
    {
        /// <summary>
        /// Returns a Gender from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override Gender? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            Gender? result = rawValue == null
                ? null
                : GenderValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gender"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, Gender? gender, JsonSerializerOptions options)
        {
            writer.WriteStringValue(gender?.ToString() ?? "null");
        }
    }
}

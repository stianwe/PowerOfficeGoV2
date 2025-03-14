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
    /// Enum defining the Value Added Tax (VAT) period on this client. The VAT period states how often VAT is reported to the government from this client.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;Weekly&lt;/i&gt; - Every week&lt;/li&gt;&lt;li&gt;&lt;i&gt;HalfMonthly&lt;/i&gt; - Half-Monthly&lt;/li&gt;&lt;li&gt;&lt;i&gt;Monthly&lt;/i&gt; - Every month&lt;/li&gt;&lt;li&gt;&lt;i&gt;BiMonthly&lt;/i&gt; - Every two months&lt;/li&gt;&lt;li&gt;&lt;i&gt;Yearly&lt;/i&gt; - Once a year&lt;/li&gt;&lt;li&gt;&lt;i&gt;HalfYearly&lt;/i&gt; - Twice a year&lt;/li&gt;&lt;li&gt;&lt;i&gt;Quarterly&lt;/i&gt; - Four times a year&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>Enum defining the Value Added Tax (VAT) period on this client. The VAT period states how often VAT is reported to the government from this client.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;Weekly&lt;/i&gt; - Every week&lt;/li&gt;&lt;li&gt;&lt;i&gt;HalfMonthly&lt;/i&gt; - Half-Monthly&lt;/li&gt;&lt;li&gt;&lt;i&gt;Monthly&lt;/i&gt; - Every month&lt;/li&gt;&lt;li&gt;&lt;i&gt;BiMonthly&lt;/i&gt; - Every two months&lt;/li&gt;&lt;li&gt;&lt;i&gt;Yearly&lt;/i&gt; - Once a year&lt;/li&gt;&lt;li&gt;&lt;i&gt;HalfYearly&lt;/i&gt; - Twice a year&lt;/li&gt;&lt;li&gt;&lt;i&gt;Quarterly&lt;/i&gt; - Four times a year&lt;/li&gt;&lt;/ul&gt;</value>
    public enum VatPeriodType
    {
        /// <summary>
        /// Enum Weekly for value: Weekly
        /// </summary>
        Weekly = 1,

        /// <summary>
        /// Enum HalfMonthly for value: HalfMonthly
        /// </summary>
        HalfMonthly = 2,

        /// <summary>
        /// Enum Monthly for value: Monthly
        /// </summary>
        Monthly = 3,

        /// <summary>
        /// Enum BiMonthly for value: BiMonthly
        /// </summary>
        BiMonthly = 4,

        /// <summary>
        /// Enum Yearly for value: Yearly
        /// </summary>
        Yearly = 5,

        /// <summary>
        /// Enum HalfYearly for value: HalfYearly
        /// </summary>
        HalfYearly = 6,

        /// <summary>
        /// Enum Quarterly for value: Quarterly
        /// </summary>
        Quarterly = 7
    }

    /// <summary>
    /// Converts <see cref="VatPeriodType"/> to and from the JSON value
    /// </summary>
    public static class VatPeriodTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="VatPeriodType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VatPeriodType FromString(string value)
        {
            if (value.Equals("Weekly"))
                return VatPeriodType.Weekly;

            if (value.Equals("HalfMonthly"))
                return VatPeriodType.HalfMonthly;

            if (value.Equals("Monthly"))
                return VatPeriodType.Monthly;

            if (value.Equals("BiMonthly"))
                return VatPeriodType.BiMonthly;

            if (value.Equals("Yearly"))
                return VatPeriodType.Yearly;

            if (value.Equals("HalfYearly"))
                return VatPeriodType.HalfYearly;

            if (value.Equals("Quarterly"))
                return VatPeriodType.Quarterly;

            throw new NotImplementedException($"Could not convert value to type VatPeriodType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="VatPeriodType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VatPeriodType? FromStringOrDefault(string value)
        {
            if (value.Equals("Weekly"))
                return VatPeriodType.Weekly;

            if (value.Equals("HalfMonthly"))
                return VatPeriodType.HalfMonthly;

            if (value.Equals("Monthly"))
                return VatPeriodType.Monthly;

            if (value.Equals("BiMonthly"))
                return VatPeriodType.BiMonthly;

            if (value.Equals("Yearly"))
                return VatPeriodType.Yearly;

            if (value.Equals("HalfYearly"))
                return VatPeriodType.HalfYearly;

            if (value.Equals("Quarterly"))
                return VatPeriodType.Quarterly;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="VatPeriodType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(VatPeriodType value)
        {
            if (value == VatPeriodType.Weekly)
                return "Weekly";

            if (value == VatPeriodType.HalfMonthly)
                return "HalfMonthly";

            if (value == VatPeriodType.Monthly)
                return "Monthly";

            if (value == VatPeriodType.BiMonthly)
                return "BiMonthly";

            if (value == VatPeriodType.Yearly)
                return "Yearly";

            if (value == VatPeriodType.HalfYearly)
                return "HalfYearly";

            if (value == VatPeriodType.Quarterly)
                return "Quarterly";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="VatPeriodType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class VatPeriodTypeJsonConverter : JsonConverter<VatPeriodType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override VatPeriodType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            VatPeriodType? result = rawValue == null
                ? null
                : VatPeriodTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the VatPeriodType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="vatPeriodType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, VatPeriodType vatPeriodType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(vatPeriodType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="VatPeriodType"/>
    /// </summary>
    public class VatPeriodTypeNullableJsonConverter : JsonConverter<VatPeriodType?>
    {
        /// <summary>
        /// Returns a VatPeriodType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override VatPeriodType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            VatPeriodType? result = rawValue == null
                ? null
                : VatPeriodTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="vatPeriodType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, VatPeriodType? vatPeriodType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(vatPeriodType?.ToString() ?? "null");
        }
    }
}

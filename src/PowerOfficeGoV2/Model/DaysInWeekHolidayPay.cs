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
    /// Enum defining the days in a week for the holiday pay settings  and how the wage deduction will be calculated.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;FiveDays&lt;/i&gt; - A week have 5 working days,                 and the calculation for wage deduction use 22 days in the denominator.&lt;/li&gt;&lt;li&gt;&lt;i&gt;FiveDays_21_67&lt;/i&gt; - A week have 5 working days,                 and the calculation for wage deduction use 21.67 days in the denominator.&lt;/li&gt;&lt;li&gt;&lt;i&gt;SixDays&lt;/i&gt; - A week have 6 working days,                 and the calculation for wage deduction use 26 days in the denominator.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>Enum defining the days in a week for the holiday pay settings  and how the wage deduction will be calculated.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;FiveDays&lt;/i&gt; - A week have 5 working days,                 and the calculation for wage deduction use 22 days in the denominator.&lt;/li&gt;&lt;li&gt;&lt;i&gt;FiveDays_21_67&lt;/i&gt; - A week have 5 working days,                 and the calculation for wage deduction use 21.67 days in the denominator.&lt;/li&gt;&lt;li&gt;&lt;i&gt;SixDays&lt;/i&gt; - A week have 6 working days,                 and the calculation for wage deduction use 26 days in the denominator.&lt;/li&gt;&lt;/ul&gt;</value>
    public enum DaysInWeekHolidayPay
    {
        /// <summary>
        /// Enum FiveDays for value: FiveDays
        /// </summary>
        FiveDays = 1,

        /// <summary>
        /// Enum FiveDays2167 for value: FiveDays_21_67
        /// </summary>
        FiveDays2167 = 2,

        /// <summary>
        /// Enum SixDays for value: SixDays
        /// </summary>
        SixDays = 3
    }

    /// <summary>
    /// Converts <see cref="DaysInWeekHolidayPay"/> to and from the JSON value
    /// </summary>
    public static class DaysInWeekHolidayPayValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="DaysInWeekHolidayPay"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DaysInWeekHolidayPay FromString(string value)
        {
            if (value.Equals("FiveDays"))
                return DaysInWeekHolidayPay.FiveDays;

            if (value.Equals("FiveDays_21_67"))
                return DaysInWeekHolidayPay.FiveDays2167;

            if (value.Equals("SixDays"))
                return DaysInWeekHolidayPay.SixDays;

            throw new NotImplementedException($"Could not convert value to type DaysInWeekHolidayPay: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="DaysInWeekHolidayPay"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DaysInWeekHolidayPay? FromStringOrDefault(string value)
        {
            if (value.Equals("FiveDays"))
                return DaysInWeekHolidayPay.FiveDays;

            if (value.Equals("FiveDays_21_67"))
                return DaysInWeekHolidayPay.FiveDays2167;

            if (value.Equals("SixDays"))
                return DaysInWeekHolidayPay.SixDays;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="DaysInWeekHolidayPay"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(DaysInWeekHolidayPay value)
        {
            if (value == DaysInWeekHolidayPay.FiveDays)
                return "FiveDays";

            if (value == DaysInWeekHolidayPay.FiveDays2167)
                return "FiveDays_21_67";

            if (value == DaysInWeekHolidayPay.SixDays)
                return "SixDays";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DaysInWeekHolidayPay"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class DaysInWeekHolidayPayJsonConverter : JsonConverter<DaysInWeekHolidayPay>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override DaysInWeekHolidayPay Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            DaysInWeekHolidayPay? result = rawValue == null
                ? null
                : DaysInWeekHolidayPayValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DaysInWeekHolidayPay to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="daysInWeekHolidayPay"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, DaysInWeekHolidayPay daysInWeekHolidayPay, JsonSerializerOptions options)
        {
            writer.WriteStringValue(daysInWeekHolidayPay.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DaysInWeekHolidayPay"/>
    /// </summary>
    public class DaysInWeekHolidayPayNullableJsonConverter : JsonConverter<DaysInWeekHolidayPay?>
    {
        /// <summary>
        /// Returns a DaysInWeekHolidayPay from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override DaysInWeekHolidayPay? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            DaysInWeekHolidayPay? result = rawValue == null
                ? null
                : DaysInWeekHolidayPayValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="daysInWeekHolidayPay"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, DaysInWeekHolidayPay? daysInWeekHolidayPay, JsonSerializerOptions options)
        {
            writer.WriteStringValue(daysInWeekHolidayPay?.ToString() ?? "null");
        }
    }
}

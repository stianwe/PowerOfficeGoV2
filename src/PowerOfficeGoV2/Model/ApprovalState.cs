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
    /// An enum that represents the approval state of a voucher.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;Approved&lt;/i&gt; - The voucher has been approved.&lt;/li&gt;&lt;li&gt;&lt;i&gt;Canceled&lt;/i&gt; - The voucher approval has been canceled.&lt;/li&gt;&lt;li&gt;&lt;i&gt;Rejected&lt;/i&gt; - The voucher approval has been rejected.&lt;/li&gt;&lt;li&gt;&lt;i&gt;Submitted&lt;/i&gt; - The voucher has been submitted to an approval workflow.&lt;/li&gt;&lt;li&gt;&lt;i&gt;UnderReview&lt;/i&gt; - The voucher is currently under review.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>An enum that represents the approval state of a voucher.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;Approved&lt;/i&gt; - The voucher has been approved.&lt;/li&gt;&lt;li&gt;&lt;i&gt;Canceled&lt;/i&gt; - The voucher approval has been canceled.&lt;/li&gt;&lt;li&gt;&lt;i&gt;Rejected&lt;/i&gt; - The voucher approval has been rejected.&lt;/li&gt;&lt;li&gt;&lt;i&gt;Submitted&lt;/i&gt; - The voucher has been submitted to an approval workflow.&lt;/li&gt;&lt;li&gt;&lt;i&gt;UnderReview&lt;/i&gt; - The voucher is currently under review.&lt;/li&gt;&lt;/ul&gt;</value>
    public enum ApprovalState
    {
        /// <summary>
        /// Enum Approved for value: Approved
        /// </summary>
        Approved = 1,

        /// <summary>
        /// Enum Canceled for value: Canceled
        /// </summary>
        Canceled = 2,

        /// <summary>
        /// Enum Rejected for value: Rejected
        /// </summary>
        Rejected = 3,

        /// <summary>
        /// Enum Submitted for value: Submitted
        /// </summary>
        Submitted = 4,

        /// <summary>
        /// Enum UnderReview for value: UnderReview
        /// </summary>
        UnderReview = 5
    }

    /// <summary>
    /// Converts <see cref="ApprovalState"/> to and from the JSON value
    /// </summary>
    public static class ApprovalStateValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="ApprovalState"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ApprovalState FromString(string value)
        {
            if (value.Equals("Approved"))
                return ApprovalState.Approved;

            if (value.Equals("Canceled"))
                return ApprovalState.Canceled;

            if (value.Equals("Rejected"))
                return ApprovalState.Rejected;

            if (value.Equals("Submitted"))
                return ApprovalState.Submitted;

            if (value.Equals("UnderReview"))
                return ApprovalState.UnderReview;

            throw new NotImplementedException($"Could not convert value to type ApprovalState: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="ApprovalState"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ApprovalState? FromStringOrDefault(string value)
        {
            if (value.Equals("Approved"))
                return ApprovalState.Approved;

            if (value.Equals("Canceled"))
                return ApprovalState.Canceled;

            if (value.Equals("Rejected"))
                return ApprovalState.Rejected;

            if (value.Equals("Submitted"))
                return ApprovalState.Submitted;

            if (value.Equals("UnderReview"))
                return ApprovalState.UnderReview;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="ApprovalState"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(ApprovalState value)
        {
            if (value == ApprovalState.Approved)
                return "Approved";

            if (value == ApprovalState.Canceled)
                return "Canceled";

            if (value == ApprovalState.Rejected)
                return "Rejected";

            if (value == ApprovalState.Submitted)
                return "Submitted";

            if (value == ApprovalState.UnderReview)
                return "UnderReview";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ApprovalState"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class ApprovalStateJsonConverter : JsonConverter<ApprovalState>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ApprovalState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            ApprovalState? result = rawValue == null
                ? null
                : ApprovalStateValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the ApprovalState to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="approvalState"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ApprovalState approvalState, JsonSerializerOptions options)
        {
            writer.WriteStringValue(approvalState.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ApprovalState"/>
    /// </summary>
    public class ApprovalStateNullableJsonConverter : JsonConverter<ApprovalState?>
    {
        /// <summary>
        /// Returns a ApprovalState from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ApprovalState? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            ApprovalState? result = rawValue == null
                ? null
                : ApprovalStateValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="approvalState"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ApprovalState? approvalState, JsonSerializerOptions options)
        {
            writer.WriteStringValue(approvalState?.ToString() ?? "null");
        }
    }
}

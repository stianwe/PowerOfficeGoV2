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
    /// The reason for the end of the employment at the end date. Must be provided if the end date is set.  This should be 1 to 1 with the EndDateReason enum in Go. (Server\\Common\\Payrolls\\Enums\\EndDateReasons.cs)&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;EmploymentRelationshipShouldNeverHaveBeenReported&lt;/i&gt; - The employment should never have been reported.&lt;/li&gt;&lt;li&gt;&lt;i&gt;EmployerHasDismissedTheEmployee&lt;/i&gt; - The employer has terminated the employment relationship.&lt;/li&gt;&lt;li&gt;&lt;i&gt;EmployeeHasResigned&lt;/i&gt; - The employee has resigned from his/her position.&lt;/li&gt;&lt;li&gt;&lt;i&gt;ChangeOfPayrollSystemOrAccountant&lt;/i&gt; - Changed payroll system or accountant.&lt;/li&gt;&lt;li&gt;&lt;i&gt;ChangeOfOrganizationStructureOrChangedJobInternally&lt;/i&gt; - Changes in organisational structure or internal job swap.&lt;/li&gt;&lt;li&gt;&lt;i&gt;ContractCommitmentOrTemporaryEmploymentExpired&lt;/i&gt; - Contract, temporary appointment or temporary position has been terminated.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>The reason for the end of the employment at the end date. Must be provided if the end date is set.  This should be 1 to 1 with the EndDateReason enum in Go. (Server\\Common\\Payrolls\\Enums\\EndDateReasons.cs)&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;EmploymentRelationshipShouldNeverHaveBeenReported&lt;/i&gt; - The employment should never have been reported.&lt;/li&gt;&lt;li&gt;&lt;i&gt;EmployerHasDismissedTheEmployee&lt;/i&gt; - The employer has terminated the employment relationship.&lt;/li&gt;&lt;li&gt;&lt;i&gt;EmployeeHasResigned&lt;/i&gt; - The employee has resigned from his/her position.&lt;/li&gt;&lt;li&gt;&lt;i&gt;ChangeOfPayrollSystemOrAccountant&lt;/i&gt; - Changed payroll system or accountant.&lt;/li&gt;&lt;li&gt;&lt;i&gt;ChangeOfOrganizationStructureOrChangedJobInternally&lt;/i&gt; - Changes in organisational structure or internal job swap.&lt;/li&gt;&lt;li&gt;&lt;i&gt;ContractCommitmentOrTemporaryEmploymentExpired&lt;/i&gt; - Contract, temporary appointment or temporary position has been terminated.&lt;/li&gt;&lt;/ul&gt;</value>
    public enum EndDateReasonType
    {
        /// <summary>
        /// Enum EmploymentRelationshipShouldNeverHaveBeenReported for value: EmploymentRelationshipShouldNeverHaveBeenReported
        /// </summary>
        EmploymentRelationshipShouldNeverHaveBeenReported = 1,

        /// <summary>
        /// Enum EmployerHasDismissedTheEmployee for value: EmployerHasDismissedTheEmployee
        /// </summary>
        EmployerHasDismissedTheEmployee = 2,

        /// <summary>
        /// Enum EmployeeHasResigned for value: EmployeeHasResigned
        /// </summary>
        EmployeeHasResigned = 3,

        /// <summary>
        /// Enum ChangeOfPayrollSystemOrAccountant for value: ChangeOfPayrollSystemOrAccountant
        /// </summary>
        ChangeOfPayrollSystemOrAccountant = 4,

        /// <summary>
        /// Enum ChangeOfOrganizationStructureOrChangedJobInternally for value: ChangeOfOrganizationStructureOrChangedJobInternally
        /// </summary>
        ChangeOfOrganizationStructureOrChangedJobInternally = 5,

        /// <summary>
        /// Enum ContractCommitmentOrTemporaryEmploymentExpired for value: ContractCommitmentOrTemporaryEmploymentExpired
        /// </summary>
        ContractCommitmentOrTemporaryEmploymentExpired = 6
    }

    /// <summary>
    /// Converts <see cref="EndDateReasonType"/> to and from the JSON value
    /// </summary>
    public static class EndDateReasonTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="EndDateReasonType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EndDateReasonType FromString(string value)
        {
            if (value.Equals("EmploymentRelationshipShouldNeverHaveBeenReported"))
                return EndDateReasonType.EmploymentRelationshipShouldNeverHaveBeenReported;

            if (value.Equals("EmployerHasDismissedTheEmployee"))
                return EndDateReasonType.EmployerHasDismissedTheEmployee;

            if (value.Equals("EmployeeHasResigned"))
                return EndDateReasonType.EmployeeHasResigned;

            if (value.Equals("ChangeOfPayrollSystemOrAccountant"))
                return EndDateReasonType.ChangeOfPayrollSystemOrAccountant;

            if (value.Equals("ChangeOfOrganizationStructureOrChangedJobInternally"))
                return EndDateReasonType.ChangeOfOrganizationStructureOrChangedJobInternally;

            if (value.Equals("ContractCommitmentOrTemporaryEmploymentExpired"))
                return EndDateReasonType.ContractCommitmentOrTemporaryEmploymentExpired;

            throw new NotImplementedException($"Could not convert value to type EndDateReasonType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="EndDateReasonType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EndDateReasonType? FromStringOrDefault(string value)
        {
            if (value.Equals("EmploymentRelationshipShouldNeverHaveBeenReported"))
                return EndDateReasonType.EmploymentRelationshipShouldNeverHaveBeenReported;

            if (value.Equals("EmployerHasDismissedTheEmployee"))
                return EndDateReasonType.EmployerHasDismissedTheEmployee;

            if (value.Equals("EmployeeHasResigned"))
                return EndDateReasonType.EmployeeHasResigned;

            if (value.Equals("ChangeOfPayrollSystemOrAccountant"))
                return EndDateReasonType.ChangeOfPayrollSystemOrAccountant;

            if (value.Equals("ChangeOfOrganizationStructureOrChangedJobInternally"))
                return EndDateReasonType.ChangeOfOrganizationStructureOrChangedJobInternally;

            if (value.Equals("ContractCommitmentOrTemporaryEmploymentExpired"))
                return EndDateReasonType.ContractCommitmentOrTemporaryEmploymentExpired;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EndDateReasonType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(EndDateReasonType value)
        {
            if (value == EndDateReasonType.EmploymentRelationshipShouldNeverHaveBeenReported)
                return "EmploymentRelationshipShouldNeverHaveBeenReported";

            if (value == EndDateReasonType.EmployerHasDismissedTheEmployee)
                return "EmployerHasDismissedTheEmployee";

            if (value == EndDateReasonType.EmployeeHasResigned)
                return "EmployeeHasResigned";

            if (value == EndDateReasonType.ChangeOfPayrollSystemOrAccountant)
                return "ChangeOfPayrollSystemOrAccountant";

            if (value == EndDateReasonType.ChangeOfOrganizationStructureOrChangedJobInternally)
                return "ChangeOfOrganizationStructureOrChangedJobInternally";

            if (value == EndDateReasonType.ContractCommitmentOrTemporaryEmploymentExpired)
                return "ContractCommitmentOrTemporaryEmploymentExpired";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EndDateReasonType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class EndDateReasonTypeJsonConverter : JsonConverter<EndDateReasonType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override EndDateReasonType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            EndDateReasonType? result = rawValue == null
                ? null
                : EndDateReasonTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the EndDateReasonType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="endDateReasonType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, EndDateReasonType endDateReasonType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(endDateReasonType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EndDateReasonType"/>
    /// </summary>
    public class EndDateReasonTypeNullableJsonConverter : JsonConverter<EndDateReasonType?>
    {
        /// <summary>
        /// Returns a EndDateReasonType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override EndDateReasonType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            EndDateReasonType? result = rawValue == null
                ? null
                : EndDateReasonTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="endDateReasonType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, EndDateReasonType? endDateReasonType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(endDateReasonType?.ToString() ?? "null");
        }
    }
}

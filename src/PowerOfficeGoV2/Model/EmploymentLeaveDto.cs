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
    /// The Employment Leave DTO contains properties relevant to a leave (line) on an employment relationship object in Go.
    /// </summary>
    public partial class EmploymentLeaveDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmploymentLeaveDto" /> class.
        /// </summary>
        /// <param name="adjustFixedWage">Value indicating whether the fixed wage should be adjusted by the leave percentage.  If true then this leave percentage will be used to adjust the fixed wage.</param>
        /// <param name="createdDateTimeOffset">The timestamp when the employment leave entity was created.</param>
        /// <param name="employeeId">The identifier of the employee the employment belongs to.</param>
        /// <param name="employmentId">The id of the employment (employment relationship) the leave line belongs to.</param>
        /// <param name="endDate">The end date of the leave.</param>
        /// <param name="endedAndReported">Value is set true if and when the leave is ended and the reporting (a-melding) is done and finalized.  If true, the leave will not be included in future reporting (a-melding).</param>
        /// <param name="excludeEmployeeFromPayroll">Value is set true if the employee should be excluded from payroll&#39;s while the leave is active.</param>
        /// <param name="id">The id of the employment leave (line).</param>
        /// <param name="lastChangedDateTimeOffset">The timestamp when the employment leave entity was last changed.</param>
        /// <param name="leavePercentage">The percentage of leave of absence.  100 represent fully absent,  50 represent 50% absence from the current employment.</param>
        /// <param name="reportingId">The id of the leave that will be reported.   If not set, Go will assign an id.   Not to be confused with the Id property.</param>
        /// <param name="startDate">The start date of the leave.</param>
        /// <param name="typeOfLeave">typeOfLeave</param>
        [JsonConstructor]
        public EmploymentLeaveDto(Option<bool?> adjustFixedWage = default, Option<DateTime?> createdDateTimeOffset = default, Option<long?> employeeId = default, Option<long?> employmentId = default, Option<DateOnly?> endDate = default, Option<bool?> endedAndReported = default, Option<bool?> excludeEmployeeFromPayroll = default, Option<Guid?> id = default, Option<DateTime?> lastChangedDateTimeOffset = default, Option<double?> leavePercentage = default, Option<string?> reportingId = default, Option<DateOnly?> startDate = default, Option<LeaveType?> typeOfLeave = default)
        {
            AdjustFixedWageOption = adjustFixedWage;
            CreatedDateTimeOffsetOption = createdDateTimeOffset;
            EmployeeIdOption = employeeId;
            EmploymentIdOption = employmentId;
            EndDateOption = endDate;
            EndedAndReportedOption = endedAndReported;
            ExcludeEmployeeFromPayrollOption = excludeEmployeeFromPayroll;
            IdOption = id;
            LastChangedDateTimeOffsetOption = lastChangedDateTimeOffset;
            LeavePercentageOption = leavePercentage;
            ReportingIdOption = reportingId;
            StartDateOption = startDate;
            TypeOfLeaveOption = typeOfLeave;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of TypeOfLeave
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<LeaveType?> TypeOfLeaveOption { get; private set; }

        /// <summary>
        /// Gets or Sets TypeOfLeave
        /// </summary>
        [JsonPropertyName("TypeOfLeave")]
        public LeaveType? TypeOfLeave { get { return this.TypeOfLeaveOption; } set { this.TypeOfLeaveOption = new(value); } }

        /// <summary>
        /// Used to track the state of AdjustFixedWage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> AdjustFixedWageOption { get; private set; }

        /// <summary>
        /// Value indicating whether the fixed wage should be adjusted by the leave percentage.  If true then this leave percentage will be used to adjust the fixed wage.
        /// </summary>
        /// <value>Value indicating whether the fixed wage should be adjusted by the leave percentage.  If true then this leave percentage will be used to adjust the fixed wage.</value>
        /* <example>false</example> */
        [JsonPropertyName("AdjustFixedWage")]
        public bool? AdjustFixedWage { get { return this.AdjustFixedWageOption; } set { this.AdjustFixedWageOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreatedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreatedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp when the employment leave entity was created.
        /// </summary>
        /// <value>The timestamp when the employment leave entity was created.</value>
        /* <example>2021-09-30T08:03:00.123456700Z</example> */
        [JsonPropertyName("CreatedDateTimeOffset")]
        public DateTime? CreatedDateTimeOffset { get { return this.CreatedDateTimeOffsetOption; } }

        /// <summary>
        /// Used to track the state of EmployeeId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> EmployeeIdOption { get; }

        /// <summary>
        /// The identifier of the employee the employment belongs to.
        /// </summary>
        /// <value>The identifier of the employee the employment belongs to.</value>
        /* <example>12345</example> */
        [JsonPropertyName("EmployeeId")]
        public long? EmployeeId { get { return this.EmployeeIdOption; } }

        /// <summary>
        /// Used to track the state of EmploymentId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> EmploymentIdOption { get; }

        /// <summary>
        /// The id of the employment (employment relationship) the leave line belongs to.
        /// </summary>
        /// <value>The id of the employment (employment relationship) the leave line belongs to.</value>
        /* <example>12345</example> */
        [JsonPropertyName("EmploymentId")]
        public long? EmploymentId { get { return this.EmploymentIdOption; } }

        /// <summary>
        /// Used to track the state of EndDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> EndDateOption { get; private set; }

        /// <summary>
        /// The end date of the leave.
        /// </summary>
        /// <value>The end date of the leave.</value>
        /* <example>Sun Jan 10 01:00:00 CET 2021</example> */
        [JsonPropertyName("EndDate")]
        public DateOnly? EndDate { get { return this.EndDateOption; } set { this.EndDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of EndedAndReported
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> EndedAndReportedOption { get; private set; }

        /// <summary>
        /// Value is set true if and when the leave is ended and the reporting (a-melding) is done and finalized.  If true, the leave will not be included in future reporting (a-melding).
        /// </summary>
        /// <value>Value is set true if and when the leave is ended and the reporting (a-melding) is done and finalized.  If true, the leave will not be included in future reporting (a-melding).</value>
        /* <example>false</example> */
        [JsonPropertyName("EndedAndReported")]
        public bool? EndedAndReported { get { return this.EndedAndReportedOption; } set { this.EndedAndReportedOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExcludeEmployeeFromPayroll
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> ExcludeEmployeeFromPayrollOption { get; private set; }

        /// <summary>
        /// Value is set true if the employee should be excluded from payroll&#39;s while the leave is active.
        /// </summary>
        /// <value>Value is set true if the employee should be excluded from payroll&#39;s while the leave is active.</value>
        /* <example>false</example> */
        [JsonPropertyName("ExcludeEmployeeFromPayroll")]
        public bool? ExcludeEmployeeFromPayroll { get { return this.ExcludeEmployeeFromPayrollOption; } set { this.ExcludeEmployeeFromPayrollOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> IdOption { get; }

        /// <summary>
        /// The id of the employment leave (line).
        /// </summary>
        /// <value>The id of the employment leave (line).</value>
        /* <example>f575b4b0-55be-4b56-b01f-44b204df82c5</example> */
        [JsonPropertyName("Id")]
        public Guid? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of LastChangedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastChangedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp when the employment leave entity was last changed.
        /// </summary>
        /// <value>The timestamp when the employment leave entity was last changed.</value>
        /* <example>2021-09-30T09:33:00.123456700Z</example> */
        [JsonPropertyName("LastChangedDateTimeOffset")]
        public DateTime? LastChangedDateTimeOffset { get { return this.LastChangedDateTimeOffsetOption; } }

        /// <summary>
        /// Used to track the state of LeavePercentage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> LeavePercentageOption { get; private set; }

        /// <summary>
        /// The percentage of leave of absence.  100 represent fully absent,  50 represent 50% absence from the current employment.
        /// </summary>
        /// <value>The percentage of leave of absence.  100 represent fully absent,  50 represent 50% absence from the current employment.</value>
        /* <example>58.45</example> */
        [JsonPropertyName("LeavePercentage")]
        public double? LeavePercentage { get { return this.LeavePercentageOption; } set { this.LeavePercentageOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReportingId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ReportingIdOption { get; private set; }

        /// <summary>
        /// The id of the leave that will be reported.   If not set, Go will assign an id.   Not to be confused with the Id property.
        /// </summary>
        /// <value>The id of the leave that will be reported.   If not set, Go will assign an id.   Not to be confused with the Id property.</value>
        /* <example>POGO_123abc</example> */
        [JsonPropertyName("ReportingId")]
        public string? ReportingId { get { return this.ReportingIdOption; } set { this.ReportingIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of StartDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> StartDateOption { get; private set; }

        /// <summary>
        /// The start date of the leave.
        /// </summary>
        /// <value>The start date of the leave.</value>
        /* <example>Fri Jan 01 01:00:00 CET 2021</example> */
        [JsonPropertyName("StartDate")]
        public DateOnly? StartDate { get { return this.StartDateOption; } set { this.StartDateOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmploymentLeaveDto {\n");
            sb.Append("  AdjustFixedWage: ").Append(AdjustFixedWage).Append("\n");
            sb.Append("  CreatedDateTimeOffset: ").Append(CreatedDateTimeOffset).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmploymentId: ").Append(EmploymentId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndedAndReported: ").Append(EndedAndReported).Append("\n");
            sb.Append("  ExcludeEmployeeFromPayroll: ").Append(ExcludeEmployeeFromPayroll).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastChangedDateTimeOffset: ").Append(LastChangedDateTimeOffset).Append("\n");
            sb.Append("  LeavePercentage: ").Append(LeavePercentage).Append("\n");
            sb.Append("  ReportingId: ").Append(ReportingId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TypeOfLeave: ").Append(TypeOfLeave).Append("\n");
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
    /// A Json converter for type <see cref="EmploymentLeaveDto" />
    /// </summary>
    public class EmploymentLeaveDtoJsonConverter : JsonConverter<EmploymentLeaveDto>
    {
        /// <summary>
        /// The format to use to serialize CreatedDateTimeOffset
        /// </summary>
        public static string CreatedDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize EndDate
        /// </summary>
        public static string EndDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize LastChangedDateTimeOffset
        /// </summary>
        public static string LastChangedDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize StartDate
        /// </summary>
        public static string StartDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="EmploymentLeaveDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EmploymentLeaveDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> adjustFixedWage = default;
            Option<DateTime?> createdDateTimeOffset = default;
            Option<long?> employeeId = default;
            Option<long?> employmentId = default;
            Option<DateOnly?> endDate = default;
            Option<bool?> endedAndReported = default;
            Option<bool?> excludeEmployeeFromPayroll = default;
            Option<Guid?> id = default;
            Option<DateTime?> lastChangedDateTimeOffset = default;
            Option<double?> leavePercentage = default;
            Option<string?> reportingId = default;
            Option<DateOnly?> startDate = default;
            Option<LeaveType?> typeOfLeave = default;

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
                        case "AdjustFixedWage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                adjustFixedWage = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "CreatedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdDateTimeOffset = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "EmployeeId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                employeeId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "EmploymentId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                employmentId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "EndDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "EndedAndReported":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endedAndReported = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "ExcludeEmployeeFromPayroll":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                excludeEmployeeFromPayroll = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "LastChangedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastChangedDateTimeOffset = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "LeavePercentage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                leavePercentage = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "ReportingId":
                            reportingId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "StartDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "TypeOfLeave":
                            string? typeOfLeaveRawValue = utf8JsonReader.GetString();
                            if (typeOfLeaveRawValue != null)
                                typeOfLeave = new Option<LeaveType?>(LeaveTypeValueConverter.FromStringOrDefault(typeOfLeaveRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createdDateTimeOffset.IsSet && createdDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(createdDateTimeOffset), "Property is not nullable for class EmploymentLeaveDto.");

            if (employeeId.IsSet && employeeId.Value == null)
                throw new ArgumentNullException(nameof(employeeId), "Property is not nullable for class EmploymentLeaveDto.");

            if (employmentId.IsSet && employmentId.Value == null)
                throw new ArgumentNullException(nameof(employmentId), "Property is not nullable for class EmploymentLeaveDto.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EmploymentLeaveDto.");

            if (lastChangedDateTimeOffset.IsSet && lastChangedDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(lastChangedDateTimeOffset), "Property is not nullable for class EmploymentLeaveDto.");

            return new EmploymentLeaveDto(adjustFixedWage, createdDateTimeOffset, employeeId, employmentId, endDate, endedAndReported, excludeEmployeeFromPayroll, id, lastChangedDateTimeOffset, leavePercentage, reportingId, startDate, typeOfLeave);
        }

        /// <summary>
        /// Serializes a <see cref="EmploymentLeaveDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employmentLeaveDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EmploymentLeaveDto employmentLeaveDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, employmentLeaveDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EmploymentLeaveDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employmentLeaveDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EmploymentLeaveDto employmentLeaveDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (employmentLeaveDto.AdjustFixedWageOption.IsSet)
                if (employmentLeaveDto.AdjustFixedWageOption.Value != null)
                    writer.WriteBoolean("AdjustFixedWage", employmentLeaveDto.AdjustFixedWageOption.Value!.Value);
                else
                    writer.WriteNull("AdjustFixedWage");

            if (employmentLeaveDto.CreatedDateTimeOffsetOption.IsSet)
                writer.WriteString("CreatedDateTimeOffset", employmentLeaveDto.CreatedDateTimeOffsetOption.Value!.Value.ToString(CreatedDateTimeOffsetFormat));

            if (employmentLeaveDto.EmployeeIdOption.IsSet)
                writer.WriteNumber("EmployeeId", employmentLeaveDto.EmployeeIdOption.Value!.Value);

            if (employmentLeaveDto.EmploymentIdOption.IsSet)
                writer.WriteNumber("EmploymentId", employmentLeaveDto.EmploymentIdOption.Value!.Value);

            if (employmentLeaveDto.EndDateOption.IsSet)
                if (employmentLeaveDto.EndDateOption.Value != null)
                    writer.WriteString("EndDate", employmentLeaveDto.EndDateOption.Value!.Value.ToString(EndDateFormat));
                else
                    writer.WriteNull("EndDate");

            if (employmentLeaveDto.EndedAndReportedOption.IsSet)
                if (employmentLeaveDto.EndedAndReportedOption.Value != null)
                    writer.WriteBoolean("EndedAndReported", employmentLeaveDto.EndedAndReportedOption.Value!.Value);
                else
                    writer.WriteNull("EndedAndReported");

            if (employmentLeaveDto.ExcludeEmployeeFromPayrollOption.IsSet)
                if (employmentLeaveDto.ExcludeEmployeeFromPayrollOption.Value != null)
                    writer.WriteBoolean("ExcludeEmployeeFromPayroll", employmentLeaveDto.ExcludeEmployeeFromPayrollOption.Value!.Value);
                else
                    writer.WriteNull("ExcludeEmployeeFromPayroll");

            if (employmentLeaveDto.IdOption.IsSet)
                writer.WriteString("Id", employmentLeaveDto.IdOption.Value!.Value);

            if (employmentLeaveDto.LastChangedDateTimeOffsetOption.IsSet)
                writer.WriteString("LastChangedDateTimeOffset", employmentLeaveDto.LastChangedDateTimeOffsetOption.Value!.Value.ToString(LastChangedDateTimeOffsetFormat));

            if (employmentLeaveDto.LeavePercentageOption.IsSet)
                if (employmentLeaveDto.LeavePercentageOption.Value != null)
                    writer.WriteNumber("LeavePercentage", employmentLeaveDto.LeavePercentageOption.Value!.Value);
                else
                    writer.WriteNull("LeavePercentage");

            if (employmentLeaveDto.ReportingIdOption.IsSet)
                if (employmentLeaveDto.ReportingIdOption.Value != null)
                    writer.WriteString("ReportingId", employmentLeaveDto.ReportingId);
                else
                    writer.WriteNull("ReportingId");

            if (employmentLeaveDto.StartDateOption.IsSet)
                if (employmentLeaveDto.StartDateOption.Value != null)
                    writer.WriteString("StartDate", employmentLeaveDto.StartDateOption.Value!.Value.ToString(StartDateFormat));
                else
                    writer.WriteNull("StartDate");

            if (employmentLeaveDto.TypeOfLeaveOption.IsSet)
                if (employmentLeaveDto.TypeOfLeaveOption!.Value != null)
                {
                    var typeOfLeaveRawValue = LeaveTypeValueConverter.ToJsonValue(employmentLeaveDto.TypeOfLeaveOption.Value!.Value);
                    writer.WriteString("TypeOfLeave", typeOfLeaveRawValue);
                }
                else
                    writer.WriteNull("TypeOfLeave");
        }
    }
}

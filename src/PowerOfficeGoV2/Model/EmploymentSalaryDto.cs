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
    /// The Employment Salary DTO contains properties relevant to a salary (line) on an employment relationship object in Go.
    /// </summary>
    public partial class EmploymentSalaryDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmploymentSalaryDto" /> class.
        /// </summary>
        /// <param name="annualSalary">The annual salary of the employment salary.  Only relevant for fixed wage salary.</param>
        /// <param name="createdDateTimeOffset">The timestamp when the employment salary entity was created.</param>
        /// <param name="employeeId">The identifier of the employee the employment belongs to.</param>
        /// <param name="employmentId">The id of the employment (employment relationship) the salary line belongs to.</param>
        /// <param name="fromDate">The from-date for the effect of the employment salary.</param>
        /// <param name="hourlyRate">The hourly rate of the employment salary.  Relevant to set for hourly wage salary and commission salary.  For fixed wage salary, the hourly rate is automatically calculated if null, but can be overridden.  The calculation is based on the full time hours per week property on the employment general information, multiplied by 52 weeks.  Relevant for fixed wage in terms of overtime/extra hours, for instance.</param>
        /// <param name="id">The id of the employment salary (line).</param>
        /// <param name="lastChangedDateTimeOffset">The timestamp when the employment salary entity was last changed.</param>
        /// <param name="remunerationType">remunerationType</param>
        [JsonConstructor]
        public EmploymentSalaryDto(Option<double?> annualSalary = default, Option<DateTimeOffset?> createdDateTimeOffset = default, Option<long?> employeeId = default, Option<long?> employmentId = default, Option<DateTimeOffset?> fromDate = default, Option<double?> hourlyRate = default, Option<long?> id = default, Option<DateTimeOffset?> lastChangedDateTimeOffset = default, Option<SalaryRemunerationType?> remunerationType = default)
        {
            AnnualSalaryOption = annualSalary;
            CreatedDateTimeOffsetOption = createdDateTimeOffset;
            EmployeeIdOption = employeeId;
            EmploymentIdOption = employmentId;
            FromDateOption = fromDate;
            HourlyRateOption = hourlyRate;
            IdOption = id;
            LastChangedDateTimeOffsetOption = lastChangedDateTimeOffset;
            RemunerationTypeOption = remunerationType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of RemunerationType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SalaryRemunerationType?> RemunerationTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets RemunerationType
        /// </summary>
        [JsonPropertyName("RemunerationType")]
        public SalaryRemunerationType? RemunerationType { get { return this.RemunerationTypeOption; } set { this.RemunerationTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of AnnualSalary
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> AnnualSalaryOption { get; private set; }

        /// <summary>
        /// The annual salary of the employment salary.  Only relevant for fixed wage salary.
        /// </summary>
        /// <value>The annual salary of the employment salary.  Only relevant for fixed wage salary.</value>
        /* <example>123.45</example> */
        [JsonPropertyName("AnnualSalary")]
        public double? AnnualSalary { get { return this.AnnualSalaryOption; } set { this.AnnualSalaryOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreatedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> CreatedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp when the employment salary entity was created.
        /// </summary>
        /// <value>The timestamp when the employment salary entity was created.</value>
        /* <example>2021-09-30T08:03:00.123456700Z</example> */
        [JsonPropertyName("CreatedDateTimeOffset")]
        public DateTimeOffset? CreatedDateTimeOffset { get { return this.CreatedDateTimeOffsetOption; } }

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
        /// The id of the employment (employment relationship) the salary line belongs to.
        /// </summary>
        /// <value>The id of the employment (employment relationship) the salary line belongs to.</value>
        /* <example>12345</example> */
        [JsonPropertyName("EmploymentId")]
        public long? EmploymentId { get { return this.EmploymentIdOption; } }

        /// <summary>
        /// Used to track the state of FromDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> FromDateOption { get; private set; }

        /// <summary>
        /// The from-date for the effect of the employment salary.
        /// </summary>
        /// <value>The from-date for the effect of the employment salary.</value>
        /* <example>Fri Jan 01 01:00:00 CET 2021</example> */
        [JsonPropertyName("FromDate")]
        public DateTimeOffset? FromDate { get { return this.FromDateOption; } set { this.FromDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of HourlyRate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> HourlyRateOption { get; private set; }

        /// <summary>
        /// The hourly rate of the employment salary.  Relevant to set for hourly wage salary and commission salary.  For fixed wage salary, the hourly rate is automatically calculated if null, but can be overridden.  The calculation is based on the full time hours per week property on the employment general information, multiplied by 52 weeks.  Relevant for fixed wage in terms of overtime/extra hours, for instance.
        /// </summary>
        /// <value>The hourly rate of the employment salary.  Relevant to set for hourly wage salary and commission salary.  For fixed wage salary, the hourly rate is automatically calculated if null, but can be overridden.  The calculation is based on the full time hours per week property on the employment general information, multiplied by 52 weeks.  Relevant for fixed wage in terms of overtime/extra hours, for instance.</value>
        /* <example>123.45</example> */
        [JsonPropertyName("HourlyRate")]
        public double? HourlyRate { get { return this.HourlyRateOption; } set { this.HourlyRateOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; }

        /// <summary>
        /// The id of the employment salary (line).
        /// </summary>
        /// <value>The id of the employment salary (line).</value>
        /* <example>12345</example> */
        [JsonPropertyName("Id")]
        public long? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of LastChangedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> LastChangedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp when the employment salary entity was last changed.
        /// </summary>
        /// <value>The timestamp when the employment salary entity was last changed.</value>
        /* <example>2021-09-30T09:33:00.123456700Z</example> */
        [JsonPropertyName("LastChangedDateTimeOffset")]
        public DateTimeOffset? LastChangedDateTimeOffset { get { return this.LastChangedDateTimeOffsetOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmploymentSalaryDto {\n");
            sb.Append("  AnnualSalary: ").Append(AnnualSalary).Append("\n");
            sb.Append("  CreatedDateTimeOffset: ").Append(CreatedDateTimeOffset).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmploymentId: ").Append(EmploymentId).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  HourlyRate: ").Append(HourlyRate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastChangedDateTimeOffset: ").Append(LastChangedDateTimeOffset).Append("\n");
            sb.Append("  RemunerationType: ").Append(RemunerationType).Append("\n");
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
    /// A Json converter for type <see cref="EmploymentSalaryDto" />
    /// </summary>
    public class EmploymentSalaryDtoJsonConverter : JsonConverter<EmploymentSalaryDto>
    {
        /// <summary>
        /// The format to use to serialize CreatedDateTimeOffset
        /// </summary>
        public static string CreatedDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize FromDate
        /// </summary>
        public static string FromDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize LastChangedDateTimeOffset
        /// </summary>
        public static string LastChangedDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="EmploymentSalaryDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EmploymentSalaryDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> annualSalary = default;
            Option<DateTimeOffset?> createdDateTimeOffset = default;
            Option<long?> employeeId = default;
            Option<long?> employmentId = default;
            Option<DateTimeOffset?> fromDate = default;
            Option<double?> hourlyRate = default;
            Option<long?> id = default;
            Option<DateTimeOffset?> lastChangedDateTimeOffset = default;
            Option<SalaryRemunerationType?> remunerationType = default;

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
                        case "AnnualSalary":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                annualSalary = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "CreatedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdDateTimeOffset = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "EmployeeId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                employeeId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "EmploymentId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                employmentId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "FromDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fromDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "HourlyRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                hourlyRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "LastChangedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastChangedDateTimeOffset = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "RemunerationType":
                            string? remunerationTypeRawValue = utf8JsonReader.GetString();
                            if (remunerationTypeRawValue != null)
                                remunerationType = new Option<SalaryRemunerationType?>(SalaryRemunerationTypeValueConverter.FromStringOrDefault(remunerationTypeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createdDateTimeOffset.IsSet && createdDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(createdDateTimeOffset), "Property is not nullable for class EmploymentSalaryDto.");

            if (employeeId.IsSet && employeeId.Value == null)
                throw new ArgumentNullException(nameof(employeeId), "Property is not nullable for class EmploymentSalaryDto.");

            if (employmentId.IsSet && employmentId.Value == null)
                throw new ArgumentNullException(nameof(employmentId), "Property is not nullable for class EmploymentSalaryDto.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EmploymentSalaryDto.");

            if (lastChangedDateTimeOffset.IsSet && lastChangedDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(lastChangedDateTimeOffset), "Property is not nullable for class EmploymentSalaryDto.");

            return new EmploymentSalaryDto(annualSalary, createdDateTimeOffset, employeeId, employmentId, fromDate, hourlyRate, id, lastChangedDateTimeOffset, remunerationType);
        }

        /// <summary>
        /// Serializes a <see cref="EmploymentSalaryDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employmentSalaryDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EmploymentSalaryDto employmentSalaryDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, employmentSalaryDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EmploymentSalaryDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employmentSalaryDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EmploymentSalaryDto employmentSalaryDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (employmentSalaryDto.AnnualSalaryOption.IsSet)
                if (employmentSalaryDto.AnnualSalaryOption.Value != null)
                    writer.WriteNumber("AnnualSalary", employmentSalaryDto.AnnualSalaryOption.Value!.Value);
                else
                    writer.WriteNull("AnnualSalary");

            if (employmentSalaryDto.CreatedDateTimeOffsetOption.IsSet)
                writer.WriteString("CreatedDateTimeOffset", employmentSalaryDto.CreatedDateTimeOffsetOption.Value!.Value.ToString(CreatedDateTimeOffsetFormat));

            if (employmentSalaryDto.EmployeeIdOption.IsSet)
                writer.WriteNumber("EmployeeId", employmentSalaryDto.EmployeeIdOption.Value!.Value);

            if (employmentSalaryDto.EmploymentIdOption.IsSet)
                writer.WriteNumber("EmploymentId", employmentSalaryDto.EmploymentIdOption.Value!.Value);

            if (employmentSalaryDto.FromDateOption.IsSet)
                if (employmentSalaryDto.FromDateOption.Value != null)
                    writer.WriteString("FromDate", employmentSalaryDto.FromDateOption.Value!.Value.ToString(FromDateFormat));
                else
                    writer.WriteNull("FromDate");

            if (employmentSalaryDto.HourlyRateOption.IsSet)
                if (employmentSalaryDto.HourlyRateOption.Value != null)
                    writer.WriteNumber("HourlyRate", employmentSalaryDto.HourlyRateOption.Value!.Value);
                else
                    writer.WriteNull("HourlyRate");

            if (employmentSalaryDto.IdOption.IsSet)
                writer.WriteNumber("Id", employmentSalaryDto.IdOption.Value!.Value);

            if (employmentSalaryDto.LastChangedDateTimeOffsetOption.IsSet)
                writer.WriteString("LastChangedDateTimeOffset", employmentSalaryDto.LastChangedDateTimeOffsetOption.Value!.Value.ToString(LastChangedDateTimeOffsetFormat));

            if (employmentSalaryDto.RemunerationTypeOption.IsSet)
                if (employmentSalaryDto.RemunerationTypeOption!.Value != null)
                {
                    var remunerationTypeRawValue = SalaryRemunerationTypeValueConverter.ToJsonValue(employmentSalaryDto.RemunerationTypeOption.Value!.Value);
                    writer.WriteString("RemunerationType", remunerationTypeRawValue);
                }
                else
                    writer.WriteNull("RemunerationType");
        }
    }
}

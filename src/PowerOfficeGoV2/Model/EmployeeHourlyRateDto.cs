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
    /// The Employee Hourly Rate DTO contains properties relevant to a \&quot;EmployeeTimeHourlyRates\&quot; object in Go
    /// </summary>
    public partial class EmployeeHourlyRateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeHourlyRateDto" /> class.
        /// </summary>
        /// <param name="billableRate">The billable hourly rate for timetransactions registered with billable activities for this employee.  Must be a positive number.  Note that a hierarchy exist in Go for timetracking price settings of billable rates.</param>
        /// <param name="costRate">The hourly cost rate for timetransactions registered for this employee.  Must be a positive number.  This cost rate have no direct relation to payroll settings, and is primarily used for reporting purposes on timetracking entries.</param>
        /// <param name="id">The identifier of the employee hourly rates.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited (PATCH), deleted (DELETE) or retrieved specifically (GET).</param>
        /// <param name="validFromDate">The date from which this rate is to be used from.</param>
        /// <param name="validToDate">The date from which this rate is no longer in use.</param>
        [JsonConstructor]
        public EmployeeHourlyRateDto(Option<double?> billableRate = default, Option<double?> costRate = default, Option<long?> id = default, Option<DateTimeOffset?> validFromDate = default, Option<DateTimeOffset?> validToDate = default)
        {
            BillableRateOption = billableRate;
            CostRateOption = costRate;
            IdOption = id;
            ValidFromDateOption = validFromDate;
            ValidToDateOption = validToDate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BillableRate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> BillableRateOption { get; private set; }

        /// <summary>
        /// The billable hourly rate for timetransactions registered with billable activities for this employee.  Must be a positive number.  Note that a hierarchy exist in Go for timetracking price settings of billable rates.
        /// </summary>
        /// <value>The billable hourly rate for timetransactions registered with billable activities for this employee.  Must be a positive number.  Note that a hierarchy exist in Go for timetracking price settings of billable rates.</value>
        /* <example>250</example> */
        [JsonPropertyName("BillableRate")]
        public double? BillableRate { get { return this.BillableRateOption; } set { this.BillableRateOption = new(value); } }

        /// <summary>
        /// Used to track the state of CostRate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> CostRateOption { get; private set; }

        /// <summary>
        /// The hourly cost rate for timetransactions registered for this employee.  Must be a positive number.  This cost rate have no direct relation to payroll settings, and is primarily used for reporting purposes on timetracking entries.
        /// </summary>
        /// <value>The hourly cost rate for timetransactions registered for this employee.  Must be a positive number.  This cost rate have no direct relation to payroll settings, and is primarily used for reporting purposes on timetracking entries.</value>
        /* <example>200</example> */
        [JsonPropertyName("CostRate")]
        public double? CostRate { get { return this.CostRateOption; } set { this.CostRateOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; }

        /// <summary>
        /// The identifier of the employee hourly rates.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited (PATCH), deleted (DELETE) or retrieved specifically (GET).
        /// </summary>
        /// <value>The identifier of the employee hourly rates.  This identifier is unique and assigned by PowerOffice Go when a new entity is saved, and should be provided when an entity should be edited (PATCH), deleted (DELETE) or retrieved specifically (GET).</value>
        /* <example>12345</example> */
        [JsonPropertyName("Id")]
        public long? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of ValidFromDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> ValidFromDateOption { get; private set; }

        /// <summary>
        /// The date from which this rate is to be used from.
        /// </summary>
        /// <value>The date from which this rate is to be used from.</value>
        /* <example>Fri Jul 01 02:00:00 CEST 2022</example> */
        [JsonPropertyName("ValidFromDate")]
        public DateTimeOffset? ValidFromDate { get { return this.ValidFromDateOption; } set { this.ValidFromDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of ValidToDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> ValidToDateOption { get; }

        /// <summary>
        /// The date from which this rate is no longer in use.
        /// </summary>
        /// <value>The date from which this rate is no longer in use.</value>
        /* <example>Fri Jul 15 02:00:00 CEST 2022</example> */
        [JsonPropertyName("ValidToDate")]
        public DateTimeOffset? ValidToDate { get { return this.ValidToDateOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeeHourlyRateDto {\n");
            sb.Append("  BillableRate: ").Append(BillableRate).Append("\n");
            sb.Append("  CostRate: ").Append(CostRate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ValidFromDate: ").Append(ValidFromDate).Append("\n");
            sb.Append("  ValidToDate: ").Append(ValidToDate).Append("\n");
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
    /// A Json converter for type <see cref="EmployeeHourlyRateDto" />
    /// </summary>
    public class EmployeeHourlyRateDtoJsonConverter : JsonConverter<EmployeeHourlyRateDto>
    {
        /// <summary>
        /// The format to use to serialize ValidFromDate
        /// </summary>
        public static string ValidFromDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize ValidToDate
        /// </summary>
        public static string ValidToDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="EmployeeHourlyRateDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EmployeeHourlyRateDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> billableRate = default;
            Option<double?> costRate = default;
            Option<long?> id = default;
            Option<DateTimeOffset?> validFromDate = default;
            Option<DateTimeOffset?> validToDate = default;

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
                        case "BillableRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                billableRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "CostRate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                costRate = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "ValidFromDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                validFromDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "ValidToDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                validToDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EmployeeHourlyRateDto.");

            if (validToDate.IsSet && validToDate.Value == null)
                throw new ArgumentNullException(nameof(validToDate), "Property is not nullable for class EmployeeHourlyRateDto.");

            return new EmployeeHourlyRateDto(billableRate, costRate, id, validFromDate, validToDate);
        }

        /// <summary>
        /// Serializes a <see cref="EmployeeHourlyRateDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employeeHourlyRateDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EmployeeHourlyRateDto employeeHourlyRateDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, employeeHourlyRateDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EmployeeHourlyRateDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employeeHourlyRateDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EmployeeHourlyRateDto employeeHourlyRateDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (employeeHourlyRateDto.BillableRateOption.IsSet)
                if (employeeHourlyRateDto.BillableRateOption.Value != null)
                    writer.WriteNumber("BillableRate", employeeHourlyRateDto.BillableRateOption.Value!.Value);
                else
                    writer.WriteNull("BillableRate");

            if (employeeHourlyRateDto.CostRateOption.IsSet)
                if (employeeHourlyRateDto.CostRateOption.Value != null)
                    writer.WriteNumber("CostRate", employeeHourlyRateDto.CostRateOption.Value!.Value);
                else
                    writer.WriteNull("CostRate");

            if (employeeHourlyRateDto.IdOption.IsSet)
                writer.WriteNumber("Id", employeeHourlyRateDto.IdOption.Value!.Value);

            if (employeeHourlyRateDto.ValidFromDateOption.IsSet)
                if (employeeHourlyRateDto.ValidFromDateOption.Value != null)
                    writer.WriteString("ValidFromDate", employeeHourlyRateDto.ValidFromDateOption.Value!.Value.ToString(ValidFromDateFormat));
                else
                    writer.WriteNull("ValidFromDate");

            if (employeeHourlyRateDto.ValidToDateOption.IsSet)
                writer.WriteString("ValidToDate", employeeHourlyRateDto.ValidToDateOption.Value!.Value.ToString(ValidToDateFormat));
        }
    }
}

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
    /// The Employment full-time equivalent (FTE) percentage DTO contains properties relevant to a FTE percentage (line) on an employment relationship object in Go.
    /// </summary>
    public partial class EmploymentFtePercentageDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmploymentFtePercentageDto" /> class.
        /// </summary>
        /// <param name="createdDateTimeOffset">The timestamp when the employment FTE percentage entity was created.</param>
        /// <param name="employeeId">The identifier of the employee the employment belongs to.</param>
        /// <param name="employmentId">The id of the employment (employment relationship) the FTE percentage line belongs to.</param>
        /// <param name="fromDate">The from-date for the effect of the employment full-time equivalent (FTE) percentage.</param>
        /// <param name="ftePercentage">The percentage of full-time equivalent (FTE) employment.  The value should be between 0 and 100 (reflects as 0% or 100% in the GUI).</param>
        /// <param name="id">The id of the employment FTE percentage (line).</param>
        /// <param name="lastChangedDateTimeOffset">The timestamp when the employment FTE percentage entity was last changed.</param>
        [JsonConstructor]
        public EmploymentFtePercentageDto(Option<DateTimeOffset?> createdDateTimeOffset = default, Option<long?> employeeId = default, Option<long?> employmentId = default, Option<DateTimeOffset?> fromDate = default, Option<double?> ftePercentage = default, Option<long?> id = default, Option<DateTimeOffset?> lastChangedDateTimeOffset = default)
        {
            CreatedDateTimeOffsetOption = createdDateTimeOffset;
            EmployeeIdOption = employeeId;
            EmploymentIdOption = employmentId;
            FromDateOption = fromDate;
            FtePercentageOption = ftePercentage;
            IdOption = id;
            LastChangedDateTimeOffsetOption = lastChangedDateTimeOffset;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CreatedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> CreatedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp when the employment FTE percentage entity was created.
        /// </summary>
        /// <value>The timestamp when the employment FTE percentage entity was created.</value>
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
        /// The id of the employment (employment relationship) the FTE percentage line belongs to.
        /// </summary>
        /// <value>The id of the employment (employment relationship) the FTE percentage line belongs to.</value>
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
        /// The from-date for the effect of the employment full-time equivalent (FTE) percentage.
        /// </summary>
        /// <value>The from-date for the effect of the employment full-time equivalent (FTE) percentage.</value>
        /* <example>Fri Jan 01 01:00:00 CET 2021</example> */
        [JsonPropertyName("FromDate")]
        public DateTimeOffset? FromDate { get { return this.FromDateOption; } set { this.FromDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of FtePercentage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> FtePercentageOption { get; private set; }

        /// <summary>
        /// The percentage of full-time equivalent (FTE) employment.  The value should be between 0 and 100 (reflects as 0% or 100% in the GUI).
        /// </summary>
        /// <value>The percentage of full-time equivalent (FTE) employment.  The value should be between 0 and 100 (reflects as 0% or 100% in the GUI).</value>
        /* <example>52.45</example> */
        [JsonPropertyName("FtePercentage")]
        public double? FtePercentage { get { return this.FtePercentageOption; } set { this.FtePercentageOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; }

        /// <summary>
        /// The id of the employment FTE percentage (line).
        /// </summary>
        /// <value>The id of the employment FTE percentage (line).</value>
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
        /// The timestamp when the employment FTE percentage entity was last changed.
        /// </summary>
        /// <value>The timestamp when the employment FTE percentage entity was last changed.</value>
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
            sb.Append("class EmploymentFtePercentageDto {\n");
            sb.Append("  CreatedDateTimeOffset: ").Append(CreatedDateTimeOffset).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmploymentId: ").Append(EmploymentId).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  FtePercentage: ").Append(FtePercentage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastChangedDateTimeOffset: ").Append(LastChangedDateTimeOffset).Append("\n");
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
    /// A Json converter for type <see cref="EmploymentFtePercentageDto" />
    /// </summary>
    public class EmploymentFtePercentageDtoJsonConverter : JsonConverter<EmploymentFtePercentageDto>
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
        /// Deserializes json to <see cref="EmploymentFtePercentageDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EmploymentFtePercentageDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTimeOffset?> createdDateTimeOffset = default;
            Option<long?> employeeId = default;
            Option<long?> employmentId = default;
            Option<DateTimeOffset?> fromDate = default;
            Option<double?> ftePercentage = default;
            Option<long?> id = default;
            Option<DateTimeOffset?> lastChangedDateTimeOffset = default;

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
                        case "FtePercentage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ftePercentage = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "LastChangedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastChangedDateTimeOffset = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createdDateTimeOffset.IsSet && createdDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(createdDateTimeOffset), "Property is not nullable for class EmploymentFtePercentageDto.");

            if (employeeId.IsSet && employeeId.Value == null)
                throw new ArgumentNullException(nameof(employeeId), "Property is not nullable for class EmploymentFtePercentageDto.");

            if (employmentId.IsSet && employmentId.Value == null)
                throw new ArgumentNullException(nameof(employmentId), "Property is not nullable for class EmploymentFtePercentageDto.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EmploymentFtePercentageDto.");

            if (lastChangedDateTimeOffset.IsSet && lastChangedDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(lastChangedDateTimeOffset), "Property is not nullable for class EmploymentFtePercentageDto.");

            return new EmploymentFtePercentageDto(createdDateTimeOffset, employeeId, employmentId, fromDate, ftePercentage, id, lastChangedDateTimeOffset);
        }

        /// <summary>
        /// Serializes a <see cref="EmploymentFtePercentageDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employmentFtePercentageDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EmploymentFtePercentageDto employmentFtePercentageDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, employmentFtePercentageDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EmploymentFtePercentageDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employmentFtePercentageDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EmploymentFtePercentageDto employmentFtePercentageDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (employmentFtePercentageDto.CreatedDateTimeOffsetOption.IsSet)
                writer.WriteString("CreatedDateTimeOffset", employmentFtePercentageDto.CreatedDateTimeOffsetOption.Value!.Value.ToString(CreatedDateTimeOffsetFormat));

            if (employmentFtePercentageDto.EmployeeIdOption.IsSet)
                writer.WriteNumber("EmployeeId", employmentFtePercentageDto.EmployeeIdOption.Value!.Value);

            if (employmentFtePercentageDto.EmploymentIdOption.IsSet)
                writer.WriteNumber("EmploymentId", employmentFtePercentageDto.EmploymentIdOption.Value!.Value);

            if (employmentFtePercentageDto.FromDateOption.IsSet)
                if (employmentFtePercentageDto.FromDateOption.Value != null)
                    writer.WriteString("FromDate", employmentFtePercentageDto.FromDateOption.Value!.Value.ToString(FromDateFormat));
                else
                    writer.WriteNull("FromDate");

            if (employmentFtePercentageDto.FtePercentageOption.IsSet)
                if (employmentFtePercentageDto.FtePercentageOption.Value != null)
                    writer.WriteNumber("FtePercentage", employmentFtePercentageDto.FtePercentageOption.Value!.Value);
                else
                    writer.WriteNull("FtePercentage");

            if (employmentFtePercentageDto.IdOption.IsSet)
                writer.WriteNumber("Id", employmentFtePercentageDto.IdOption.Value!.Value);

            if (employmentFtePercentageDto.LastChangedDateTimeOffsetOption.IsSet)
                writer.WriteString("LastChangedDateTimeOffset", employmentFtePercentageDto.LastChangedDateTimeOffsetOption.Value!.Value.ToString(LastChangedDateTimeOffsetFormat));
        }
    }
}

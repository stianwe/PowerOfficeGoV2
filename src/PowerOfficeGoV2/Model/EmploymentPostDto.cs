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
    /// The Employment post DTO contains properties relevant to creating a new employment relationship object in Go.
    /// </summary>
    public partial class EmploymentPostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmploymentPostDto" /> class.
        /// </summary>
        /// <param name="employmentForm">employmentForm</param>
        /// <param name="employmentSpecification">employmentSpecification</param>
        /// <param name="employmentType">employmentType</param>
        /// <param name="endDate">The end date of the employment.</param>
        /// <param name="endDateReason">endDateReason</param>
        /// <param name="enterpriseId">The identifier of the enterprise for the employment.</param>
        /// <param name="fullTimeHoursPerWeek">The number of hours that would represent full time week of employment.</param>
        /// <param name="isDefault">Indicates if the employment is the default employment for the employee.</param>
        /// <param name="professionCode">The profession code of the employment.  The code follow SSB&#39;s STYRK-98 standard with 7 digits.</param>
        /// <param name="reportingId">The id of the employment that will be reported.  Can be set to match the id of the previous payroll system.  If not set, Go will assign an id.</param>
        /// <param name="startDate">The start date of the employment.</param>
        /// <param name="taxCountryCode">The ISO 3166-1 alfa-2 country code (two characters).  Can only be set to Finland (FI) or Sweden (SE) if employment specification is set to cross border commuter.</param>
        /// <param name="taxRule">taxRule</param>
        /// <param name="workingHoursArrangement">workingHoursArrangement</param>
        [JsonConstructor]
        public EmploymentPostDto(EmploymentFormType? employmentForm = default, Option<EmploymentSpecificationType?> employmentSpecification = default, EmploymentType? employmentType = default, Option<DateTimeOffset?> endDate = default, Option<EndDateReasonType?> endDateReason = default, long? enterpriseId = default, double? fullTimeHoursPerWeek = default, bool? isDefault = default, string? professionCode = default, Option<string?> reportingId = default, DateTimeOffset? startDate = default, Option<string?> taxCountryCode = default, Option<TaxRuleType?> taxRule = default, WorkingHoursArrangementType? workingHoursArrangement = default)
        {
            EmploymentForm = employmentForm;
            EmploymentSpecificationOption = employmentSpecification;
            EmploymentType = employmentType;
            EndDateOption = endDate;
            EndDateReasonOption = endDateReason;
            EnterpriseId = enterpriseId;
            FullTimeHoursPerWeek = fullTimeHoursPerWeek;
            IsDefault = isDefault;
            ProfessionCode = professionCode;
            ReportingIdOption = reportingId;
            StartDate = startDate;
            TaxCountryCodeOption = taxCountryCode;
            TaxRuleOption = taxRule;
            WorkingHoursArrangement = workingHoursArrangement;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets EmploymentForm
        /// </summary>
        [JsonPropertyName("EmploymentForm")]
        public EmploymentFormType? EmploymentForm { get; set; }

        /// <summary>
        /// Used to track the state of EmploymentSpecification
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<EmploymentSpecificationType?> EmploymentSpecificationOption { get; private set; }

        /// <summary>
        /// Gets or Sets EmploymentSpecification
        /// </summary>
        [JsonPropertyName("EmploymentSpecification")]
        public EmploymentSpecificationType? EmploymentSpecification { get { return this.EmploymentSpecificationOption; } set { this.EmploymentSpecificationOption = new(value); } }

        /// <summary>
        /// Gets or Sets EmploymentType
        /// </summary>
        [JsonPropertyName("EmploymentType")]
        public EmploymentType? EmploymentType { get; set; }

        /// <summary>
        /// Used to track the state of EndDateReason
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<EndDateReasonType?> EndDateReasonOption { get; private set; }

        /// <summary>
        /// Gets or Sets EndDateReason
        /// </summary>
        [JsonPropertyName("EndDateReason")]
        public EndDateReasonType? EndDateReason { get { return this.EndDateReasonOption; } set { this.EndDateReasonOption = new(value); } }

        /// <summary>
        /// Used to track the state of TaxRule
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TaxRuleType?> TaxRuleOption { get; private set; }

        /// <summary>
        /// Gets or Sets TaxRule
        /// </summary>
        [JsonPropertyName("TaxRule")]
        public TaxRuleType? TaxRule { get { return this.TaxRuleOption; } set { this.TaxRuleOption = new(value); } }

        /// <summary>
        /// Gets or Sets WorkingHoursArrangement
        /// </summary>
        [JsonPropertyName("WorkingHoursArrangement")]
        public WorkingHoursArrangementType? WorkingHoursArrangement { get; set; }

        /// <summary>
        /// Used to track the state of EndDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> EndDateOption { get; private set; }

        /// <summary>
        /// The end date of the employment.
        /// </summary>
        /// <value>The end date of the employment.</value>
        /* <example>Sun Jul 31 02:00:00 CEST 2022</example> */
        [JsonPropertyName("EndDate")]
        public DateTimeOffset? EndDate { get { return this.EndDateOption; } set { this.EndDateOption = new(value); } }

        /// <summary>
        /// The identifier of the enterprise for the employment.
        /// </summary>
        /// <value>The identifier of the enterprise for the employment.</value>
        /* <example>12345</example> */
        [JsonPropertyName("EnterpriseId")]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// The number of hours that would represent full time week of employment.
        /// </summary>
        /// <value>The number of hours that would represent full time week of employment.</value>
        /* <example>37.5</example> */
        [JsonPropertyName("FullTimeHoursPerWeek")]
        public double? FullTimeHoursPerWeek { get; set; }

        /// <summary>
        /// Indicates if the employment is the default employment for the employee.
        /// </summary>
        /// <value>Indicates if the employment is the default employment for the employee.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The profession code of the employment.  The code follow SSB&#39;s STYRK-98 standard with 7 digits.
        /// </summary>
        /// <value>The profession code of the employment.  The code follow SSB&#39;s STYRK-98 standard with 7 digits.</value>
        /* <example>5163121</example> */
        [JsonPropertyName("ProfessionCode")]
        public string? ProfessionCode { get; set; }

        /// <summary>
        /// Used to track the state of ReportingId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ReportingIdOption { get; private set; }

        /// <summary>
        /// The id of the employment that will be reported.  Can be set to match the id of the previous payroll system.  If not set, Go will assign an id.
        /// </summary>
        /// <value>The id of the employment that will be reported.  Can be set to match the id of the previous payroll system.  If not set, Go will assign an id.</value>
        /* <example>POGO_24677</example> */
        [JsonPropertyName("ReportingId")]
        public string? ReportingId { get { return this.ReportingIdOption; } set { this.ReportingIdOption = new(value); } }

        /// <summary>
        /// The start date of the employment.
        /// </summary>
        /// <value>The start date of the employment.</value>
        /* <example>Fri Jan 01 01:00:00 CET 2021</example> */
        [JsonPropertyName("StartDate")]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Used to track the state of TaxCountryCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TaxCountryCodeOption { get; private set; }

        /// <summary>
        /// The ISO 3166-1 alfa-2 country code (two characters).  Can only be set to Finland (FI) or Sweden (SE) if employment specification is set to cross border commuter.
        /// </summary>
        /// <value>The ISO 3166-1 alfa-2 country code (two characters).  Can only be set to Finland (FI) or Sweden (SE) if employment specification is set to cross border commuter.</value>
        /* <example>SE</example> */
        [JsonPropertyName("TaxCountryCode")]
        public string? TaxCountryCode { get { return this.TaxCountryCodeOption; } set { this.TaxCountryCodeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmploymentPostDto {\n");
            sb.Append("  EmploymentForm: ").Append(EmploymentForm).Append("\n");
            sb.Append("  EmploymentSpecification: ").Append(EmploymentSpecification).Append("\n");
            sb.Append("  EmploymentType: ").Append(EmploymentType).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndDateReason: ").Append(EndDateReason).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  FullTimeHoursPerWeek: ").Append(FullTimeHoursPerWeek).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  ProfessionCode: ").Append(ProfessionCode).Append("\n");
            sb.Append("  ReportingId: ").Append(ReportingId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TaxCountryCode: ").Append(TaxCountryCode).Append("\n");
            sb.Append("  TaxRule: ").Append(TaxRule).Append("\n");
            sb.Append("  WorkingHoursArrangement: ").Append(WorkingHoursArrangement).Append("\n");
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
    /// A Json converter for type <see cref="EmploymentPostDto" />
    /// </summary>
    public class EmploymentPostDtoJsonConverter : JsonConverter<EmploymentPostDto>
    {
        /// <summary>
        /// The format to use to serialize EndDate
        /// </summary>
        public static string EndDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize StartDate
        /// </summary>
        public static string StartDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="EmploymentPostDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EmploymentPostDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<EmploymentFormType?> employmentForm = default;
            Option<EmploymentSpecificationType?> employmentSpecification = default;
            Option<EmploymentType?> employmentType = default;
            Option<DateTimeOffset?> endDate = default;
            Option<EndDateReasonType?> endDateReason = default;
            Option<long?> enterpriseId = default;
            Option<double?> fullTimeHoursPerWeek = default;
            Option<bool?> isDefault = default;
            Option<string?> professionCode = default;
            Option<string?> reportingId = default;
            Option<DateTimeOffset?> startDate = default;
            Option<string?> taxCountryCode = default;
            Option<TaxRuleType?> taxRule = default;
            Option<WorkingHoursArrangementType?> workingHoursArrangement = default;

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
                        case "EmploymentForm":
                            string? employmentFormRawValue = utf8JsonReader.GetString();
                            if (employmentFormRawValue != null)
                                employmentForm = new Option<EmploymentFormType?>(EmploymentFormTypeValueConverter.FromStringOrDefault(employmentFormRawValue));
                            break;
                        case "EmploymentSpecification":
                            string? employmentSpecificationRawValue = utf8JsonReader.GetString();
                            if (employmentSpecificationRawValue != null)
                                employmentSpecification = new Option<EmploymentSpecificationType?>(EmploymentSpecificationTypeValueConverter.FromStringOrDefault(employmentSpecificationRawValue));
                            break;
                        case "EmploymentType":
                            string? employmentTypeRawValue = utf8JsonReader.GetString();
                            if (employmentTypeRawValue != null)
                                employmentType = new Option<EmploymentType?>(EmploymentTypeValueConverter.FromStringOrDefault(employmentTypeRawValue));
                            break;
                        case "EndDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "EndDateReason":
                            string? endDateReasonRawValue = utf8JsonReader.GetString();
                            if (endDateReasonRawValue != null)
                                endDateReason = new Option<EndDateReasonType?>(EndDateReasonTypeValueConverter.FromStringOrDefault(endDateReasonRawValue));
                            break;
                        case "EnterpriseId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enterpriseId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "FullTimeHoursPerWeek":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fullTimeHoursPerWeek = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "IsDefault":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isDefault = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "ProfessionCode":
                            professionCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "ReportingId":
                            reportingId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "StartDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "TaxCountryCode":
                            taxCountryCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "TaxRule":
                            string? taxRuleRawValue = utf8JsonReader.GetString();
                            if (taxRuleRawValue != null)
                                taxRule = new Option<TaxRuleType?>(TaxRuleTypeValueConverter.FromStringOrDefault(taxRuleRawValue));
                            break;
                        case "WorkingHoursArrangement":
                            string? workingHoursArrangementRawValue = utf8JsonReader.GetString();
                            if (workingHoursArrangementRawValue != null)
                                workingHoursArrangement = new Option<WorkingHoursArrangementType?>(WorkingHoursArrangementTypeValueConverter.FromStringOrDefault(workingHoursArrangementRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!employmentForm.IsSet)
                throw new ArgumentException("Property is required for class EmploymentPostDto.", nameof(employmentForm));

            if (!employmentType.IsSet)
                throw new ArgumentException("Property is required for class EmploymentPostDto.", nameof(employmentType));

            if (!enterpriseId.IsSet)
                throw new ArgumentException("Property is required for class EmploymentPostDto.", nameof(enterpriseId));

            if (!fullTimeHoursPerWeek.IsSet)
                throw new ArgumentException("Property is required for class EmploymentPostDto.", nameof(fullTimeHoursPerWeek));

            if (!isDefault.IsSet)
                throw new ArgumentException("Property is required for class EmploymentPostDto.", nameof(isDefault));

            if (!professionCode.IsSet)
                throw new ArgumentException("Property is required for class EmploymentPostDto.", nameof(professionCode));

            if (!startDate.IsSet)
                throw new ArgumentException("Property is required for class EmploymentPostDto.", nameof(startDate));

            if (!workingHoursArrangement.IsSet)
                throw new ArgumentException("Property is required for class EmploymentPostDto.", nameof(workingHoursArrangement));

            return new EmploymentPostDto(employmentForm.Value!, employmentSpecification, employmentType.Value!, endDate, endDateReason, enterpriseId.Value!, fullTimeHoursPerWeek.Value!, isDefault.Value!, professionCode.Value!, reportingId, startDate.Value!, taxCountryCode, taxRule, workingHoursArrangement.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="EmploymentPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employmentPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EmploymentPostDto employmentPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, employmentPostDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EmploymentPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employmentPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EmploymentPostDto employmentPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (employmentPostDto.EmploymentForm == null)
                writer.WriteNull("EmploymentForm");
            else
            {
                var employmentFormRawValue = EmploymentFormTypeValueConverter.ToJsonValue(employmentPostDto.EmploymentForm.Value);
                if (employmentFormRawValue != null)
                    writer.WriteString("EmploymentForm", employmentFormRawValue);
                else
                    writer.WriteNull("EmploymentForm");
            }

            if (employmentPostDto.EmploymentSpecificationOption.IsSet)
                if (employmentPostDto.EmploymentSpecificationOption!.Value != null)
                {
                    var employmentSpecificationRawValue = EmploymentSpecificationTypeValueConverter.ToJsonValue(employmentPostDto.EmploymentSpecificationOption.Value!.Value);
                    writer.WriteString("EmploymentSpecification", employmentSpecificationRawValue);
                }
                else
                    writer.WriteNull("EmploymentSpecification");
            if (employmentPostDto.EmploymentType == null)
                writer.WriteNull("EmploymentType");
            else
            {
                var employmentTypeRawValue = EmploymentTypeValueConverter.ToJsonValue(employmentPostDto.EmploymentType.Value);
                if (employmentTypeRawValue != null)
                    writer.WriteString("EmploymentType", employmentTypeRawValue);
                else
                    writer.WriteNull("EmploymentType");
            }

            if (employmentPostDto.EndDateOption.IsSet)
                if (employmentPostDto.EndDateOption.Value != null)
                    writer.WriteString("EndDate", employmentPostDto.EndDateOption.Value!.Value.ToString(EndDateFormat));
                else
                    writer.WriteNull("EndDate");

            if (employmentPostDto.EndDateReasonOption.IsSet)
                if (employmentPostDto.EndDateReasonOption!.Value != null)
                {
                    var endDateReasonRawValue = EndDateReasonTypeValueConverter.ToJsonValue(employmentPostDto.EndDateReasonOption.Value!.Value);
                    writer.WriteString("EndDateReason", endDateReasonRawValue);
                }
                else
                    writer.WriteNull("EndDateReason");
            if (employmentPostDto.EnterpriseId != null)
                writer.WriteNumber("EnterpriseId", employmentPostDto.EnterpriseId.Value);
            else
                writer.WriteNull("EnterpriseId");

            if (employmentPostDto.FullTimeHoursPerWeek != null)
                writer.WriteNumber("FullTimeHoursPerWeek", employmentPostDto.FullTimeHoursPerWeek.Value);
            else
                writer.WriteNull("FullTimeHoursPerWeek");

            if (employmentPostDto.IsDefault != null)
                writer.WriteBoolean("IsDefault", employmentPostDto.IsDefault.Value);
            else
                writer.WriteNull("IsDefault");

            if (employmentPostDto.ProfessionCode != null)
                writer.WriteString("ProfessionCode", employmentPostDto.ProfessionCode);
            else
                writer.WriteNull("ProfessionCode");

            if (employmentPostDto.ReportingIdOption.IsSet)
                if (employmentPostDto.ReportingIdOption.Value != null)
                    writer.WriteString("ReportingId", employmentPostDto.ReportingId);
                else
                    writer.WriteNull("ReportingId");

            if (employmentPostDto.StartDate != null)
                writer.WriteString("StartDate", employmentPostDto.StartDate.Value.ToString(StartDateFormat));
            else
                writer.WriteNull("StartDate");

            if (employmentPostDto.TaxCountryCodeOption.IsSet)
                if (employmentPostDto.TaxCountryCodeOption.Value != null)
                    writer.WriteString("TaxCountryCode", employmentPostDto.TaxCountryCode);
                else
                    writer.WriteNull("TaxCountryCode");

            if (employmentPostDto.TaxRuleOption.IsSet)
                if (employmentPostDto.TaxRuleOption!.Value != null)
                {
                    var taxRuleRawValue = TaxRuleTypeValueConverter.ToJsonValue(employmentPostDto.TaxRuleOption.Value!.Value);
                    writer.WriteString("TaxRule", taxRuleRawValue);
                }
                else
                    writer.WriteNull("TaxRule");
            if (employmentPostDto.WorkingHoursArrangement == null)
                writer.WriteNull("WorkingHoursArrangement");
            else
            {
                var workingHoursArrangementRawValue = WorkingHoursArrangementTypeValueConverter.ToJsonValue(employmentPostDto.WorkingHoursArrangement.Value);
                if (workingHoursArrangementRawValue != null)
                    writer.WriteString("WorkingHoursArrangement", workingHoursArrangementRawValue);
                else
                    writer.WriteNull("WorkingHoursArrangement");
            }
        }
    }
}

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
    /// The Employee payroll settings DTO contains properties relevant for payroll settings on an employee in Go.
    /// </summary>
    public partial class EmployeePayrollSettingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeePayrollSettingsDto" /> class.
        /// </summary>
        /// <param name="holidayPayAbove60Percentage">The holiday pay percentage above 60 years for this employee.  If null, the general payroll settings will be used.  Note that only 1 decimal is allowed, if more than 1 decimal is provided, the value will be rounded to nearest 1 decimal.</param>
        /// <param name="holidayPayPercentage">The holiday pay percentage for the employee.  If null, the general payroll settings will be used.  Note that only 1 decimal is allowed, if more than 1 decimal is provided, the value will be rounded to nearest 1 decimal.</param>
        /// <param name="limitHolidayPayAbove60To6G">Property indicating whether holiday pay above 60 years is limited to 6G for the employee.  If null, the general payroll settings will be used.</param>
        /// <param name="numberOfHolidays">The number of holidays for the employee.  If null, the general payroll settings will be used.</param>
        /// <param name="numberOfHolidaysAbove60">The number of holidays above 60 years for the employee.  If null, the general payroll settings will be used.</param>
        /// <param name="omitECOnHolidayPayProvision">Property indicating whether employer contribution should be used or not for holiday pay provisions for this employee.  The typical case to set true, is for foreign employees subject of a foreign social security legislation.</param>
        /// <param name="payslipDeliveryType">payslipDeliveryType</param>
        /// <param name="payslipEmailAddress">The e-mail address of the employee that the payslip will be sent to.  Relevant only if the payslip type is set to e-mail and app.  If this property is null, the general e-mail address of the employee will be used if payslips are delivered by e-mail.</param>
        /// <param name="payslipLanguageType">payslipLanguageType</param>
        /// <param name="remunerationPeriodType">remunerationPeriodType</param>
        [JsonConstructor]
        public EmployeePayrollSettingsDto(Option<double?> holidayPayAbove60Percentage = default, Option<double?> holidayPayPercentage = default, Option<bool?> limitHolidayPayAbove60To6G = default, Option<int?> numberOfHolidays = default, Option<int?> numberOfHolidaysAbove60 = default, Option<bool?> omitECOnHolidayPayProvision = default, Option<PayslipDeliveryType?> payslipDeliveryType = default, Option<string?> payslipEmailAddress = default, Option<PayslipLanguageType?> payslipLanguageType = default, Option<RemunerationPeriodType?> remunerationPeriodType = default)
        {
            HolidayPayAbove60PercentageOption = holidayPayAbove60Percentage;
            HolidayPayPercentageOption = holidayPayPercentage;
            LimitHolidayPayAbove60To6GOption = limitHolidayPayAbove60To6G;
            NumberOfHolidaysOption = numberOfHolidays;
            NumberOfHolidaysAbove60Option = numberOfHolidaysAbove60;
            OmitECOnHolidayPayProvisionOption = omitECOnHolidayPayProvision;
            PayslipDeliveryTypeOption = payslipDeliveryType;
            PayslipEmailAddressOption = payslipEmailAddress;
            PayslipLanguageTypeOption = payslipLanguageType;
            RemunerationPeriodTypeOption = remunerationPeriodType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of PayslipDeliveryType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PayslipDeliveryType?> PayslipDeliveryTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets PayslipDeliveryType
        /// </summary>
        [JsonPropertyName("PayslipDeliveryType")]
        public PayslipDeliveryType? PayslipDeliveryType { get { return this.PayslipDeliveryTypeOption; } set { this.PayslipDeliveryTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of PayslipLanguageType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PayslipLanguageType?> PayslipLanguageTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets PayslipLanguageType
        /// </summary>
        [JsonPropertyName("PayslipLanguageType")]
        public PayslipLanguageType? PayslipLanguageType { get { return this.PayslipLanguageTypeOption; } set { this.PayslipLanguageTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of RemunerationPeriodType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<RemunerationPeriodType?> RemunerationPeriodTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets RemunerationPeriodType
        /// </summary>
        [JsonPropertyName("RemunerationPeriodType")]
        public RemunerationPeriodType? RemunerationPeriodType { get { return this.RemunerationPeriodTypeOption; } set { this.RemunerationPeriodTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of HolidayPayAbove60Percentage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> HolidayPayAbove60PercentageOption { get; private set; }

        /// <summary>
        /// The holiday pay percentage above 60 years for this employee.  If null, the general payroll settings will be used.  Note that only 1 decimal is allowed, if more than 1 decimal is provided, the value will be rounded to nearest 1 decimal.
        /// </summary>
        /// <value>The holiday pay percentage above 60 years for this employee.  If null, the general payroll settings will be used.  Note that only 1 decimal is allowed, if more than 1 decimal is provided, the value will be rounded to nearest 1 decimal.</value>
        /* <example>2.3</example> */
        [JsonPropertyName("HolidayPayAbove60Percentage")]
        public double? HolidayPayAbove60Percentage { get { return this.HolidayPayAbove60PercentageOption; } set { this.HolidayPayAbove60PercentageOption = new(value); } }

        /// <summary>
        /// Used to track the state of HolidayPayPercentage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> HolidayPayPercentageOption { get; private set; }

        /// <summary>
        /// The holiday pay percentage for the employee.  If null, the general payroll settings will be used.  Note that only 1 decimal is allowed, if more than 1 decimal is provided, the value will be rounded to nearest 1 decimal.
        /// </summary>
        /// <value>The holiday pay percentage for the employee.  If null, the general payroll settings will be used.  Note that only 1 decimal is allowed, if more than 1 decimal is provided, the value will be rounded to nearest 1 decimal.</value>
        /* <example>12.8</example> */
        [JsonPropertyName("HolidayPayPercentage")]
        public double? HolidayPayPercentage { get { return this.HolidayPayPercentageOption; } set { this.HolidayPayPercentageOption = new(value); } }

        /// <summary>
        /// Used to track the state of LimitHolidayPayAbove60To6G
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> LimitHolidayPayAbove60To6GOption { get; private set; }

        /// <summary>
        /// Property indicating whether holiday pay above 60 years is limited to 6G for the employee.  If null, the general payroll settings will be used.
        /// </summary>
        /// <value>Property indicating whether holiday pay above 60 years is limited to 6G for the employee.  If null, the general payroll settings will be used.</value>
        /* <example>true</example> */
        [JsonPropertyName("LimitHolidayPayAbove60To6G")]
        public bool? LimitHolidayPayAbove60To6G { get { return this.LimitHolidayPayAbove60To6GOption; } set { this.LimitHolidayPayAbove60To6GOption = new(value); } }

        /// <summary>
        /// Used to track the state of NumberOfHolidays
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> NumberOfHolidaysOption { get; private set; }

        /// <summary>
        /// The number of holidays for the employee.  If null, the general payroll settings will be used.
        /// </summary>
        /// <value>The number of holidays for the employee.  If null, the general payroll settings will be used.</value>
        /* <example>25</example> */
        [JsonPropertyName("NumberOfHolidays")]
        public int? NumberOfHolidays { get { return this.NumberOfHolidaysOption; } set { this.NumberOfHolidaysOption = new(value); } }

        /// <summary>
        /// Used to track the state of NumberOfHolidaysAbove60
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> NumberOfHolidaysAbove60Option { get; private set; }

        /// <summary>
        /// The number of holidays above 60 years for the employee.  If null, the general payroll settings will be used.
        /// </summary>
        /// <value>The number of holidays above 60 years for the employee.  If null, the general payroll settings will be used.</value>
        /* <example>5</example> */
        [JsonPropertyName("NumberOfHolidaysAbove60")]
        public int? NumberOfHolidaysAbove60 { get { return this.NumberOfHolidaysAbove60Option; } set { this.NumberOfHolidaysAbove60Option = new(value); } }

        /// <summary>
        /// Used to track the state of OmitECOnHolidayPayProvision
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> OmitECOnHolidayPayProvisionOption { get; private set; }

        /// <summary>
        /// Property indicating whether employer contribution should be used or not for holiday pay provisions for this employee.  The typical case to set true, is for foreign employees subject of a foreign social security legislation.
        /// </summary>
        /// <value>Property indicating whether employer contribution should be used or not for holiday pay provisions for this employee.  The typical case to set true, is for foreign employees subject of a foreign social security legislation.</value>
        /* <example>true</example> */
        [JsonPropertyName("OmitECOnHolidayPayProvision")]
        public bool? OmitECOnHolidayPayProvision { get { return this.OmitECOnHolidayPayProvisionOption; } set { this.OmitECOnHolidayPayProvisionOption = new(value); } }

        /// <summary>
        /// Used to track the state of PayslipEmailAddress
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PayslipEmailAddressOption { get; private set; }

        /// <summary>
        /// The e-mail address of the employee that the payslip will be sent to.  Relevant only if the payslip type is set to e-mail and app.  If this property is null, the general e-mail address of the employee will be used if payslips are delivered by e-mail.
        /// </summary>
        /// <value>The e-mail address of the employee that the payslip will be sent to.  Relevant only if the payslip type is set to e-mail and app.  If this property is null, the general e-mail address of the employee will be used if payslips are delivered by e-mail.</value>
        /* <example>abc@online.no</example> */
        [JsonPropertyName("PayslipEmailAddress")]
        public string? PayslipEmailAddress { get { return this.PayslipEmailAddressOption; } set { this.PayslipEmailAddressOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeePayrollSettingsDto {\n");
            sb.Append("  HolidayPayAbove60Percentage: ").Append(HolidayPayAbove60Percentage).Append("\n");
            sb.Append("  HolidayPayPercentage: ").Append(HolidayPayPercentage).Append("\n");
            sb.Append("  LimitHolidayPayAbove60To6G: ").Append(LimitHolidayPayAbove60To6G).Append("\n");
            sb.Append("  NumberOfHolidays: ").Append(NumberOfHolidays).Append("\n");
            sb.Append("  NumberOfHolidaysAbove60: ").Append(NumberOfHolidaysAbove60).Append("\n");
            sb.Append("  OmitECOnHolidayPayProvision: ").Append(OmitECOnHolidayPayProvision).Append("\n");
            sb.Append("  PayslipDeliveryType: ").Append(PayslipDeliveryType).Append("\n");
            sb.Append("  PayslipEmailAddress: ").Append(PayslipEmailAddress).Append("\n");
            sb.Append("  PayslipLanguageType: ").Append(PayslipLanguageType).Append("\n");
            sb.Append("  RemunerationPeriodType: ").Append(RemunerationPeriodType).Append("\n");
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
    /// A Json converter for type <see cref="EmployeePayrollSettingsDto" />
    /// </summary>
    public class EmployeePayrollSettingsDtoJsonConverter : JsonConverter<EmployeePayrollSettingsDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="EmployeePayrollSettingsDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EmployeePayrollSettingsDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double?> holidayPayAbove60Percentage = default;
            Option<double?> holidayPayPercentage = default;
            Option<bool?> limitHolidayPayAbove60To6G = default;
            Option<int?> numberOfHolidays = default;
            Option<int?> numberOfHolidaysAbove60 = default;
            Option<bool?> omitECOnHolidayPayProvision = default;
            Option<PayslipDeliveryType?> payslipDeliveryType = default;
            Option<string?> payslipEmailAddress = default;
            Option<PayslipLanguageType?> payslipLanguageType = default;
            Option<RemunerationPeriodType?> remunerationPeriodType = default;

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
                        case "HolidayPayAbove60Percentage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                holidayPayAbove60Percentage = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "HolidayPayPercentage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                holidayPayPercentage = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "LimitHolidayPayAbove60To6G":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                limitHolidayPayAbove60To6G = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "NumberOfHolidays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                numberOfHolidays = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "NumberOfHolidaysAbove60":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                numberOfHolidaysAbove60 = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "OmitECOnHolidayPayProvision":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                omitECOnHolidayPayProvision = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "PayslipDeliveryType":
                            string? payslipDeliveryTypeRawValue = utf8JsonReader.GetString();
                            if (payslipDeliveryTypeRawValue != null)
                                payslipDeliveryType = new Option<PayslipDeliveryType?>(PayslipDeliveryTypeValueConverter.FromStringOrDefault(payslipDeliveryTypeRawValue));
                            break;
                        case "PayslipEmailAddress":
                            payslipEmailAddress = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "PayslipLanguageType":
                            string? payslipLanguageTypeRawValue = utf8JsonReader.GetString();
                            if (payslipLanguageTypeRawValue != null)
                                payslipLanguageType = new Option<PayslipLanguageType?>(PayslipLanguageTypeValueConverter.FromStringOrDefault(payslipLanguageTypeRawValue));
                            break;
                        case "RemunerationPeriodType":
                            string? remunerationPeriodTypeRawValue = utf8JsonReader.GetString();
                            if (remunerationPeriodTypeRawValue != null)
                                remunerationPeriodType = new Option<RemunerationPeriodType?>(RemunerationPeriodTypeValueConverter.FromStringOrDefault(remunerationPeriodTypeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            return new EmployeePayrollSettingsDto(holidayPayAbove60Percentage, holidayPayPercentage, limitHolidayPayAbove60To6G, numberOfHolidays, numberOfHolidaysAbove60, omitECOnHolidayPayProvision, payslipDeliveryType, payslipEmailAddress, payslipLanguageType, remunerationPeriodType);
        }

        /// <summary>
        /// Serializes a <see cref="EmployeePayrollSettingsDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employeePayrollSettingsDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EmployeePayrollSettingsDto employeePayrollSettingsDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, employeePayrollSettingsDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EmployeePayrollSettingsDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="employeePayrollSettingsDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EmployeePayrollSettingsDto employeePayrollSettingsDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (employeePayrollSettingsDto.HolidayPayAbove60PercentageOption.IsSet)
                if (employeePayrollSettingsDto.HolidayPayAbove60PercentageOption.Value != null)
                    writer.WriteNumber("HolidayPayAbove60Percentage", employeePayrollSettingsDto.HolidayPayAbove60PercentageOption.Value!.Value);
                else
                    writer.WriteNull("HolidayPayAbove60Percentage");

            if (employeePayrollSettingsDto.HolidayPayPercentageOption.IsSet)
                if (employeePayrollSettingsDto.HolidayPayPercentageOption.Value != null)
                    writer.WriteNumber("HolidayPayPercentage", employeePayrollSettingsDto.HolidayPayPercentageOption.Value!.Value);
                else
                    writer.WriteNull("HolidayPayPercentage");

            if (employeePayrollSettingsDto.LimitHolidayPayAbove60To6GOption.IsSet)
                if (employeePayrollSettingsDto.LimitHolidayPayAbove60To6GOption.Value != null)
                    writer.WriteBoolean("LimitHolidayPayAbove60To6G", employeePayrollSettingsDto.LimitHolidayPayAbove60To6GOption.Value!.Value);
                else
                    writer.WriteNull("LimitHolidayPayAbove60To6G");

            if (employeePayrollSettingsDto.NumberOfHolidaysOption.IsSet)
                if (employeePayrollSettingsDto.NumberOfHolidaysOption.Value != null)
                    writer.WriteNumber("NumberOfHolidays", employeePayrollSettingsDto.NumberOfHolidaysOption.Value!.Value);
                else
                    writer.WriteNull("NumberOfHolidays");

            if (employeePayrollSettingsDto.NumberOfHolidaysAbove60Option.IsSet)
                if (employeePayrollSettingsDto.NumberOfHolidaysAbove60Option.Value != null)
                    writer.WriteNumber("NumberOfHolidaysAbove60", employeePayrollSettingsDto.NumberOfHolidaysAbove60Option.Value!.Value);
                else
                    writer.WriteNull("NumberOfHolidaysAbove60");

            if (employeePayrollSettingsDto.OmitECOnHolidayPayProvisionOption.IsSet)
                if (employeePayrollSettingsDto.OmitECOnHolidayPayProvisionOption.Value != null)
                    writer.WriteBoolean("OmitECOnHolidayPayProvision", employeePayrollSettingsDto.OmitECOnHolidayPayProvisionOption.Value!.Value);
                else
                    writer.WriteNull("OmitECOnHolidayPayProvision");

            if (employeePayrollSettingsDto.PayslipDeliveryTypeOption.IsSet)
                if (employeePayrollSettingsDto.PayslipDeliveryTypeOption!.Value != null)
                {
                    var payslipDeliveryTypeRawValue = PayslipDeliveryTypeValueConverter.ToJsonValue(employeePayrollSettingsDto.PayslipDeliveryTypeOption.Value!.Value);
                    writer.WriteString("PayslipDeliveryType", payslipDeliveryTypeRawValue);
                }
                else
                    writer.WriteNull("PayslipDeliveryType");
            if (employeePayrollSettingsDto.PayslipEmailAddressOption.IsSet)
                if (employeePayrollSettingsDto.PayslipEmailAddressOption.Value != null)
                    writer.WriteString("PayslipEmailAddress", employeePayrollSettingsDto.PayslipEmailAddress);
                else
                    writer.WriteNull("PayslipEmailAddress");

            if (employeePayrollSettingsDto.PayslipLanguageTypeOption.IsSet)
                if (employeePayrollSettingsDto.PayslipLanguageTypeOption!.Value != null)
                {
                    var payslipLanguageTypeRawValue = PayslipLanguageTypeValueConverter.ToJsonValue(employeePayrollSettingsDto.PayslipLanguageTypeOption.Value!.Value);
                    writer.WriteString("PayslipLanguageType", payslipLanguageTypeRawValue);
                }
                else
                    writer.WriteNull("PayslipLanguageType");
            if (employeePayrollSettingsDto.RemunerationPeriodTypeOption.IsSet)
                if (employeePayrollSettingsDto.RemunerationPeriodTypeOption!.Value != null)
                {
                    var remunerationPeriodTypeRawValue = RemunerationPeriodTypeValueConverter.ToJsonValue(employeePayrollSettingsDto.RemunerationPeriodTypeOption.Value!.Value);
                    writer.WriteString("RemunerationPeriodType", remunerationPeriodTypeRawValue);
                }
                else
                    writer.WriteNull("RemunerationPeriodType");
        }
    }
}

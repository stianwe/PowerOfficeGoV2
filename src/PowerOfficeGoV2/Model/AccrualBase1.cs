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
    /// Accrual (Norwegian: Periodisering)
    /// </summary>
    public partial class AccrualBase1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccrualBase1" /> class.
        /// </summary>
        /// <param name="balanceAccountAgricultureDepartment">balanceAccountAgricultureDepartment</param>
        /// <param name="balanceAccountId">The account id of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).</param>
        /// <param name="balanceAccountNo">The account number of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).</param>
        /// <param name="fromDate">The start date of the accrual.</param>
        /// <param name="isActive">Value indicating whether the accrual is active or not.</param>
        /// <param name="toDate">The end date of the accrual.</param>
        [JsonConstructor]
        public AccrualBase1(Option<AgricultureDepartment?> balanceAccountAgricultureDepartment = default, Option<long?> balanceAccountId = default, Option<long?> balanceAccountNo = default, Option<DateOnly?> fromDate = default, Option<bool?> isActive = default, Option<DateOnly?> toDate = default)
        {
            BalanceAccountAgricultureDepartmentOption = balanceAccountAgricultureDepartment;
            BalanceAccountIdOption = balanceAccountId;
            BalanceAccountNoOption = balanceAccountNo;
            FromDateOption = fromDate;
            IsActiveOption = isActive;
            ToDateOption = toDate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BalanceAccountAgricultureDepartment
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AgricultureDepartment?> BalanceAccountAgricultureDepartmentOption { get; private set; }

        /// <summary>
        /// Gets or Sets BalanceAccountAgricultureDepartment
        /// </summary>
        [JsonPropertyName("BalanceAccountAgricultureDepartment")]
        public AgricultureDepartment? BalanceAccountAgricultureDepartment { get { return this.BalanceAccountAgricultureDepartmentOption; } set { this.BalanceAccountAgricultureDepartmentOption = new(value); } }

        /// <summary>
        /// Used to track the state of BalanceAccountId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> BalanceAccountIdOption { get; private set; }

        /// <summary>
        /// The account id of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).
        /// </summary>
        /// <value>The account id of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).</value>
        /* <example>123456</example> */
        [JsonPropertyName("BalanceAccountId")]
        public long? BalanceAccountId { get { return this.BalanceAccountIdOption; } set { this.BalanceAccountIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of BalanceAccountNo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> BalanceAccountNoOption { get; private set; }

        /// <summary>
        /// The account number of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).
        /// </summary>
        /// <value>The account number of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).</value>
        /* <example>2970</example> */
        [JsonPropertyName("BalanceAccountNo")]
        public long? BalanceAccountNo { get { return this.BalanceAccountNoOption; } set { this.BalanceAccountNoOption = new(value); } }

        /// <summary>
        /// Used to track the state of FromDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> FromDateOption { get; private set; }

        /// <summary>
        /// The start date of the accrual.
        /// </summary>
        /// <value>The start date of the accrual.</value>
        /* <example>Sun Jan 01 01:00:00 CET 2023</example> */
        [JsonPropertyName("FromDate")]
        public DateOnly? FromDate { get { return this.FromDateOption; } set { this.FromDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsActive
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsActiveOption { get; private set; }

        /// <summary>
        /// Value indicating whether the accrual is active or not.
        /// </summary>
        /// <value>Value indicating whether the accrual is active or not.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get { return this.IsActiveOption; } set { this.IsActiveOption = new(value); } }

        /// <summary>
        /// Used to track the state of ToDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> ToDateOption { get; private set; }

        /// <summary>
        /// The end date of the accrual.
        /// </summary>
        /// <value>The end date of the accrual.</value>
        /* <example>Sun Dec 31 01:00:00 CET 2023</example> */
        [JsonPropertyName("ToDate")]
        public DateOnly? ToDate { get { return this.ToDateOption; } set { this.ToDateOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccrualBase1 {\n");
            sb.Append("  BalanceAccountAgricultureDepartment: ").Append(BalanceAccountAgricultureDepartment).Append("\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  BalanceAccountNo: ").Append(BalanceAccountNo).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
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
    /// A Json converter for type <see cref="AccrualBase1" />
    /// </summary>
    public class AccrualBase1JsonConverter : JsonConverter<AccrualBase1>
    {
        /// <summary>
        /// The format to use to serialize FromDate
        /// </summary>
        public static string FromDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize ToDate
        /// </summary>
        public static string ToDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="AccrualBase1" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AccrualBase1 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<AgricultureDepartment?> balanceAccountAgricultureDepartment = default;
            Option<long?> balanceAccountId = default;
            Option<long?> balanceAccountNo = default;
            Option<DateOnly?> fromDate = default;
            Option<bool?> isActive = default;
            Option<DateOnly?> toDate = default;

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
                        case "BalanceAccountAgricultureDepartment":
                            string? balanceAccountAgricultureDepartmentRawValue = utf8JsonReader.GetString();
                            if (balanceAccountAgricultureDepartmentRawValue != null)
                                balanceAccountAgricultureDepartment = new Option<AgricultureDepartment?>(AgricultureDepartmentValueConverter.FromStringOrDefault(balanceAccountAgricultureDepartmentRawValue));
                            break;
                        case "BalanceAccountId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                balanceAccountId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "BalanceAccountNo":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                balanceAccountNo = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "FromDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fromDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "ToDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                toDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (fromDate.IsSet && fromDate.Value == null)
                throw new ArgumentNullException(nameof(fromDate), "Property is not nullable for class AccrualBase1.");

            if (isActive.IsSet && isActive.Value == null)
                throw new ArgumentNullException(nameof(isActive), "Property is not nullable for class AccrualBase1.");

            if (toDate.IsSet && toDate.Value == null)
                throw new ArgumentNullException(nameof(toDate), "Property is not nullable for class AccrualBase1.");

            return new AccrualBase1(balanceAccountAgricultureDepartment, balanceAccountId, balanceAccountNo, fromDate, isActive, toDate);
        }

        /// <summary>
        /// Serializes a <see cref="AccrualBase1" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="accrualBase1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AccrualBase1 accrualBase1, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, accrualBase1, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AccrualBase1" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="accrualBase1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AccrualBase1 accrualBase1, JsonSerializerOptions jsonSerializerOptions)
        {
            if (accrualBase1.BalanceAccountAgricultureDepartmentOption.IsSet)
                if (accrualBase1.BalanceAccountAgricultureDepartmentOption!.Value != null)
                {
                    var balanceAccountAgricultureDepartmentRawValue = AgricultureDepartmentValueConverter.ToJsonValue(accrualBase1.BalanceAccountAgricultureDepartmentOption.Value!.Value);
                    writer.WriteString("BalanceAccountAgricultureDepartment", balanceAccountAgricultureDepartmentRawValue);
                }
                else
                    writer.WriteNull("BalanceAccountAgricultureDepartment");
            if (accrualBase1.BalanceAccountIdOption.IsSet)
                if (accrualBase1.BalanceAccountIdOption.Value != null)
                    writer.WriteNumber("BalanceAccountId", accrualBase1.BalanceAccountIdOption.Value!.Value);
                else
                    writer.WriteNull("BalanceAccountId");

            if (accrualBase1.BalanceAccountNoOption.IsSet)
                if (accrualBase1.BalanceAccountNoOption.Value != null)
                    writer.WriteNumber("BalanceAccountNo", accrualBase1.BalanceAccountNoOption.Value!.Value);
                else
                    writer.WriteNull("BalanceAccountNo");

            if (accrualBase1.FromDateOption.IsSet)
                writer.WriteString("FromDate", accrualBase1.FromDateOption.Value!.Value.ToString(FromDateFormat));

            if (accrualBase1.IsActiveOption.IsSet)
                writer.WriteBoolean("IsActive", accrualBase1.IsActiveOption.Value!.Value);

            if (accrualBase1.ToDateOption.IsSet)
                writer.WriteString("ToDate", accrualBase1.ToDateOption.Value!.Value.ToString(ToDateFormat));
        }
    }
}

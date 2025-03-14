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
    public partial class Accrual : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Accrual" /> class.
        /// </summary>
        /// <param name="balanceAccountAgricultureDepartment">balanceAccountAgricultureDepartment</param>
        /// <param name="balanceAccountId">The account id of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).</param>
        /// <param name="balanceAccountNo">The account number of the balance account used for the accrual balance  (norwegian: balansekonto benyttet for periodiseringen).</param>
        /// <param name="fromDate">The start date of the accrual.</param>
        /// <param name="isActive">Value indicating whether the accrual is active or not.</param>
        /// <param name="resultAccountAgricultureDepartment">resultAccountAgricultureDepartment</param>
        /// <param name="resultAccountId">The account id of the result account used for the posting of the accrued revenue  (norwegian: resultatkonto benyttet for periodiseringen).</param>
        /// <param name="resultAccountNo">The account number of the result account used for the posting of the accrued revenue  (norwegian: resultatkonto benyttet for periodiseringen).</param>
        /// <param name="toDate">The end date of the accrual.</param>
        [JsonConstructor]
        public Accrual(Option<AgricultureDepartment?> balanceAccountAgricultureDepartment = default, Option<long?> balanceAccountId = default, Option<long?> balanceAccountNo = default, Option<DateTimeOffset?> fromDate = default, Option<bool?> isActive = default, Option<AgricultureDepartment?> resultAccountAgricultureDepartment = default, Option<long?> resultAccountId = default, Option<long?> resultAccountNo = default, Option<DateTimeOffset?> toDate = default)
        {
            BalanceAccountAgricultureDepartmentOption = balanceAccountAgricultureDepartment;
            BalanceAccountIdOption = balanceAccountId;
            BalanceAccountNoOption = balanceAccountNo;
            FromDateOption = fromDate;
            IsActiveOption = isActive;
            ResultAccountAgricultureDepartmentOption = resultAccountAgricultureDepartment;
            ResultAccountIdOption = resultAccountId;
            ResultAccountNoOption = resultAccountNo;
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
        /// Used to track the state of ResultAccountAgricultureDepartment
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AgricultureDepartment?> ResultAccountAgricultureDepartmentOption { get; private set; }

        /// <summary>
        /// Gets or Sets ResultAccountAgricultureDepartment
        /// </summary>
        [JsonPropertyName("ResultAccountAgricultureDepartment")]
        public AgricultureDepartment? ResultAccountAgricultureDepartment { get { return this.ResultAccountAgricultureDepartmentOption; } set { this.ResultAccountAgricultureDepartmentOption = new(value); } }

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
        public Option<DateTimeOffset?> FromDateOption { get; private set; }

        /// <summary>
        /// The start date of the accrual.
        /// </summary>
        /// <value>The start date of the accrual.</value>
        /* <example>Sun Jan 01 01:00:00 CET 2023</example> */
        [JsonPropertyName("FromDate")]
        public DateTimeOffset? FromDate { get { return this.FromDateOption; } set { this.FromDateOption = new(value); } }

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
        /// Used to track the state of ResultAccountId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ResultAccountIdOption { get; private set; }

        /// <summary>
        /// The account id of the result account used for the posting of the accrued revenue  (norwegian: resultatkonto benyttet for periodiseringen).
        /// </summary>
        /// <value>The account id of the result account used for the posting of the accrued revenue  (norwegian: resultatkonto benyttet for periodiseringen).</value>
        /* <example>123456</example> */
        [JsonPropertyName("ResultAccountId")]
        public long? ResultAccountId { get { return this.ResultAccountIdOption; } set { this.ResultAccountIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ResultAccountNo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ResultAccountNoOption { get; private set; }

        /// <summary>
        /// The account number of the result account used for the posting of the accrued revenue  (norwegian: resultatkonto benyttet for periodiseringen).
        /// </summary>
        /// <value>The account number of the result account used for the posting of the accrued revenue  (norwegian: resultatkonto benyttet for periodiseringen).</value>
        /* <example>3901</example> */
        [JsonPropertyName("ResultAccountNo")]
        public long? ResultAccountNo { get { return this.ResultAccountNoOption; } set { this.ResultAccountNoOption = new(value); } }

        /// <summary>
        /// Used to track the state of ToDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> ToDateOption { get; private set; }

        /// <summary>
        /// The end date of the accrual.
        /// </summary>
        /// <value>The end date of the accrual.</value>
        /* <example>Sun Dec 31 01:00:00 CET 2023</example> */
        [JsonPropertyName("ToDate")]
        public DateTimeOffset? ToDate { get { return this.ToDateOption; } set { this.ToDateOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Accrual {\n");
            sb.Append("  BalanceAccountAgricultureDepartment: ").Append(BalanceAccountAgricultureDepartment).Append("\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  BalanceAccountNo: ").Append(BalanceAccountNo).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ResultAccountAgricultureDepartment: ").Append(ResultAccountAgricultureDepartment).Append("\n");
            sb.Append("  ResultAccountId: ").Append(ResultAccountId).Append("\n");
            sb.Append("  ResultAccountNo: ").Append(ResultAccountNo).Append("\n");
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
    /// A Json converter for type <see cref="Accrual" />
    /// </summary>
    public class AccrualJsonConverter : JsonConverter<Accrual>
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
        /// Deserializes json to <see cref="Accrual" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Accrual Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<AgricultureDepartment?> balanceAccountAgricultureDepartment = default;
            Option<long?> balanceAccountId = default;
            Option<long?> balanceAccountNo = default;
            Option<DateTimeOffset?> fromDate = default;
            Option<bool?> isActive = default;
            Option<AgricultureDepartment?> resultAccountAgricultureDepartment = default;
            Option<long?> resultAccountId = default;
            Option<long?> resultAccountNo = default;
            Option<DateTimeOffset?> toDate = default;

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
                                fromDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "ResultAccountAgricultureDepartment":
                            string? resultAccountAgricultureDepartmentRawValue = utf8JsonReader.GetString();
                            if (resultAccountAgricultureDepartmentRawValue != null)
                                resultAccountAgricultureDepartment = new Option<AgricultureDepartment?>(AgricultureDepartmentValueConverter.FromStringOrDefault(resultAccountAgricultureDepartmentRawValue));
                            break;
                        case "ResultAccountId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                resultAccountId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "ResultAccountNo":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                resultAccountNo = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "ToDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                toDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (fromDate.IsSet && fromDate.Value == null)
                throw new ArgumentNullException(nameof(fromDate), "Property is not nullable for class Accrual.");

            if (isActive.IsSet && isActive.Value == null)
                throw new ArgumentNullException(nameof(isActive), "Property is not nullable for class Accrual.");

            if (toDate.IsSet && toDate.Value == null)
                throw new ArgumentNullException(nameof(toDate), "Property is not nullable for class Accrual.");

            return new Accrual(balanceAccountAgricultureDepartment, balanceAccountId, balanceAccountNo, fromDate, isActive, resultAccountAgricultureDepartment, resultAccountId, resultAccountNo, toDate);
        }

        /// <summary>
        /// Serializes a <see cref="Accrual" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="accrual"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Accrual accrual, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, accrual, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Accrual" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="accrual"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Accrual accrual, JsonSerializerOptions jsonSerializerOptions)
        {
            if (accrual.BalanceAccountAgricultureDepartmentOption.IsSet)
                if (accrual.BalanceAccountAgricultureDepartmentOption!.Value != null)
                {
                    var balanceAccountAgricultureDepartmentRawValue = AgricultureDepartmentValueConverter.ToJsonValue(accrual.BalanceAccountAgricultureDepartmentOption.Value!.Value);
                    writer.WriteString("BalanceAccountAgricultureDepartment", balanceAccountAgricultureDepartmentRawValue);
                }
                else
                    writer.WriteNull("BalanceAccountAgricultureDepartment");
            if (accrual.BalanceAccountIdOption.IsSet)
                if (accrual.BalanceAccountIdOption.Value != null)
                    writer.WriteNumber("BalanceAccountId", accrual.BalanceAccountIdOption.Value!.Value);
                else
                    writer.WriteNull("BalanceAccountId");

            if (accrual.BalanceAccountNoOption.IsSet)
                if (accrual.BalanceAccountNoOption.Value != null)
                    writer.WriteNumber("BalanceAccountNo", accrual.BalanceAccountNoOption.Value!.Value);
                else
                    writer.WriteNull("BalanceAccountNo");

            if (accrual.FromDateOption.IsSet)
                writer.WriteString("FromDate", accrual.FromDateOption.Value!.Value.ToString(FromDateFormat));

            if (accrual.IsActiveOption.IsSet)
                writer.WriteBoolean("IsActive", accrual.IsActiveOption.Value!.Value);

            if (accrual.ResultAccountAgricultureDepartmentOption.IsSet)
                if (accrual.ResultAccountAgricultureDepartmentOption!.Value != null)
                {
                    var resultAccountAgricultureDepartmentRawValue = AgricultureDepartmentValueConverter.ToJsonValue(accrual.ResultAccountAgricultureDepartmentOption.Value!.Value);
                    writer.WriteString("ResultAccountAgricultureDepartment", resultAccountAgricultureDepartmentRawValue);
                }
                else
                    writer.WriteNull("ResultAccountAgricultureDepartment");
            if (accrual.ResultAccountIdOption.IsSet)
                if (accrual.ResultAccountIdOption.Value != null)
                    writer.WriteNumber("ResultAccountId", accrual.ResultAccountIdOption.Value!.Value);
                else
                    writer.WriteNull("ResultAccountId");

            if (accrual.ResultAccountNoOption.IsSet)
                if (accrual.ResultAccountNoOption.Value != null)
                    writer.WriteNumber("ResultAccountNo", accrual.ResultAccountNoOption.Value!.Value);
                else
                    writer.WriteNull("ResultAccountNo");

            if (accrual.ToDateOption.IsSet)
                writer.WriteString("ToDate", accrual.ToDateOption.Value!.Value.ToString(ToDateFormat));
        }
    }
}

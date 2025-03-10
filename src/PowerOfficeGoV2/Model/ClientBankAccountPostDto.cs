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
    /// Properties for creating a client bank account
    /// </summary>
    public partial class ClientBankAccountPostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBankAccountPostDto" /> class.
        /// </summary>
        /// <param name="bankAccountNumber">The bank account number.</param>
        /// <param name="bicSwift">The BIC Swift code of the bank.</param>
        /// <param name="countryCode">The ISO 3166-1 alfa-2 country code (two characters).</param>
        /// <param name="generalLedgerAccountId">The identifier of the general ledger account this bank account is associated with.</param>
        /// <param name="allowOverdraft">A value indicating whether this bank account can be overdrawn (Norwegian: Kassekreditt).</param>
        /// <param name="bankName">The name of the bank.</param>
        /// <param name="currencyCode">The standard code of the currency associated with the client bank account.</param>
        /// <param name="isActive">A value indicating whether this bank account is active. Inactive bank accounts disable the usage of that bank account in the GUI.</param>
        /// <param name="isClientTrustAccount">A value indicating whether this is a bank account containing client trust funds (example use cases: real estate brokers, lawyers).</param>
        /// <param name="overdraftLimit">The overdraft limit for the bank account, if set. Available only for bank accounts with overdraft enabled.</param>
        [JsonConstructor]
        public ClientBankAccountPostDto(string bankAccountNumber, string bicSwift, string countryCode, long generalLedgerAccountId, Option<bool?> allowOverdraft = default, Option<string?> bankName = default, string? currencyCode = default, Option<bool?> isActive = default, Option<bool?> isClientTrustAccount = default, Option<double?> overdraftLimit = default)
        {
            BankAccountNumber = bankAccountNumber;
            BicSwift = bicSwift;
            CountryCode = countryCode;
            GeneralLedgerAccountId = generalLedgerAccountId;
            AllowOverdraftOption = allowOverdraft;
            BankNameOption = bankName;
            CurrencyCode = currencyCode;
            IsActiveOption = isActive;
            IsClientTrustAccountOption = isClientTrustAccount;
            OverdraftLimitOption = overdraftLimit;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The bank account number.
        /// </summary>
        /// <value>The bank account number.</value>
        /* <example>12345678903</example> */
        [JsonPropertyName("BankAccountNumber")]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The BIC Swift code of the bank.
        /// </summary>
        /// <value>The BIC Swift code of the bank.</value>
        /* <example>DNBANOKK</example> */
        [JsonPropertyName("BicSwift")]
        public string BicSwift { get; set; }

        /// <summary>
        /// The ISO 3166-1 alfa-2 country code (two characters).
        /// </summary>
        /// <value>The ISO 3166-1 alfa-2 country code (two characters).</value>
        /* <example>NO</example> */
        [JsonPropertyName("CountryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The identifier of the general ledger account this bank account is associated with.
        /// </summary>
        /// <value>The identifier of the general ledger account this bank account is associated with.</value>
        /* <example>123456</example> */
        [JsonPropertyName("GeneralLedgerAccountId")]
        public long GeneralLedgerAccountId { get; set; }

        /// <summary>
        /// Used to track the state of AllowOverdraft
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> AllowOverdraftOption { get; private set; }

        /// <summary>
        /// A value indicating whether this bank account can be overdrawn (Norwegian: Kassekreditt).
        /// </summary>
        /// <value>A value indicating whether this bank account can be overdrawn (Norwegian: Kassekreditt).</value>
        /* <example>true</example> */
        [JsonPropertyName("AllowOverdraft")]
        public bool? AllowOverdraft { get { return this.AllowOverdraftOption; } set { this.AllowOverdraftOption = new(value); } }

        /// <summary>
        /// Used to track the state of BankName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BankNameOption { get; private set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        /// <value>The name of the bank.</value>
        /* <example>DNB</example> */
        [JsonPropertyName("BankName")]
        public string? BankName { get { return this.BankNameOption; } set { this.BankNameOption = new(value); } }

        /// <summary>
        /// The standard code of the currency associated with the client bank account.
        /// </summary>
        /// <value>The standard code of the currency associated with the client bank account.</value>
        /* <example>NOK</example> */
        [JsonPropertyName("CurrencyCode")]
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Used to track the state of IsActive
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsActiveOption { get; private set; }

        /// <summary>
        /// A value indicating whether this bank account is active. Inactive bank accounts disable the usage of that bank account in the GUI.
        /// </summary>
        /// <value>A value indicating whether this bank account is active. Inactive bank accounts disable the usage of that bank account in the GUI.</value>
        /* <example>false</example> */
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get { return this.IsActiveOption; } set { this.IsActiveOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsClientTrustAccount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsClientTrustAccountOption { get; private set; }

        /// <summary>
        /// A value indicating whether this is a bank account containing client trust funds (example use cases: real estate brokers, lawyers).
        /// </summary>
        /// <value>A value indicating whether this is a bank account containing client trust funds (example use cases: real estate brokers, lawyers).</value>
        /* <example>false</example> */
        [JsonPropertyName("IsClientTrustAccount")]
        public bool? IsClientTrustAccount { get { return this.IsClientTrustAccountOption; } set { this.IsClientTrustAccountOption = new(value); } }

        /// <summary>
        /// Used to track the state of OverdraftLimit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> OverdraftLimitOption { get; private set; }

        /// <summary>
        /// The overdraft limit for the bank account, if set. Available only for bank accounts with overdraft enabled.
        /// </summary>
        /// <value>The overdraft limit for the bank account, if set. Available only for bank accounts with overdraft enabled.</value>
        /* <example>12500</example> */
        [JsonPropertyName("OverdraftLimit")]
        public double? OverdraftLimit { get { return this.OverdraftLimitOption; } set { this.OverdraftLimitOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientBankAccountPostDto {\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BicSwift: ").Append(BicSwift).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  GeneralLedgerAccountId: ").Append(GeneralLedgerAccountId).Append("\n");
            sb.Append("  AllowOverdraft: ").Append(AllowOverdraft).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsClientTrustAccount: ").Append(IsClientTrustAccount).Append("\n");
            sb.Append("  OverdraftLimit: ").Append(OverdraftLimit).Append("\n");
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
            // BankAccountNumber (string) maxLength
            if (this.BankAccountNumber != null && this.BankAccountNumber.Length > 50)
            {
                yield return new ValidationResult("Invalid value for BankAccountNumber, length must be less than 50.", new [] { "BankAccountNumber" });
            }

            // BankAccountNumber (string) minLength
            if (this.BankAccountNumber != null && this.BankAccountNumber.Length < 1)
            {
                yield return new ValidationResult("Invalid value for BankAccountNumber, length must be greater than 1.", new [] { "BankAccountNumber" });
            }

            // BicSwift (string) maxLength
            if (this.BicSwift != null && this.BicSwift.Length > 50)
            {
                yield return new ValidationResult("Invalid value for BicSwift, length must be less than 50.", new [] { "BicSwift" });
            }

            // BicSwift (string) minLength
            if (this.BicSwift != null && this.BicSwift.Length < 1)
            {
                yield return new ValidationResult("Invalid value for BicSwift, length must be greater than 1.", new [] { "BicSwift" });
            }

            // CountryCode (string) maxLength
            if (this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // CountryCode (string) minLength
            if (this.CountryCode != null && this.CountryCode.Length < 2)
            {
                yield return new ValidationResult("Invalid value for CountryCode, length must be greater than 2.", new [] { "CountryCode" });
            }

            // BankName (string) maxLength
            if (this.BankName != null && this.BankName.Length > 400)
            {
                yield return new ValidationResult("Invalid value for BankName, length must be less than 400.", new [] { "BankName" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ClientBankAccountPostDto" />
    /// </summary>
    public class ClientBankAccountPostDtoJsonConverter : JsonConverter<ClientBankAccountPostDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="ClientBankAccountPostDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClientBankAccountPostDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> bankAccountNumber = default;
            Option<string?> bicSwift = default;
            Option<string?> countryCode = default;
            Option<long?> generalLedgerAccountId = default;
            Option<bool?> allowOverdraft = default;
            Option<string?> bankName = default;
            Option<string?> currencyCode = default;
            Option<bool?> isActive = default;
            Option<bool?> isClientTrustAccount = default;
            Option<double?> overdraftLimit = default;

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
                        case "BankAccountNumber":
                            bankAccountNumber = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "BicSwift":
                            bicSwift = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "CountryCode":
                            countryCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "GeneralLedgerAccountId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                generalLedgerAccountId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "AllowOverdraft":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                allowOverdraft = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "BankName":
                            bankName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "CurrencyCode":
                            currencyCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "IsClientTrustAccount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isClientTrustAccount = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "OverdraftLimit":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                overdraftLimit = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!bankAccountNumber.IsSet)
                throw new ArgumentException("Property is required for class ClientBankAccountPostDto.", nameof(bankAccountNumber));

            if (!bicSwift.IsSet)
                throw new ArgumentException("Property is required for class ClientBankAccountPostDto.", nameof(bicSwift));

            if (!countryCode.IsSet)
                throw new ArgumentException("Property is required for class ClientBankAccountPostDto.", nameof(countryCode));

            if (!generalLedgerAccountId.IsSet)
                throw new ArgumentException("Property is required for class ClientBankAccountPostDto.", nameof(generalLedgerAccountId));

            if (!currencyCode.IsSet)
                throw new ArgumentException("Property is required for class ClientBankAccountPostDto.", nameof(currencyCode));

            if (bankAccountNumber.IsSet && bankAccountNumber.Value == null)
                throw new ArgumentNullException(nameof(bankAccountNumber), "Property is not nullable for class ClientBankAccountPostDto.");

            if (bicSwift.IsSet && bicSwift.Value == null)
                throw new ArgumentNullException(nameof(bicSwift), "Property is not nullable for class ClientBankAccountPostDto.");

            if (countryCode.IsSet && countryCode.Value == null)
                throw new ArgumentNullException(nameof(countryCode), "Property is not nullable for class ClientBankAccountPostDto.");

            if (generalLedgerAccountId.IsSet && generalLedgerAccountId.Value == null)
                throw new ArgumentNullException(nameof(generalLedgerAccountId), "Property is not nullable for class ClientBankAccountPostDto.");

            return new ClientBankAccountPostDto(bankAccountNumber.Value!, bicSwift.Value!, countryCode.Value!, generalLedgerAccountId.Value!.Value!, allowOverdraft, bankName, currencyCode.Value!, isActive, isClientTrustAccount, overdraftLimit);
        }

        /// <summary>
        /// Serializes a <see cref="ClientBankAccountPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientBankAccountPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClientBankAccountPostDto clientBankAccountPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, clientBankAccountPostDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ClientBankAccountPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientBankAccountPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ClientBankAccountPostDto clientBankAccountPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (clientBankAccountPostDto.BankAccountNumber == null)
                throw new ArgumentNullException(nameof(clientBankAccountPostDto.BankAccountNumber), "Property is required for class ClientBankAccountPostDto.");

            if (clientBankAccountPostDto.BicSwift == null)
                throw new ArgumentNullException(nameof(clientBankAccountPostDto.BicSwift), "Property is required for class ClientBankAccountPostDto.");

            if (clientBankAccountPostDto.CountryCode == null)
                throw new ArgumentNullException(nameof(clientBankAccountPostDto.CountryCode), "Property is required for class ClientBankAccountPostDto.");

            writer.WriteString("BankAccountNumber", clientBankAccountPostDto.BankAccountNumber);

            writer.WriteString("BicSwift", clientBankAccountPostDto.BicSwift);

            writer.WriteString("CountryCode", clientBankAccountPostDto.CountryCode);

            writer.WriteNumber("GeneralLedgerAccountId", clientBankAccountPostDto.GeneralLedgerAccountId);

            if (clientBankAccountPostDto.AllowOverdraftOption.IsSet)
                if (clientBankAccountPostDto.AllowOverdraftOption.Value != null)
                    writer.WriteBoolean("AllowOverdraft", clientBankAccountPostDto.AllowOverdraftOption.Value!.Value);
                else
                    writer.WriteNull("AllowOverdraft");

            if (clientBankAccountPostDto.BankNameOption.IsSet)
                if (clientBankAccountPostDto.BankNameOption.Value != null)
                    writer.WriteString("BankName", clientBankAccountPostDto.BankName);
                else
                    writer.WriteNull("BankName");

            if (clientBankAccountPostDto.CurrencyCode != null)
                writer.WriteString("CurrencyCode", clientBankAccountPostDto.CurrencyCode);
            else
                writer.WriteNull("CurrencyCode");

            if (clientBankAccountPostDto.IsActiveOption.IsSet)
                if (clientBankAccountPostDto.IsActiveOption.Value != null)
                    writer.WriteBoolean("IsActive", clientBankAccountPostDto.IsActiveOption.Value!.Value);
                else
                    writer.WriteNull("IsActive");

            if (clientBankAccountPostDto.IsClientTrustAccountOption.IsSet)
                if (clientBankAccountPostDto.IsClientTrustAccountOption.Value != null)
                    writer.WriteBoolean("IsClientTrustAccount", clientBankAccountPostDto.IsClientTrustAccountOption.Value!.Value);
                else
                    writer.WriteNull("IsClientTrustAccount");

            if (clientBankAccountPostDto.OverdraftLimitOption.IsSet)
                if (clientBankAccountPostDto.OverdraftLimitOption.Value != null)
                    writer.WriteNumber("OverdraftLimit", clientBankAccountPostDto.OverdraftLimitOption.Value!.Value);
                else
                    writer.WriteNull("OverdraftLimit");
        }
    }
}

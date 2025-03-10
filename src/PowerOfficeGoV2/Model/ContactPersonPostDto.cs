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
    /// Properties for creating a new contact person.
    /// </summary>
    public partial class ContactPersonPostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPersonPostDto" /> class.
        /// </summary>
        /// <param name="emailAddress">The e-mail address registered for the contact person.  This field is validated for typos in POST/PATCH calls.</param>
        /// <param name="externalCode">The external code. This field is not available in the GUI,  but can be used by the integrating party to reference the contact  person in the external system. The field must be unique (for each contact person).</param>
        /// <param name="firstName">The first name of the contact person.</param>
        /// <param name="isActive">A value indicating whether this instance is active. Inactive contact persons disable the usage of that in the GUI.</param>
        /// <param name="isDefault">A bool indicating whether this contact person is the default contact person.</param>
        /// <param name="lastName">The last name of the contact person.</param>
        /// <param name="mailAddress">mailAddress</param>
        /// <param name="phoneNumber">The phone number of the contact person.</param>
        /// <param name="title">The title of the contact person. This might for instance be the job title of the person.</param>
        [JsonConstructor]
        public ContactPersonPostDto(Option<string?> emailAddress = default, Option<string?> externalCode = default, string? firstName = default, Option<bool?> isActive = default, Option<bool?> isDefault = default, string? lastName = default, Option<AddressPostDto?> mailAddress = default, Option<string?> phoneNumber = default, Option<string?> title = default)
        {
            EmailAddressOption = emailAddress;
            ExternalCodeOption = externalCode;
            FirstName = firstName;
            IsActiveOption = isActive;
            IsDefaultOption = isDefault;
            LastName = lastName;
            MailAddressOption = mailAddress;
            PhoneNumberOption = phoneNumber;
            TitleOption = title;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of EmailAddress
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EmailAddressOption { get; private set; }

        /// <summary>
        /// The e-mail address registered for the contact person.  This field is validated for typos in POST/PATCH calls.
        /// </summary>
        /// <value>The e-mail address registered for the contact person.  This field is validated for typos in POST/PATCH calls.</value>
        /* <example>api@example.com</example> */
        [JsonPropertyName("EmailAddress")]
        public string? EmailAddress { get { return this.EmailAddressOption; } set { this.EmailAddressOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExternalCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ExternalCodeOption { get; private set; }

        /// <summary>
        /// The external code. This field is not available in the GUI,  but can be used by the integrating party to reference the contact  person in the external system. The field must be unique (for each contact person).
        /// </summary>
        /// <value>The external code. This field is not available in the GUI,  but can be used by the integrating party to reference the contact  person in the external system. The field must be unique (for each contact person).</value>
        /* <example>123xyz</example> */
        [JsonPropertyName("ExternalCode")]
        public string? ExternalCode { get { return this.ExternalCodeOption; } set { this.ExternalCodeOption = new(value); } }

        /// <summary>
        /// The first name of the contact person.
        /// </summary>
        /// <value>The first name of the contact person.</value>
        /* <example>Espen</example> */
        [JsonPropertyName("FirstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Used to track the state of IsActive
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsActiveOption { get; private set; }

        /// <summary>
        /// A value indicating whether this instance is active. Inactive contact persons disable the usage of that in the GUI.
        /// </summary>
        /// <value>A value indicating whether this instance is active. Inactive contact persons disable the usage of that in the GUI.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get { return this.IsActiveOption; } set { this.IsActiveOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsDefault
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsDefaultOption { get; private set; }

        /// <summary>
        /// A bool indicating whether this contact person is the default contact person.
        /// </summary>
        /// <value>A bool indicating whether this contact person is the default contact person.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsDefault")]
        public bool? IsDefault { get { return this.IsDefaultOption; } set { this.IsDefaultOption = new(value); } }

        /// <summary>
        /// The last name of the contact person.
        /// </summary>
        /// <value>The last name of the contact person.</value>
        /* <example>Askeladd</example> */
        [JsonPropertyName("LastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Used to track the state of MailAddress
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AddressPostDto?> MailAddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets MailAddress
        /// </summary>
        [JsonPropertyName("MailAddress")]
        public AddressPostDto? MailAddress { get { return this.MailAddressOption; } set { this.MailAddressOption = new(value); } }

        /// <summary>
        /// Used to track the state of PhoneNumber
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PhoneNumberOption { get; private set; }

        /// <summary>
        /// The phone number of the contact person.
        /// </summary>
        /// <value>The phone number of the contact person.</value>
        /* <example>+4712345678</example> */
        [JsonPropertyName("PhoneNumber")]
        public string? PhoneNumber { get { return this.PhoneNumberOption; } set { this.PhoneNumberOption = new(value); } }

        /// <summary>
        /// Used to track the state of Title
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TitleOption { get; private set; }

        /// <summary>
        /// The title of the contact person. This might for instance be the job title of the person.
        /// </summary>
        /// <value>The title of the contact person. This might for instance be the job title of the person.</value>
        /* <example>CEO</example> */
        [JsonPropertyName("Title")]
        public string? Title { get { return this.TitleOption; } set { this.TitleOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContactPersonPostDto {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  ExternalCode: ").Append(ExternalCode).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MailAddress: ").Append(MailAddress).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            // ExternalCode (string) maxLength
            if (this.ExternalCode != null && this.ExternalCode.Length > 50)
            {
                yield return new ValidationResult("Invalid value for ExternalCode, length must be less than 50.", new [] { "ExternalCode" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ContactPersonPostDto" />
    /// </summary>
    public class ContactPersonPostDtoJsonConverter : JsonConverter<ContactPersonPostDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="ContactPersonPostDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ContactPersonPostDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> emailAddress = default;
            Option<string?> externalCode = default;
            Option<string?> firstName = default;
            Option<bool?> isActive = default;
            Option<bool?> isDefault = default;
            Option<string?> lastName = default;
            Option<AddressPostDto?> mailAddress = default;
            Option<string?> phoneNumber = default;
            Option<string?> title = default;

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
                        case "EmailAddress":
                            emailAddress = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "ExternalCode":
                            externalCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "FirstName":
                            firstName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "IsDefault":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isDefault = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "LastName":
                            lastName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "MailAddress":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                mailAddress = new Option<AddressPostDto?>(JsonSerializer.Deserialize<AddressPostDto>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "PhoneNumber":
                            phoneNumber = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Title":
                            title = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!firstName.IsSet)
                throw new ArgumentException("Property is required for class ContactPersonPostDto.", nameof(firstName));

            if (!lastName.IsSet)
                throw new ArgumentException("Property is required for class ContactPersonPostDto.", nameof(lastName));

            if (mailAddress.IsSet && mailAddress.Value == null)
                throw new ArgumentNullException(nameof(mailAddress), "Property is not nullable for class ContactPersonPostDto.");

            return new ContactPersonPostDto(emailAddress, externalCode, firstName.Value!, isActive, isDefault, lastName.Value!, mailAddress, phoneNumber, title);
        }

        /// <summary>
        /// Serializes a <see cref="ContactPersonPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="contactPersonPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ContactPersonPostDto contactPersonPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, contactPersonPostDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ContactPersonPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="contactPersonPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ContactPersonPostDto contactPersonPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (contactPersonPostDto.MailAddressOption.IsSet && contactPersonPostDto.MailAddress == null)
                throw new ArgumentNullException(nameof(contactPersonPostDto.MailAddress), "Property is required for class ContactPersonPostDto.");

            if (contactPersonPostDto.EmailAddressOption.IsSet)
                if (contactPersonPostDto.EmailAddressOption.Value != null)
                    writer.WriteString("EmailAddress", contactPersonPostDto.EmailAddress);
                else
                    writer.WriteNull("EmailAddress");

            if (contactPersonPostDto.ExternalCodeOption.IsSet)
                if (contactPersonPostDto.ExternalCodeOption.Value != null)
                    writer.WriteString("ExternalCode", contactPersonPostDto.ExternalCode);
                else
                    writer.WriteNull("ExternalCode");

            if (contactPersonPostDto.FirstName != null)
                writer.WriteString("FirstName", contactPersonPostDto.FirstName);
            else
                writer.WriteNull("FirstName");

            if (contactPersonPostDto.IsActiveOption.IsSet)
                if (contactPersonPostDto.IsActiveOption.Value != null)
                    writer.WriteBoolean("IsActive", contactPersonPostDto.IsActiveOption.Value!.Value);
                else
                    writer.WriteNull("IsActive");

            if (contactPersonPostDto.IsDefaultOption.IsSet)
                if (contactPersonPostDto.IsDefaultOption.Value != null)
                    writer.WriteBoolean("IsDefault", contactPersonPostDto.IsDefaultOption.Value!.Value);
                else
                    writer.WriteNull("IsDefault");

            if (contactPersonPostDto.LastName != null)
                writer.WriteString("LastName", contactPersonPostDto.LastName);
            else
                writer.WriteNull("LastName");

            if (contactPersonPostDto.MailAddressOption.IsSet)
            {
                writer.WritePropertyName("MailAddress");
                JsonSerializer.Serialize(writer, contactPersonPostDto.MailAddress, jsonSerializerOptions);
            }
            if (contactPersonPostDto.PhoneNumberOption.IsSet)
                if (contactPersonPostDto.PhoneNumberOption.Value != null)
                    writer.WriteString("PhoneNumber", contactPersonPostDto.PhoneNumber);
                else
                    writer.WriteNull("PhoneNumber");

            if (contactPersonPostDto.TitleOption.IsSet)
                if (contactPersonPostDto.TitleOption.Value != null)
                    writer.WriteString("Title", contactPersonPostDto.Title);
                else
                    writer.WriteNull("Title");
        }
    }
}

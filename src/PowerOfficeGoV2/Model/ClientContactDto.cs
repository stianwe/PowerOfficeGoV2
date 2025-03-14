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
    /// Client contact is representing a contact of the client.  Usually this is the board of directors and the general manager.
    /// </summary>
    public partial class ClientContactDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContactDto" /> class.
        /// </summary>
        /// <param name="email">The E-mail address registered for the contact.</param>
        /// <param name="firstName">The first name of the contact.</param>
        /// <param name="id">The Id of the contact.</param>
        /// <param name="lastName">The last name of the contact.</param>
        /// <param name="phone">The phone number registered for the contact.</param>
        /// <param name="role">role</param>
        /// <param name="yearOfBirth">The year of birth for the contact.</param>
        [JsonConstructor]
        public ClientContactDto(Option<string?> email = default, Option<string?> firstName = default, Option<long?> id = default, Option<string?> lastName = default, Option<string?> phone = default, Option<ClientContactPersonRole?> role = default, Option<string?> yearOfBirth = default)
        {
            EmailOption = email;
            FirstNameOption = firstName;
            IdOption = id;
            LastNameOption = lastName;
            PhoneOption = phone;
            RoleOption = role;
            YearOfBirthOption = yearOfBirth;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Role
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ClientContactPersonRole?> RoleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [JsonPropertyName("Role")]
        public ClientContactPersonRole? Role { get { return this.RoleOption; } set { this.RoleOption = new(value); } }

        /// <summary>
        /// Used to track the state of Email
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EmailOption { get; }

        /// <summary>
        /// The E-mail address registered for the contact.
        /// </summary>
        /// <value>The E-mail address registered for the contact.</value>
        /* <example>mail@example.com</example> */
        [JsonPropertyName("Email")]
        public string? Email { get { return this.EmailOption; } }

        /// <summary>
        /// Used to track the state of FirstName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FirstNameOption { get; }

        /// <summary>
        /// The first name of the contact.
        /// </summary>
        /// <value>The first name of the contact.</value>
        /* <example>Ola</example> */
        [JsonPropertyName("FirstName")]
        public string? FirstName { get { return this.FirstNameOption; } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; }

        /// <summary>
        /// The Id of the contact.
        /// </summary>
        /// <value>The Id of the contact.</value>
        /* <example>12345</example> */
        [JsonPropertyName("Id")]
        public long? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of LastName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LastNameOption { get; }

        /// <summary>
        /// The last name of the contact.
        /// </summary>
        /// <value>The last name of the contact.</value>
        /* <example>Nordmann</example> */
        [JsonPropertyName("LastName")]
        public string? LastName { get { return this.LastNameOption; } }

        /// <summary>
        /// Used to track the state of Phone
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PhoneOption { get; }

        /// <summary>
        /// The phone number registered for the contact.
        /// </summary>
        /// <value>The phone number registered for the contact.</value>
        /* <example>81549300</example> */
        [JsonPropertyName("Phone")]
        public string? Phone { get { return this.PhoneOption; } }

        /// <summary>
        /// Used to track the state of YearOfBirth
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> YearOfBirthOption { get; }

        /// <summary>
        /// The year of birth for the contact.
        /// </summary>
        /// <value>The year of birth for the contact.</value>
        /* <example>1981</example> */
        [JsonPropertyName("YearOfBirth")]
        public string? YearOfBirth { get { return this.YearOfBirthOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientContactDto {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  YearOfBirth: ").Append(YearOfBirth).Append("\n");
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
    /// A Json converter for type <see cref="ClientContactDto" />
    /// </summary>
    public class ClientContactDtoJsonConverter : JsonConverter<ClientContactDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="ClientContactDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClientContactDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> email = default;
            Option<string?> firstName = default;
            Option<long?> id = default;
            Option<string?> lastName = default;
            Option<string?> phone = default;
            Option<ClientContactPersonRole?> role = default;
            Option<string?> yearOfBirth = default;

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
                        case "Email":
                            email = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "FirstName":
                            firstName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "LastName":
                            lastName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Phone":
                            phone = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Role":
                            string? roleRawValue = utf8JsonReader.GetString();
                            if (roleRawValue != null)
                                role = new Option<ClientContactPersonRole?>(ClientContactPersonRoleValueConverter.FromStringOrDefault(roleRawValue));
                            break;
                        case "YearOfBirth":
                            yearOfBirth = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ClientContactDto.");

            return new ClientContactDto(email, firstName, id, lastName, phone, role, yearOfBirth);
        }

        /// <summary>
        /// Serializes a <see cref="ClientContactDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientContactDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClientContactDto clientContactDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, clientContactDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ClientContactDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientContactDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ClientContactDto clientContactDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (clientContactDto.EmailOption.IsSet)
                if (clientContactDto.EmailOption.Value != null)
                    writer.WriteString("Email", clientContactDto.Email);
                else
                    writer.WriteNull("Email");

            if (clientContactDto.FirstNameOption.IsSet)
                if (clientContactDto.FirstNameOption.Value != null)
                    writer.WriteString("FirstName", clientContactDto.FirstName);
                else
                    writer.WriteNull("FirstName");

            if (clientContactDto.IdOption.IsSet)
                writer.WriteNumber("Id", clientContactDto.IdOption.Value!.Value);

            if (clientContactDto.LastNameOption.IsSet)
                if (clientContactDto.LastNameOption.Value != null)
                    writer.WriteString("LastName", clientContactDto.LastName);
                else
                    writer.WriteNull("LastName");

            if (clientContactDto.PhoneOption.IsSet)
                if (clientContactDto.PhoneOption.Value != null)
                    writer.WriteString("Phone", clientContactDto.Phone);
                else
                    writer.WriteNull("Phone");

            if (clientContactDto.RoleOption.IsSet)
                if (clientContactDto.RoleOption!.Value != null)
                {
                    var roleRawValue = ClientContactPersonRoleValueConverter.ToJsonValue(clientContactDto.RoleOption.Value!.Value);
                    writer.WriteString("Role", roleRawValue);
                }
                else
                    writer.WriteNull("Role");
            if (clientContactDto.YearOfBirthOption.IsSet)
                if (clientContactDto.YearOfBirthOption.Value != null)
                    writer.WriteString("YearOfBirth", clientContactDto.YearOfBirth);
                else
                    writer.WriteNull("YearOfBirth");
        }
    }
}

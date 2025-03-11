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
    /// The available properties for users in Go.
    /// </summary>
    public partial class UserDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDto" /> class.
        /// </summary>
        /// <param name="accessRoleId">The access role id the user have on the client.  Note: Administrator Role always has id: aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa</param>
        /// <param name="emailAddress">The e-mail address of the user.</param>
        /// <param name="firstName">The first name of the user.</param>
        /// <param name="fromDate">From date, inclusive.  The user will have access to the client from this date.  If null, the from date is undefined.</param>
        /// <param name="id">The identifier of the user.  This identifier is unique and assigned by PowerOffice Go when a new user is created.  Will be empty (null) if the user is invited and has not yet accepted. (Status &#x3D; InvitePending)</param>
        /// <param name="lastName">The last name of the user.</param>
        /// <param name="status">status</param>
        /// <param name="toDate">To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client.  If null, the to date is undefined and unrestricted.</param>
        [JsonConstructor]
        public UserDto(Option<Guid?> accessRoleId = default, Option<string?> emailAddress = default, Option<string?> firstName = default, Option<DateTimeOffset?> fromDate = default, Option<Guid?> id = default, Option<string?> lastName = default, Option<UserStatus?> status = default, Option<DateTimeOffset?> toDate = default)
        {
            AccessRoleIdOption = accessRoleId;
            EmailAddressOption = emailAddress;
            FirstNameOption = firstName;
            FromDateOption = fromDate;
            IdOption = id;
            LastNameOption = lastName;
            StatusOption = status;
            ToDateOption = toDate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<UserStatus?> StatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("Status")]
        public UserStatus? Status { get { return this.StatusOption; } set { this.StatusOption = new(value); } }

        /// <summary>
        /// Used to track the state of AccessRoleId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> AccessRoleIdOption { get; }

        /// <summary>
        /// The access role id the user have on the client.  Note: Administrator Role always has id: aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa
        /// </summary>
        /// <value>The access role id the user have on the client.  Note: Administrator Role always has id: aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa</value>
        /* <example>09ab6bcf-4219-4149-8283-6b6a7342bfd9</example> */
        [JsonPropertyName("AccessRoleId")]
        public Guid? AccessRoleId { get { return this.AccessRoleIdOption; } }

        /// <summary>
        /// Used to track the state of EmailAddress
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EmailAddressOption { get; }

        /// <summary>
        /// The e-mail address of the user.
        /// </summary>
        /// <value>The e-mail address of the user.</value>
        /* <example>abc@test.yxz</example> */
        [JsonPropertyName("EmailAddress")]
        public string? EmailAddress { get { return this.EmailAddressOption; } }

        /// <summary>
        /// Used to track the state of FirstName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FirstNameOption { get; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        /// <value>The first name of the user.</value>
        /* <example>Espen</example> */
        [JsonPropertyName("FirstName")]
        public string? FirstName { get { return this.FirstNameOption; } }

        /// <summary>
        /// Used to track the state of FromDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> FromDateOption { get; }

        /// <summary>
        /// From date, inclusive.  The user will have access to the client from this date.  If null, the from date is undefined.
        /// </summary>
        /// <value>From date, inclusive.  The user will have access to the client from this date.  If null, the from date is undefined.</value>
        /* <example>Mon Jan 01 01:00:00 CET 2024</example> */
        [JsonPropertyName("FromDate")]
        public DateTimeOffset? FromDate { get { return this.FromDateOption; } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> IdOption { get; }

        /// <summary>
        /// The identifier of the user.  This identifier is unique and assigned by PowerOffice Go when a new user is created.  Will be empty (null) if the user is invited and has not yet accepted. (Status &#x3D; InvitePending)
        /// </summary>
        /// <value>The identifier of the user.  This identifier is unique and assigned by PowerOffice Go when a new user is created.  Will be empty (null) if the user is invited and has not yet accepted. (Status &#x3D; InvitePending)</value>
        /* <example>ee373540-ca8d-4562-8fb6-6fb52de47722</example> */
        [JsonPropertyName("Id")]
        public Guid? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of LastName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LastNameOption { get; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        /// <value>The last name of the user.</value>
        /* <example>Askeladd</example> */
        [JsonPropertyName("LastName")]
        public string? LastName { get { return this.LastNameOption; } }

        /// <summary>
        /// Used to track the state of ToDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> ToDateOption { get; }

        /// <summary>
        /// To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client.  If null, the to date is undefined and unrestricted.
        /// </summary>
        /// <value>To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client.  If null, the to date is undefined and unrestricted.</value>
        /* <example>Wed Jan 31 01:00:00 CET 2024</example> */
        [JsonPropertyName("ToDate")]
        public DateTimeOffset? ToDate { get { return this.ToDateOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserDto {\n");
            sb.Append("  AccessRoleId: ").Append(AccessRoleId).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
    /// A Json converter for type <see cref="UserDto" />
    /// </summary>
    public class UserDtoJsonConverter : JsonConverter<UserDto>
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
        /// Deserializes json to <see cref="UserDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid?> accessRoleId = default;
            Option<string?> emailAddress = default;
            Option<string?> firstName = default;
            Option<DateTimeOffset?> fromDate = default;
            Option<Guid?> id = default;
            Option<string?> lastName = default;
            Option<UserStatus?> status = default;
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
                        case "AccessRoleId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                accessRoleId = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "EmailAddress":
                            emailAddress = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "FirstName":
                            firstName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "FromDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fromDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "LastName":
                            lastName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<UserStatus?>(UserStatusValueConverter.FromStringOrDefault(statusRawValue));
                            break;
                        case "ToDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                toDate = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            return new UserDto(accessRoleId, emailAddress, firstName, fromDate, id, lastName, status, toDate);
        }

        /// <summary>
        /// Serializes a <see cref="UserDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserDto userDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserDto userDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userDto.AccessRoleIdOption.IsSet)
                if (userDto.AccessRoleIdOption.Value != null)
                    writer.WriteString("AccessRoleId", userDto.AccessRoleIdOption.Value!.Value);
                else
                    writer.WriteNull("AccessRoleId");

            if (userDto.EmailAddressOption.IsSet)
                if (userDto.EmailAddressOption.Value != null)
                    writer.WriteString("EmailAddress", userDto.EmailAddress);
                else
                    writer.WriteNull("EmailAddress");

            if (userDto.FirstNameOption.IsSet)
                if (userDto.FirstNameOption.Value != null)
                    writer.WriteString("FirstName", userDto.FirstName);
                else
                    writer.WriteNull("FirstName");

            if (userDto.FromDateOption.IsSet)
                if (userDto.FromDateOption.Value != null)
                    writer.WriteString("FromDate", userDto.FromDateOption.Value!.Value.ToString(FromDateFormat));
                else
                    writer.WriteNull("FromDate");

            if (userDto.IdOption.IsSet)
                if (userDto.IdOption.Value != null)
                    writer.WriteString("Id", userDto.IdOption.Value!.Value);
                else
                    writer.WriteNull("Id");

            if (userDto.LastNameOption.IsSet)
                if (userDto.LastNameOption.Value != null)
                    writer.WriteString("LastName", userDto.LastName);
                else
                    writer.WriteNull("LastName");

            if (userDto.StatusOption.IsSet)
                if (userDto.StatusOption!.Value != null)
                {
                    var statusRawValue = UserStatusValueConverter.ToJsonValue(userDto.StatusOption.Value!.Value);
                    writer.WriteString("Status", statusRawValue);
                }
                else
                    writer.WriteNull("Status");
            if (userDto.ToDateOption.IsSet)
                if (userDto.ToDateOption.Value != null)
                    writer.WriteString("ToDate", userDto.ToDateOption.Value!.Value.ToString(ToDateFormat));
                else
                    writer.WriteNull("ToDate");
        }
    }
}

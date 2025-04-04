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
    /// The available properties returned when retrieving access roles for a user.
    /// </summary>
    public partial class UserAccessRoleDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccessRoleDto" /> class.
        /// </summary>
        /// <param name="accessRoleId">The identifier of the access role.</param>
        /// <param name="clientId">The identifier of the client.</param>
        /// <param name="clientName">The name of the client.</param>
        [JsonConstructor]
        internal UserAccessRoleDto(Option<Guid?> accessRoleId = default, Option<Guid?> clientId = default, Option<string?> clientName = default)
        {
            AccessRoleIdOption = accessRoleId;
            ClientIdOption = clientId;
            ClientNameOption = clientName;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of AccessRoleId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> AccessRoleIdOption { get; }

        /// <summary>
        /// The identifier of the access role.
        /// </summary>
        /// <value>The identifier of the access role.</value>
        /* <example>09ab6bcf-4219-4149-8283-6b6a7342bfd9</example> */
        [JsonPropertyName("AccessRoleId")]
        public Guid? AccessRoleId { get { return this.AccessRoleIdOption; } }

        /// <summary>
        /// Used to track the state of ClientId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> ClientIdOption { get; }

        /// <summary>
        /// The identifier of the client.
        /// </summary>
        /// <value>The identifier of the client.</value>
        /* <example>09ab6bcf-4219-4149-8283-6b6a7342bfd9</example> */
        [JsonPropertyName("ClientId")]
        public Guid? ClientId { get { return this.ClientIdOption; } }

        /// <summary>
        /// Used to track the state of ClientName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ClientNameOption { get; }

        /// <summary>
        /// The name of the client.
        /// </summary>
        /// <value>The name of the client.</value>
        /* <example>Poweroffice AS</example> */
        [JsonPropertyName("ClientName")]
        public string? ClientName { get { return this.ClientNameOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAccessRoleDto {\n");
            sb.Append("  AccessRoleId: ").Append(AccessRoleId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
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
    /// A Json converter for type <see cref="UserAccessRoleDto" />
    /// </summary>
    public class UserAccessRoleDtoJsonConverter : JsonConverter<UserAccessRoleDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserAccessRoleDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserAccessRoleDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid?> accessRoleId = default;
            Option<Guid?> clientId = default;
            Option<string?> clientName = default;

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
                        case "ClientId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                clientId = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "ClientName":
                            clientName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (clientId.IsSet && clientId.Value == null)
                throw new ArgumentNullException(nameof(clientId), "Property is not nullable for class UserAccessRoleDto.");

            return new UserAccessRoleDto(accessRoleId, clientId, clientName);
        }

        /// <summary>
        /// Serializes a <see cref="UserAccessRoleDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAccessRoleDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserAccessRoleDto userAccessRoleDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userAccessRoleDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserAccessRoleDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAccessRoleDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserAccessRoleDto userAccessRoleDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userAccessRoleDto.AccessRoleIdOption.IsSet)
                if (userAccessRoleDto.AccessRoleIdOption.Value != null)
                    writer.WriteString("AccessRoleId", userAccessRoleDto.AccessRoleIdOption.Value!.Value);
                else
                    writer.WriteNull("AccessRoleId");

            if (userAccessRoleDto.ClientIdOption.IsSet)
                writer.WriteString("ClientId", userAccessRoleDto.ClientIdOption.Value!.Value);

            if (userAccessRoleDto.ClientNameOption.IsSet)
                if (userAccessRoleDto.ClientNameOption.Value != null)
                    writer.WriteString("ClientName", userAccessRoleDto.ClientName);
                else
                    writer.WriteNull("ClientName");
        }
    }
}

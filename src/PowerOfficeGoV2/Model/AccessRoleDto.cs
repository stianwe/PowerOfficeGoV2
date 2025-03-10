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
    /// The available properties returned when retrieving access roles for a client.
    /// </summary>
    public partial class AccessRoleDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRoleDto" /> class.
        /// </summary>
        /// <param name="accessRoleId">The identifier of the access role.</param>
        /// <param name="accessRoleName">The name of the access role.</param>
        [JsonConstructor]
        internal AccessRoleDto(Option<Guid?> accessRoleId = default, Option<string?> accessRoleName = default)
        {
            AccessRoleIdOption = accessRoleId;
            AccessRoleNameOption = accessRoleName;
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
        /// Used to track the state of AccessRoleName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AccessRoleNameOption { get; }

        /// <summary>
        /// The name of the access role.
        /// </summary>
        /// <value>The name of the access role.</value>
        /* <example>980386465</example> */
        [JsonPropertyName("AccessRoleName")]
        public string? AccessRoleName { get { return this.AccessRoleNameOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessRoleDto {\n");
            sb.Append("  AccessRoleId: ").Append(AccessRoleId).Append("\n");
            sb.Append("  AccessRoleName: ").Append(AccessRoleName).Append("\n");
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
    /// A Json converter for type <see cref="AccessRoleDto" />
    /// </summary>
    public class AccessRoleDtoJsonConverter : JsonConverter<AccessRoleDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="AccessRoleDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AccessRoleDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid?> accessRoleId = default;
            Option<string?> accessRoleName = default;

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
                        case "AccessRoleName":
                            accessRoleName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (accessRoleId.IsSet && accessRoleId.Value == null)
                throw new ArgumentNullException(nameof(accessRoleId), "Property is not nullable for class AccessRoleDto.");

            return new AccessRoleDto(accessRoleId, accessRoleName);
        }

        /// <summary>
        /// Serializes a <see cref="AccessRoleDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="accessRoleDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AccessRoleDto accessRoleDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, accessRoleDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AccessRoleDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="accessRoleDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AccessRoleDto accessRoleDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (accessRoleDto.AccessRoleIdOption.IsSet)
                writer.WriteString("AccessRoleId", accessRoleDto.AccessRoleIdOption.Value!.Value);

            if (accessRoleDto.AccessRoleNameOption.IsSet)
                if (accessRoleDto.AccessRoleNameOption.Value != null)
                    writer.WriteString("AccessRoleName", accessRoleDto.AccessRoleName);
                else
                    writer.WriteNull("AccessRoleName");
        }
    }
}

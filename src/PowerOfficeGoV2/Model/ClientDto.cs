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
    /// The available properties returned after creating a new client.
    /// </summary>
    public partial class ClientDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDto" /> class.
        /// </summary>
        /// <param name="clientName">The name of the client.</param>
        /// <param name="id">The unique identifier that the new client has in Go.</param>
        /// <param name="isActive">Value indicating whether the client is active or not in Go.</param>
        /// <param name="organizationNumber">The organization number of the client.</param>
        [JsonConstructor]
        internal ClientDto(Option<string?> clientName = default, Option<Guid?> id = default, Option<bool?> isActive = default, Option<string?> organizationNumber = default)
        {
            ClientNameOption = clientName;
            IdOption = id;
            IsActiveOption = isActive;
            OrganizationNumberOption = organizationNumber;
            OnCreated();
        }

        partial void OnCreated();

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
        /* <example>Office Power</example> */
        [JsonPropertyName("ClientName")]
        public string? ClientName { get { return this.ClientNameOption; } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> IdOption { get; }

        /// <summary>
        /// The unique identifier that the new client has in Go.
        /// </summary>
        /// <value>The unique identifier that the new client has in Go.</value>
        /* <example>09ab6bcf-4219-4149-8283-6b6a7342bfd9</example> */
        [JsonPropertyName("Id")]
        public Guid? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of IsActive
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsActiveOption { get; }

        /// <summary>
        /// Value indicating whether the client is active or not in Go.
        /// </summary>
        /// <value>Value indicating whether the client is active or not in Go.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get { return this.IsActiveOption; } }

        /// <summary>
        /// Used to track the state of OrganizationNumber
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OrganizationNumberOption { get; }

        /// <summary>
        /// The organization number of the client.
        /// </summary>
        /// <value>The organization number of the client.</value>
        /* <example>980386465</example> */
        [JsonPropertyName("OrganizationNumber")]
        public string? OrganizationNumber { get { return this.OrganizationNumberOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientDto {\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  OrganizationNumber: ").Append(OrganizationNumber).Append("\n");
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
    /// A Json converter for type <see cref="ClientDto" />
    /// </summary>
    public class ClientDtoJsonConverter : JsonConverter<ClientDto>
    {
        /// <summary>
        /// Deserializes json to <see cref="ClientDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClientDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> clientName = default;
            Option<Guid?> id = default;
            Option<bool?> isActive = default;
            Option<string?> organizationNumber = default;

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
                        case "ClientName":
                            clientName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "IsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isActive = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "OrganizationNumber":
                            organizationNumber = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ClientDto.");

            if (isActive.IsSet && isActive.Value == null)
                throw new ArgumentNullException(nameof(isActive), "Property is not nullable for class ClientDto.");

            return new ClientDto(clientName, id, isActive, organizationNumber);
        }

        /// <summary>
        /// Serializes a <see cref="ClientDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClientDto clientDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, clientDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ClientDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ClientDto clientDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (clientDto.ClientNameOption.IsSet)
                if (clientDto.ClientNameOption.Value != null)
                    writer.WriteString("ClientName", clientDto.ClientName);
                else
                    writer.WriteNull("ClientName");

            if (clientDto.IdOption.IsSet)
                writer.WriteString("Id", clientDto.IdOption.Value!.Value);

            if (clientDto.IsActiveOption.IsSet)
                writer.WriteBoolean("IsActive", clientDto.IsActiveOption.Value!.Value);

            if (clientDto.OrganizationNumberOption.IsSet)
                if (clientDto.OrganizationNumberOption.Value != null)
                    writer.WriteString("OrganizationNumber", clientDto.OrganizationNumber);
                else
                    writer.WriteNull("OrganizationNumber");
        }
    }
}

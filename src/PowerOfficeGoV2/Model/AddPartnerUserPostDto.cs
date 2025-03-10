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
    /// The available properties for adding a partner user to a client.
    /// </summary>
    public partial class AddPartnerUserPostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPartnerUserPostDto" /> class.
        /// </summary>
        /// <param name="accessRoleId">The access role id the user should have on the client.</param>
        /// <param name="partnerUserId">The existing partner user that should be added to the client.</param>
        /// <param name="fromDate">From date, inclusive.  The user will have access to the client from this date.</param>
        /// <param name="toDate">To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client.</param>
        [JsonConstructor]
        public AddPartnerUserPostDto(Guid accessRoleId, Guid partnerUserId, Option<DateOnly?> fromDate = default, Option<DateOnly?> toDate = default)
        {
            AccessRoleId = accessRoleId;
            PartnerUserId = partnerUserId;
            FromDateOption = fromDate;
            ToDateOption = toDate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The access role id the user should have on the client.
        /// </summary>
        /// <value>The access role id the user should have on the client.</value>
        /* <example>09ab6bcf-4219-4149-8283-6b6a7342bfd9</example> */
        [JsonPropertyName("AccessRoleId")]
        public Guid AccessRoleId { get; set; }

        /// <summary>
        /// The existing partner user that should be added to the client.
        /// </summary>
        /// <value>The existing partner user that should be added to the client.</value>
        /* <example>ee373540-ca8d-4562-8fb6-6fb52de47722</example> */
        [JsonPropertyName("PartnerUserId")]
        public Guid PartnerUserId { get; set; }

        /// <summary>
        /// Used to track the state of FromDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> FromDateOption { get; private set; }

        /// <summary>
        /// From date, inclusive.  The user will have access to the client from this date.
        /// </summary>
        /// <value>From date, inclusive.  The user will have access to the client from this date.</value>
        /* <example>Mon Jan 01 01:00:00 CET 2024</example> */
        [JsonPropertyName("FromDate")]
        public DateOnly? FromDate { get { return this.FromDateOption; } set { this.FromDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of ToDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> ToDateOption { get; private set; }

        /// <summary>
        /// To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client.
        /// </summary>
        /// <value>To date, inclusive.  The user will have access to the client until and including this date.  Afterwards, the user is deactivated on the client.</value>
        /* <example>Wed Jan 31 01:00:00 CET 2024</example> */
        [JsonPropertyName("ToDate")]
        public DateOnly? ToDate { get { return this.ToDateOption; } set { this.ToDateOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddPartnerUserPostDto {\n");
            sb.Append("  AccessRoleId: ").Append(AccessRoleId).Append("\n");
            sb.Append("  PartnerUserId: ").Append(PartnerUserId).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
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
    /// A Json converter for type <see cref="AddPartnerUserPostDto" />
    /// </summary>
    public class AddPartnerUserPostDtoJsonConverter : JsonConverter<AddPartnerUserPostDto>
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
        /// Deserializes json to <see cref="AddPartnerUserPostDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AddPartnerUserPostDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid?> accessRoleId = default;
            Option<Guid?> partnerUserId = default;
            Option<DateOnly?> fromDate = default;
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
                        case "AccessRoleId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                accessRoleId = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "PartnerUserId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                partnerUserId = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "FromDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fromDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "ToDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                toDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!accessRoleId.IsSet)
                throw new ArgumentException("Property is required for class AddPartnerUserPostDto.", nameof(accessRoleId));

            if (!partnerUserId.IsSet)
                throw new ArgumentException("Property is required for class AddPartnerUserPostDto.", nameof(partnerUserId));

            if (accessRoleId.IsSet && accessRoleId.Value == null)
                throw new ArgumentNullException(nameof(accessRoleId), "Property is not nullable for class AddPartnerUserPostDto.");

            if (partnerUserId.IsSet && partnerUserId.Value == null)
                throw new ArgumentNullException(nameof(partnerUserId), "Property is not nullable for class AddPartnerUserPostDto.");

            return new AddPartnerUserPostDto(accessRoleId.Value!.Value!, partnerUserId.Value!.Value!, fromDate, toDate);
        }

        /// <summary>
        /// Serializes a <see cref="AddPartnerUserPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addPartnerUserPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AddPartnerUserPostDto addPartnerUserPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, addPartnerUserPostDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AddPartnerUserPostDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addPartnerUserPostDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AddPartnerUserPostDto addPartnerUserPostDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("AccessRoleId", addPartnerUserPostDto.AccessRoleId);

            writer.WriteString("PartnerUserId", addPartnerUserPostDto.PartnerUserId);

            if (addPartnerUserPostDto.FromDateOption.IsSet)
                if (addPartnerUserPostDto.FromDateOption.Value != null)
                    writer.WriteString("FromDate", addPartnerUserPostDto.FromDateOption.Value!.Value.ToString(FromDateFormat));
                else
                    writer.WriteNull("FromDate");

            if (addPartnerUserPostDto.ToDateOption.IsSet)
                if (addPartnerUserPostDto.ToDateOption.Value != null)
                    writer.WriteString("ToDate", addPartnerUserPostDto.ToDateOption.Value!.Value.ToString(ToDateFormat));
                else
                    writer.WriteNull("ToDate");
        }
    }
}

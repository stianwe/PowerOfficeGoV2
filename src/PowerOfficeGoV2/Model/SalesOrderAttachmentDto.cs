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
    /// A SalesOrderAttachment DTO.
    /// </summary>
    public partial class SalesOrderAttachmentDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderAttachmentDto" /> class.
        /// </summary>
        /// <param name="createdDateTimeOffset">Created date time offset. Date in UTC time.</param>
        /// <param name="fileName">Name of the file, including file extension. File name and extension is extracted from the uploaded file.</param>
        /// <param name="fileSize">File size in bytes.</param>
        /// <param name="id">The identifier of the sales order attachment.</param>
        /// <param name="lastChangedDateTimeOffset">Last changed date time offset. Date in UTC time.</param>
        /// <param name="salesOrderId">Id of the sales order the attachment belongs to.</param>
        [JsonConstructor]
        public SalesOrderAttachmentDto(Option<DateTimeOffset?> createdDateTimeOffset = default, Option<string?> fileName = default, Option<long?> fileSize = default, Option<long?> id = default, Option<DateTimeOffset?> lastChangedDateTimeOffset = default, Option<Guid?> salesOrderId = default)
        {
            CreatedDateTimeOffsetOption = createdDateTimeOffset;
            FileNameOption = fileName;
            FileSizeOption = fileSize;
            IdOption = id;
            LastChangedDateTimeOffsetOption = lastChangedDateTimeOffset;
            SalesOrderIdOption = salesOrderId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CreatedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> CreatedDateTimeOffsetOption { get; }

        /// <summary>
        /// Created date time offset. Date in UTC time.
        /// </summary>
        /// <value>Created date time offset. Date in UTC time.</value>
        /* <example>2023-12-20T14:32:15.132079600Z</example> */
        [JsonPropertyName("CreatedDateTimeOffset")]
        public DateTimeOffset? CreatedDateTimeOffset { get { return this.CreatedDateTimeOffsetOption; } }

        /// <summary>
        /// Used to track the state of FileName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FileNameOption { get; private set; }

        /// <summary>
        /// Name of the file, including file extension. File name and extension is extracted from the uploaded file.
        /// </summary>
        /// <value>Name of the file, including file extension. File name and extension is extracted from the uploaded file.</value>
        /* <example>Timetrackingreport.pdf</example> */
        [JsonPropertyName("FileName")]
        public string? FileName { get { return this.FileNameOption; } set { this.FileNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of FileSize
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> FileSizeOption { get; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        /// <value>File size in bytes.</value>
        /* <example>256</example> */
        [JsonPropertyName("FileSize")]
        public long? FileSize { get { return this.FileSizeOption; } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; }

        /// <summary>
        /// The identifier of the sales order attachment.
        /// </summary>
        /// <value>The identifier of the sales order attachment.</value>
        /* <example>12345</example> */
        [JsonPropertyName("Id")]
        public long? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of LastChangedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> LastChangedDateTimeOffsetOption { get; }

        /// <summary>
        /// Last changed date time offset. Date in UTC time.
        /// </summary>
        /// <value>Last changed date time offset. Date in UTC time.</value>
        /* <example>2023-12-20T14:32:15.132079600Z</example> */
        [JsonPropertyName("LastChangedDateTimeOffset")]
        public DateTimeOffset? LastChangedDateTimeOffset { get { return this.LastChangedDateTimeOffsetOption; } }

        /// <summary>
        /// Used to track the state of SalesOrderId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> SalesOrderIdOption { get; private set; }

        /// <summary>
        /// Id of the sales order the attachment belongs to.
        /// </summary>
        /// <value>Id of the sales order the attachment belongs to.</value>
        [JsonPropertyName("SalesOrderId")]
        public Guid? SalesOrderId { get { return this.SalesOrderIdOption; } set { this.SalesOrderIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesOrderAttachmentDto {\n");
            sb.Append("  CreatedDateTimeOffset: ").Append(CreatedDateTimeOffset).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastChangedDateTimeOffset: ").Append(LastChangedDateTimeOffset).Append("\n");
            sb.Append("  SalesOrderId: ").Append(SalesOrderId).Append("\n");
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
    /// A Json converter for type <see cref="SalesOrderAttachmentDto" />
    /// </summary>
    public class SalesOrderAttachmentDtoJsonConverter : JsonConverter<SalesOrderAttachmentDto>
    {
        /// <summary>
        /// The format to use to serialize CreatedDateTimeOffset
        /// </summary>
        public static string CreatedDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize LastChangedDateTimeOffset
        /// </summary>
        public static string LastChangedDateTimeOffsetFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="SalesOrderAttachmentDto" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SalesOrderAttachmentDto Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTimeOffset?> createdDateTimeOffset = default;
            Option<string?> fileName = default;
            Option<long?> fileSize = default;
            Option<long?> id = default;
            Option<DateTimeOffset?> lastChangedDateTimeOffset = default;
            Option<Guid?> salesOrderId = default;

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
                        case "CreatedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdDateTimeOffset = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "FileName":
                            fileName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "FileSize":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fileSize = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "LastChangedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastChangedDateTimeOffset = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "SalesOrderId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                salesOrderId = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createdDateTimeOffset.IsSet && createdDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(createdDateTimeOffset), "Property is not nullable for class SalesOrderAttachmentDto.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class SalesOrderAttachmentDto.");

            if (lastChangedDateTimeOffset.IsSet && lastChangedDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(lastChangedDateTimeOffset), "Property is not nullable for class SalesOrderAttachmentDto.");

            return new SalesOrderAttachmentDto(createdDateTimeOffset, fileName, fileSize, id, lastChangedDateTimeOffset, salesOrderId);
        }

        /// <summary>
        /// Serializes a <see cref="SalesOrderAttachmentDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="salesOrderAttachmentDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SalesOrderAttachmentDto salesOrderAttachmentDto, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, salesOrderAttachmentDto, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SalesOrderAttachmentDto" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="salesOrderAttachmentDto"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SalesOrderAttachmentDto salesOrderAttachmentDto, JsonSerializerOptions jsonSerializerOptions)
        {
            if (salesOrderAttachmentDto.CreatedDateTimeOffsetOption.IsSet)
                writer.WriteString("CreatedDateTimeOffset", salesOrderAttachmentDto.CreatedDateTimeOffsetOption.Value!.Value.ToString(CreatedDateTimeOffsetFormat));

            if (salesOrderAttachmentDto.FileNameOption.IsSet)
                if (salesOrderAttachmentDto.FileNameOption.Value != null)
                    writer.WriteString("FileName", salesOrderAttachmentDto.FileName);
                else
                    writer.WriteNull("FileName");

            if (salesOrderAttachmentDto.FileSizeOption.IsSet)
                if (salesOrderAttachmentDto.FileSizeOption.Value != null)
                    writer.WriteNumber("FileSize", salesOrderAttachmentDto.FileSizeOption.Value!.Value);
                else
                    writer.WriteNull("FileSize");

            if (salesOrderAttachmentDto.IdOption.IsSet)
                writer.WriteNumber("Id", salesOrderAttachmentDto.IdOption.Value!.Value);

            if (salesOrderAttachmentDto.LastChangedDateTimeOffsetOption.IsSet)
                writer.WriteString("LastChangedDateTimeOffset", salesOrderAttachmentDto.LastChangedDateTimeOffsetOption.Value!.Value.ToString(LastChangedDateTimeOffsetFormat));

            if (salesOrderAttachmentDto.SalesOrderIdOption.IsSet)
                if (salesOrderAttachmentDto.SalesOrderIdOption.Value != null)
                    writer.WriteString("SalesOrderId", salesOrderAttachmentDto.SalesOrderIdOption.Value!.Value);
                else
                    writer.WriteNull("SalesOrderId");
        }
    }
}

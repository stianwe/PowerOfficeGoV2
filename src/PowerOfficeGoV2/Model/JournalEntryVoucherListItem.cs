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
    /// Properties of journal entry vouchers list item.
    /// </summary>
    public partial class JournalEntryVoucherListItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryVoucherListItem" /> class.
        /// </summary>
        /// <param name="createdDateTimeOffset">The timestamp of when the voucher object was created.</param>
        /// <param name="id">A value that uniquely identifies this voucher.  The Id is assigned by Go when the entry is created, and will persist when/if the voucher is posted.</param>
        /// <param name="inApprovalWorkflow">Indicates whether the journal entry voucher is sent to approval and is in the approval workflow.  If true, the voucher cannot be deleted.</param>
        /// <param name="isCreatedByCurrentIntegration">Indicates whether the querying integration created the journal entry voucher, in which case the value is true.</param>
        /// <param name="isPosted">Indicates whether the journal entry voucher is posted. If true, the voucher is posted an cannot be deleted via api or edited by a user in the GUI.  If false, the voucher is unposted.  If true, the voucher cannot be deleted.</param>
        /// <param name="lastChangedDateTimeOffset">The timestamp of the last change of voucher.</param>
        /// <param name="originatedFromEhf">Indicates whether the journal entry voucher was received by EHF. If true, the journal entry voucher have an EHF XML file.</param>
        /// <param name="voucherType">voucherType</param>
        [JsonConstructor]
        public JournalEntryVoucherListItem(Option<DateTimeOffset?> createdDateTimeOffset = default, Option<Guid?> id = default, Option<bool?> inApprovalWorkflow = default, Option<bool?> isCreatedByCurrentIntegration = default, Option<bool?> isPosted = default, Option<DateTimeOffset?> lastChangedDateTimeOffset = default, Option<bool?> originatedFromEhf = default, Option<VoucherType?> voucherType = default)
        {
            CreatedDateTimeOffsetOption = createdDateTimeOffset;
            IdOption = id;
            InApprovalWorkflowOption = inApprovalWorkflow;
            IsCreatedByCurrentIntegrationOption = isCreatedByCurrentIntegration;
            IsPostedOption = isPosted;
            LastChangedDateTimeOffsetOption = lastChangedDateTimeOffset;
            OriginatedFromEhfOption = originatedFromEhf;
            VoucherTypeOption = voucherType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of VoucherType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<VoucherType?> VoucherTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets VoucherType
        /// </summary>
        [JsonPropertyName("VoucherType")]
        public VoucherType? VoucherType { get { return this.VoucherTypeOption; } set { this.VoucherTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreatedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> CreatedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp of when the voucher object was created.
        /// </summary>
        /// <value>The timestamp of when the voucher object was created.</value>
        /* <example>2024-06-25T12:06:00.123456700Z</example> */
        [JsonPropertyName("CreatedDateTimeOffset")]
        public DateTimeOffset? CreatedDateTimeOffset { get { return this.CreatedDateTimeOffsetOption; } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> IdOption { get; }

        /// <summary>
        /// A value that uniquely identifies this voucher.  The Id is assigned by Go when the entry is created, and will persist when/if the voucher is posted.
        /// </summary>
        /// <value>A value that uniquely identifies this voucher.  The Id is assigned by Go when the entry is created, and will persist when/if the voucher is posted.</value>
        /* <example>38ecfc1a-bf51-448f-99a8-a61bc5771109</example> */
        [JsonPropertyName("Id")]
        public Guid? Id { get { return this.IdOption; } }

        /// <summary>
        /// Used to track the state of InApprovalWorkflow
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> InApprovalWorkflowOption { get; }

        /// <summary>
        /// Indicates whether the journal entry voucher is sent to approval and is in the approval workflow.  If true, the voucher cannot be deleted.
        /// </summary>
        /// <value>Indicates whether the journal entry voucher is sent to approval and is in the approval workflow.  If true, the voucher cannot be deleted.</value>
        /* <example>false</example> */
        [JsonPropertyName("InApprovalWorkflow")]
        public bool? InApprovalWorkflow { get { return this.InApprovalWorkflowOption; } }

        /// <summary>
        /// Used to track the state of IsCreatedByCurrentIntegration
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsCreatedByCurrentIntegrationOption { get; }

        /// <summary>
        /// Indicates whether the querying integration created the journal entry voucher, in which case the value is true.
        /// </summary>
        /// <value>Indicates whether the querying integration created the journal entry voucher, in which case the value is true.</value>
        /* <example>true</example> */
        [JsonPropertyName("IsCreatedByCurrentIntegration")]
        public bool? IsCreatedByCurrentIntegration { get { return this.IsCreatedByCurrentIntegrationOption; } }

        /// <summary>
        /// Used to track the state of IsPosted
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsPostedOption { get; }

        /// <summary>
        /// Indicates whether the journal entry voucher is posted. If true, the voucher is posted an cannot be deleted via api or edited by a user in the GUI.  If false, the voucher is unposted.  If true, the voucher cannot be deleted.
        /// </summary>
        /// <value>Indicates whether the journal entry voucher is posted. If true, the voucher is posted an cannot be deleted via api or edited by a user in the GUI.  If false, the voucher is unposted.  If true, the voucher cannot be deleted.</value>
        /* <example>false</example> */
        [JsonPropertyName("IsPosted")]
        public bool? IsPosted { get { return this.IsPostedOption; } }

        /// <summary>
        /// Used to track the state of LastChangedDateTimeOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> LastChangedDateTimeOffsetOption { get; }

        /// <summary>
        /// The timestamp of the last change of voucher.
        /// </summary>
        /// <value>The timestamp of the last change of voucher.</value>
        /* <example>2024-07-09T13:03:00.123456700Z</example> */
        [JsonPropertyName("LastChangedDateTimeOffset")]
        public DateTimeOffset? LastChangedDateTimeOffset { get { return this.LastChangedDateTimeOffsetOption; } }

        /// <summary>
        /// Used to track the state of OriginatedFromEhf
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> OriginatedFromEhfOption { get; }

        /// <summary>
        /// Indicates whether the journal entry voucher was received by EHF. If true, the journal entry voucher have an EHF XML file.
        /// </summary>
        /// <value>Indicates whether the journal entry voucher was received by EHF. If true, the journal entry voucher have an EHF XML file.</value>
        /* <example>true</example> */
        [JsonPropertyName("OriginatedFromEhf")]
        public bool? OriginatedFromEhf { get { return this.OriginatedFromEhfOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JournalEntryVoucherListItem {\n");
            sb.Append("  CreatedDateTimeOffset: ").Append(CreatedDateTimeOffset).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InApprovalWorkflow: ").Append(InApprovalWorkflow).Append("\n");
            sb.Append("  IsCreatedByCurrentIntegration: ").Append(IsCreatedByCurrentIntegration).Append("\n");
            sb.Append("  IsPosted: ").Append(IsPosted).Append("\n");
            sb.Append("  LastChangedDateTimeOffset: ").Append(LastChangedDateTimeOffset).Append("\n");
            sb.Append("  OriginatedFromEhf: ").Append(OriginatedFromEhf).Append("\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
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
    /// A Json converter for type <see cref="JournalEntryVoucherListItem" />
    /// </summary>
    public class JournalEntryVoucherListItemJsonConverter : JsonConverter<JournalEntryVoucherListItem>
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
        /// Deserializes json to <see cref="JournalEntryVoucherListItem" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override JournalEntryVoucherListItem Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTimeOffset?> createdDateTimeOffset = default;
            Option<Guid?> id = default;
            Option<bool?> inApprovalWorkflow = default;
            Option<bool?> isCreatedByCurrentIntegration = default;
            Option<bool?> isPosted = default;
            Option<DateTimeOffset?> lastChangedDateTimeOffset = default;
            Option<bool?> originatedFromEhf = default;
            Option<VoucherType?> voucherType = default;

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
                        case "Id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "InApprovalWorkflow":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                inApprovalWorkflow = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "IsCreatedByCurrentIntegration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isCreatedByCurrentIntegration = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "IsPosted":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isPosted = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "LastChangedDateTimeOffset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastChangedDateTimeOffset = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "OriginatedFromEhf":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                originatedFromEhf = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "VoucherType":
                            string? voucherTypeRawValue = utf8JsonReader.GetString();
                            if (voucherTypeRawValue != null)
                                voucherType = new Option<VoucherType?>(VoucherTypeValueConverter.FromStringOrDefault(voucherTypeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createdDateTimeOffset.IsSet && createdDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(createdDateTimeOffset), "Property is not nullable for class JournalEntryVoucherListItem.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class JournalEntryVoucherListItem.");

            if (inApprovalWorkflow.IsSet && inApprovalWorkflow.Value == null)
                throw new ArgumentNullException(nameof(inApprovalWorkflow), "Property is not nullable for class JournalEntryVoucherListItem.");

            if (lastChangedDateTimeOffset.IsSet && lastChangedDateTimeOffset.Value == null)
                throw new ArgumentNullException(nameof(lastChangedDateTimeOffset), "Property is not nullable for class JournalEntryVoucherListItem.");

            return new JournalEntryVoucherListItem(createdDateTimeOffset, id, inApprovalWorkflow, isCreatedByCurrentIntegration, isPosted, lastChangedDateTimeOffset, originatedFromEhf, voucherType);
        }

        /// <summary>
        /// Serializes a <see cref="JournalEntryVoucherListItem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="journalEntryVoucherListItem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, JournalEntryVoucherListItem journalEntryVoucherListItem, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, journalEntryVoucherListItem, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="JournalEntryVoucherListItem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="journalEntryVoucherListItem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, JournalEntryVoucherListItem journalEntryVoucherListItem, JsonSerializerOptions jsonSerializerOptions)
        {
            if (journalEntryVoucherListItem.CreatedDateTimeOffsetOption.IsSet)
                writer.WriteString("CreatedDateTimeOffset", journalEntryVoucherListItem.CreatedDateTimeOffsetOption.Value!.Value.ToString(CreatedDateTimeOffsetFormat));

            if (journalEntryVoucherListItem.IdOption.IsSet)
                writer.WriteString("Id", journalEntryVoucherListItem.IdOption.Value!.Value);

            if (journalEntryVoucherListItem.InApprovalWorkflowOption.IsSet)
                writer.WriteBoolean("InApprovalWorkflow", journalEntryVoucherListItem.InApprovalWorkflowOption.Value!.Value);

            if (journalEntryVoucherListItem.IsCreatedByCurrentIntegrationOption.IsSet)
                if (journalEntryVoucherListItem.IsCreatedByCurrentIntegrationOption.Value != null)
                    writer.WriteBoolean("IsCreatedByCurrentIntegration", journalEntryVoucherListItem.IsCreatedByCurrentIntegrationOption.Value!.Value);
                else
                    writer.WriteNull("IsCreatedByCurrentIntegration");

            if (journalEntryVoucherListItem.IsPostedOption.IsSet)
                if (journalEntryVoucherListItem.IsPostedOption.Value != null)
                    writer.WriteBoolean("IsPosted", journalEntryVoucherListItem.IsPostedOption.Value!.Value);
                else
                    writer.WriteNull("IsPosted");

            if (journalEntryVoucherListItem.LastChangedDateTimeOffsetOption.IsSet)
                writer.WriteString("LastChangedDateTimeOffset", journalEntryVoucherListItem.LastChangedDateTimeOffsetOption.Value!.Value.ToString(LastChangedDateTimeOffsetFormat));

            if (journalEntryVoucherListItem.OriginatedFromEhfOption.IsSet)
                if (journalEntryVoucherListItem.OriginatedFromEhfOption.Value != null)
                    writer.WriteBoolean("OriginatedFromEhf", journalEntryVoucherListItem.OriginatedFromEhfOption.Value!.Value);
                else
                    writer.WriteNull("OriginatedFromEhf");

            if (journalEntryVoucherListItem.VoucherTypeOption.IsSet)
                if (journalEntryVoucherListItem.VoucherTypeOption!.Value != null)
                {
                    var voucherTypeRawValue = VoucherTypeValueConverter.ToJsonValue(journalEntryVoucherListItem.VoucherTypeOption.Value!.Value);
                    writer.WriteString("VoucherType", voucherTypeRawValue);
                }
                else
                    writer.WriteNull("VoucherType");
        }
    }
}

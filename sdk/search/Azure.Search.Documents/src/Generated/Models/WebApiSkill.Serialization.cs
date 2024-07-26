// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class WebApiSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BatchSize))
            {
                if (BatchSize != null)
                {
                    writer.WritePropertyName("batchSize"u8);
                    writer.WriteNumberValue(BatchSize.Value);
                }
                else
                {
                    writer.WriteNull("batchSize");
                }
            }
            if (Optional.IsDefined(DegreeOfParallelism))
            {
                if (DegreeOfParallelism != null)
                {
                    writer.WritePropertyName("degreeOfParallelism"u8);
                    writer.WriteNumberValue(DegreeOfParallelism.Value);
                }
                else
                {
                    writer.WriteNull("degreeOfParallelism");
                }
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri);
            }
            if (Optional.IsCollectionDefined(HttpHeaders))
            {
                writer.WritePropertyName("httpHeaders"u8);
                writer.WriteStartObject();
                foreach (var item in HttpHeaders)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(HttpMethod))
            {
                writer.WritePropertyName("httpMethod"u8);
                writer.WriteStringValue(HttpMethod);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
            }
            if (Optional.IsDefined(AuthResourceId))
            {
                if (AuthResourceId != null)
                {
                    writer.WritePropertyName("authResourceId"u8);
                    writer.WriteStringValue(AuthResourceId);
                }
                else
                {
                    writer.WriteNull("authResourceId");
                }
            }
            if (Optional.IsDefined(AuthIdentity))
            {
                if (AuthIdentity != null)
                {
                    writer.WritePropertyName("authIdentity"u8);
                    writer.WriteObjectValue(AuthIdentity);
                }
                else
                {
                    writer.WriteNull("authIdentity");
                }
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue<InputFieldMappingEntry>(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue<OutputFieldMappingEntry>(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static WebApiSkill DeserializeWebApiSkill(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? batchSize = default;
            int? degreeOfParallelism = default;
            string uri = default;
            IDictionary<string, string> httpHeaders = default;
            string httpMethod = default;
            TimeSpan? timeout = default;
            ResourceIdentifier authResourceId = default;
            SearchIndexerDataIdentity authIdentity = default;
            string odataType = default;
            string name = default;
            string description = default;
            string context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        batchSize = null;
                        continue;
                    }
                    batchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("degreeOfParallelism"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        degreeOfParallelism = null;
                        continue;
                    }
                    degreeOfParallelism = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    httpHeaders = dictionary;
                    continue;
                }
                if (property.NameEquals("httpMethod"u8))
                {
                    httpMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("authResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authResourceId = null;
                        continue;
                    }
                    authResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authIdentity = null;
                        continue;
                    }
                    authIdentity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
            }
            return new WebApiSkill(
                odataType,
                name,
                description,
                context,
                inputs,
                outputs,
                batchSize,
                degreeOfParallelism,
                uri,
                httpHeaders ?? new ChangeTrackingDictionary<string, string>(),
                httpMethod,
                timeout,
                authResourceId,
                authIdentity);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WebApiSkill FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWebApiSkill(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}

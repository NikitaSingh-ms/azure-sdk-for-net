// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class DeploymentStackResource : IJsonModel<DeploymentStackData>
    {
        void IJsonModel<DeploymentStackData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DeploymentStackData>)Data).Write(writer, options);

        DeploymentStackData IJsonModel<DeploymentStackData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DeploymentStackData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DeploymentStackData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DeploymentStackData IPersistableModel<DeploymentStackData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DeploymentStackData>(data, options);

        string IPersistableModel<DeploymentStackData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DeploymentStackData>)Data).GetFormatFromOptions(options);
    }
}

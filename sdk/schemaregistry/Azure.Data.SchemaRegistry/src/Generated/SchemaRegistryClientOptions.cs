// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Data.SchemaRegistry
{
    /// <summary> Client options for SchemaRegistryClient. </summary>
    public partial class SchemaRegistryClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2023_07_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2021-10". </summary>
            V2021_10 = 1,
            /// <summary> Service version "2022-10". </summary>
            V2022_10 = 2,
            /// <summary> Service version "2023-07-01". </summary>
            V2023_07_01 = 3,
        }
    }
}

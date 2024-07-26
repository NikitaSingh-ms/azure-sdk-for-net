// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The Azure Open AI model name that will be called. </summary>
    public readonly partial struct AzureOpenAIModelName : IEquatable<AzureOpenAIModelName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureOpenAIModelName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureOpenAIModelName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextEmbeddingAda002Value = "text-embedding-ada-002";
        private const string TextEmbedding3LargeValue = "text-embedding-3-large";
        private const string TextEmbedding3SmallValue = "text-embedding-3-small";

        /// <summary> text-embedding-ada-002. </summary>
        public static AzureOpenAIModelName TextEmbeddingAda002 { get; } = new AzureOpenAIModelName(TextEmbeddingAda002Value);
        /// <summary> text-embedding-3-large. </summary>
        public static AzureOpenAIModelName TextEmbedding3Large { get; } = new AzureOpenAIModelName(TextEmbedding3LargeValue);
        /// <summary> text-embedding-3-small. </summary>
        public static AzureOpenAIModelName TextEmbedding3Small { get; } = new AzureOpenAIModelName(TextEmbedding3SmallValue);
        /// <summary> Determines if two <see cref="AzureOpenAIModelName"/> values are the same. </summary>
        public static bool operator ==(AzureOpenAIModelName left, AzureOpenAIModelName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureOpenAIModelName"/> values are not the same. </summary>
        public static bool operator !=(AzureOpenAIModelName left, AzureOpenAIModelName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureOpenAIModelName"/>. </summary>
        public static implicit operator AzureOpenAIModelName(string value) => new AzureOpenAIModelName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureOpenAIModelName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureOpenAIModelName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualNetworkResource"/> and their operations.
    /// Each <see cref="VirtualNetworkResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VirtualNetworkCollection"/> instance call the GetVirtualNetworks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VirtualNetworkCollection : ArmCollection, IEnumerable<VirtualNetworkResource>, IAsyncEnumerable<VirtualNetworkResource>
    {
        private readonly ClientDiagnostics _virtualNetworkClientDiagnostics;
        private readonly VirtualNetworksRestOperations _virtualNetworkRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkCollection"/> class for mocking. </summary>
        protected VirtualNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualNetworkResource.ResourceType, out string virtualNetworkApiVersion);
            _virtualNetworkRestClient = new VirtualNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualNetworkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a virtual network in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkName, VirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualNetworkResource>(new VirtualNetworkOperationSource(Client), _virtualNetworkClientDiagnostics, Pipeline, _virtualNetworkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a virtual network in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkName, VirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualNetworkResource>(new VirtualNetworkOperationSource(Client), _virtualNetworkClientDiagnostics, Pipeline, _virtualNetworkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified virtual network by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkResource>> GetAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified virtual network by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<VirtualNetworkResource> Get(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all virtual networks in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkResource(Client, VirtualNetworkData.DeserializeVirtualNetworkData(e)), _virtualNetworkClientDiagnostics, Pipeline, "VirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all virtual networks in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkResource(Client, VirtualNetworkData.DeserializeVirtualNetworkData(e)), _virtualNetworkClientDiagnostics, Pipeline, "VirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualNetworkResource>> GetIfExistsAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual NullableResponse<VirtualNetworkResource> GetIfExists(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkResource> IEnumerable<VirtualNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkResource> IAsyncEnumerable<VirtualNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

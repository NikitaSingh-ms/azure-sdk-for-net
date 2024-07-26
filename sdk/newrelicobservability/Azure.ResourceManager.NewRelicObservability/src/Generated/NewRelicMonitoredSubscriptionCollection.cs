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
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability
{
    /// <summary>
    /// A class representing a collection of <see cref="NewRelicMonitoredSubscriptionResource"/> and their operations.
    /// Each <see cref="NewRelicMonitoredSubscriptionResource"/> in the collection will belong to the same instance of <see cref="NewRelicMonitorResource"/>.
    /// To get a <see cref="NewRelicMonitoredSubscriptionCollection"/> instance call the GetNewRelicMonitoredSubscriptions method from an instance of <see cref="NewRelicMonitorResource"/>.
    /// </summary>
    public partial class NewRelicMonitoredSubscriptionCollection : ArmCollection, IEnumerable<NewRelicMonitoredSubscriptionResource>, IAsyncEnumerable<NewRelicMonitoredSubscriptionResource>
    {
        private readonly ClientDiagnostics _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics;
        private readonly MonitoredSubscriptionsRestOperations _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NewRelicMonitoredSubscriptionCollection"/> class for mocking. </summary>
        protected NewRelicMonitoredSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NewRelicMonitoredSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NewRelicMonitoredSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NewRelicObservability", NewRelicMonitoredSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NewRelicMonitoredSubscriptionResource.ResourceType, out string newRelicMonitoredSubscriptionMonitoredSubscriptionsApiVersion);
            _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient = new MonitoredSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, newRelicMonitoredSubscriptionMonitoredSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NewRelicMonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NewRelicMonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add the subscriptions that should be monitored by the NewRelic monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> The configuration name. Only 'default' value is supported. </param>
        /// <param name="data"> The <see cref="NewRelicMonitoredSubscriptionData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NewRelicMonitoredSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, MonitoredSubscriptionConfigurationName configurationName, NewRelicMonitoredSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics.CreateScope("NewRelicMonitoredSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NewRelicObservabilityArmOperation<NewRelicMonitoredSubscriptionResource>(new NewRelicMonitoredSubscriptionOperationSource(Client), _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics, Pipeline, _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Add the subscriptions that should be monitored by the NewRelic monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> The configuration name. Only 'default' value is supported. </param>
        /// <param name="data"> The <see cref="NewRelicMonitoredSubscriptionData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NewRelicMonitoredSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, MonitoredSubscriptionConfigurationName configurationName, NewRelicMonitoredSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics.CreateScope("NewRelicMonitoredSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken);
                var operation = new NewRelicObservabilityArmOperation<NewRelicMonitoredSubscriptionResource>(new NewRelicMonitoredSubscriptionOperationSource(Client), _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics, Pipeline, _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// List the subscriptions currently being monitored by the NewRelic monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The configuration name. Only 'default' value is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NewRelicMonitoredSubscriptionResource>> GetAsync(MonitoredSubscriptionConfigurationName configurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics.CreateScope("NewRelicMonitoredSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NewRelicMonitoredSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the subscriptions currently being monitored by the NewRelic monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The configuration name. Only 'default' value is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NewRelicMonitoredSubscriptionResource> Get(MonitoredSubscriptionConfigurationName configurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics.CreateScope("NewRelicMonitoredSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NewRelicMonitoredSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the subscriptions currently being monitored by the NewRelic monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NewRelicMonitoredSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NewRelicMonitoredSubscriptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NewRelicMonitoredSubscriptionResource(Client, NewRelicMonitoredSubscriptionData.DeserializeNewRelicMonitoredSubscriptionData(e)), _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics, Pipeline, "NewRelicMonitoredSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the subscriptions currently being monitored by the NewRelic monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NewRelicMonitoredSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NewRelicMonitoredSubscriptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NewRelicMonitoredSubscriptionResource(Client, NewRelicMonitoredSubscriptionData.DeserializeNewRelicMonitoredSubscriptionData(e)), _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics, Pipeline, "NewRelicMonitoredSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The configuration name. Only 'default' value is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(MonitoredSubscriptionConfigurationName configurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics.CreateScope("NewRelicMonitoredSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The configuration name. Only 'default' value is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(MonitoredSubscriptionConfigurationName configurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics.CreateScope("NewRelicMonitoredSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The configuration name. Only 'default' value is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<NewRelicMonitoredSubscriptionResource>> GetIfExistsAsync(MonitoredSubscriptionConfigurationName configurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics.CreateScope("NewRelicMonitoredSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NewRelicMonitoredSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new NewRelicMonitoredSubscriptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicMonitoredSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The configuration name. Only 'default' value is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<NewRelicMonitoredSubscriptionResource> GetIfExists(MonitoredSubscriptionConfigurationName configurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _newRelicMonitoredSubscriptionMonitoredSubscriptionsClientDiagnostics.CreateScope("NewRelicMonitoredSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _newRelicMonitoredSubscriptionMonitoredSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NewRelicMonitoredSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new NewRelicMonitoredSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NewRelicMonitoredSubscriptionResource> IEnumerable<NewRelicMonitoredSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NewRelicMonitoredSubscriptionResource> IAsyncEnumerable<NewRelicMonitoredSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

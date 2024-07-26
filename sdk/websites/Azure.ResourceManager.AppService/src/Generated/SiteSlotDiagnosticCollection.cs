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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotDiagnosticResource"/> and their operations.
    /// Each <see cref="SiteSlotDiagnosticResource"/> in the collection will belong to the same instance of <see cref="WebSiteSlotResource"/>.
    /// To get a <see cref="SiteSlotDiagnosticCollection"/> instance call the GetSiteSlotDiagnostics method from an instance of <see cref="WebSiteSlotResource"/>.
    /// </summary>
    public partial class SiteSlotDiagnosticCollection : ArmCollection, IEnumerable<SiteSlotDiagnosticResource>, IAsyncEnumerable<SiteSlotDiagnosticResource>
    {
        private readonly ClientDiagnostics _siteSlotDiagnosticDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticCollection"/> class for mocking. </summary>
        protected SiteSlotDiagnosticCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDiagnosticCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDiagnosticResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotDiagnosticResource.ResourceType, out string siteSlotDiagnosticDiagnosticsApiVersion);
            _siteSlotDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDiagnosticResource>> GetAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticResource> Get(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Categories
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteDiagnosticCategoriesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDiagnosticResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDiagnosticResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotDiagnosticDiagnosticsRestClient.CreateListSiteDiagnosticCategoriesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotDiagnosticDiagnosticsRestClient.CreateListSiteDiagnosticCategoriesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteSlotDiagnosticResource(Client, DiagnosticCategoryData.DeserializeDiagnosticCategoryData(e)), _siteSlotDiagnosticDiagnosticsClientDiagnostics, Pipeline, "SiteSlotDiagnosticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get Diagnostics Categories
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteDiagnosticCategoriesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDiagnosticResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDiagnosticResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotDiagnosticDiagnosticsRestClient.CreateListSiteDiagnosticCategoriesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotDiagnosticDiagnosticsRestClient.CreateListSiteDiagnosticCategoriesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteSlotDiagnosticResource(Client, DiagnosticCategoryData.DeserializeDiagnosticCategoryData(e)), _siteSlotDiagnosticDiagnosticsClientDiagnostics, Pipeline, "SiteSlotDiagnosticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<bool> Exists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteSlotDiagnosticResource>> GetIfExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteSlotDiagnosticResource>(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual NullableResponse<SiteSlotDiagnosticResource> GetIfExists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteSlotDiagnosticResource>(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDiagnosticResource> IEnumerable<SiteSlotDiagnosticResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDiagnosticResource> IAsyncEnumerable<SiteSlotDiagnosticResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

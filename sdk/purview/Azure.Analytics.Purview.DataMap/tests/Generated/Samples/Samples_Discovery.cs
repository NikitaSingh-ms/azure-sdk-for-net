// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.DataMap.Samples
{
    public partial class Samples_Discovery
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_Query_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Query(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_Query_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.QueryAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_Query_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            QueryConfig body = new QueryConfig();
            Response<QueryResult> response = client.Query(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_Query_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            QueryConfig body = new QueryConfig();
            Response<QueryResult> response = await client.QueryAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_Query_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new
            {
                keywords = "<keywords>",
                limit = 1234,
                continuationToken = "<continuationToken>",
                orderby = new object[]
            {
new object()
            },
                filter = new object(),
                facets = new object[]
            {
new
{
count = 1234,
facet = "<facet>",
sort = new
{
count = "asc",
value = "asc",
},
}
            },
                taxonomySetting = new
                {
                    assetTypes = new object[]
            {
"<assetTypes>"
            },
                },
            });
            Response response = client.Query(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("@search.count").ToString());
            Console.WriteLine(result.GetProperty("@search.count.approximate").ToString());
            Console.WriteLine(result.GetProperty("continuationToken").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("entityType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("entityType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("assetType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("assetType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classification")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classification")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("term")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("term")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactId")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactId")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("label")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("label")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("glossaryType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("glossaryType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("termStatus")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("termStatus")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("termTemplate")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("termTemplate")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.score").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("id")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("qualifiedName")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("name")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("description")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("entityType")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("objectType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("createTime").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("updateTime").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("endorsement").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("classification")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("label")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("glossaryName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("guid").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("info").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("assetType")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("glossaryType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("glossary").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("termStatus").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("termTemplate")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("longDescription").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_Query_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new
            {
                keywords = "<keywords>",
                limit = 1234,
                continuationToken = "<continuationToken>",
                orderby = new object[]
            {
new object()
            },
                filter = new object(),
                facets = new object[]
            {
new
{
count = 1234,
facet = "<facet>",
sort = new
{
count = "asc",
value = "asc",
},
}
            },
                taxonomySetting = new
                {
                    assetTypes = new object[]
            {
"<assetTypes>"
            },
                },
            });
            Response response = await client.QueryAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("@search.count").ToString());
            Console.WriteLine(result.GetProperty("@search.count.approximate").ToString());
            Console.WriteLine(result.GetProperty("continuationToken").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("entityType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("entityType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("assetType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("assetType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classification")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("classification")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("term")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("term")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactId")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactId")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("contactType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("label")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("label")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("glossaryType")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("glossaryType")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("termStatus")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("termStatus")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("termTemplate")[0].GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("@search.facets").GetProperty("termTemplate")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.score").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("id")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("qualifiedName")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("name")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("description")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.highlights").GetProperty("entityType")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("objectType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("createTime").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("updateTime").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("endorsement").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("classification")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("label")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("glossaryName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("guid").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("info").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("assetType")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("glossaryType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("glossary").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("termStatus").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("termTemplate")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("longDescription").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_Query_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            QueryConfig body = new QueryConfig
            {
                Keywords = "<keywords>",
                Limit = 1234,
                ContinuationToken = "<continuationToken>",
                Orderby = { BinaryData.FromObjectAsJson(new object()) },
                Filter = BinaryData.FromObjectAsJson(new object()),
                Facets = {new SearchFacetItem
{
Count = 1234,
Facet = "<facet>",
Sort = new SearchFacetSort
{
Count = SearchSortOrder.Ascend,
Value = SearchSortOrder.Ascend,
},
}},
                TaxonomySetting = new SearchTaxonomySetting
                {
                    AssetTypes = { "<assetTypes>" },
                    Facet = default,
                },
            };
            Response<QueryResult> response = client.Query(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_Query_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            QueryConfig body = new QueryConfig
            {
                Keywords = "<keywords>",
                Limit = 1234,
                ContinuationToken = "<continuationToken>",
                Orderby = { BinaryData.FromObjectAsJson(new object()) },
                Filter = BinaryData.FromObjectAsJson(new object()),
                Facets = {new SearchFacetItem
{
Count = 1234,
Facet = "<facet>",
Sort = new SearchFacetSort
{
Count = SearchSortOrder.Ascend,
Value = SearchSortOrder.Ascend,
},
}},
                TaxonomySetting = new SearchTaxonomySetting
                {
                    AssetTypes = { "<assetTypes>" },
                    Facet = default,
                },
            };
            Response<QueryResult> response = await client.QueryAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_Suggest_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Suggest(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_Suggest_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.SuggestAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_Suggest_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            SuggestConfig body = new SuggestConfig();
            Response<SuggestResult> response = client.Suggest(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_Suggest_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            SuggestConfig body = new SuggestConfig();
            Response<SuggestResult> response = await client.SuggestAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_Suggest_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new
            {
                keywords = "<keywords>",
                limit = 1234,
                filter = new object(),
            });
            Response response = client.Suggest(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.score").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("objectType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("createTime").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("updateTime").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("endorsement").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("classification")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("label")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("glossaryName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("guid").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("info").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("assetType")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("glossaryType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("glossary").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("termStatus").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("termTemplate")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("longDescription").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_Suggest_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new
            {
                keywords = "<keywords>",
                limit = 1234,
                filter = new object(),
            });
            Response response = await client.SuggestAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.score").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("@search.text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("objectType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("createTime").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("updateTime").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("qualifiedName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("entityType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("endorsement").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("owner").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("classification")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("label")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("glossaryName").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("term")[0].GetProperty("guid").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("info").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("contact")[0].GetProperty("contactType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("assetType")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("glossaryType").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("glossary").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("termStatus").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("termTemplate")[0].ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("longDescription").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_Suggest_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            SuggestConfig body = new SuggestConfig
            {
                Keywords = "<keywords>",
                Limit = 1234,
                Filter = BinaryData.FromObjectAsJson(new object()),
            };
            Response<SuggestResult> response = client.Suggest(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_Suggest_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            SuggestConfig body = new SuggestConfig
            {
                Keywords = "<keywords>",
                Limit = 1234,
                Filter = BinaryData.FromObjectAsJson(new object()),
            };
            Response<SuggestResult> response = await client.SuggestAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_AutoComplete_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.AutoComplete(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_AutoComplete_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.AutoCompleteAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_AutoComplete_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            AutoCompleteConfig body = new AutoCompleteConfig();
            Response<AutoCompleteResult> response = client.AutoComplete(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_AutoComplete_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            AutoCompleteConfig body = new AutoCompleteConfig();
            Response<AutoCompleteResult> response = await client.AutoCompleteAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_AutoComplete_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new
            {
                keywords = "<keywords>",
                limit = 1234,
                filter = new object(),
            });
            Response response = client.AutoComplete(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("queryPlusText").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_AutoComplete_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            using RequestContent content = RequestContent.Create(new
            {
                keywords = "<keywords>",
                limit = 1234,
                filter = new object(),
            });
            Response response = await client.AutoCompleteAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("queryPlusText").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Discovery_AutoComplete_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            AutoCompleteConfig body = new AutoCompleteConfig
            {
                Keywords = "<keywords>",
                Limit = 1234,
                Filter = BinaryData.FromObjectAsJson(new object()),
            };
            Response<AutoCompleteResult> response = client.AutoComplete(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Discovery_AutoComplete_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Discovery client = new DataMapClient(endpoint, credential).GetDiscoveryClient(apiVersion: "2023-09-01");

            AutoCompleteConfig body = new AutoCompleteConfig
            {
                Keywords = "<keywords>",
                Limit = 1234,
                Filter = BinaryData.FromObjectAsJson(new object()),
            };
            Response<AutoCompleteResult> response = await client.AutoCompleteAsync(body);
        }
    }
}

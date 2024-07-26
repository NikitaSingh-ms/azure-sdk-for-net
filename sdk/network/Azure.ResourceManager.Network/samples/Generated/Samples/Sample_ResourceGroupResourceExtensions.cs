// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        // Get available delegations in the resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableResourceGroupDelegations_GetAvailableDelegationsInTheResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/AvailableDelegationsResourceGroupGet.json
            // this example is just showing the usage of "AvailableResourceGroupDelegations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westcentralus");
            await foreach (AvailableDelegation item in resourceGroupResource.GetAvailableResourceGroupDelegationsAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get available service aliases in the resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableServiceAliasesByResourceGroup_GetAvailableServiceAliasesInTheResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/AvailableServiceAliasesListByResourceGroup.json
            // this example is just showing the usage of "AvailableServiceAliases_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westcentralus");
            await foreach (AvailableServiceAlias item in resourceGroupResource.GetAvailableServiceAliasesByResourceGroupAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get available PrivateEndpoint types in the resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailablePrivateEndpointTypesByResourceGroup_GetAvailablePrivateEndpointTypesInTheResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/AvailablePrivateEndpointTypesResourceGroupGet.json
            // this example is just showing the usage of "AvailablePrivateEndpointTypes_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("regionName");
            await foreach (AvailablePrivateEndpointType item in resourceGroupResource.GetAvailablePrivateEndpointTypesByResourceGroupAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Check private link service visibility
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkService_CheckPrivateLinkServiceVisibility()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/CheckPrivateLinkServiceVisibilityByResourceGroup.json
            // this example is just showing the usage of "PrivateLinkServices_CheckPrivateLinkServiceVisibilityByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            CheckPrivateLinkServiceVisibilityRequest checkPrivateLinkServiceVisibilityRequest = new CheckPrivateLinkServiceVisibilityRequest()
            {
                PrivateLinkServiceAlias = "mypls.00000000-0000-0000-0000-000000000000.azure.privatelinkservice",
            };
            ArmOperation<PrivateLinkServiceVisibility> lro = await resourceGroupResource.CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkServiceAsync(WaitUntil.Completed, location, checkPrivateLinkServiceVisibilityRequest);
            PrivateLinkServiceVisibility result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get list of private link service id that can be linked to a private end point with auto approved
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAutoApprovedPrivateLinkServicesByResourceGroupPrivateLinkServices_GetListOfPrivateLinkServiceIdThatCanBeLinkedToAPrivateEndPointWithAutoApproved()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/AutoApprovedPrivateLinkServicesResourceGroupGet.json
            // this example is just showing the usage of "PrivateLinkServices_ListAutoApprovedPrivateLinkServicesByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("regionName");
            await foreach (AutoApprovedPrivateLinkService item in resourceGroupResource.GetAutoApprovedPrivateLinkServicesByResourceGroupPrivateLinkServicesAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

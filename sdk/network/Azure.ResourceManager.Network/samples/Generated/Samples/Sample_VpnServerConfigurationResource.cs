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
    public partial class Sample_VpnServerConfigurationResource
    {
        // VpnServerConfigurationGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VpnServerConfigurationGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/VpnServerConfigurationGet.json
            // this example is just showing the usage of "VpnServerConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationResource created on azure
            // for more information of creating VpnServerConfigurationResource, please refer to the document of VpnServerConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            ResourceIdentifier vpnServerConfigurationResourceId = VpnServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            VpnServerConfigurationResource vpnServerConfiguration = client.GetVpnServerConfigurationResource(vpnServerConfigurationResourceId);

            // invoke the operation
            VpnServerConfigurationResource result = await vpnServerConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VpnServerConfigurationUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VpnServerConfigurationUpdate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/VpnServerConfigurationUpdateTags.json
            // this example is just showing the usage of "VpnServerConfigurations_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationResource created on azure
            // for more information of creating VpnServerConfigurationResource, please refer to the document of VpnServerConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            ResourceIdentifier vpnServerConfigurationResourceId = VpnServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            VpnServerConfigurationResource vpnServerConfiguration = client.GetVpnServerConfigurationResource(vpnServerConfigurationResourceId);

            // invoke the operation
            NetworkTagsObject vpnServerConfigurationParameters = new NetworkTagsObject()
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            VpnServerConfigurationResource result = await vpnServerConfiguration.UpdateAsync(vpnServerConfigurationParameters);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VpnServerConfigurationDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VpnServerConfigurationDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/VpnServerConfigurationDelete.json
            // this example is just showing the usage of "VpnServerConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationResource created on azure
            // for more information of creating VpnServerConfigurationResource, please refer to the document of VpnServerConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            ResourceIdentifier vpnServerConfigurationResourceId = VpnServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            VpnServerConfigurationResource vpnServerConfiguration = client.GetVpnServerConfigurationResource(vpnServerConfigurationResourceId);

            // invoke the operation
            await vpnServerConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VpnServerConfigurationList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVpnServerConfigurations_VpnServerConfigurationList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/VpnServerConfigurationList.json
            // this example is just showing the usage of "VpnServerConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VpnServerConfigurationResource item in subscriptionResource.GetVpnServerConfigurationsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnServerConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

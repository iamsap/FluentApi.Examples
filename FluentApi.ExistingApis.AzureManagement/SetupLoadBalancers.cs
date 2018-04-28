using System;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.Network.Fluent.Models;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace FluentApi.ExistingApis.AzureManagement
{
    public class SetupLoadBalancers
    {
        public async Task CreateAzureInfrastructure(IAzure azure)
        {
            await azure.LoadBalancers
                       .Define("myLoadBalancer")
                            .WithRegion(Region.USWest)
                            .WithExistingResourceGroup("myRg")
                            .DefineLoadBalancingRule("allow80")
                                .WithProtocol(TransportProtocol.Tcp)
                                .FromFrontend("myFrontEnd")
                                .FromFrontendPort(80)
                                .ToBackend("myBackEnd")
                                .WithFloatingIP(true)
                       .Attach()
                       .CreateAsync();
        }
    }
}

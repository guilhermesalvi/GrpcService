using Grpc.Net.Client;
using GrpcService.CustomerOnBoarding.Protos;
using GrpcService.CustomerOnBoarding.Services.Abstraction;
using System.Threading.Tasks;

namespace GrpcService.CustomerOnBoarding.Services
{
    public class CustomerIntegrationService : ICustomerIntegrationService
    {
        public async Task<CustomerIntegrationResult> Integrate(CustomerIntegrationRequest request)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new IntegrateCustomer.IntegrateCustomerClient(channel);
            var reply = await client.IntegrateCustomerDataAsync(request);

            return reply;
        }
    }
}

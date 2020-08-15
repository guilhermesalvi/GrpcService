using GrpcService.CustomerOnBoarding.Protos;
using System.Threading.Tasks;

namespace GrpcService.CustomerOnBoarding.Services.Abstraction
{
    public interface ICustomerIntegrationService
    {
        Task<CustomerIntegrationResult> Integrate(CustomerIntegrationRequest request);
    }
}

using Grpc.Core;
using GrpcService.CustomerIntegration.Protos;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace GrpcService.CustomerIntegration.Services
{
    public class IntegrateCustomerService : IntegrateCustomer.IntegrateCustomerBase
    {
        private readonly ILogger<IntegrateCustomerService> _logger;

        public IntegrateCustomerService(ILogger<IntegrateCustomerService> logger)
        {
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public override Task<CustomerIntegrationResult> IntegrateCustomerData(CustomerIntegrationRequest request,
                                                                              ServerCallContext context)
        {
            // Write here your implementation to integrate customer

            this._logger.LogInformation(@$"===== Customer with identifier '{request.Id}' and name '{request.Name}' was integrated. =====");

            return Task.FromResult(new CustomerIntegrationResult { Succeeded = true });
        }
    }
}

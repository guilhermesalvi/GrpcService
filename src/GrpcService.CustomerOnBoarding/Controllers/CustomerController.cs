using GrpcService.CustomerOnBoarding.Models;
using GrpcService.CustomerOnBoarding.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GrpcService.CustomerOnBoarding.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerIntegrationService _integrationService;

        public CustomerController(ICustomerIntegrationService integrationService)
        {
            this._integrationService = integrationService ?? throw new ArgumentNullException(nameof(integrationService));
        }

        [HttpPost("")]
        public async Task<IActionResult> Create(CustomerInputModel model)
        {
            // Write here your implementation before call IntegrationService

            var result = await this._integrationService.Integrate(new Protos.CustomerIntegrationRequest
            {
                Id = new Guid("b292e25e-10d3-4877-b5b9-6c7cc0108f5c").ToString("D"),
                Name = model.Name
            });

            return Ok(new
            {
                Succeded = result.Succeeded
            });
        }
    }
}

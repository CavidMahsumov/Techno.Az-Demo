using E_CommerceAPI.Application.Features.Commands.Customer.CreateCustomer;
using E_CommerceAPI.Application.Features.Commands.Customer.RemoveCustomer;
using E_CommerceAPI.Application.Features.Commands.Customer.UpdateCustomer;
using E_CommerceAPI.Application.Features.Queries.Customer.GetAllCustomer;
using E_CommerceAPI.Application.Features.Queries.Customer.GetByIdCustomer;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetAllCustomerQueryRequest getAllCustomerQueryRequest)
        {
            GetAllCustomerQueryResponse response = await _mediator.Send(getAllCustomerQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]GetByIdCustomerQueryRequest getByIdCustomerQueryRequest)
        {
            GetByIdCustomerQueryResponse response = await _mediator.Send(getByIdCustomerQueryRequest);
            return Ok(response);
        }
         
        [HttpPost]
        public async Task<IActionResult> Post(CreateCustomerCommandRequest createCustomerCommandRequest)
        {
            CreateCustomerCommandResponse response = await _mediator.Send(createCustomerCommandRequest);
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult>Delete([FromRoute]RemoveCustomerCommandRequest removeCustomerCommandRequest)
        {
            RemoveCustomerCommandResponse response = await _mediator.Send(removeCustomerCommandRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult>Put([FromBody]UpdateCustomerCommandRequest updateCustomerCommandRequest)
        {
            UpdateCustomerCommandResponse response = await _mediator.Send(updateCustomerCommandRequest);
            return Ok();
        }
       
    }
}

using E_CommerceAPI.Application.Features.Commands.Category.CreateCategory;
using E_CommerceAPI.Application.Features.Commands.Product.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult>Post(CreateCategoryCommandRequest _createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse _response = await _mediator.Send(_createCategoryCommandRequest);
            return Ok();
        }
    }
}

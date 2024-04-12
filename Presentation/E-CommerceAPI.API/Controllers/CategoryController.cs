using E_CommerceAPI.Application.Features.Commands.Category.CreateCategory;
using E_CommerceAPI.Application.Features.Commands.Category.RemoveCategory;
using E_CommerceAPI.Application.Features.Commands.Category.UpdateCategory;
using E_CommerceAPI.Application.Features.Commands.Product.CreateProduct;
using E_CommerceAPI.Application.Features.Commands.Product.UpdateProduct;
using E_CommerceAPI.Application.Features.Queries.Category.GetAllCategory;
using E_CommerceAPI.Application.Features.Queries.Category.GetByIdCategory;
using E_CommerceAPI.Application.Features.Queries.Product.GetAllProduct;
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
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCategoryCommandRequest removeCategoryCommandRequest)
        {
            RemoveCategoryCommandResponse response = await _mediator.Send(removeCategoryCommandRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UpdateCategoryCommandRequest updateCategoryCommandRequest)
        {
            UpdateCategoryCommandResponse response = await  _mediator.Send(updateCategoryCommandRequest);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetAllCategoryQueryRequest getAllCategoryQueryRequest)
        {
            GetAllCategoryQueryResponse response =await _mediator.Send(getAllCategoryQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdCategoryQueryRequest getByIdCategoryQueryRequest)
        {
            GetByIdCategoryQueryResponse response=await _mediator.Send(getByIdCategoryQueryRequest);
            return Ok(response);
        }

    }
}

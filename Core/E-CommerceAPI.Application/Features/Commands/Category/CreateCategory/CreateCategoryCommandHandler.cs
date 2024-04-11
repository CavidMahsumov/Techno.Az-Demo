using E_CommerceAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        public ICategoryWriteRepository _categoryWriteRepository { get; set; }
        public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository)
        {
            this._categoryWriteRepository = categoryWriteRepository;
        }
        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {

           await _categoryWriteRepository.AddAsync(new()
            {
                CategoryName = request.CategoryName,
                CategoryDescription = request.CategoryDescription,
                CategoryImagePath = request.CategoryImagePath
            });
            await _categoryWriteRepository.SaveAsync();
            return new();
        }
    }
}

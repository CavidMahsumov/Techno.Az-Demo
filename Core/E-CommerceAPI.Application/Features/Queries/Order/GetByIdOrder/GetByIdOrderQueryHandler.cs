using E_CommerceAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Queries.Order.GetByIdOrder
{
    public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQueryRequest, GetByIdOrderQeuryResponse>
    {
        private IOrderReadRepository _orderReadRepository;

        public GetByIdOrderQueryHandler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<GetByIdOrderQeuryResponse> Handle(GetByIdOrderQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Order order = await _orderReadRepository.GetByIdAsync(request.Id);
            return new() { Order = order };
            
        }
    }
}

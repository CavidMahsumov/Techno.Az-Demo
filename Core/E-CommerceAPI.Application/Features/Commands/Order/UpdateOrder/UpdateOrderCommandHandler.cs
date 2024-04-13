using E_CommerceAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Commands.Order.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        private IOrderWriteRepository _orderWriteRepository;
        private IOrderReadRepository _orderReadRepository;

        public UpdateOrderCommandHandler(IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Order order = await _orderReadRepository.GetByIdAsync(request.Id);
            order.Adress = request.Adress;
            order.Order_No = request.Order_No;
            order.CustomerId = request.CustomerId;
            order.Description = request.Description;
            await _orderWriteRepository.SaveAsync();
            return new();
        }
    }
}

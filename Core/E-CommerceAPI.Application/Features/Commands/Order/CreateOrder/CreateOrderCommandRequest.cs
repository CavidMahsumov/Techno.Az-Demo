using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public string Order_No { get; set; }
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Queries.Order.GetByIdOrder
{
    public class GetByIdOrderQeuryResponse
    {
        public Domain.Entities.Order Order { get; set; }
    }
}

﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Queries.Order.GetAllOrder
{
    public class GetAllOrderQueryRequest:IRequest<GetAllOrderQueryResponse>
    {
    }
}

﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Commands.Order.RemoveOrder
{
    public class RemoveOrderCommandRequest : IRequest<RemoveOrderCommandResponse>
    {
        public string Id { get; set; }
    }
}

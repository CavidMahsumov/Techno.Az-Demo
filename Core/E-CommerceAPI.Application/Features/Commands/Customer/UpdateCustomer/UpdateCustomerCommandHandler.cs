using E_CommerceAPI.Application.Repositories;
using E_CommerceAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Commands.Customer.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        private ICustomerWriteRepository _customerWriteRepository;
        private ICustomerReadRepository _customerReadRepository;

        public UpdateCustomerCommandHandler(ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await                                   _customerReadRepository.GetByIdAsync(request.Id);
                customer.PhoneNumber = request.PhoneNumber;
                customer.FirstName = request.FirstName;
                customer.LastName = request.LastName;
                customer.Email = request.Email;
                customer.Adress = request.Adress;

             await _customerWriteRepository.SaveAsync();
            return new ();
        }
    }
}

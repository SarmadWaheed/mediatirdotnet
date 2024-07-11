using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRCQRSDemo.Models;
using MediatRCQRSDemo.Services;

namespace MediatRCQRSDemo.Commands
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {


        private readonly ICustomerService _customerService;

        public UpdateCustomerCommandHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerService.UpdateCustomer(request.customer.Id, request.customer);
        }
    }
}
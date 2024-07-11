using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRCQRSDemo.Models;
using MediatRCQRSDemo.Services;

namespace MediatRCQRSDemo.Queries
{
    public class GetCustomersIdQueryHandler : IRequestHandler<GetCustomersByIdIdQuery, Customer>
    {
        private readonly ICustomerService _customerService;

        public GetCustomersIdQueryHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<Customer> Handle(GetCustomersByIdIdQuery request, CancellationToken cancellationToken)
        {
            // Call the service method to retrieve customer by ID
            return await _customerService.GetCustomerById(request.id);
        }
    }
}





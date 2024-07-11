using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRCQRSDemo.Models;

namespace MediatRCQRSDemo.Queries
{
    public record GetCustomersByIdIdQuery(int id) : IRequest<Customer>;
}
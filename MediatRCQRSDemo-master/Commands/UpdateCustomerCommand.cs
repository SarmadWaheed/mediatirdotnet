using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRCQRSDemo.Models;

namespace MediatRCQRSDemo.Commands
{

    public record UpdateCustomerCommand(int id, Customer customer) : IRequest<Customer>;


}
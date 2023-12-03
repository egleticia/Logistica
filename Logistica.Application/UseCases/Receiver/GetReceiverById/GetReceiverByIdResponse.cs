using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.UseCases.Receiver.GetReceiverById
{
    public sealed record GetReceiverByIdResponse
    {
        public Domain.Entities.Address Address { get; set; }
        public string Name { get; set; }
    }
}

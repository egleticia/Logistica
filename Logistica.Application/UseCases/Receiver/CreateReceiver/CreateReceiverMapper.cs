using AutoMapper;
using Logistica.Application.UseCases.Product;

namespace Logistica.Application.UseCases.Receiver.CreateReceiver
{
    public class CreateReceiverMapper : Profile
    {
        public CreateReceiverMapper()
        {
            CreateMap<CreateReceiverRequest, Domain.Entities.Receiver>();
            CreateMap<Domain.Entities.Receiver, CreateReceiverResponse>();
        }
    }
}

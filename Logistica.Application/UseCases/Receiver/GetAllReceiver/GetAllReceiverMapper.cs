using AutoMapper;

namespace Logistica.Application.UseCases.Receiver.GetAllReceiver
{
    public class GetAllReceiverMapper : Profile
    {
        public GetAllReceiverMapper()
        {
            CreateMap<Domain.Entities.Receiver, GetAllReceiverResponse>();
        }
    }
}

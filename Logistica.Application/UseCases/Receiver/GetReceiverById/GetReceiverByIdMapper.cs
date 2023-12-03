using AutoMapper;

namespace Logistica.Application.UseCases.Receiver.GetReceiverById
{
    public class GetReceiverByIdMapper : Profile
    {
        public GetReceiverByIdMapper()
        {
            CreateMap<Domain.Entities.Receiver, GetReceiverByIdResponse>();
        }
    }
}

using AutoMapper;

namespace Logistica.Application.UseCases.Message
{
    public class CreateMessageMapper : Profile
    {
        public CreateMessageMapper()
        {
            CreateMap<CreateMessageRequest, Domain.Entities.Message>();
            CreateMap<Domain.Entities.Message, CreateMessageResponse>();
        }
    }
}

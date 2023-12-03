using AutoMapper;

namespace Logistica.Application.UseCases.Receiver.UpdateReceiver
{
    public class UpdateReceiverMapper : Profile
    {
        public UpdateReceiverMapper()
        {
            CreateMap<UpdateReceiverRequest, Domain.Entities.Receiver>();
            CreateMap<Domain.Entities.Receiver, UpdateReceiverResponse>();
        }
    }
}

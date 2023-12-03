using AutoMapper;
namespace Logistica.Application.UseCases.Receiver.DeleteReceiver
{
    public sealed class DeleteReceiverMapper : Profile
    {
        public DeleteReceiverMapper()
        {
            CreateMap<DeleteReceiverRequest, Domain.Entities.Receiver>();
            CreateMap<Domain.Entities.Receiver, DeleteReceiverResponse>();
        }
    }
}

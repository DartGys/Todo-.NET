using MediatR;

namespace ShopExpressTest.Services.Commands.DeleteTask
{
    public class DeleteTaskCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}

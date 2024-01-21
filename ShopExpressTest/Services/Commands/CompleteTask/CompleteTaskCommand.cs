using MediatR;

namespace ShopExpressTest.Services.Commands.CompleteTask
{
    public class CompleteTaskCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}

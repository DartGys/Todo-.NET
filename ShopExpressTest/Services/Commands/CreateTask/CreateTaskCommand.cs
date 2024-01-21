using MediatR;

namespace ShopExpressTest.Services.Commands.CreateTask
{
    public class CreateTaskCommand : IRequest<Guid>
    {
        public string Title { get; set; } = string.Empty;
    }
}

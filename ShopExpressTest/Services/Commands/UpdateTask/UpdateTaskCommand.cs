using MediatR;

namespace ShopExpressTest.Services.Commands.UpdateTask
{
    public class UpdateTaskCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Title {  get; set; } = string.Empty;

    }
}

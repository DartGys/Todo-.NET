using MediatR;
using ShopExpressTest.Data;
using ShopExpressTest.Entities;

namespace ShopExpressTest.Services.Commands.DeleteTask
{
    public class DeleteTaskHandler : IRequestHandler<DeleteTaskCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public DeleteTaskHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteTaskCommand command, CancellationToken cancellationToken)
        {
            var entity = new UserTask()
            {
                Id = command.Id,
            };

            _context.Tasks.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

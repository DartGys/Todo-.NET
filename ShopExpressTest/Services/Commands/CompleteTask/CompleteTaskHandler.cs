using MediatR;
using ShopExpressTest.Data;

namespace ShopExpressTest.Services.Commands.CompleteTask
{
    public class CompleteTaskHandler : IRequestHandler<CompleteTaskCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public CompleteTaskHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CompleteTaskCommand command, CancellationToken cancellationToken)
        {
            var entity = await _context.Tasks.FindAsync(command.Id, cancellationToken);

            if (entity == null)
            {
                return Unit.Value;
            }

            entity.IsCompleted = !entity.IsCompleted;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

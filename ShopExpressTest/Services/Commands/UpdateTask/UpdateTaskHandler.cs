using MediatR;
using ShopExpressTest.Data;

namespace ShopExpressTest.Services.Commands.UpdateTask
{
    public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public UpdateTaskHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateTaskCommand command, CancellationToken  cancellationToken)
        {
            var entity = await _context.Tasks.FindAsync(command.Id, cancellationToken);

            if (entity == null)
            {
                return Unit.Value;
            }

            if(!string.IsNullOrWhiteSpace(command.Title))
            {
                entity.Title = command.Title;
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

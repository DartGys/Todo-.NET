using MediatR;
using ShopExpressTest.Data;
using ShopExpressTest.Entities;

namespace ShopExpressTest.Services.Commands.CreateTask
{
    public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, Guid>
    {
        private readonly ApplicationDbContext _context;

        public CreateTaskHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateTaskCommand command, CancellationToken cancellationToken)
        {
            var task = new UserTask()
            {
                Title = command.Title,
                IsCompleted = false
            };

            await _context.Tasks.AddAsync(task, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return task.Id;
        }
    }
}

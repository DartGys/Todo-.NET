using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopExpressTest.Data;
using ShopExpressTest.Entities;

namespace ShopExpressTest.Services.Queries.GetTaskList
{
    public class GetTaskListHandler : IRequestHandler<GetTaskListQuery, TaskListVm>
    {
        private readonly ApplicationDbContext _context;

        public GetTaskListHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TaskListVm> Handle(GetTaskListQuery query, CancellationToken cancellationToken)
        {
            var tasks = await _context.Tasks.ToListAsync(cancellationToken);

            return new TaskListVm { Tasks = (IList<UserTask>)tasks };
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using ShopExpressTest.Models;
using ShopExpressTest.Services.Commands.CompleteTask;
using ShopExpressTest.Services.Commands.CreateTask;
using ShopExpressTest.Services.Commands.DeleteTask;
using ShopExpressTest.Services.Queries.GetTaskList;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ShopExpressTest.Controllers
{
    public class TaskController : Controller
    {
        private readonly IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CompleteTask(CompleteTaskCommand command) =>
            Ok(await _mediator.Send(command));

        public async Task<IActionResult> CreateTask(CreateTaskCommand command) =>
            Ok(await _mediator.Send(command));

        public async Task<IActionResult> DeleteTask(DeleteTaskCommand command) =>
            Ok(await _mediator.Send(command));

        public async Task<IActionResult> GetTaskList(GetTaskListQuery query) =>
            Ok(await _mediator.Send(query));
        
    }
}

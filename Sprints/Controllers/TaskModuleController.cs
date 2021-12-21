using Microsoft.AspNetCore.Mvc;
using Sprints.Interfaces;
using Sprints.Models;

namespace Sprints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskModuleController : ControllerBase
    {
        private readonly ITaskModule _taskModule;

        public TaskModuleController(ITaskModule taskModule)
        {
            _taskModule = taskModule;
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _taskModule.GetAllTask();
            return Ok(data);

        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            var data = _taskModule.GetTaskById(id);
            if (data == null)
                return NotFound("No data Found");
            return Ok(data);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(TaskModule task)
        {
            var data = _taskModule.AddTask(task);
            if (data == null)
                return BadRequest("Bad Request");
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + task.Id, task);
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            _taskModule.DeleteTask(id);
            return Ok("Record is deleted ");
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Update(int id, TaskModule task)
        {
            _taskModule.UpdateTask(id, task);
            return Ok("Record is Updated ");
        }
    }
}

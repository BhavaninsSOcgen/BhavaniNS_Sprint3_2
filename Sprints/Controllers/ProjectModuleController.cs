using Microsoft.AspNetCore.Mvc;
using Sprints.DataLayer.Interfaces;
using Sprints.DataLayer.Models;

namespace Sprints.ApplicationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectModuleController : ControllerBase
    {
        private readonly IProjectModule _projectModule;

        public ProjectModuleController(IProjectModule projectModule)
        {
            _projectModule = projectModule;
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _projectModule.GetAllProject();
            return Ok(data);

        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            var data = _projectModule.GetProjectById(id);
            if (data == null)
                return NotFound("No data Found");
            return Ok(data);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(ProjectModule project)
        {
            var data = _projectModule.AddProject(project);
            if (data == null)
                return BadRequest("Bad Request");
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + project.Id, project);
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            _projectModule.DeleteProject(id);
            return Ok("Record is deleted ");
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Update(int id, ProjectModule project)
        {
            _projectModule.UpdateProject(id, project);
            return Ok("Record is updated ");
        }
    }
}

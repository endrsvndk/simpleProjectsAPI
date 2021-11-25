using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleProjectsAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleProjectsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private ProjectService projectService;

        public ProjectsController(ProjectService projectService)
        {
            this.projectService = projectService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(projectService.GetProjects());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var projects = projectService.GetProjects().Where(p => p.CategoryId == id);
            return Ok(projects);
        }
    }
}

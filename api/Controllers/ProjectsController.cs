using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProjectsController : ControllerBase
  {
    private readonly DataContext _context;
    public ProjectsController(DataContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Project>>> getProjects()
    {
      var projects = await _context.Projects.ToListAsync();
      return projects;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Project>> GetProject(int id) 
    {
      var project = await _context.Projects.FindAsync(id);
      return project == null ? NotFound() : project;
    }

  }
}
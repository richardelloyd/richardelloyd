using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class DesignsController : ControllerBase
  {
    private readonly DataContext _context;
    public DesignsController(DataContext context)
    {
      _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Design>>> GetDesigns()
    {
      var designs = await _context.Designs.ToListAsync();
      return designs;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Design>> GetDesign(int id) 
    {
      var design = await _context.Designs.FindAsync(id);
      return design == null ? NotFound() : design;
    }

  }
}
using Agencia.Data;
using Agencia.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agencia.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class AgenciaController : ControllerBase
  {

    private readonly DataContext _dataContext;
    public AgenciaController(DataContext dataContext)
    {
      _dataContext = dataContext;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>>> GetClients()
    {
      return await _dataContext.Agencia.ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> GetClientById(int id)
    {
      var client = await _dataContext.Agencia.FindAsync(id);
      if (client == null)
      {
        return NotFound();
      }
      return Ok(client);
    }
  }
}
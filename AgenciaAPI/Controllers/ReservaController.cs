using AgenciaAPI.Data;
using AgenciaAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgenciaAPI.Controllers
{
    [ApiController]
    
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {

        private readonly ReservaContext _reservaContext;
        public ReservaController(ReservaContext reservaContext)
        {
            _reservaContext = reservaContext;
        }

        
        [HttpGet]  
        public async Task<ActionResult<IEnumerable<Reserva>>> GetReservas()
        {
            return await _reservaContext.Reservas.ToListAsync();

        }

        //GET PELO ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> GetReservaById(int id)
        {
            var reserva = await _reservaContext.Reservas.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }

            return Ok(reserva);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevCo.ConsultaVeiculos.WebAPI.Models;
using System.Text.RegularExpressions;

namespace DevCo.ConsultaVeiculos.WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly VeiculosContext _context;

        public VeiculosController(VeiculosContext context)
        {
            _context = context;
        }

        // POST: api/consulta-placa
        [HttpPost]
        [Route("consulta-placa")]
        [Consumes("application/json")]
        public async Task<ActionResult<Veiculos>> PostVeiculos([FromBody] string Placa)
        {
            if(!Regex.IsMatch(Placa, "[A-Za-z]{3}[0-9]{4}"))
            {
                return BadRequest();
            }

            var veiculo = await _context.Veiculos.SingleOrDefaultAsync(v => v.Placa.ToUpper() == Placa);

            if (veiculo == null)
            {
                return NoContent();
            }

            return Ok(veiculo);
        }

        [HttpPost]
        [Route("gravar-placa")]
        [Consumes("application/json")]
        public async Task<ActionResult<Veiculos>> SaveVeiculos(Veiculos veiculos)
        {
            _context.Veiculos.Add(veiculos);
            await _context.SaveChangesAsync();

            return Ok(veiculos);
        }
    }
}

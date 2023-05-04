using CursosAPI.Domain.Entities;
using CursosAPI.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CursosAPI.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private ICursos _cursos;

        public CursosController(ICursos cursos)
        {
            _cursos = cursos;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register( EntidadeCursos entidadeCursos)
        {
            if(entidadeCursos is null)
            {
                return BadRequest($"{entidadeCursos} não pode ser nulo");
            }
            
            await _cursos.Insert(entidadeCursos);
            return Ok("Curso registrado com sucesso!");
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _cursos.GetAll();
            return Ok(result.ToList());
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _cursos.Delete(id);
            return Ok();
        }

    }
}

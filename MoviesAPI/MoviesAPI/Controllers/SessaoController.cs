using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;
using MoviesAPI.Services;
using System.Linq;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SessaoController : ControllerBase
    {
        private SessaoService _sessaoService;

        public SessaoController(SessaoService sessaoService)
        {
            _sessaoService = sessaoService;
        }

        [HttpPost]
        public IActionResult AdicionaSessao([FromBody] CreateSessaoDto sessaoDto)
        {
            ReadSessaoDto readDto = _sessaoService.AdicionaSessao(sessaoDto);
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessaoPorId(int id)
        {
            ReadSessaoDto readDto = _sessaoService.RecuperaSessoesPorId(id);
            if (readDto == null) return NotFound();
            return Ok(readDto);
        }
    }
}

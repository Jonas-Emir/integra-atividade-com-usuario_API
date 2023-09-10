using API_SistemaDeAtividades.Models;
using API_SistemaDeAtividades.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace API_SistemaDeAtividades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtividadeController : ControllerBase
    {
        private readonly IAtividadeRepositorio _atividadeRepositorio;
        public AtividadeController(IAtividadeRepositorio atividadeRepositorio)
        {
            _atividadeRepositorio = atividadeRepositorio;
        }

        [HttpGet("ListarAtividade")]
        public async Task<ActionResult<List<AtividadeModel>>> ListarTodas()
        {
            List<AtividadeModel> atividades = await _atividadeRepositorio.BuscarTodasAtividades();
            return Ok(atividades);
        }

        [HttpGet("BuscarPorId")]
        public async Task<ActionResult<List<AtividadeModel>>> BuscarPorId(int id)
        {
            AtividadeModel atividade = await _atividadeRepositorio.BuscarPorId(id);
            return Ok(atividade);
        }

        [HttpPost("InserirAtividade")]
        public async Task<ActionResult<AtividadeModel>> Cadastrar([FromBody] AtividadeModel atividadeModel)
        {
            AtividadeModel atividade = await _atividadeRepositorio.Adicionar(atividadeModel);
            return Ok(atividade);
        }

        [HttpPut("AtualizarAtividade")]
        public async Task<ActionResult<AtividadeModel>> Atualizar([FromBody] AtividadeModel atividadeModel, int id)
        {
            atividadeModel.Id = id;
            AtividadeModel atividade = await _atividadeRepositorio.Atualizar(atividadeModel, id);
            return Ok(atividade);
        }

        [HttpDelete("ApagarAtividade")]
        public async Task<ActionResult<AtividadeModel>> Apagar(int id)
        {
            bool apagado = await _atividadeRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}

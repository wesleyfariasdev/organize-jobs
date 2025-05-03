using Microsoft.AspNetCore.Mvc;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;

namespace OrganizeJobs.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HistoricoAtividadeController : ControllerBase
{
    private readonly IHistoricoAtividadeServices _historicoService;

    public HistoricoAtividadeController(IHistoricoAtividadeServices historicoService)
    {
        _historicoService = historicoService;
    }

    [HttpGet("tarefa/{taskId}")]
    [ProducesResponseType(typeof(HistoricoAtividadeResponseDto[]), StatusCodes.Status200OK)]
    public async Task<ActionResult<HistoricoAtividadeResponseDto[]>> GetPorTarefaId(Guid taskId)
    {
        var historicos = await _historicoService.ObterTodosPorId(taskId);
        return Ok(historicos);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(HistoricoAtividadeResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<HistoricoAtividadeResponseDto>> GetPorId(Guid id)
    {
        var historico = await _historicoService.ObterDetalheHistoricoAtividadePorId(id);
        if (historico == null)
            return NotFound(new { Message = "Histórico de atividade não encontrado." });

        return Ok(historico);
    }

    [HttpPost]
    [ProducesResponseType(typeof(HistoricoAtividadeResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<HistoricoAtividadeResponseDto>> Create([FromBody] HistoricoAtividadeResquestDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var criado = await _historicoService.CriarHistorico(dto);
        if (criado == null)
            return BadRequest(new { Message = "Não foi possível criar o histórico." });

        return CreatedAtAction(nameof(GetPorId), new { id = criado.Id }, criado);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(HistoricoAtividadeResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<HistoricoAtividadeResponseDto>> Update(Guid id, [FromBody] HistoricoAtividadeResquestDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var atualizado = await _historicoService.AtualizarHistoricoAtividade(dto);
        if (atualizado == null)
            return NotFound(new { Message = "Histórico de atividade não encontrado para atualização." });

        return Ok(atualizado);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id)
    {
        var removido = await _historicoService.DeletarHistoricoAtividade(id);
        if (!removido)
            return NotFound(new { Message = "Histórico de atividade não encontrado para exclusão." });

        return NoContent();
    }
}

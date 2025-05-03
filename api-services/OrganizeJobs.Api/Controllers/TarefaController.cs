using Microsoft.AspNetCore.Mvc;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;

namespace OrganizeJobs.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefaController : ControllerBase
{
    private readonly ITarefaServices _tarefaServices;

    public TarefaController(ITarefaServices tarefaServices)
    {
        _tarefaServices = tarefaServices;
    }

    [HttpGet]
    [ProducesResponseType(typeof(TarefaResponseDto[]), StatusCodes.Status200OK)]
    public async Task<ActionResult<TarefaResponseDto[]>> GetTarefas()
    {
        var tarefas = await _tarefaServices.ObterTodasTarefas();
        return Ok(tarefas);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(TarefaResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TarefaResponseDto>> GetTarefaPorId(Guid id)
    {
        var tarefa = await _tarefaServices.ObterTarefaPorId(id);
        if (tarefa == null)
            return NotFound(new { Message = "Tarefa não encontrada." });

        return Ok(tarefa);
    }

    [HttpPost]
    [ProducesResponseType(typeof(TarefaResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TarefaResponseDto>> CreateTarefa([FromBody] TarefaRequestDto requestDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var tarefa = await _tarefaServices.CriarTarefa(requestDto);
        if (tarefa == null)
            return BadRequest(new { Message = "Não foi possível criar a tarefa." });

        return CreatedAtAction(nameof(GetTarefaPorId), new { id = tarefa.Id }, tarefa);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(TarefaResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TarefaResponseDto>> UpdateTarefa(Guid id, [FromBody] TarefaRequestDto update)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _tarefaServices.AtualizarTarefa(update);
        if (result == null)
            return NotFound(new { Message = "Tarefa não encontrada para atualização." });

        return Ok(result);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteTarefa(Guid id)
    {
        var result = await _tarefaServices.DeletarPorId(id);
        if (!result)
            return NotFound(new { Message = "Tarefa não encontrada para exclusão." });

        return NoContent();
    }
}

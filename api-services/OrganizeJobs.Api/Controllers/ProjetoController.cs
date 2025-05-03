using Microsoft.AspNetCore.Mvc;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;

namespace OrganizeJobs.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjetoController : ControllerBase
{
    private readonly IProjetoServices _projetoServices;

    public ProjetoController(IProjetoServices projetoServices)
    {
        _projetoServices = projetoServices;
    }

    [HttpGet]
    [ProducesResponseType(typeof(ProjetoResponseDto[]), StatusCodes.Status200OK)]
    public async Task<ActionResult<ProjetoResponseDto[]>> GetProjetos()
    {
        var projetos = await _projetoServices.ObterTodosProjetos();
        return Ok(projetos);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ProjetoResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProjetoResponseDto>> GetProjetoPorId(Guid id)
    {
        var projeto = await _projetoServices.ObterProjetoPorId(id);
        if (projeto == null)
            return NotFound(new { Message = "Projeto não encontrado." });

        return Ok(projeto);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ProjetoResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProjetoResponseDto>> CreateProjeto([FromBody] ProjetoRequestDto requestDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var projeto = await _projetoServices.CriarProjeto(requestDto);
        if (projeto == null)
            return BadRequest(new { Message = "Não foi possível criar o projeto." });

        return CreatedAtAction(nameof(GetProjetoPorId), new { id = projeto.Id }, projeto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(ProjetoResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProjetoResponseDto>> UpdateProjeto(Guid id, [FromBody] ProjetoRequestDto update)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _projetoServices.AtualizarProjeto(update);
        if (result == null)
            return NotFound(new { Message = "Projeto não encontrado para atualização." });

        return Ok(result);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteProjeto(Guid id)
    {
        var result = await _projetoServices.DeletarProjeto(id);
        if (!result)
            return NotFound(new { Message = "Projeto não encontrado para exclusão." });

        return NoContent();
    }
}

using Microsoft.AspNetCore.Mvc;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;

namespace OrganizeJobs.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PerfilController : ControllerBase
{
    private readonly IPerfilServices _perfilServices;

    public PerfilController(IPerfilServices perfilServices)
    {
        _perfilServices = perfilServices;
    }

    [HttpGet]
    [ProducesResponseType(typeof(PerfilResponseDto[]), StatusCodes.Status200OK)]
    public async Task<ActionResult<PerfilResponseDto[]>> GetPerfis()
    {
        var perfis = await _perfilServices.ObterTodosPerfil();
        return Ok(perfis);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(PerfilResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<PerfilResponseDto>> GetPerfilPorId(Guid id)
    {
        var perfil = await _perfilServices.ObterPerfilPorId(id);
        if (perfil == null)
            return NotFound(new { Message = "Perfil não encontrado." });

        return Ok(perfil);
    }

    [HttpPost]
    [ProducesResponseType(typeof(PerfilResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PerfilResponseDto>> CreatePerfil([FromBody] PerfilRequestDto requestDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var perfil = await _perfilServices.CriarPerfil(requestDto);
        if (perfil == null)
            return BadRequest(new { Message = "Não foi possível criar o perfil." });

        return CreatedAtAction(nameof(GetPerfilPorId), new { id = perfil.Id }, perfil);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(PerfilResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PerfilResponseDto>> UpdatePerfil(Guid id, [FromBody] PerfilRequestDto update)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _perfilServices.AtualizarPerfil(id, update);
        if (result == null)
            return NotFound(new { Message = "Perfil não encontrado para atualização." });

        return Ok(result);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePerfil(Guid id)
    {
        var result = await _perfilServices.DeletarPerfil(id);
        if (!result)
            return NotFound(new { Message = "Perfil não encontrado para exclusão." });

        return NoContent();
    }
}

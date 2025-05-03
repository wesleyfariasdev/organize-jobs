using Microsoft.AspNetCore.Mvc;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;

namespace OrganizeJobs.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmpresasController : ControllerBase
{
    private readonly IEmpresaServices _empresaServices;

    public EmpresasController(IEmpresaServices empresaServices)
    {
        _empresaServices = empresaServices;
    }

    [HttpGet]
    [ProducesResponseType(typeof(EmpresaResponseDto[]), StatusCodes.Status200OK)]
    public async Task<ActionResult<EmpresaResponseDto[]>> GetEmpresas()
    {
        var empresas = await _empresaServices.ObterTodasEmpresas();
        return Ok(empresas);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(EmpresaResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<EmpresaResponseDto>> GetEmpresaPorId(Guid id)
    {
        var empresa = await _empresaServices.ObterEmpresaPorId(id);
        if (empresa == null)
            return NotFound(new { Message = "Empresa não encontrada." });

        return Ok(empresa);
    }

    [HttpPost]
    [ProducesResponseType(typeof(EmpresaResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EmpresaResponseDto>> CreateEmpresa([FromBody] EmpresaRequestDto requestDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var empresa = await _empresaServices.CriarEmpresa(requestDto);
        if (empresa == null)
            return BadRequest(new { Message = "Não foi possível criar a empresa." });

        return CreatedAtAction(nameof(GetEmpresaPorId), new { id = empresa.Id }, empresa);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(EmpresaResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EmpresaResponseDto>> UpdateEmpresa(Guid id, [FromBody] EmpresaRequestDto update)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _empresaServices.AtualizarEmpresa(id, update);
        if (result == null)
            return NotFound(new { Message = "Empresa não encontrada para atualização." });

        return Ok(result);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteEmpresa(Guid id)
    {
        var result = await _empresaServices.DeletarEmpresa(id);
        if (!result)
            return NotFound(new { Message = "Empresa não encontrada para exclusão." });

        return NoContent();
    }
}

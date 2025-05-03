using Microsoft.AspNetCore.Mvc;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Service.IServices;

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
    public async Task<IActionResult> GetEmpresas()
    {
        var empresas = await _empresaServices.ObterTodasEmpresas();
        return Ok(empresas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmpresaPorId(Guid id)
    {
        var empresa = await _empresaServices.ObterEmpresaPorId(id);
        if (empresa == null)
            return NotFound();

        return Ok(empresa);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmpresa([FromBody] EmpresaRequestDto requestDto)
    {
        var empresa = await _empresaServices.CriarEmpresa(requestDto);
        if (empresa == null)
            return BadRequest();

        return CreatedAtAction(nameof(GetEmpresaPorId), new { id = empresa.Id }, empresa);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmpresa(Guid id, [FromBody] EmpresaRequestDto update)
    {
        var result = await _empresaServices.AtualizarEmpresa(id, update);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmpresa(Guid id)
    {
        var result = await _empresaServices.DeletarEmpresa(id);
        if (!result)
            return NotFound();

        return NoContent();
    }
}

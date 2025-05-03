using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;
using OrganizeJobs.Domain.Models;
using OrganizeJobs.Infra.Data.Context;

namespace OrganizeJobs.Application.Service;

public class PerfilServices(OrganizeJobsContext perfilContext, IMapper mapper) : IPerfilServices
{
    public async Task<PerfilResponseDto> AtualizarPerfil(Guid id, PerfilRequestDto perfil)
    {
        var perfiMapper = mapper.Map<Perfil>(perfil);
        var atualizarPerfil = perfilContext.Perfils.Update(perfiMapper);
        await perfilContext.SaveChangesAsync();
        return mapper.Map<PerfilResponseDto>(atualizarPerfil);
    }

    public async Task<PerfilResponseDto> CriarPerfil(PerfilRequestDto perfil)
    {
        var perfiMapper = mapper.Map<Perfil>(perfil);
        var criarPerfil = await perfilContext.Perfils.AddAsync(perfiMapper);
        await perfilContext.SaveChangesAsync();
        return mapper.Map<PerfilResponseDto>(criarPerfil);
    }
    public async Task<bool> DeletarPerfil(Guid id)
    {
        var perfil = await perfilContext.Perfils
            .FirstOrDefaultAsync(x => x.Id == id);

        if (perfil is null)
            return false;

        perfilContext.Perfils.Remove(perfil);
        return await perfilContext.SaveChangesAsync() > 0;
    }

    public async Task<PerfilResponseDto> ObterPerfilPorId(Guid id)
    {
        var perfil = await perfilContext.Perfils.Where(x => x.Id == id)
                                                 .FirstOrDefaultAsync();
        return mapper.Map<PerfilResponseDto>(perfil);
    }

    public async Task<PerfilResponseDto[]> ObterTodosPerfil()
    {
        var perfis = await perfilContext.Perfils.ToListAsync();
        return mapper.Map<PerfilResponseDto[]>(perfis);
    }
}

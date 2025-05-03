using AutoMapper;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Application.ProfileMapping;

public class ProfileMap : Profile
{
    public ProfileMap()
    {
        CreateMap<EmpresaRequestDto, Empresa>().ReverseMap();
        CreateMap<EmpresaResponseDto, Empresa>().ReverseMap();

        CreateMap<HistoricoAtividadeResquestDto, HistoricoAtividade>().ReverseMap();
        CreateMap<HistoricoAtividadeResponseDto, HistoricoAtividade>().ReverseMap();

        CreateMap<ProjetoRequestDto, Projeto>().ReverseMap();
        CreateMap<ProjetoResponseDto, Projeto>().ReverseMap();

        CreateMap<TarefaRequestDto, Tarefa>().ReverseMap();
        CreateMap<TarefaResponseDto, Tarefa>().ReverseMap();

        CreateMap<PerfilRequestDto, Perfil>().ReverseMap();
        CreateMap<PerfilResponseDto, Perfil>().ReverseMap();
    }
}

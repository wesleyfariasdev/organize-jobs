using AutoMapper;
using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Service.IServices;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Application.Service;

public class HistoricoAtividadeService(IHistoricoAtividadeRespository historicoAtividadeRespository, IMapper mapper) : IHistoricoAtividadeServices
{
    public async Task<HistoricoAtividadeResponseDto> AtualizarHistoricoAtividade(HistoricoAtividadeResquestDto historicoAtividade)
    {
        var historicoMap = mapper.Map<HistoricoAtividade>(historicoAtividade);
        var atualizarHistorico = await historicoAtividadeRespository.AtualizarHistoricoAtividade(historicoMap);
        return mapper.Map<HistoricoAtividadeResponseDto>(atualizarHistorico);
    }

    public async Task<HistoricoAtividadeResponseDto> CriarHistorico(HistoricoAtividadeResquestDto historicoAtividade)
    {
        var historicoMap = mapper.Map<HistoricoAtividade>(historicoAtividade);
        var novoHistorico = await historicoAtividadeRespository.CriarHistorico(historicoMap);
        return mapper.Map<HistoricoAtividadeResponseDto>(novoHistorico);
    }

    public async Task<bool> DeletarHistoricoAtividade(Guid historicoAtividadeId) =>
           await historicoAtividadeRespository.DeletarHistoricoAtividade(historicoAtividadeId);

    public async Task<HistoricoAtividadeResponseDto> ObterDetalheHistoricoAtividadePorId(Guid historicoAtividadeId)
    {
        var obterHistorico = await historicoAtividadeRespository.ObterDetalheHistoricoAtividadePorId(historicoAtividadeId);
        return mapper.Map<HistoricoAtividadeResponseDto>(obterHistorico);
    }

    public async Task<HistoricoAtividadeResponseDto[]> ObterTodosPorId(Guid taskId)
    {
        var obterHistorico = await historicoAtividadeRespository.ObterTodosPorId(taskId);
        return mapper.Map<HistoricoAtividadeResponseDto[]>(obterHistorico);
    }
}

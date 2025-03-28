using OrganizeJobs.Application.Dto.Request;
using OrganizeJobs.Application.Dto.Response;
using OrganizeJobs.Application.Extensions;
using OrganizeJobs.Application.Service.IServices;
using OrganizeJobs.Domain.Interface;
using OrganizeJobs.Domain.Models;

namespace OrganizeJobs.Application.Service
{
    internal class EmpresaServices(IEmpresaRepository empresaRepository) : IEmpresaServices
    {
        public async Task<EmpresaResponseDto> AtualizarEmpresa(EmpresaRequestDto empresa)
        {
            var empresaEntity = new Empresa(empresa.NomeEmpresa);
            var resultado = await empresaRepository.AtualizarEmpresa(empresaEntity);

            return resultado.ToEmpresaReponseDto();
        }

        public async Task<EmpresaResponseDto> CraiarEmpresa(EmpresaRequestDto empresa)
        {
            var empresaEntity = new Empresa(empresa.NomeEmpresa);
            var resultado = await empresaRepository.CraiarEmpresa(empresaEntity);

            return resultado.ToEmpresaReponseDto();
        }

        public async Task<bool> DeletarEmpresa(Guid id) =>
               await empresaRepository.DeletarEmpresa(id);

        public async Task<EmpresaResponseDto> ObterEmpresaPorId(Guid id)
        {
            var resultado = await empresaRepository.ObterEmpresaPorId(id);

            return resultado.ToEmpresaReponseDto();
        }

        public async Task<EmpresaResponseDto[]> ObterTodasEmpresas()
        {
            var resultado = await empresaRepository.ObterTodasEmpresas();

            return resultado.ToEmpresaListResponseDto();
        }
    }
}

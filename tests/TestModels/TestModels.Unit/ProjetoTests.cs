using OrganizeJobs.Domain.Models;

namespace TestModels.Unit;

public class ProjetoTests
{
    [Fact]
    public void CriarProjeto_ComDadosValidos_DeveCriarProjetoCorretamente()
    {
        // Arrange
        var nomeProjeto = "Sistema de Gestão";
        var descricao = "Sistema para gestão de tarefas e projetos";
        var projetoLink = "https://github.com/projeto";
        var statusProjeto = true;
        var remuneracao = 5000.00m;
        var dataInicio = DateTime.Now;
        var dataFim = DateTime.Now.AddMonths(3);
        var empresaId = Guid.NewGuid();

        // Act
        var projeto = new Projeto(nomeProjeto, descricao, projetoLink, statusProjeto, remuneracao, dataInicio, dataFim, empresaId);

        // Assert
        Assert.Equal(nomeProjeto, projeto.NomeProjeto);
        Assert.Equal(descricao, projeto.Descricao);
        Assert.Equal(projetoLink, projeto.ProjetoLink);
        Assert.Equal(statusProjeto, projeto.StatusProjeto);
        Assert.Equal(remuneracao, projeto.Remuneracao);
        Assert.Equal(dataInicio, projeto.DataInicio);
        Assert.Equal(dataFim, projeto.DataFim);
        Assert.Equal(empresaId, projeto.EmpresaId);
    }

    [Fact]
    public void CriarProjeto_SemDescricao_DeveCriarProjetoCorretamente()
    {
        // Arrange
        var nomeProjeto = "Sistema de Gestão";
        string? descricao = null;
        var projetoLink = "https://github.com/projeto";
        var statusProjeto = true;
        var remuneracao = 5000.00m;
        var dataInicio = DateTime.Now;
        var dataFim = DateTime.Now.AddMonths(3);
        var empresaId = Guid.NewGuid();

        // Act
        var projeto = new Projeto(nomeProjeto, descricao, projetoLink, statusProjeto, remuneracao, dataInicio, dataFim, empresaId);

        // Assert
        Assert.Equal(nomeProjeto, projeto.NomeProjeto);
        Assert.Null(projeto.Descricao);
        Assert.Equal(projetoLink, projeto.ProjetoLink);
        Assert.Equal(statusProjeto, projeto.StatusProjeto);
        Assert.Equal(remuneracao, projeto.Remuneracao);
        Assert.Equal(dataInicio, projeto.DataInicio);
        Assert.Equal(dataFim, projeto.DataFim);
        Assert.Equal(empresaId, projeto.EmpresaId);
    }

    [Fact]
    public void CriarProjeto_SemDataFim_DeveCriarProjetoCorretamente()
    {
        // Arrange
        var nomeProjeto = "Sistema de Gestão";
        var descricao = "Sistema para gestão de tarefas e projetos";
        var projetoLink = "https://github.com/projeto";
        var statusProjeto = true;
        var remuneracao = 5000.00m;
        var dataInicio = DateTime.Now;
        DateTime? dataFim = null;
        var empresaId = Guid.NewGuid();

        // Act
        var projeto = new Projeto(nomeProjeto, descricao, projetoLink, statusProjeto, remuneracao, dataInicio, dataFim, empresaId);

        // Assert
        Assert.Equal(nomeProjeto, projeto.NomeProjeto);
        Assert.Equal(descricao, projeto.Descricao);
        Assert.Equal(projetoLink, projeto.ProjetoLink);
        Assert.Equal(statusProjeto, projeto.StatusProjeto);
        Assert.Equal(remuneracao, projeto.Remuneracao);
        Assert.Equal(dataInicio, projeto.DataInicio);
        Assert.Null(projeto.DataFim);
        Assert.Equal(empresaId, projeto.EmpresaId);
    }
}
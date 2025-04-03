using OrganizeJobs.Domain.Models;

namespace TestModels.Unit;

public class TarefaTests
{
    [Fact]
    public void CriarTarefa_ComDadosValidos_DeveCriarTarefaCorretamente()
    {
        // Arrange
        var id = Guid.NewGuid();
        var nomeTarefa = "Implementar Login";
        var descricaoTarefa = "Criar tela de login com autenticação";
        var dataInicio = DateTime.Now;
        var prazo = DateTime.Now.AddDays(7);
        var concluida = false;
        var projetoId = Guid.NewGuid();

        // Act
        var tarefa = new Tarefa(id, nomeTarefa, descricaoTarefa, dataInicio, prazo, concluida, projetoId);

        // Assert
        Assert.Equal(id, tarefa.Id);
        Assert.Equal(nomeTarefa, tarefa.NomeTarefa);
        Assert.Equal(descricaoTarefa, tarefa.DescricaoTarefa);
        Assert.Equal(dataInicio, tarefa.DataInicio);
        Assert.Equal(prazo, tarefa.Prazo);
        Assert.Equal(concluida, tarefa.Concluida);
        Assert.Equal(projetoId, tarefa.ProjetoId);
    }

    [Fact]
    public void CriarTarefa_SemDescricao_DeveCriarTarefaCorretamente()
    {
        // Arrange
        var id = Guid.NewGuid();
        var nomeTarefa = "Implementar Login";
        string? descricaoTarefa = null;
        var dataInicio = DateTime.Now;
        var prazo = DateTime.Now.AddDays(7);
        var concluida = false;
        var projetoId = Guid.NewGuid();

        // Act
        var tarefa = new Tarefa(id, nomeTarefa, descricaoTarefa, dataInicio, prazo, concluida, projetoId);

        // Assert
        Assert.Equal(id, tarefa.Id);
        Assert.Equal(nomeTarefa, tarefa.NomeTarefa);
        Assert.Null(tarefa.DescricaoTarefa);
        Assert.Equal(dataInicio, tarefa.DataInicio);
        Assert.Equal(prazo, tarefa.Prazo);
        Assert.Equal(concluida, tarefa.Concluida);
        Assert.Equal(projetoId, tarefa.ProjetoId);
    }

    [Fact]
    public void CriarTarefa_SemPrazo_DeveCriarTarefaCorretamente()
    {
        // Arrange
        var id = Guid.NewGuid();
        var nomeTarefa = "Implementar Login";
        var descricaoTarefa = "Criar tela de login com autenticação";
        var dataInicio = DateTime.Now;
        DateTime? prazo = null;
        var concluida = false;
        var projetoId = Guid.NewGuid();

        // Act
        var tarefa = new Tarefa(id, nomeTarefa, descricaoTarefa, dataInicio, prazo, concluida, projetoId);

        // Assert
        Assert.Equal(id, tarefa.Id);
        Assert.Equal(nomeTarefa, tarefa.NomeTarefa);
        Assert.Equal(descricaoTarefa, tarefa.DescricaoTarefa);
        Assert.Equal(dataInicio, tarefa.DataInicio);
        Assert.Null(tarefa.Prazo);
        Assert.Equal(concluida, tarefa.Concluida);
        Assert.Equal(projetoId, tarefa.ProjetoId);
    }
}
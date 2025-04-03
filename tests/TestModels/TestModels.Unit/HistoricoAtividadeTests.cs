using OrganizeJobs.Domain.Models;

namespace TestModels.Unit;

public class HistoricoAtividadeTests
{
    [Fact]
    public void CriarHistoricoAtividade_ComDadosValidos_DeveCriarHistoricoCorretamente()
    {
        // Arrange
        var inicioAtividade = DateTime.Now;
        var fimAtividade = DateTime.Now.AddHours(2);
        var tarefaId = Guid.NewGuid();

        // Act
        var historico = new HistoricoAtividade(inicioAtividade, fimAtividade, tarefaId);

        // Assert
        Assert.Equal(inicioAtividade, historico.InicioAtividade);
        Assert.Equal(fimAtividade, historico.FimAtividade);
        Assert.Equal(tarefaId, historico.TarefaId);
    }

    [Fact]
    public void CriarHistoricoAtividade_SemFimAtividade_DeveCriarHistoricoCorretamente()
    {
        // Arrange
        var inicioAtividade = DateTime.Now;
        DateTime? fimAtividade = null;
        var tarefaId = Guid.NewGuid();

        // Act
        var historico = new HistoricoAtividade(inicioAtividade, fimAtividade, tarefaId);

        // Assert
        Assert.Equal(inicioAtividade, historico.InicioAtividade);
        Assert.Null(historico.FimAtividade);
        Assert.Equal(tarefaId, historico.TarefaId);
    }
}
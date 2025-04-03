using OrganizeJobs.Domain.Models;

namespace TestModels.Unit;

public class EmpresaTests
{
    [Fact]
    public void CriarEmpresa_ComDadosValidos_DeveCriarEmpresaCorretamente()
    {
        // Arrange
        var nomeEmpresa = "Empresa XYZ";

        // Act
        var empresa = new Empresa(nomeEmpresa);

        // Assert
        Assert.Equal(nomeEmpresa, empresa.NomeEmpresa);
    }
}
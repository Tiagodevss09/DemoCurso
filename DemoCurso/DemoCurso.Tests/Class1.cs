using Xunit;

namespace DemoCurso.Tests
{
    public class Class1
    {
        [Fact]
        public void Somar_DeveRetornarResultadoCorreto()
        {
            // Arrange
            var resultado = 2 + 3;

            // Act & Assert
            Assert.Equal(5, resultado);
        }
    }
}

using HelloWorldAzureFunctions;
using Xunit;

namespace TestHelloWorldAzureFunction
{
    public class TesteDeCalculos
    {
        [Fact]
        public void TestandoSoma()
        {
            double a = 1;
            double b = 2;
            double resultadoExperado = 3;

            double resultadoObtido = Calculo.Somar(a, b);

            Assert.Equal(resultadoObtido, resultadoExperado);
        }

        [Fact]
        public void TestandoSubtracao()
        {
            double a = 2;
            double b = 1;
            double resultadoExperado = 1;

            double resultadoObtido = Calculo.Subtrair(a, b);

            Assert.Equal(resultadoObtido, resultadoExperado);
        }

        [Fact]
        public void TestandoDivisao()
        {
            double a = 4;
            double b = 2;
            double resultadoExperado = 2;

            double resultadoObtido = Calculo.Dividir(a, b);

            Assert.Equal(resultadoObtido, resultadoExperado);
        }

        [Fact]
        public void TestandoMultiplicao()
        {
            double a = 3;
            double b = 2;
            double resultadoExperado = 6;

            double resultadoObtido = Calculo.Multiplicar(a, b);

            Assert.Equal(resultadoObtido, resultadoExperado);
        }
    }
}
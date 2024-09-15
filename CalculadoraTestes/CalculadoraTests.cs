using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraService _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraService();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {   
        double num1 = 5;
        double num2 = 10;

        double resultado = _calc.Somar(num1, num2);

        Assert.Equal(15, resultado);
    }

    [Theory]
    [InlineData (5, 2, 10)]
    [InlineData (10, 10, 100)]
    [InlineData (0, 10, 0)]
    public void TeoricamenteMultiplicarAlgumasSequencias(double num1, double num2, double resultadoEsperado)
    {
        
        double resultado = _calc.Multiplicar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);

    }

    [Fact]
    public void DeveDividir10Por5ERetornar2()
    {   
        double num1 = 10;
        double num2 = 5;

        double resultado = _calc.Dividir(num1, num2);

        Assert.Equal(2, resultado);
    }

    [Theory]
    [InlineData (5, 2, 3)]
    [InlineData (10, 10, 0)]
    public void TeoricamenteSubtrairAlgumasSequencias(double num1, double num2, double resultadoEsperado)
    {
        
        double resultado = _calc.Subtrair(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);

    }


}
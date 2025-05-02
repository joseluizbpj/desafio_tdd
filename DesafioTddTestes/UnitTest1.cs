using DesafioTdd;

namespace DesafioTddTestes;

public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestarSomar(int num1, int num2, int resultado)
    {
        Calculadora calculadora = new Calculadora();

        int resultadoCalculadora = calculadora.Somar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestarMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calculadora = new Calculadora();

        int resultadoCalculadora = calculadora.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, -1)]
    [InlineData (4, 5, -1)]
    public void TestarSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calculadora = new Calculadora();

        int resultadoCalculadora = calculadora.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }
    
    [Theory]
    [InlineData (4, 2, 2)]
    [InlineData (6, 3, 2)]
    public void TestarDividir(int num1, int num2, int resultado)
    {
        Calculadora calculadora = new Calculadora();

        int resultadoCalculadora = calculadora.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDividirPorZero()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(1, 0));
    }
}

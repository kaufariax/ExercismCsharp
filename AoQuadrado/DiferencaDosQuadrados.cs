public static class DiferencaDosQuadrados
{
    public static int CalcularQuadradoDaSoma(int numeroNaturalMaximo)
    {
        int solucao = 0;

       for(int i = 0; i <= numeroNaturalMaximo; i++)
       {
           solucao += i;
       }

        var somaNumerosNaturaisAoQuadrado = solucao * solucao;

        return somaNumerosNaturaisAoQuadrado;
    }

    public static int CalcularSomaDosQuadrados(int numeroNaturalMaximo)
    {
        int soma = 0;

        for(int i = 0; i <= numeroNaturalMaximo; i++)
        {
            soma += (i * i);
        }

        return soma;
    }

    public static int CalcularDiferencaDosQuadrados(int numeroNaturalMaximo)
    {
        var differenceOfSquares = CalcularQuadradoDaSoma(numeroNaturalMaximo) - CalcularSomaDosQuadrados(numeroNaturalMaximo);
        return differenceOfSquares;
    }
}
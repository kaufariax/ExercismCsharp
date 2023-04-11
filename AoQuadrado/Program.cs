Console.WriteLine(@"Digite um número natural máximo e encontre a diferença entre o quadrado da soma e a soma dos quadrados dos primeiros (máximo solicitado) números naturais.");


int numeroNaturalMaximo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DiferencaDosQuadrados.CalcularDiferencaDosQuadrados(numeroNaturalMaximo));

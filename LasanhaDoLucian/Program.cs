/* Tarefa 1: Defina o tempo de forno esperado em minutos

Defina o Lasagna.ExpectedMinutesInOven() método que não aceita nenhum parâmetro e retorna quantos minutos a lasanha deve ficar no forno. 
De acordo com o livro de culinária, o tempo de forno esperado em minutos é de 40:

var lasagna = new Lasagna();
Lasagna.ExpectedMinutesInOven();
=> 40 
*/

var lasagna = new Lasagna();
Console.WriteLine(lasagna.ExpectedMinutesInOven());

/* Tarefa 2: Calcule o tempo restante do forno em minutos

Defina o Lasagna.RemainingMinutesInOven() método que toma como parâmetro os minutos reais que a lasanha ficou no forno e retorna quantos minutos a lasanha ainda tem para ficar no forno, com base no tempo de forno esperado em minutos da tarefa anterior.

var lasagna = new Lasagna();
Lasagna.RemainingMinutesInOven(30);
=> 10 
*/

Console.WriteLine(lasagna.RemainingMinutesInOven(30));

/* Tarefa 3: Calcule o tempo de preparo em minutos

Defina o Lasagna.PreparationTimeInMinutes() método que considera o número de camadas que você adicionou à lasanha como parâmetro 
e retorna quantos minutos você gastou preparando a lasanha, assumindo que cada camada leva 2 minutos para ser preparada.

var lasagna = new Lasagna();
lasagna.PreparationTimeInMinutes(2);
=> 4 
*/

Console.WriteLine(lasagna.PreparationTimeInMinutes(2));

/* Tarefa 4: Calcule o tempo decorrido em minutos

Defina o Lasagna.ElapsedTimeInMinutes() método que leva dois parâmetros: o primeiro parâmetro é o número de camadas 
que você adicionou à lasanha e o segundo parâmetro é o número de minutos que a lasanha está no forno. 
A função deve retornar quantos minutos você trabalhou no cozimento da lasanha, que é a soma do tempo de preparo 
em minutos e o tempo em minutos que a lasanha passou no forno no momento.

var lasagna = new Lasagna();
lasagna.ElapsedTimeInMinutes(3, 20);
=> 26
*/

Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));
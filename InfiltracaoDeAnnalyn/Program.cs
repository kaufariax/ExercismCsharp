/* Tarefa 1: Verifique se um ataque rápido pode ser feito

Implemente o método QuestLogic.CanFastAttack() que recebe um valor booleano que indica se o cavaleiro está acordado. 
Este método retorna true se um ataque rápido puder ser feito com base no estado do cavaleiro. Caso contrário, retorna false:

var knightIsAwake = true;
QuestLogic.CanFastAttack(knightIsAwake);
=> false */

var knightIsAwake = true;
Console.WriteLine(QuestLogic.CanFastAttack(knightIsAwake));

/* Tarefa 2: Verifique se o grupo pode ser espionado

Implemente o método QuestLogic.CanSpy() que assume três valores booleanos, indicando se o cavaleiro, 
o arqueiro e o prisioneiro, respectivamente, estão acordados. 
O método retorna true se o grupo puder ser espionado, com base no estado dos três caracteres. Caso contrário, retorna false:

var knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;
QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
=> true */

var knightIsAwakeTwo = false;
var archerIsAwakeTwo = true;
var prisonerIsAwakeTwo = false;
Console.WriteLine(QuestLogic.CanSpy(knightIsAwakeTwo, archerIsAwakeTwo, prisonerIsAwakeTwo));

/* Tarefa 3: Verifique se o prisioneiro pode ser sinalizado

Implemente o método QuestLogic.CanSignalPrisoner() que assume dois valores booleanos, indicando se o arqueiro e o prisioneiro, 
respectivamente, estão acordados. O método retorna true se o prisioneiro puder ser sinalizado, com base no estado dos dois personagens.
Caso contrário, retorna false:

var archerIsAwake = false;
var prisonerIsAwake = true;
QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
=> true */

var archerIsAwakeThree = false;
var prisonerIsAwakeThree = true;
Console.WriteLine(QuestLogic.CanSignalPrisoner(archerIsAwakeThree, prisonerIsAwakeThree));

/* Tarefa 4: Verifique se o prisioneiro pode ser libertado

Implemente o método QuestLogic.CanFreePrisoner()que aceita quatro valores booleanos. Os três primeiros parâmetros indicam se o cavaleiro, 
o arqueiro e o prisioneiro, respectivamente, estão acordados. O último parâmetro indica se o cachorro de estimação de Annalyn 
está presente. O método retorna truese o prisioneiro puder ser libertado com base no estado dos três personagens 
e na presença do cachorro de estimação de Annalyn. Caso contrário, retorna false:

var knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;
var petDogIsPresent = false;
QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);
=> false */

var knightIsAwakeFour = false;
var archerIsAwakeFour = true;
var prisonerIsAwakeFour = false;
var petDogIsPresentFour = false;
Console.WriteLine(QuestLogic.CanFreePrisoner(knightIsAwakeFour, archerIsAwakeFour, prisonerIsAwakeFour, petDogIsPresentFour));
/* Tarefa 1 - Permita que um jogador de magos e guerreiros jogue um dado.
Implemente um RollDie()método na Playerclasse.

var player = new Player();
player.RollDie();
=> >= 1 <= 18 
*/

var player = new Player();
Console.WriteLine(player.RollDie());

/* Tarefa 2 - Os jogadores precisam de sua força. Fornecer um meio para gerar força mágica
Implemente um GenerateSpellStrength()método na classe player. 
A força do feitiço está entre 0,0 e até, mas não incluindo 100,0.

Observe que a força do feitiço deve ser um número real (não um número inteiro) para reduzir a possibilidade de empate 
quando as forças de dois adversários são comparadas.

var player = new Player();
player.GenerateSpellStrength();
=> >= 0.0 < 100.0 
*/

Console.WriteLine(player.GenerateSpellStrength());
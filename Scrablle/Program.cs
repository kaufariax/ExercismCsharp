/* Instruções: Dada uma palavra, calcule a pontuação do Scrabble para essa palavra.

Valores de letras:

Letter                           Value
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10 */

Console.WriteLine("Digite a palavra na qual quer saber a pontuação em Scrablle: ");
Console.WriteLine(ScrabbleScore.Score(Console.ReadLine()!));

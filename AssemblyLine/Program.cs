/* Tarefa 1: Calcular a taxa de sucesso

Implemente o método AssemblyLine.SuccessRate() para calcular a proporção de um item sendo criado sem erro para uma determinada velocidade. 
A tabela a seguir mostra como a velocidade influencia a taxa de sucesso:

0: 0% de taxa de sucesso.
1 para 4: taxa de sucesso de 100%.
5 para 8: taxa de sucesso de 90%.
9: 80% de taxa de sucesso.
10: 77% de taxa de sucesso.
AssemblyLine.SuccessRate(10)
=> 0.77 
*/

Console.WriteLine(AssemblyLine.SuccessRate(10));

/* Tarefa 2: Calcular a taxa de produção por hora

Implemente o método AssemblyLine.ProductionRatePerHour() para calcular a taxa de produção por hora da linha de montagem, 
levando em consideração sua taxa de sucesso:

AssemblyLine.ProductionRatePerHour(6)
=> 1193.4 
*/

Console.WriteLine(AssemblyLine.ProductionRatePerHour(6));

/* Tarefa 3: Calcular o número de itens de trabalho produzidos por minuto

Implemente o método AssemblyLine.WorkingItemsPerMinute() para calcular quantos carros funcionais são produzidos por minuto:

AssemblyLine.WorkingItemsPerMinute(6)
=> 19 
*/

Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(6));
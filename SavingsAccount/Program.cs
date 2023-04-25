/* Tarefa 1 - Calcule a taxa de juros
Implemente o método ( estático ) SavingsAccount.InterestRate()para calcular a taxa de juros 
com base no saldo especificado:

SavingsAccount.InterestRate(balance: 200.75m)
// 0.5f 
*/

Console.WriteLine(SavingsAccount.InterestRate(balance: 200.75m));

/* Tarefa 2 - Calcule os juros

Implemente o método ( estático ) SavingsAccount.Interest()para calcular os juros com base no saldo especificado:

SavingsAccount.Interest(balance: 200.75m)
// 1.00375m 
*/

Console.WriteLine(SavingsAccount.Interest(balance: 200.75m));

/* Tarefa 3 - Calcular a atualização anual do saldo

Implemente o método ( estático ) SavingsAccount.AnnualBalanceUpdate()para calcular a atualização do saldo anual, 
tendo em conta a taxa de juro:

SavingsAccount.AnnualBalanceUpdate(balance: 200.75m)
// 201.75375m 
*/

Console.WriteLine(SavingsAccount.AnnualBalanceUpdate(balance: 200.75m));

/* Tarefa 4 - Calcule os anos antes de atingir o equilíbrio desejado

Implemente o método ( estático ) SavingsAccount.YearsBeforeDesiredBalance()para calcular o número 
mínimo de anos necessários para atingir o equilíbrio desejado, dados juros compostos anualmente:

SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m)
// 14 
*/

Console.WriteLine(SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m));
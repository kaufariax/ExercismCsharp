static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance)
        {
            case < 0.0m:
                return 3.213f;
            case < 1000.0m:
                return 0.5f;
            case >= 1000.0m when balance < 5000.0m:
                return 1.621f;
            default:
                return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        float juros = InterestRate(balance);
        decimal jurosEmDecimal = Convert.ToDecimal(juros);

        return (balance * jurosEmDecimal) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal valorDoJuros = Interest(balance);

        return balance + valorDoJuros;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int quantidadeAnosNecessarios = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            quantidadeAnosNecessarios += 1;
        }

        return quantidadeAnosNecessarios;
    }
}
class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutesLeft)
    {
        return ExpectedMinutesInOven() - minutesLeft;
    }

    public int PreparationTimeInMinutes(int amountLayers)
    {
        return amountLayers * 2;
    }

    public int ElapsedTimeInMinutes(int amountLayers, int minutesLeftOven)
    {
        return PreparationTimeInMinutes(amountLayers) + minutesLeftOven;
    }
}

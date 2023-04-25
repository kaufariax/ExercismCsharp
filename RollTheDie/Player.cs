
public class Player
{
    Random random = new Random();
    public int RollDie()
    {
        return random.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        return random.NextDouble() * 100;
    }
}
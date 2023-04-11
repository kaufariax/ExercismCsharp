public static class ScrabbleScore
{
    private static Dictionary<int, string> dicionarioScrablle = new Dictionary<int, string>()
    {
        [1] = "AEIOULNRST",
        [2] = "DG",
        [3] = "BCMP",
        [4] = "FHVWY",
        [5] = "K",
        [8] = "JX",
        [10] = "QZ"

    };
    public static int Score(string input)
    {
        int pontuacaoDoScrablle = 0;
        
        foreach (char caracter in input.ToUpper())
        {
            if(!char.IsLetter(caracter))
            {
                throw new Exception("Digite apenas uma palavra contendo apenas letras!!");
            }
            
            var valorDoCaracter = dicionarioScrablle.Where(c => c.Value.Contains(caracter)).ToDictionary(k => k.Key, v => v.Value);
            pontuacaoDoScrablle += valorDoCaracter.Keys.First();
        }

        return pontuacaoDoScrablle;


    }
}
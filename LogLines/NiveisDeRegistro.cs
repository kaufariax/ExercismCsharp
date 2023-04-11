
public static class NiveisDeRegistro
{
    public static string RecuperarApenasMensagem(string logLine)
    {
        var message = logLine.Split(":");

        var messageSemEspacos = message[1].Trim();

        return messageSemEspacos;
    }

    public static string RecuperarApenasNivelDeRegistro(string logLine)
    {
        var message = logLine.Split(":");

        var messageTratada = message[0].Replace("[", string.Empty)
                                       .Replace("]", string.Empty);

        return messageTratada.ToLower();
    }

    public static string FormatarStringLog(string logLine)
    {
        var message = logLine.Split(":");

        var primeiraPalavra = message[0]
                                .Replace("[", "(")
                                .Replace("]", ")")
                                .ToLower();

        var fraseFormatada = $"{message[1].Trim()} {primeiraPalavra}";

        return fraseFormatada;
    }
}
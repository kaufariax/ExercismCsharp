
    public static class LogAnalysis
    {
        public static string SubstringAfter(this string log, string stringSeparacao)
        {
            return log.Split(stringSeparacao)[1];
        }

        public static string SubstringBetween(this string log, string inicioSeparador, string fimSeparador)
        {
            return log.Split(fimSeparador).First().Split(inicioSeparador).Last();
        }

        public static string Message(this string log)
        {
            return log.Split(":")[1].Trim();
        }

        public static string LogLevel(this string log)
        {
            var inicioSeparador = "[";
            var fimSeparador = "]";

            return log.SubstringBetween(inicioSeparador, fimSeparador);
            
        }
    }

    

/* Tarefa 1 - Permitir a recuperação da string após uma substring específica

Observando os logs do último mês, você vê que a mensagem de teste está sempre localizada após uma substring específica. 
Como você está prevendo ter que extrair a mensagem de teste em algum momento no futuro próximo, você decide criar um método 
auxiliar para ajudá-lo com isso.

Implemente o método de extensão ( static ) LogAnalysis.SubstringAfter(), que recebe algum delimitador de string
 e retorna a substring após o delimitador. 
 
var log = "[INFO]: File Deleted.";
log.SubstringAfter(": "); // => returns "File Deleted."
*/

var logTarefaUm = "[INFO]: File Deleted.";
Console.WriteLine(logTarefaUm.SubstringAfter(": "));



/* Tarefa 2 - Permitir recuperar a string entre duas substrings

Em uma inspeção mais aprofundada, você verá que o nível de log está sempre localizado entre colchetes ( [e ]). 
Como você também está prevendo ter que extrair o nível de log em um futuro próximo, decide criar outro método 
auxiliar para ajudá-lo com isso.

Implemente o método de extensão ( static ) LogAnalysis.SubstringBetween()que aceita dois delimitadores de string 
e retorna a substring que está entre os dois delimitadores.

var log = "[INFO]: File Deleted.";
log.SubstringBetween("[", "]"); // => returns "INFO" 
*/

var logTarefaDois = "[INFO]: File Deleted.";
Console.WriteLine(logTarefaDois.SubstringBetween("[", "]"));


/* Tarefa 3 - Analisar mensagem em um log

Implemente o método de extensão ( static ) LogAnalysis.Message()para retornar a mensagem contida em um log.

var log = "[ERROR]: Missing ; on line 20.";
log.Message(); // => returns "Missing ; on line 20." 
*/

var logTarefaTres = "[ERROR]: Missing ; on line 20.";
Console.WriteLine(logTarefaTres.Message());

/* Tarefa 4 - Analisar o nível de log em um log

Implemente o método de extensão ( estático ) LogAnalysis.LogLevel()para retornar o nível de log de um log.

var log = "[ERROR]: Missing ; on line 20.";
log.LogLevel(); // => returns "ERROR" 
*/

var logTarefaQuatro = "[ERROR]: Missing ; on line 20.";
Console.WriteLine(logTarefaQuatro.LogLevel());

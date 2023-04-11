/* Tarefa 1: Obter mensagem de uma linha de log
Implemente o método RecuperarApenasMensagem() para retornar a mensagem de uma linha de log e 
qualquer espaço em branco inicial ou final deve ser removido:
Exemplo: RecuperarApenasMensagem("[WARNING]:  Disk almost full\r\n")
=> "Disk almost full"
*/

Console.WriteLine(NiveisDeRegistro.RecuperarApenasMensagem("[WARNING]:  Disk almost full\r\n"));

/* Tarefa 2: Obtenha o nível de log de uma linha de log
Implemente o método RecuperarApenasNivelDeRegistro() para retornar o nível de log de uma linha de log, 
que deve ser retornado em letras minúsculas: 
Exemplo: RecuperarApenasNivelDeRegistro("[ERROR]: Invalid operation")
=> "error"
*/

Console.WriteLine(NiveisDeRegistro.RecuperarApenasNivelDeRegistro("[ERROR]: Invalid operation"));

/* Tarefa 3: Reformatar uma linha de log
Implemente o método FormatarStringLog() que reformata a linha de log, colocando a mensagem primeiro e o nível de log
depois dela entre parênteses: 
Exemplo: FormatarStringLog("[INFO]: Operation completed")
=> "Operation completed (info)"
*/

Console.WriteLine(NiveisDeRegistro.FormatarStringLog("[INFO]: Operation completed"));
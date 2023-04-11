Console.WriteLine("Digite um ano para saber se ele é bissexto: ");
int anoSolicitado = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Leap.IsLeapYear(anoSolicitado));

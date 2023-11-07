// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region TiposDados
int tipointeiro;
double tipodouble;
decimal tipodecimal;
long tipolong;
float tipofloat;

tipointeiro = int.MaxValue;
Console.WriteLine("O maior valor inteiro é: " + tipointeiro);
tipointeiro = int.MinValue;
Console.WriteLine("O menor valor inteiro é: " + tipointeiro);
tipolong = long.MaxValue;
Console.WriteLine("O maior valor long é: " + tipolong);
tipolong = long.MinValue;
Console.WriteLine("O menor valor long é: " + tipolong);

#endregion
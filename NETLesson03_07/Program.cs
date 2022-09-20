// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI TEMPERATŪRA C, O IŠVEDA KELVINUSIR FARENHEITUS */

Console.WriteLine("Iveskite  temperatura Celsijais");
double c = Convert.ToDouble(Console.ReadLine());
double farenheitai = c + 32;
double kelvinai = c + 273.15;
Console.WriteLine($"Temperatura Farenheitais: {farenheitai}");
Console.WriteLine($"Temperatura Kelvinais: {kelvinai}");

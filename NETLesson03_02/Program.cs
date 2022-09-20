// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (METRAIS) IR LAIKĄ (SEKUNDĖMIS), 
 * O IŠVEDA GREITĮ (KM/H). NAUDOTI DOUBLE. */

Console.WriteLine("Iveskite atstuma metrais:");
double atstumas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Iveskite laika sekundemis");
double laikas = Convert.ToDouble(Console.ReadLine());

double greitis = atstumas / 1000 / (laikas / 36000);
Console.WriteLine($"Greitis yra {greitis} KM/H");

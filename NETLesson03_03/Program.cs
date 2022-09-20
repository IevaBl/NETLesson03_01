// See https://aka.ms/new-console-template for more information

/*PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI RUTULIO DIAMETRĄ, O IŠVEDA PLOTĄ IR TŪRĮ */

Console.WriteLine("Iveskite skritulio diametra:");
var diam = Convert.ToDouble(Console.ReadLine());
var r = diam / 2;
var plotas = 3.14 * diam;
var turis = 4 / 3 * 3.14 * (r * r * r);
Console.WriteLine($"Plotas: {plotas}, Turis: {turis}");

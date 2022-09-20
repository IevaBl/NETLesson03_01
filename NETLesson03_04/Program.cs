// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI 2 SKAIČIUS. 
 * JEI ABU LYGINIAI, PROGRAMA TURI IŠVESTI TRUE, JEI NE -FALSE */

Console.WriteLine("iveskite du skaicius:");
var sk1 = Convert.ToDouble(Console.ReadLine());
var sk2 = Convert.ToDouble(Console.ReadLine());
bool ats1 = sk1 % 2 == 0;
bool ats2 = sk2 % 2 == 0;
var galutinis = ats1 = ats2;
Console.WriteLine($" Jusu suvesti skaiciai yra lyginiai => {galutinis}");
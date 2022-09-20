// See https://aka.ms/new-console-template for more information

/*PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI SIMBOLĮ. IŠVEDA TRIKAMPĮ IŠ SIMBOLIŲ:111111 */


Console.WriteLine("Iveskite viena simboli:");
char sim = Convert.ToChar(Console.ReadLine());
Console.WriteLine($"{sim}");
Console.WriteLine($"{sim}{sim}");
Console.WriteLine($"{sim}{sim}{sim}");

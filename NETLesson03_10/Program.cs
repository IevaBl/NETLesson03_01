// See https://aka.ms/new-console-template for more information

/* PARAŠYTIPROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI EGZAMINO PAŽYMĮ.
 * IŠVESTI:0 –4: NEPATEKINAMAI5: SILPNAI6: PATENKINAMAI7: VIDUTINIŠKAI8: GERAI9: LABAI GERAI10: PUIKIAINAUDOTI SWICH ... CASE */

Console.WriteLine("Parasykite egzamino pazymi:");
int mark;
bool check = int.TryParse(Console.ReadLine(), out mark);
switch (mark)
{
    case 0 or 1 or 2 or 3 or 4:
        Console.WriteLine("NEPATENKINAMAI");
        break;
    case 5:
        Console.WriteLine("SILPNAI");
        break;
    case 6:
        Console.WriteLine("PATENKINAMAI");
        break;
    case 7:
        Console.WriteLine("VIDUTINISKAI");
        break;
    case 8:
        Console.WriteLine("GERAI");
        break;
    case 9:
        Console.WriteLine("LABAI GERAI");
        break;
    case 10:
        Console.WriteLine("PUIKIAI");
        break;
    default:
        Console.WriteLine("Jusu pazymis neteisingas, programa uzbaigiama...");
        Environment.Exit(0);
        break;

}




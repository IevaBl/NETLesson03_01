// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURĮ PRAŠO ĮVESTI VARTOTOJO VARDĄ IR SLAPTAŽODĮ. PO 3 NESĖKMINGŲ BANDYMŲ IŠVEDA KLAIDĄ.*/

string checkVardas = "Ieva";
string checkPin = "murklys12";



for(int i = 0; i < 3; i++)
{
    Console.WriteLine("Iveskite varda:");
    string vardas = Console.ReadLine();
    Console.WriteLine("Iveskite slaptazodi:");
    string pin = Console.ReadLine();

    if (checkVardas != vardas || checkPin != pin)
    {
        continue;
    }
    else if(checkVardas == vardas && checkPin == pin)
    {
        Console.WriteLine("Jusu bandymas sekmingas!!!");
    }
    else
        Console.WriteLine("Jus suklydote tris kartus");
        break;

}



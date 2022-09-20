// See https://aka.ms/new-console-template for more information

/*PARAŠYTIPROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI IŠDIRBTAS VALANDAS.
 * JEI VALANDŲ YRA MAŽIAU NEI 160, PROGRAMA TURI PARODYTI, KIEK DAR REIKIA IŠDIRBTI, 
 * JEI LYGIAI 160, PARODO, KAD IŠDIRBTAS PILNAS ETATAS, JEI DAUGIAU –PARODO KIEK YRA VIRŠVALANDŽIŲ.
 * JEI VARTOTOJAS PADARO ĮVEDIMO KLAIDĄ –PRANEŠTI IR UŽBAIGTI DARBĄ */

Console.WriteLine("Iveskite isdirbtas valandas per si menesi:");

int laikas = Convert.ToInt32(Console.ReadLine());

switch (laikas)
{
    case < 160:
        Console.WriteLine($"Jums liko dar dirbti {160 - laikas} valandu");
        break;
    case 160:
        Console.WriteLine("Jus irdirbote pilna etata");
        break;
    case > 160:
        Console.WriteLine($"Jus turite {laikas - 160} val virvalandziu");
        break;
    dafault:
        Console.WriteLine("Jusu ivestis nera tinkama, programa uzbaigiama...");
        Environment.Exit(0);
        break;
}
   
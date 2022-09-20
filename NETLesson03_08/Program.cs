// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ DIDELĮ 10-ŽENKLĮ SKAIČIŲ (DOUBLE), KONVERTUOJA Į INT, SHORT, BYTE.STEBĖTI REZULTATĄ.*/

float number = 1234567890;
int a = Convert.ToInt32(number);
char b = Convert.ToChar(number);
byte c = Convert.ToByte(number);

Console.WriteLine($"Konvertuoti skaiciai: {a} {b} {c}");
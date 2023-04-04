// See https://aka.ms/new-console-template for more information
string[] cibiPreferiti = { "Hamburger", "Spaghetti alle vongole", "Uova all'occhio di bue", "Fettine Panate", "Patate Lesse" };

Console.Write("Quantità di cibi:");

Console.WriteLine(cibiPreferiti.Length);

var ciboPreferito1 = cibiPreferiti[0];
var ciboPreferito5 = cibiPreferiti[4];
var ciboPreferito2 = cibiPreferiti[2];

for(var i=0; i<cibiPreferiti.Length; i++)
{
    System.Console.WriteLine(cibiPreferiti[i]);

    

}

Console.Write("Primo Piatto preferito: ");
Console.WriteLine(ciboPreferito1);

Console.Write("Ultimo Piatto preferito: ");
Console.WriteLine(ciboPreferito5);

Console.Write(" Piatto medio preferito: ");
Console.WriteLine(ciboPreferito2);
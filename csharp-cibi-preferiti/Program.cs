// See https://aka.ms/new-console-template for more information

//Andiamo a creare il nostro array di Piatti preferiti

string[] cibiPreferiti = { "Hamburger", "Spaghetti alle vongole", "Uova all'occhio di bue", "Fettine Panate", "Patate Lesse" ,"Bollito"};

//Stampiamo a schermo la lunghezza del nostro array

Console.Write($"Quantità di cibi:{cibiPreferiti.Length}");



//Creo le variabili per poi stampare i cibi a parte

var ciboTop = cibiPreferiti[0];
var ciboFinale = cibiPreferiti[5];


//Creiamo un ciclo for per stampare la lista completa

for(var i=0; i<cibiPreferiti.Length; i++)
{
    System.Console.WriteLine(cibiPreferiti[i]);

    

}

//Stampiamo il cibo top lista

Console.WriteLine($"Il cibo top è {ciboTop}");

//Stampiamo il cibo fine lista

Console.WriteLine($"Il cibo fine lista è {ciboFinale}");

//Stampiamo il cibo in mezzo alla lista

if (cibiPreferiti.Length % 2 == 0)
{
    int ciboDiMezzo = cibiPreferiti.Length / 2;
    Console.WriteLine($"Il cibo di mezza classifica è {cibiPreferiti[ciboDiMezzo - 1]} e {cibiPreferiti[ciboDiMezzo]}");
}
else
{
    int ciboDiMezzo = cibiPreferiti.Length / 2;
    Console.WriteLine($"Il cibo di mezza classifica è {cibiPreferiti[ciboDiMezzo]}");
}
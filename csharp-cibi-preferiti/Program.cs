﻿// See https://aka.ms/new-console-template for more information

//Andiamo a creare il nostro array di Piatti preferiti

string[] cibiPreferiti = { "Hamburger", "Spaghetti alle vongole", "Uova all'occhio di bue", "Fettine Panate", "Patate Lesse" };

//Stampiamo a schermo la lunghezza del nostro array

Console.Write("Quantità di cibi:");

Console.WriteLine(cibiPreferiti.Length);

//Creo le variabili per poi stampare i cibi a parte

var ciboPreferito1 = cibiPreferiti[0];
var ciboPreferito5 = cibiPreferiti[4];
var ciboPreferito2 = cibiPreferiti[2];

//Creiamo un ciclo for per stampare la lista completa

for(var i=0; i<cibiPreferiti.Length; i++)
{
    System.Console.WriteLine(cibiPreferiti[i]);

    

}

//Stampiamo il cibo top lista

Console.Write("Primo Piatto preferito: ");
Console.WriteLine(ciboPreferito1);

//Stampiamo il cibo fine lista

Console.Write("Ultimo Piatto preferito: ");
Console.WriteLine(ciboPreferito5);

//Stampiamo il cibo in mezzo alla lista

Console.Write(" Piatto medio preferito: ");
Console.WriteLine(ciboPreferito2);
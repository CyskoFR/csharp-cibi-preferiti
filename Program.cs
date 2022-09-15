// See https://aka.ms/new-console-template for more information

//Create un progetto App Console CibiPreferiti con VS2022. Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
//La lunghezza della classifica
//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
//Il vostro cibo top (prima posizione della classifica)
//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
//Le modalità di consegna sono le solite: repo GitHub, commit e push
//BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.

using System;

string[] prefFoods = { "Mela", "Arancia", "Kiwi", "Pane", "Gelato", "Cioccolato" };

//La lunghezza della classifica
Console.WriteLine($"La lunghezza della classifica: {prefFoods.Length} elementi in array");

//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
int rank = 1;
Console.WriteLine("La classifica: ");
foreach (var elm in prefFoods)
{
    Console.WriteLine($"n.{rank} - {elm}");
    rank++;
}


//Il vostro cibo top (prima posizione della classifica)
Console.WriteLine($"Il mio preferito: {prefFoods[0]}");

//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Console.WriteLine($"Il mio preferito ma anche no: {prefFoods[prefFoods.Length-1]}");

//BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.
var middleFood = "";
if (prefFoods.Length % 2 != 0)
{
    middleFood = prefFoods[prefFoods.Length/2];
}
else
{
    middleFood = ($"{prefFoods[prefFoods.Length/2]}, {prefFoods[prefFoods.Length / 2-1]}");
}
Console.WriteLine($"Il cibo o i cibi di mezza classifica: {middleFood}");
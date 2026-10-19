/*
Uppgift 1: Bas- och underklass (Fordon och Bil)
Skapa en basklass som heter Fordon med ett fält för Märke. Skapa en underklass Bil
som ärver från Fordon och lägger till ett eget fält för AntalDörrar. Instansiera en Bil i
Main och visa hur den kommer åt båda fälten.
*/

var bil = new Bil();

bil.Märke = "Volvo";
bil.AntalDörrar = 5;

System.Console.WriteLine($"Bilen är en {bil.Märke} med {bil.AntalDörrar} dörrar.");

public class Fordon
{
    public string Märke;
}

public class Bil : Fordon
{
    public int AntalDörrar;
}
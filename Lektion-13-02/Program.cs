/*
Uppgift 2: Konstruktorer vid arv (Djur och Katt)
Skapa en basklass Djur som har en konstruktor som tar emot ett Namn. Skapa en
underklass Katt som ärver från Djur. Använd base-nyckelordet i kattens konstruktor för
att skicka namnet vidare till basklassen.
*/

var katt = new Katt("Foo");

System.Console.WriteLine($"Katten heter {katt.Namn}!");

public class Djur
{
    public string Namn;

    public Djur(string namn)
    {
        Namn = namn;
    }
}

public class Katt : Djur
{
    public Katt(string namn):base(namn)
    {
        
    }
}


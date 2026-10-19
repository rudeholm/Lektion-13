/*
Uppgift 10: Flera abstrakta underklasser (Kvadrat)
Skapa ytterligare en klass Kvadrat som ärver från GeometriskForm. Ge den en helt
egen implementering av den abstrakta metoden Rita(). Visa i Main hur du skapar en
Cirkel och en Kvadrat och anropar deras respektive metoder.
*/

internal class Program
{
    static void Main()
    {
        var c = new Cirkel();
        var k = new Kvadrat();
        c.Färg = "Röd";
        k.Färg = "Grön";
        c.Rita();
        k.Rita();
    }
}

public abstract class GeometriskForm
{
public string? Färg { get; set; }
    public abstract void Rita();
}

public class Cirkel : GeometriskForm
{
    public override void Rita()
    {
        Console.WriteLine($"Rita en {Färg} cirkel");
    }
}

public class Kvadrat : GeometriskForm
{
    public override void Rita()
    {
        Console.WriteLine($"Rita en {Färg} kvadrat");
    }
}
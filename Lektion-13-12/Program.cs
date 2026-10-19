/*
Uppgift 12: Implementera ett gränssnitt (Mobiltelefon)
Skapa en klass Mobiltelefon som implementerar gränssnittet ILaddbar. Skriv den
konkreta koden för metoden Ladda() i klassen så att den skriver ut "Telefonen
laddas..." i konsolen.
*/

internal class Program
{
    static void Main()
    {
        var telefon = new Mobiltelefon();
        telefon.Ladda();
    }
}

class Mobiltelefon : ILaddbar
{
    public void Ladda()
    {
        System.Console.WriteLine("Telefonen laddas...");
    }
}

public interface ILaddbar
{
    public void Ladda();
}
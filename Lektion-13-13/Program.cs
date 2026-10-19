/*
Uppgift 13: Flera klasser, samma gränssnitt (Elbil)
Skapa en till klass Elbil som också implementerar gränssnittet ILaddbar. Ge den en
egen logik för metoden Ladda(). Visa i Main hur båda klasserna tvingas följa samma
kontrakt.
*/

internal class Program
{
    static void Main()
    {
        var telefon = new Mobiltelefon();
        telefon.Ladda();
        var bil = new Elbil();
        bil.Ladda();
    }
}

class Elbil : ILaddbar
{
    public void Ladda()
    {
        System.Console.WriteLine("Elbilen laddas... (med en mycket större sladd)");
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
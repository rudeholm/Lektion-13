/*
Uppgift 14: Utmaning – Kombinera flera gränssnitt
Skapa ytterligare ett gränssnitt IGps med metoden HämtaPosition(). Skapa klassen
SmartKlocka som implementerar både ILaddbar och IGps. Visa hur en klass kan ha
flera olika gränssnitt samtidigt.
*/

internal class Program
{
    static void Main()
    {
        var telefon = new Mobiltelefon();
        telefon.Ladda();
        var bil = new Elbil();
        bil.Ladda();
        var klocka = new SmartKlocka();
        klocka.Ladda();
        klocka.HämtaPosition();
    }
}

class SmartKlocka : ILaddbar, IGps
{
    public void HämtaPosition()
    {
        System.Console.WriteLine("Du är HÄR!");
    }

    public void Ladda()
    {
        System.Console.WriteLine("Klockan laddar... (trådlöst)");
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

public interface IGps
{
    public void HämtaPosition();
}

public interface ILaddbar
{
    public void Ladda();
}
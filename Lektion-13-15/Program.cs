/*
Uppgift 15: Utmaning – Abstrakt klass kombinerat med
Gränssnitt
Skapa en abstrakt basklass Maskin. Skapa sedan en underklass Robot som ärver från
Maskin och samtidigt implementerar gränssnittet ILaddbar. Visa hur syntaxen ser ut i
klasshuvudet när man kombinerar arv med gränssnitt.
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
        var kenny = new Robot();
        kenny.Ladda();
    }
}

public class Robot : Maskin, ILaddbar
{
    public void Ladda()
    {
        System.Console.WriteLine("Roboten laddar... (sig själv!)");
    }
}

public abstract class Maskin
{
    
}

public class SmartKlocka : ILaddbar, IGps
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

public class Elbil : ILaddbar
{
    public void Ladda()
    {
        System.Console.WriteLine("Elbilen laddas... (med en mycket större sladd)");
    }
}

public class Mobiltelefon : ILaddbar
{
    public void Ladda()
    {
        System.Console.WriteLine("Telefonen laddas...");
    }
}

interface IGps
{
    public void HämtaPosition();
}

interface ILaddbar
{
    public void Ladda();
}
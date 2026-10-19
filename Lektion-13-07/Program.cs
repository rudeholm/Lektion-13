/*
Uppgift 7: Skrivskyddad inkapsling (SpelKaraktär)
Skapa en klass SpelKaraktär som har egenskaper för Hälsa och MaxHälsa. Hälsan ska
ha en publik get men en privat set. Lägg till en metod TaSkada(int skada) som
sänker hälsan men skyddar den från att bli negativ.
*/

internal class Program
{
    static void Main()
    {
        var gubbe = new SpelKaraktär();
        gubbe.TaSkada(33);
        gubbe.TaSkada(33);
    }
}

public class SpelKaraktär
{
    public int Hälsa { get; private set; } = 45;
    public int MaxHälsa { get; private set; } = 45;

    public void TaSkada(int skada)
    {
        Hälsa = Math.Max(0, Hälsa - skada);
        
        if (Hälsa <= 0)
            System.Console.WriteLine("Död!");
        else
            System.Console.WriteLine("Ny Hälsopoäng: {0}/{1}", Hälsa, MaxHälsa);
    }
}
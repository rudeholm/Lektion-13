/*
Uppgift 4: Arv och åtkomstnivån protected
Skapa en klass Konto med en variabel för KontoNummer markerad som protected.
Skapa en underklass Sparkonto. Visa i underklassen att du kommer åt variabeln, men
att den är helt dold om man försöker nå den direkt från ett objekt i Main.
*/

var konto = new Sparkonto(123456);

System.Console.WriteLine(konto.VisaKontoNummer());


public class Konto
{
    protected int KontoNummer;
}

public class Sparkonto : Konto
{
    public Sparkonto(int kontoNummer)
    {
        KontoNummer = kontoNummer;
    }

    internal int VisaKontoNummer()
    {
        
        return KontoNummer;
    }
}
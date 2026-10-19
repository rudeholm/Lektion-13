/*
Uppgift 3: Treledshierarki (Anställd -> Manager -> VD)
Skapa en klasshierarki i tre led: Basklassen Anställd, underklassen Manager och
underklassen VD (som ärver från Manager). Lägg till en specifik egenskap eller metod på
varje nivå och instansiera en VD i Main.
*/

var chef = new VD();
chef.Lön = 85_000;
chef.Avdelning = "HQ";
chef.AntalAktier = 500;

System.Console.WriteLine($"VD Lön: {chef.Lön}, Avdelning: {chef.Avdelning}, Antal Aktier: {chef.AntalAktier}");

public class Anställd
{
    public double Lön;
}

public class Manager : Anställd
{
    public string Avdelning;
}

public class VD : Manager
{
    public int AntalAktier;
}


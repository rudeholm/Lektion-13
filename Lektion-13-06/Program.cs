/*
Uppgift 6: Inkapsling med validering (AnvändarProfil)
Skapa en klass AnvändarProfil med en privat variabel för Lösenord. Skapa en
egenskap (property) som gör det möjligt att ändra lösenordet, men bara om det nya
lösenordet är minst 6 tecken långt.
*/

public class AnvändarProfil
{
    private string _lösenord;

    public string Lösenord
    {
        get { return "********"; }
        set
        {
            if (value.Length >= 12)
            {
                _lösenord = value;
                System.Console.WriteLine("Lösenordet har ändrats.");
            }
            else
            {
                System.Console.WriteLine("FEL: Lösenordet måste vara minst 12 tecken långt!");
            }
        }
    }
}

internal class Program
{
    static void Main()
    {
        var profil = new AnvändarProfil();
        profil.Lösenord = "123";
        profil.Lösenord = "0123456789ABCDEF";
        System.Console.WriteLine("Hemligt lösenord: {0}", profil.Lösenord);
    }
}
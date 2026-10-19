/*
Uppgift 9: Implementera en abstrakt klass (Cirkel)
Skapa en underklass Cirkel som ärver från den abstrakta klassen GeometriskForm i
föregående uppgift. Använd nyckelordet override för att tvinga fram en konkret
implementering av metoden Rita().
*/

public abstract class GeometriskForm
{
    public string Färg { get; set; }
    public abstract void Rita();
}

public class Cirkel : GeometriskForm
{
    public override void Rita()
    {
        System.Console.WriteLine("Rita cirkeln");
    }
}
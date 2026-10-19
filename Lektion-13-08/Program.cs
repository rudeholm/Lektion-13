/*
Uppgift 8: Enkel abstrakt klass (GeometriskForm)
Skapa en abstrakt klass GeometriskForm som har en vanlig egenskap för Färg och en
abstrakt metod Rita(). Förklara varför du inte kan skapa ett objekt av typen
GeometriskForm med new.
*/

// Abstrakta klasser kan inte instantieras!
abstract class GeometriskForm
{
    public string Färg { get; set; }
    public abstract void Rita();
}
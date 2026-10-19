/*
Uppgift 5: Åtkomstnivån internal
Skapa en klass SystemModul och markera den som internal. Skapa ett objekt av
klassen i Main och förklara vad det innebär för synligheten om koden skulle delas upp i
flera olika assemblies (DLL-filer).
*/

// Klassen är synlig inom samma assembly (project)
internal class SystemModul
{

}

internal class Program
{
    static void Main()
    {
        var modul = new SystemModul();

    }
}
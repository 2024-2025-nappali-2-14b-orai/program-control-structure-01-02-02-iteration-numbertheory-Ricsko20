// See https://aka.ms/new-console-template for more information
using SzamelmeletProjekt;

// Nem kell példányosítani a statikus osztályokat
// Szamelmelet szamelmelet = new Szamelmelet();

// Statikus osztályokat osztálynévvel érjük el
Console.WriteLine(Szamelmelet.OsztoE(5,35));
Console.WriteLine(Szamelmelet.OsztoE(8,35));

Console.WriteLine(Szamelmelet.ListaToString(Szamelmelet.GetOsztok(6)));

Console.WriteLine("Kétjegyű prímszámok: ");
Console.WriteLine(Szamelmelet.ListaToString(Szamelmelet.GetPrimszamok(10, 99)));

Console.WriteLine(Szamelmelet.TokeletesE(7));

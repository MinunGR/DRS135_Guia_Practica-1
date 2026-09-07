namespace ResEjercicios._04_Polimorfismo;

public class Perro : Animal
{
    // Sobrescritura de método
    public override void HacerSonido() => Console.WriteLine("Guau guau (waos)!");
}

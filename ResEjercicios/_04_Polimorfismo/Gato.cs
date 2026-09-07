namespace ResEjercicios._04_Polimorfismo;

public class Gato : Animal
{
    // Sobrescritura de método
    public override void HacerSonido() => Console.WriteLine("Miau miau! (larry)");
}

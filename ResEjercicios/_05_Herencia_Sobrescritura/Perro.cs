namespace ResEjercicios._05_Herencia_Sobrescritura;

public class Perro : Mamifero
{
    // Sobrescritura de método
    public override void HacerSonido() => Console.WriteLine("El perro realiza sonido de ladrido.");
}

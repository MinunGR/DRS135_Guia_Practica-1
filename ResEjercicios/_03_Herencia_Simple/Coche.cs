namespace ResEjercicios._03_Herencia_Simple;

public class Coche : Vehiculo // Herencia simple
{
    // Método propio de la clase Coche
    public void Conducir() => Console.WriteLine("El coche está en movimiento.");
}
class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Coche
        Coche coche = new Coche();
        // Heredados
        coche.Arrancar();
        coche.Detener();
        // Propios
        coche.Conducir();
    }
}
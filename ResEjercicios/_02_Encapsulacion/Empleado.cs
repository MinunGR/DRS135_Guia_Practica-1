namespace ResEjercicios._02_Encapsulacion;

public class Empleado
{
    // Atributos Privados
    private string nombre;
    private int edad;


    // Propiedad para campo nombre
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    // Propiedad para campo edad
    public int Edad
    {
        get { return edad; }
        set
        {
            // Definimos regla para campo edad
            if (value > 0 && value < 100)
            {
                edad = value;
            }
            else
            {
                Console.WriteLine("La edad debe ser mayor que 0 y menor que 100.");
            }
            ;
        }
    }
}

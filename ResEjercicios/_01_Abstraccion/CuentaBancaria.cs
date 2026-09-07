namespace ResEjercicios._01_Abstraccion;

// Ejercicio 1: Implementación de Abstracción de Datos
public class CuentaBancaria
{
    
    private decimal saldo; // Atributo privado

    public CuentaBancaria(decimal saldoInicial = 0)
    {
        if (saldoInicial >= 0) saldo = saldoInicial;
    }

    // Función utilizada para registrar el deposito a cuenta
    public void Depositar(decimal monto)
    {
        if (monto <= 0) { Console.WriteLine("El monto debe ser mayor a $0.00."); return; }
        saldo += monto;
    }

    // Función utilizada para registrar un retiro de cuenta
    public bool Retirar(decimal monto)
    {
        if (monto <= 0) { Console.WriteLine("El monto debe ser mayor a $0.00."); return false; }
        if (monto > saldo) { Console.WriteLine("Fondos insuficientes, intente de nuevo."); return false; }

        saldo -= monto;
        return true;
    }

    // Función que devuelve el valor del saldo actual
    public decimal ObtenerSaldo() => saldo;
}

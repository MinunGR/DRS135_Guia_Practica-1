using System;
using ResEjercicios._01_Abstraccion;
using ResEjercicios._02_Encapsulacion;
using ResEjercicios._03_Herencia_Simple;
using ResEjercicios._04_Polimorfismo;
using ResEjercicios._05_Herencia_Sobrescritura;

// Usamos un Alias para evitar conflicto entre las clases "Perro"
using Perro04 = ResEjercicios._04_Polimorfismo.Perro;
using Perro05 = ResEjercicios._05_Herencia_Sobrescritura.Perro;

Console.WriteLine("==================================================");
Console.WriteLine("    PRUEBAS DE LA GUÍA PRÁCTICA 1 - POO EN C#     ");
Console.WriteLine("==================================================\n");

// --------------------------------------------------
// • Ejercicio 1: Implementación de Abstracción de Datos 
// --------------------------------------------------
Console.WriteLine("--- EJERCICIO 1: Abstracción (CuentaBancaria) ---");
CuentaBancaria cuenta = new CuentaBancaria(100.00m);
Console.WriteLine("Saldo inicial: $" + cuenta.ObtenerSaldo());

Console.WriteLine("\n[Prueba de depósito]");
cuenta.Depositar(50.00m);
Console.WriteLine("Saldo actual: $" + cuenta.ObtenerSaldo());

Console.WriteLine("\n[Prueba de depósito inválido (monto negativo o cero)]");
cuenta.Depositar(-20.00m);

Console.WriteLine("\n[Prueba de retiro]");
cuenta.Retirar(30.00m);
Console.WriteLine("Saldo actual: $" + cuenta.ObtenerSaldo());

Console.WriteLine("\n[Prueba de fondos insuficientes]");
cuenta.Retirar(500.00m);
Console.WriteLine("Saldo final: $" + cuenta.ObtenerSaldo());


// --------------------------------------------------
// • Ejercicio 2: Encapsulación y Control de Acceso 
// --------------------------------------------------
Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine("--- EJERCICIO 2: Encapsulación (Empleado) ---");
Empleado empleado = new Empleado();
empleado.Nombre = "Carlos Mendoza";

Console.WriteLine("Empleado : " + empleado.Nombre);

Console.WriteLine("\n[Prueba de edad (entre 1 y 99)]");
empleado.Edad = 25;
Console.WriteLine("Edad asignada con éxito: " + empleado.Edad);

Console.WriteLine("\n[Prueba de edad menor o igual a 0]");
empleado.Edad = -5;
Console.WriteLine("Edad actual tras intento inválido: " + empleado.Edad);

Console.WriteLine("\n[Prueba de edad mayor o igual a 100]");
empleado.Edad = 105;
Console.WriteLine("Edad actual tras intento inválido: " + empleado.Edad);


// --------------------------------------------------
// • Ejercicio 3: Herencia Simple
// --------------------------------------------------
Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine("--- EJERCICIO 3: Herencia Simple (Coche) ---");
Coche miCoche = new Coche();

miCoche.Arrancar(); // Heredado de Vehiculo
miCoche.Conducir(); // Propio de Coche
miCoche.Detener();  // Heredado de Vehiculo


// --------------------------------------------------
// • Ejercicio 4: Polimorfismo
// --------------------------------------------------
Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine("--- EJERCICIO 4: Polimorfismo ---");

// Demostración con referencia de tipo base Animal
Animal animalReferencia;

animalReferencia = new Perro04();
Console.Write("Instancia Perro asignada a referencia Animal -> ");
animalReferencia.HacerSonido();

animalReferencia = new Gato();
Console.Write("Instancia Gato asignada a referencia Animal -> ");
animalReferencia.HacerSonido();


// --------------------------------------------------
// Ejercicio 5: Herencia Multinivel y Sobrescritura de Métodos
// --------------------------------------------------
Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine("--- EJERCICIO 5: Herencia Multinivel ---");
Perro05 perroMultinivel = new Perro05();

Console.Write("Método sobrescrito y heredado HacerSonido() -> ");
perroMultinivel.HacerSonido();

Console.Write("Método heredado Alimentar() de Mamifero -> ");
perroMultinivel.Alimentar();

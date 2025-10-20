using System;

namespace estructurasdecontrol_3147912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su primer nota: .");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segunda nota: .");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tercera nota: .");
            float nota3 = float.Parse(Console.ReadLine());

            float promedio = (nota1 * 0.2f) + (nota2 * 0.3f) + (nota3 * 0.5f);
            if (promedio >=3)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("No aprobado");                                                                                                                          
            }

            Console.Write("Ingrese el monto del préstamo: ");
            double prestamo = Convert.ToDouble(Console.ReadLine());

            
            double tasa = 0.05; 
            int años = 5;

            
            double interesAnual = prestamo * tasa;
            double interesTrimestre = interesAnual / 4;   
            double interesMensual = interesAnual / 12;    
            double interesTotal = interesAnual * años;    
            double montoTotal = prestamo + interesTotal;

            
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"1. Interés pagado en un año: {interesAnual:C}");
            Console.WriteLine($"2. Interés pagado en el tercer trimestre: {interesTrimestre:C}");
            Console.WriteLine($"3. Interés pagado en el primer mes: {interesMensual:C}");
            Console.WriteLine($"4. Total a pagar (incluyendo intereses): {montoTotal:C}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

            //Ejercicio#1
            double salario, ahorro, eps, pension, totalRecibir;

            Console.Write("Ingrese el salario del empleado: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de ahorro mensual programado: ");
            ahorro = double.Parse(Console.ReadLine());

            eps = salario * 0.125;
            pension = salario * 0.16;
            totalRecibir = salario - eps - pension - ahorro;

            Console.WriteLine("\n--- Colilla de Pago ---");
            Console.WriteLine($"Salario: {salario}");
            Console.WriteLine($"Ahorro mensual: {ahorro}");
            Console.WriteLine($"Descuento EPS (12.5%): {eps}");
            Console.WriteLine($"Descuento Pensión (16%): {pension}");
            Console.WriteLine($"Total a recibir: {totalRecibir}");

            //Ejercicio#2
            double matricula, cuota1, cuota2, cuota3, cuota4;

            Console.Write("Ingrese el valor total de la matrícula: ");
            matricula = double.Parse(Console.ReadLine());

            cuota1 = matricula * 0.40;
            cuota2 = matricula * 0.25;
            cuota3 = matricula * 0.20;
            cuota4 = matricula * 0.15;

            Console.WriteLine("\n--- Cuotas de pago ---");
            Console.WriteLine($"Primera cuota (40%): {cuota1}");
            Console.WriteLine($"Segunda cuota (25%): {cuota2}");
            Console.WriteLine($"Tercera cuota (20%): {cuota3}");
            Console.WriteLine($"Cuarta cuota (15%): {cuota4}");

            //ejercicio#3
            string nombre, direccion;
            int anioNacimiento, anioActual, edad;

            Console.Write("Ingrese el nombre del aprendiz: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la dirección: ");
            direccion = Console.ReadLine();

            Console.Write("Ingrese el año de nacimiento: ");
            anioNacimiento = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año actual: ");
            anioActual = int.Parse(Console.ReadLine());

            edad = anioActual - anioNacimiento;

            Console.WriteLine($"\nNombre: {nombre}");
            Console.WriteLine($"Dirección: {direccion}");
            Console.WriteLine($"Edad: {edad} años");

            //ejercicio#4
            double tiempo1 = 1.5; // 1 hora y media para 1 litro
            double tiempo3, tiempo5;

            tiempo3 = (tiempo1 / 1) * 3;
            tiempo5 = (tiempo1 / 1) * 5;

            Console.WriteLine($"Tiempo para llenar el balde de 3 litros: {tiempo3} horas");
            Console.WriteLine($"Tiempo para llenar el balde de 5 litros: {tiempo5} horas");

            //ejercicio#5
            double tiempo = 5; // horas
            double altura = 7; // metros
            double nuevaAltura, nuevoTiempo;

            Console.Write("Ingrese la altura que desea subir (en metros): ");
            nuevaAltura = double.Parse(Console.ReadLine());

            nuevoTiempo = (nuevaAltura * tiempo) / altura;

            Console.WriteLine($"Tiempo estimado de subida: {nuevoTiempo} horas");

            //ejercicio#6
            double montoPrestamo, tasaAnual = 0.05, interesAnualCalculado, interesTrimestre3, interesPrimerMes, totalConInteres;

            Console.Write("Ingrese el monto del préstamo del estudiante: ");
            montoPrestamo = double.Parse(Console.ReadLine());

            interesAnualCalculado = montoPrestamo * tasaAnual;
            interesTrimestre3 = interesAnualCalculado / 4 * 3;  // Interés del tercer trimestre
            interesPrimerMes = interesAnualCalculado / 12;      // Interés del primer mes
            totalConInteres = montoPrestamo + (interesAnualCalculado * 5); // 5 años de interés

            Console.WriteLine($"\nInterés generado en un año: {interesAnualCalculado}");
            Console.WriteLine($"Interés del tercer trimestre: {interesTrimestre3}");
            Console.WriteLine($"Interés del primer mes: {interesPrimerMes}");
            Console.WriteLine($"Total a pagar (5 años con intereses): {totalConInteres}");
        }
    }
}

 




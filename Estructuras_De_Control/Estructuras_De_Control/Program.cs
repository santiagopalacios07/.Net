using System;
using System.Collections.Generic;

namespace estructurasdecontrol_3147912
{
    internal class Program
    {
        static List<Producto> productos = new List<Producto>();

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su primer nota: .");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segunda nota: .");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tercera nota: .");
            float nota3 = float.Parse(Console.ReadLine());

            float promedio = (nota1 * 0.2f) + (nota2 * 0.3f) + (nota3 * 0.5f);
            if (promedio >= 3)
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

            Console.WriteLine("\nPresione cualquier tecla para continuar con los demás ejercicios...");
            Console.ReadKey();

            // Ejercicio #1
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

            // Ejercicio #2
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

            // Ejercicio #3
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

            // Ejercicio #4
            double tiempo1 = 1.5;
            double tiempo3, tiempo5;

            tiempo3 = (tiempo1 / 1) * 3;
            tiempo5 = (tiempo1 / 1) * 5;

            Console.WriteLine($"Tiempo para llenar el balde de 3 litros: {tiempo3} horas");
            Console.WriteLine($"Tiempo para llenar el balde de 5 litros: {tiempo5} horas");

            // Ejercicio #5
            double tiempo = 5;
            double altura = 7;
            double nuevaAltura, nuevoTiempo;

            Console.Write("Ingrese la altura que desea subir (en metros): ");
            nuevaAltura = double.Parse(Console.ReadLine());

            nuevoTiempo = (nuevaAltura * tiempo) / altura;

            Console.WriteLine($"Tiempo estimado de subida: {nuevoTiempo} horas");

            // Ejercicio #6
            double montoPrestamo, tasaAnual = 0.05, interesAnualCalculado, interesTrimestre3, interesPrimerMes, totalConInteres;

            Console.Write("Ingrese el monto del préstamo del estudiante: ");
            montoPrestamo = double.Parse(Console.ReadLine());

            interesAnualCalculado = montoPrestamo * tasaAnual;
            interesTrimestre3 = interesAnualCalculado / 4 * 3;
            interesPrimerMes = interesAnualCalculado / 12;
            totalConInteres = montoPrestamo + (interesAnualCalculado * 5);

            Console.WriteLine($"\nInterés generado en un año: {interesAnualCalculado}");
            Console.WriteLine($"Interés del tercer trimestre: {interesTrimestre3}");
            Console.WriteLine($"Interés del primer mes: {interesPrimerMes}");
            Console.WriteLine($"Total a pagar (5 años con intereses): {totalConInteres}");

            // Ejecución del menú de productos
            Console.WriteLine("\nPresione cualquier tecla para ingresar al menú de productos...");
            Console.ReadKey();
            EjecutarMenuProductos();
        }

        // --------- MÉTODOS DEL MENÚ DE PRODUCTOS ---------
        static void EjecutarMenuProductos()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Menú de productos:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Actualizar producto");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarProducto();
                        break;
                    case "2":
                        MostrarProductos();
                        break;
                    case "3":
                        ActualizarProducto();
                        break;
                    case "4":
                        EliminarProducto();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AgregarProducto()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            decimal precio;
            while (true)
            {
                Console.Write("Ingrese el precio del producto: ");
                if (decimal.TryParse(Console.ReadLine(), out precio) && precio >= 0)
                    break;
                else
                    Console.WriteLine("Precio inválido. Intente de nuevo.");
            }

            productos.Add(new Producto(nombre, precio));
            Console.WriteLine("Producto agregado correctamente. Presione una tecla para continuar.");
            Console.ReadKey();
        }

        static void MostrarProductos()
        {
            Console.Clear();
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos para mostrar.");
            }
            else
            {
                Console.WriteLine("Lista de productos:");
                for (int i = 0; i < productos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {productos[i].Nombre} - ${productos[i].Precio}");
                }
            }
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }

        static void ActualizarProducto()
        {
            Console.Clear();
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos para actualizar.");
                Console.ReadKey();
                return;
            }

            MostrarProductos();
            Console.Write("Seleccione el número del producto que desea actualizar: ");

            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= productos.Count)
            {
                index -= 1;

                Console.Write("Ingrese el nuevo nombre del producto: ");
                string nuevoNombre = Console.ReadLine();

                decimal nuevoPrecio;
                while (true)
                {
                    Console.Write("Ingrese el nuevo precio del producto: ");
                    if (decimal.TryParse(Console.ReadLine(), out nuevoPrecio) && nuevoPrecio >= 0)
                        break;
                    else
                        Console.WriteLine("Precio inválido. Intente de nuevo.");
                }

                productos[index].Nombre = nuevoNombre;
                productos[index].Precio = nuevoPrecio;

                Console.WriteLine("Producto actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Selección inválida.");
            }

            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }

        static void EliminarProducto()
        {
            Console.Clear();
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos para eliminar.");
                Console.ReadKey();
                return;
            }

            MostrarProductos();
            Console.Write("Seleccione el número del producto que desea eliminar: ");

            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= productos.Count)
            {
                index -= 1;
                productos.RemoveAt(index);
                Console.WriteLine("Producto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Selección inválida.");
            }

            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }
    }

    
    class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}

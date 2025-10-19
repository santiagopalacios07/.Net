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
        }
    }
}

 




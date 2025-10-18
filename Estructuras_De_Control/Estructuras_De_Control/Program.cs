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
        }
    }
}

 




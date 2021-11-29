using System;

namespace Años
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa tu fecha de nacimiento:");
                int fechaNac = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa una fecha futura");
                int fechaFu = Convert.ToInt32(Console.ReadLine());

                const int hoy = 2021;

                int edad = hoy - fechaNac;

                int futuro = fechaFu - fechaNac;

                if (fechaNac <= hoy)
                {
                    Console.WriteLine("Tu edad es: " + edad + " años.");
                }
                else
                {
                    Console.WriteLine("Todavia no haz nacido");
                }

                if (fechaNac <= fechaFu)
                {
                    Console.WriteLine("En este año tendras: " + futuro + " años.");
                }
                else
                {
                    Console.WriteLine("Esta fecha ya paso");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error, Valor incorrecto");
                
            }
            

            Console.ReadKey();
        }
    }
}

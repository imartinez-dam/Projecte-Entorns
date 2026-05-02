using System;

namespace CalculDNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDNI;
            int residu;
            string lletres = "TRWAGMYFPDXBNJZSQVHLCKE";
            char lletraDNI;
            bool correcte;

            do
            {
                Console.WriteLine("=== CALCULADORA DE LLETRA DEL DNI ===");
                Console.WriteLine();

                Console.Write("Introdueix el número del DNI sense lletra: ");
                correcte = int.TryParse(Console.ReadLine(), out numeroDNI);

                if (correcte && numeroDNI >= 0 && numeroDNI <= 99999999)
                {
                    residu = numeroDNI % 23;
                    lletraDNI = lletres[residu];

                    Console.WriteLine();
                    Console.WriteLine("La lletra del DNI és: " + lletraDNI);
                    Console.WriteLine("El DNI complet és: " + numeroDNI.ToString("D8") + lletraDNI); // D8 formata el número amb 8 dígits, afegint zeros al principi si cal
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR: has d'introduir un número de DNI vàlid, entre 0 i 99999999.");
                }
            } while (!correcte || numeroDNI < 0 || numeroDNI > 99999999);
        }
    }
}
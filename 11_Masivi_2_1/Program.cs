using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Masivi_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mas = new string[10];

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"Ievadiet {i +1} masīva vērtību: ");
                mas[i] = Console.ReadLine();    
            }

            for (int i = 0;i < mas.Length;i++) 
            {
            Console.WriteLine($"Masīva {i +1} vērtība ir: {mas[1]}");
            }

            string simboluRinda = string.Join("", mas);

            Console.WriteLine("Apvienotais masīvs:");
            Console.WriteLine(simboluRinda);
        }
    }
}

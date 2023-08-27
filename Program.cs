using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_of_Students_with_Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \t\t\t PENILAIAN MAHASISWA ");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------");

            Console.Write(" Nama  Lengkap         : ");
            string nama = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            Console.Write(" Masukan Angka Pertama : ");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Masukan Angka Kedua   : ");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Masukan Angka Ketiga  : ");
            int angka3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");

            double perkalian = angka1 * angka2 * angka3;
            double pembagian = angka1 / angka2 / angka3;
            double pengurangan = angka1 - angka2 - angka3;

            Console.WriteLine();
            Console.WriteLine($" Nama Lengkap             : {nama}");
            Console.WriteLine($" Hasil perkalian yaitu    : {perkalian} ");
            Console.WriteLine($" Hasil pembagian yaitu    : {pembagian}");
            Console.WriteLine($" Hasil pengurangan yaitu  : {pengurangan}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            if (perkalian > 60)
            {
                Console.WriteLine(" LULUS/BAIK ");
            }
            else
            {
                Console.WriteLine(" TIDAK LULUS/KURANG BAIK");
            }
            if (pembagian > 60)
            {
                Console.WriteLine(" LULUS/BAIK ");
            }
            else
            {
                Console.WriteLine(" TIDAK LULUS/KURANG BAIK");
            }
            if (pengurangan > 60)
            {
                Console.WriteLine(" LULUS/BAIK ");
            }
            else
            {
                Console.WriteLine(" TIDAK LULUS/KURANG BAIK");
            }

            Console.ReadKey();
        }
    }
}

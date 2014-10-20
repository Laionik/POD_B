using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POD_B
{
    class Program
    {
        private static void ZadB()
        {
            Console.WriteLine("|||ZAD B|||");
            string wejscie = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\POD\\cw2" + "\\EN62B_98.txt");
            string wyjscie = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\POD\\cw2" + "\\EN62B_98_WY.txt");
            string[] T = new string[wejscie.Length];
            for (int i = 0; i < wejscie.Length; i++)
            {
                T[i] = wejscie[i] + " " + wyjscie[i];
            }
            string[] Tout = T.Distinct().ToArray();
            Array.Sort(Tout);
            Console.WriteLine("Pary liter");
            foreach (string a in Tout)
            {
                Console.WriteLine(a);
            }
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ,. ";
            string tekst = "";
            Console.WriteLine("\nPo usunięciu duplikatów widzimy przesunięcie o 8 pozycji na alfabecie " + alfabet + "\nRozszyfrowany tekst\n");
            for (int i = 0; i < wejscie.Length; i++)
            {
                tekst += alfabet[(29 + alfabet.IndexOf(wejscie[i]) - 8) % 29];
            }
            Console.WriteLine(tekst);
            File.WriteAllText((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\POD\\cw2" + "\\EN62B_98_OK.txt"), tekst);
        }

        private static void ZadA()
        {
            Console.WriteLine("|||ZAD A|||");
            string wejscie = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\POD\\cw2" + "\\EN62A_89.txt");
            string wyjscie = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\POD\\cw2" + "\\EN62A_89_WY.txt");
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ,. (#";
            int[] Ti = new int[alfabet.Length];
            for (int i = 0; i < Ti.Length; i++)
            {
                Ti[i] = 0;
            }

            foreach (char a in wejscie)
            {
                if (alfabet.IndexOf(a) < alfabet.Length && alfabet.IndexOf(a) >= 0)
                    Ti[alfabet.IndexOf(a)]++;
                else
                {
                    Console.WriteLine("||" + wejscie.IndexOf(a) + "||" + (int)a);
                }
            }

            for (int i = 0; i < Ti.Length; i++)
            {
                Console.WriteLine(alfabet[i] + " " + Ti[i]);
            }
            Console.WriteLine("Dlugosc alfabetu to: " + alfabet.Length);

            string[] T = new string[wejscie.Length];
            for (int i = 0; i < wyjscie.Length; i++)
            {
                T[i] = wejscie[i] + " " + wyjscie[i];
            }
            string[] Tout = T.Distinct().ToArray();
            Array.Sort(Tout);
            Console.WriteLine("Pary liter");
            foreach (string a in Tout)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Wielkość tablicy T {0}, Wielkość tablicy Tout {1}", T.Length, Tout.Length);
        }
        static void Main(string[] args)
        {
            ZadA();
            ZadB();
        }
    }

}

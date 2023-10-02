using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dp = new int[] { 10, 10, 10, 10 };
            bool[] b = new bool[4] { true, true, true, true };
            Console.WriteLine(Convert_Decimale_Puntato_To_Decimale(dp));
            Console.WriteLine(Convert_Binario_To_Intero(b));
            Console.ReadLine();
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[] dp)
        {
            int decimale=0;//Assegno il variabile decimale a 0 in modo che viene ritornato il valore 
            int giroArray= dp.Length - 1;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale += Convert.ToInt32((dp[giroArray] * Math.Pow(256, i)));
                giroArray--;
            }
            return decimale;//
        }
        static int Convert_Binario_To_Intero(bool[] b)
        {
            int decimale = 0;
            int giroArray = b.Length - 1;
            for (int i = 0; i < b.Length; i++)
            {
                decimale += Convert.ToInt32(Convert.ToInt64(b[giroArray]) * Math.Pow(2, i));//Viene restituito un valore di x elevato alla potenza di y Math è una classe
                giroArray--;
            }
            return decimale;
        }
       
    }
}

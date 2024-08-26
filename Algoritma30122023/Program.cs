using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma30122023
{
   /*Calculating the result of multiplying two given numbers without using multiplication
  */
  
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 2, s2 = 3, sonuc = 0;
            for(int i = 0; i < s2; i++)
            {
                sonuc += s1;
            }
            Console.WriteLine(sonuc);
            Console.ReadKey();
        } 
    }
}

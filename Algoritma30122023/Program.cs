using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma30122023
{
    /* kullanıcıdan pozitif olan max 2 basamaklı bir sayı alınacaktır. Alınan bu sayının okunuşu yazı ile yazılacaktır.
  * 11 onbir
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

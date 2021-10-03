
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Mercado_LIvre
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxDigit = 6;
            CalculaDigitos(maxDigit);
        }

        private static void CalculaDigitos(int maxDigit)
        {
            List<int> numeros = new List<int>();
            for (var x = 1000; x < 9999; x++)
            {
                bool verifica = true;

                string convertString = x.ToString();
                for (var y = 0; y < 4; y++)
                {
                    int converInt = Convert.ToInt32(convertString.Substring(y, 1));
                    if (converInt > maxDigit)
                        verifica = false;

                }

                if (verifica == true)
                {
                    numeros.Add(x);
                }


            }

            for (int i = 0; i < numeros.Count; i++)
            {
                string numString = numeros[i].ToString();
                int soma = 0;
                for(var z = 0; z < 4; z++)
                {
                    soma += Convert.ToInt32(numString.Substring(z, 1));
                }
                if (soma == 21)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            Console.ReadKey();
        }
    }
}

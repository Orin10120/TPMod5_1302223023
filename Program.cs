using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * nama: Rindang Bani isyan
 * Kelas: SE-46-03
 * NIM: 1302223023
 **/

namespace TPModul5_1302223023
{
    public class SapaUser<T>
    {
        private T input;

        public SapaUser(T input)
        {
            this.input = input;
        }

        public void PrintUser()
        {
            Console.WriteLine("Halo User " + input);
        }
    }
   
}

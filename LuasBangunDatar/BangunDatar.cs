using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    interface BangunDatar
    {
        void pilihan();
    }

    class luasBangunDatar : BangunDatar
    {
        public void pilihan()
        {
            Menu:
            Console.WriteLine("Pilh Nomor 1-5");
            Console.WriteLine("1. Persegi Panjang");
            Console.WriteLine("2. Persegi");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Lingkaran");
            Console.WriteLine("5. Layang-layang \n");
        }
    }
}

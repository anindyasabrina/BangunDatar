using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class Lingkaran : LuasBangunDatar
    {
        private double jarijari;

        public double Jarijari
        {
            set
            {
                jarijari = value;
            }
            get 
            { 
                return jarijari; 
            }
            
        }

        public override double jumlahLuas()
        {
            hitung = 3.14 * (jarijari *jarijari) ;
            return hitung;
        }
        public override double jumlahKeliling()
        {
            hitung = 2 * 3.14 * jarijari;
            return hitung;
        }
    }
}

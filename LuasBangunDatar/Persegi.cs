using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class Persegi : LuasBangunDatar
    {
        private double sisi;

        public double Sisi
        {
            set
            {
                sisi = value;
            }
            get 
            {
                return sisi; 
            }
            
        }

        public override double jumlahLuas()
        {
            hitung = sisi * sisi;
            return hitung;
        }
        public override double jumlahKeliling()
        {
            hitung = sisi * 4;
            return hitung;
        }

    }
}

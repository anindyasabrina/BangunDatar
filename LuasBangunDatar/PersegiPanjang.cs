using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class PersegiPanjang : LuasBangunDatar
    {
        private double panjang;
        private double lebar;

        public double Panjang
        {
            set
            {
                panjang = value;
            }
            get 
            { 
                return panjang;
            }
            
        }

        public double Lebar
        {
            set
            {
                lebar = value;
            }
            get 
            { 
                return 
                    lebar; 
            }
           
        }
        public override double jumlahLuas ()
        {
            hitung = panjang * lebar;
            return hitung;
        }
        public override double jumlahKeliling()
        {
            hitung = (panjang + lebar) * 2;
            return hitung;
        }
    }
}

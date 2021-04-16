using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class Segitiga : LuasBangunDatar
    {
        private double alas;
        private double tinggi;
        private double sisiSgtg;

        public double Alas
        {
            set
            {
                alas = value;
            }
            get 
            { 
                return alas; 
            }
            
        }

        public double Tinggi
        {
            set
            {
                tinggi = value;
            }
            get
            {
                return tinggi; 
            }
            
        }

        public double SisiSegitiga
        {
            set
            {
                sisiSgtg = value;
            }
            get
            {
                return sisiSgtg;
            }

        }

        public override double jumlahLuas()
        {
            hitung = alas * tinggi / 2;
            return hitung;
        }

        public override double jumlahKeliling()
        {
            hitung = sisiSgtg + sisiSgtg + sisiSgtg;
            return hitung;
        }
    }
}

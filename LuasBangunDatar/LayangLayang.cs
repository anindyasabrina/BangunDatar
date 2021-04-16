using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class LayangLayang : LuasBangunDatar
    {
        private double diagonal1;
        private double diagonal2;
        private double sisiA;
        private double sisiC;

        public double Diagonal1
        {
            set
            {
                diagonal1 = value;
            }
            get 
            { 
                return diagonal1; 
            }
            
        }

        public double Diagonal2
        {
            set
            {
                diagonal2 = value;
            }
            get
            { 
                return diagonal2;
            }
            
        }
        public double SisiA
        {
            set
            {
               sisiA = value;
            }
            get
            {
                return sisiA;
            }

        }
        public double SisiC
        {
            set
            {
                sisiC = value;
            }
            get
            {
                return sisiC;
            }

        }

        public override double jumlahLuas()
        {
            hitung = diagonal1 * diagonal2 / 2;
            return hitung;
        }
        public override double jumlahKeliling()
        {
            hitung = 2 * (sisiA + sisiC);
            return hitung;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    abstract class LuasBangunDatar
    {
        public double hitung;
     
        public double Hitung
        {
            set
            {
                hitung = value;
            }
            get
            {
                return hitung;
            }
            
        }
        public abstract double jumlahLuas();
        public abstract double jumlahKeliling();
    }
}

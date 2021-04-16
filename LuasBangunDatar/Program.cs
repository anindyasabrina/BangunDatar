using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class Program
    {
       static void Main(string[] args)
        {
            luasBangunDatar pil = new luasBangunDatar();
            pil.pilihan();

            Menu:
             int pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {

            case 1:  
            PersegiPanjang pp = new PersegiPanjang();
            Console.WriteLine("Persegi Panjang");
            Console.Write("Nilai Panjang : ");
            pp.Panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai Lebar : ");
            pp.Lebar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas : " + pp.jumlahLuas());
            Console.WriteLine("Keliling : " + pp.jumlahKeliling());
            break;

            case 2:
            Persegi p = new Persegi();
            Console.WriteLine("Persegi");
            Console.Write("Nilai Sisi : ");
            p.Sisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas : " + p.jumlahLuas());
            Console.WriteLine("Keliling : " + p.jumlahKeliling());
            break;

            case 3:
            Segitiga s = new Segitiga();
            Console.WriteLine("Segitiga");
            Console.Write("Nilai Alas : ");
            s.Alas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai Tinggi : ");
            s.Tinggi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai Sisi : ");
            s.SisiSegitiga = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas : " + s.jumlahLuas());
            Console.WriteLine("Keliling : " + s.jumlahKeliling());
            break;

            case 4:
            Lingkaran l = new Lingkaran();
            Console.WriteLine("Lingkaran");
            Console.Write("Nilai Jari-jari : ");
            l.Jarijari = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas : " + l.jumlahLuas());
            Console.WriteLine("Keliling : " + l.jumlahKeliling());
                    break;

                case 5:
            LayangLayang lay = new LayangLayang();                   
            Console.WriteLine("Layang-Layang");
            Console.Write("Nilai Diagonal 1 : ");
            lay.Diagonal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai Diagonal 2 : ");
            lay.Diagonal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai Sisi A : ");
            lay.SisiA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai Sisi C : ");
            lay.SisiC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas : " + lay.jumlahLuas());
            Console.WriteLine("Keliling : " + lay.jumlahKeliling());
            break;
            }

            Console.WriteLine("Type Yes for Restart Program");
            String masuk = Console.ReadLine();
            if (masuk.ToLower() != "Yes")
            {
                Console.WriteLine("Yes".Equals("yes", StringComparison.CurrentCultureIgnoreCase));
                Console.Clear();
                pil.pilihan();
                goto Menu;
            }

        }
    }
}

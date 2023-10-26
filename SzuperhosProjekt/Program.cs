using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Halasi-Czalbert Tibor
            try
            {
                Kepregeny.Szereplok("szuperhos.txt");
            }
            catch (IOException)
            {
                throw new IOException("Rossz fájl nevet adott meg!");
            }
            Kepregeny.Szuperhosok();
        }
    }
}

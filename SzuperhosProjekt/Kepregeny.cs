using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();
        public static void Szereplok(string eleresiUt) 
        {
            StreamReader sr = new StreamReader(eleresiUt);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] darabok = sor.Split(' ');
                string tipus = darabok[0];
                int hanyszorKeszitKutyut = int.Parse(darabok[1]);
                if (tipus == "Batman")
                {
                    Batman batman = new Batman();
                    for (int i = 0; i < hanyszorKeszitKutyut; i++)
                    {
                        batman.KutyutKeszit();
                    }
                    szuperhosok.Add(batman);
                }
                else if(tipus == "Vasember")
                {
                    Vasember vasember = new Vasember();
                    for (int i = 0; i < hanyszorKeszitKutyut; i++)
                    {
                        vasember.KutyutKeszit();
                    }
                    szuperhosok.Add(vasember);
                }
                else
                {
                    throw new Exception("A fájl egy hibás sort tartalmaz!");
                }
            }
            sr.Close();
        }

        public static void Szuperhosok()
        {
            foreach (var item in szuperhosok)
            {
                Console.WriteLine(item);
            }
        }
    }
}

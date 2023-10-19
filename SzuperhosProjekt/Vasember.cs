using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        private Random RND = new Random();
        public Vasember() : base(150,true)
        {
        }

        public void KutyutKeszit()
        {
            double erejeNo = RND.NextDouble()*10;
            this.Szuperero += erejeNo;
        }

        public override bool MegmentiAVilagot()
        {
            if (this.Szuperero > 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Vasember: {base.ToString()}";
        }
    }
}

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preyecto1.RN
{
    public class RNEntero
    {
        public Int32 Num {  get; set; }
        public RNEntero() {
            Num = 1;
        }

        public  Int32 Invertir()
        {
            Int32 ac = 0;
            int NAux = Num;
            while (Num > 0)
            {
                Int32 Residuo = Num % 10;
                ac = ac * 10 + Residuo;
                Num = Num / 10;
            }
            Num = NAux;
            return ac;
        }
        //funcion evaluar primo.- Evalua si un numero entero es primo
        [Benchmark]
        public Boolean Primo()
        {
            for( Int32 i=2;i<=Num;i++)
            {
                Int32 Residuo=Num % i;
                if (Residuo == 0)                {
                    if(Num ==i)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public Boolean Capicua()
        {

            return this.Invertir() == Num;
        }

    }
}

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preyecto1.RN
{
    public class RNVector
    {
        private const Int32 Max = 100;
        RNEntero[] V = new RNEntero[Max];
        public Int32 n { get; set; }
        public RNEntero LeerVector(Int32 Pos)
        {
            return V[Pos];
        }
        public bool Lleno()
        {
            return n == Max;
        }
        public bool InsertarVector(RNEntero ObjEntero)
        {
            if (!Lleno())
            {
                V[n] = ObjEntero;
                n++;
                return true;
            }
            return false;
        }
        private void Intercambiar(ref RNEntero ObjEnteroA, ref RNEntero ObjEnteroB)
        {
            RNEntero AuxObjRnEntero = new RNEntero();
            AuxObjRnEntero.Num = ObjEnteroA.Num;
            ObjEnteroA.Num = ObjEnteroB.Num;
            ObjEnteroB.Num = AuxObjRnEntero.Num;
        }
        [Benchmark]
        public void OrdenarVector()
        {
            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (V[j].Num > V[i].Num)
                    {
                        this.Intercambiar(ref V[i], ref V[j]);
                    }
                }
            }
        }
        //contar primos.- Cuenta los numeros primos del vector
        [Benchmark]
        public Int32 ContarPrimos()
        {
            Int32 Cont = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                if (V[i].Primo())
                {
                    Cont++;
                }
            }
            return Cont;
        }
        [Benchmark]
        public void InvertirVector()
        {
            for (int i = 0; i <= n / 2 - 1; i++){
                this.Intercambiar(ref V[i], ref V[n - (i + 1)]);
            }
        }
    }
}

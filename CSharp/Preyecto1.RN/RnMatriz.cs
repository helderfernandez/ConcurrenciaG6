using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preyecto1.RN
{
    public class RnMatriz
    {

        public Int32 f { set; get; }
        public Int32 c { set; get; }
        public RNEntero[,] M = new RNEntero[100, 100];

        public bool InsertarMatriz(Int32 f, Int32 c, RNEntero Ele)
        {
            try
            {
                M[f, c] = Ele;
                return true;
            }
            catch { return false; }
         }
        public RNEntero LeerMatriz(Int32 f, Int32 c)
        {
            return M[f, c];
        }
        public Int32 ContarPrimos()
        {
            Int32 cont = 0;
            for (Int32 i = 0; i <= f-1; i++)
            {
                for (Int32 j = 0; j <= c-1; j++)
                {
                    if (M[i,j].Primo())
                    {
                        cont++;
                    }
                }
            }
            return cont;

        }
        private void Intercambiar(ref RNEntero ObjEnteroA, ref RNEntero ObjEnteroB)
        {
            RNEntero AuxObjRnEntero = new RNEntero();
            AuxObjRnEntero.Num = ObjEnteroA.Num;
            ObjEnteroA.Num = ObjEnteroB.Num;
            ObjEnteroB.Num = AuxObjRnEntero.Num;
        }
        public void OrdenarMatriz()
        {
            for (Int32 i = 0; i <= f - 1; i++)
            {
                for (Int32 j = 0; j <= c - 1; j++)
                {
                    for (Int32 k = 0; k <= f - 1; k++)
                    {
                        for (Int32 l = 0; l <= c - 1; l++)
                        {
                            if (M[i, j].Num<M[k, l].Num)
                            {
                                this.Intercambiar(ref M[i, j], ref M[k, l]);
                            }
                        }
                    }
                }
            }
        }

        public RnMatriz SumarMatriz(RnMatriz M1,RnMatriz M2)
        {
            RnMatriz Mr=new RnMatriz ();
            for (Int32 i = 0; i <= M1.f - 1; i++){
                for (Int32 j = 0; j <= M1.c - 1; j++){
                    RNEntero ObjRnEntero = new RNEntero();
                    ObjRnEntero.Num = M1.LeerMatriz(i, j).Num + M2.LeerMatriz(i, j).Num;
                    Mr.InsertarMatriz(i, j, ObjRnEntero);
                }
            }
            Mr.f = M1.f;
            Mr.c = M1.c;
            return Mr;
        }
    }
}

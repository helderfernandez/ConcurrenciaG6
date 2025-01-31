using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preyecto1.RN
{
    public class RNMutiplicacion:RNOperacion
    {
        public override Int32 Calcular(RNEntero a, RNEntero b)
        {
            return a.Num * b.Num;
        }
        public override RnMatriz Calcular(RnMatriz a, RnMatriz b)
        {
            RnMatriz M1 = new RnMatriz();
            RNEntero objRnEntero = new RNEntero();
            objRnEntero.Num = a.LeerMatriz(1,1).Num  * b.LeerMatriz (1,1).Num ;
            M1.InsertarMatriz(1, 1, objRnEntero);
            return M1;
        }
    }
}

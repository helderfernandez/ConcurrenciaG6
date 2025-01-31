using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preyecto1.RN
{
    public abstract class RNOperacion
    {
        public abstract int Calcular(RNEntero a, RNEntero  b);
        public abstract RnMatriz Calcular(RnMatriz a, RnMatriz b);
    }
}

using Proyecto1.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preyecto1.RN
{
    public class RNRubro:Contexto
    {
        dbFinanciaCorpEntities Esquema;
        public RNRubro()
        {
            Esquema = this.TraerContexto();
        }
        public List <Rubro >TraerRubro(Int32 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Rubro select e).ToList ();
            }
            else
            {
                return (from e in Esquema.Rubro where e.id.Equals (id) select e).ToList();
            }

        }
    }
}

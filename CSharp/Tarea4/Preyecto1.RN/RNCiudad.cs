using Proyecto1.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preyecto1.RN
{
    public class RNCiudad:Contexto
    {
        dbFinanciaCorpEntities Esquema;
        public RNCiudad()
        {
            Esquema = this.TraerContexto();
        }
        public List<Ciudad> TraerCiudad(Int32 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Ciudad select e).ToList();
            }
            else
            {
                return (from e in Esquema.Ciudad where e.id.Equals(id) select e).ToList();
            }

        }
    }
}

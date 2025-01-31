using Proyecto1.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Contexto
{
    public class Contexto
    {
        public dbFinanciaCorpEntities TraerContexto()
        {
            dbFinanciaCorpEntities cont = new dbFinanciaCorpEntities();
            return cont;
        }
    }
}

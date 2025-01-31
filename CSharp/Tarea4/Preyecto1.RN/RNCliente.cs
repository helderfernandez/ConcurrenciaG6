using Proyecto1.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

using BenchmarkDotNet.Running;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Attributes;

namespace Preyecto1.RN
{
    public  class RNCliente:Contexto 
    {
        dbFinanciaCorpEntities Esquema;
        public RNCliente()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarId () {
             return  (from  e in Esquema.Cliente select e.id).Max()+1;
        }

        //sincrono
        [Benchmark]
        public Boolean InsertarClienteNatural(Cliente Objcliente, Natural ObjNatural){
            using (var transaction = Esquema.Database.BeginTransaction()){
                try
                {
                    Esquema.Cliente.Add(Objcliente);
                    Esquema.Natural.Add(ObjNatural);
                    int changes = Esquema.SaveChanges();
                   if (changes >= 2){
                        transaction.Commit();
                        return true;
                    }
                    else  {
                        transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
        //asincrono
        public async Task<Boolean> InsertarClienteNaturalAsiync(Cliente Objcliente, Natural ObjNatural)
        {
            using (var transaction = Esquema.Database.BeginTransaction())
            {
                try
                {
                    Esquema.Cliente.Add(Objcliente);
                    Esquema.Natural.Add(ObjNatural);
                    int changes = await Esquema.SaveChangesAsync();
                    if (changes >= 2)
                    {
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}

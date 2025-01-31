using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Preyecto1.RN;
using Proyecto1.Datos;

namespace Proyecto1.consulaEvaluacionRendimiento
{
    public class RNEvaluarREndimiento
    {
        [Benchmark (Baseline=true)]
        public void HolaMundobase()
        {
            Thread.Sleep(100);
            Console.WriteLine("Hola Mundo Refactorizado!");
        }

        [Benchmark]
        public void HolaMundoRefactorizado()
        {
            Thread.Sleep(150);
            Console.WriteLine("Hola Mundo Refactorizado!");
        }
        
        [Benchmark]
        public void PruebaPerformRNCliente()
        {
            Cliente ObjCliente = new Cliente();
            RNCliente objRnCliente = new RNCliente();
            ObjCliente.id = objRnCliente.GenerarId();
            ObjCliente.Direccion = "sagfsdgfdh";
            ObjCliente.Telefono = "437437437";
            ObjCliente.Telefono2 = "547548";
            ObjCliente.Nit = 3363664363;
            ObjCliente.idrubro = 1;
            ObjCliente.idCiuddad = 1;

            Natural ObjNatural = new Natural();
            ObjNatural.id = ObjCliente.id;
            ObjNatural.NombreCliente = "reyreyer";
            ObjNatural.ApellidoPaterno = "reyreuerurr";
            ObjNatural.ApellidoMaterno = "reureururre";
            ObjNatural.Genero = "Femenino";
            ObjNatural.DocumentoIdentidad ="485585";
            objRnCliente.InsertarClienteNatural(ObjCliente, ObjNatural);
           
        }

        [Benchmark]
        public  void InsertarClienteNaturalAsiync()
        {
            Cliente ObjCliente = new Cliente();
            RNCliente objRnCliente = new RNCliente();
            ObjCliente.id = objRnCliente.GenerarId();
            ObjCliente.Direccion = "sagfsdgfdh";
            ObjCliente.Telefono = "437437437";
            ObjCliente.Telefono2 = "547548";
            ObjCliente.Nit = 3363664363;
            ObjCliente.idrubro = 1;
            ObjCliente.idCiuddad = 1;
            Natural ObjNatural = new Natural();
            ObjNatural.id = ObjCliente.id;
            ObjNatural.NombreCliente = "reyreyer";
            ObjNatural.ApellidoPaterno = "reyreuerurr";
            ObjNatural.ApellidoMaterno = "reureururre";
            ObjNatural.Genero = "Femenino";
            ObjNatural.DocumentoIdentidad = "485585";
            objRnCliente.InsertarClienteNaturalAsiync(ObjCliente, ObjNatural);

        }
    }
}
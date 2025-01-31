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
        [Benchmark]
        public async Task<bool> PrimoAsync()
        {
            // Ejecutamos el cálculo en un hilo separado para no bloquear el hilo principal
            return await Task.Run(() =>
            {
                if (Num <= 1) return false; // Los números menores o iguales a 1 no son primos

                for (int i = 2; i <= Math.Sqrt(Num); i++) // Solo necesitamos ir hasta la raíz cuadrada de Num
                {
                    if (Num % i == 0) // Si el número es divisible por algún i, no es primo
                    {
                        return false;
                    }
                }
                return true; // Si no encontramos divisores, es primo
            });
        }
        [Benchmark]
        public bool PrimoParalelo()
        {
            if (Num <= 1) return false; // Los números menores o iguales a 1 no son primos

            // Solo necesitamos verificar hasta la raíz cuadrada de Num
            int limite = (int)Math.Sqrt(Num);

            // Usamos Parallel.For para dividir el trabajo de manera eficiente en múltiples hilos
            bool esPrimo = true; // Asumimos que es primo hasta que se demuestre lo contrario

            Parallel.For(2, limite + 1, (i, state) =>
            {
                if (Num % i == 0)
                {
                    esPrimo = false;
                    state.Break(); // Detenemos la iteración tan pronto como encontramos un divisor
                }
            });

            return esPrimo;
        }

        public Boolean Capicua()
        {

            return this.Invertir() == Num;
        }

    }
}

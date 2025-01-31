using Preyecto1.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Test
{

    [TestClass]
    public class UnitTestRNVector
    {
        [TestMethod]
        public void TestMethod11()
        {
            RNEntero ObjRNEntero = new RNEntero();
            RNVector objVector = new RNVector();
            ObjRNEntero.Num = 12;
            objVector.InsertarVector(ObjRNEntero);

            ObjRNEntero.Num = 3;
            objVector.InsertarVector(ObjRNEntero);

            ObjRNEntero.Num = 8;
            objVector.InsertarVector(ObjRNEntero);

            Assert.AreEqual(objVector.ContarPrimos(), 1);

        }

        [TestMethod]
        public void TestMethod11157()
        {
            RNEntero ObjRNEntero = new RNEntero();
            RNVector objVector = new RNVector();
            ObjRNEntero.Num = 1;
            objVector.InsertarVector(ObjRNEntero);

            ObjRNEntero.Num = 5;
            objVector.InsertarVector(ObjRNEntero);

            ObjRNEntero.Num = 7;
            objVector.InsertarVector(ObjRNEntero);

            Assert.AreEqual(objVector.ContarPrimos(), 2);

        }
    }
}

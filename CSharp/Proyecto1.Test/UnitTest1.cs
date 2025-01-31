using Preyecto1.RN;

namespace Proyecto1.Test
{
    [TestClass]
    public class UnitTest1RNEntero
    {
        [TestMethod]
        public void TestMethod11() 
        {
            RNEntero ObjRNEntero = new RNEntero();
            ObjRNEntero.Num = 1;
            Assert.IsFalse(ObjRNEntero.Primo ());

        }

        [TestMethod]
        public void TestMethod2()
        {
            RNEntero ObjRNEntero = new RNEntero();
            ObjRNEntero.Num = 2;
            Assert.IsTrue(ObjRNEntero.Primo());

        }

        [TestMethod]
        public void TestMethod4()
        {
            RNEntero ObjRNEntero = new RNEntero();
            ObjRNEntero.Num = 4;
            Assert.IsFalse(ObjRNEntero.Primo());

        }

        [TestMethod]
        public void TestMethod7()
        {
            RNEntero ObjRNEntero = new RNEntero();
            ObjRNEntero.Num = 7;
            Assert.IsTrue(ObjRNEntero.Primo());

        }
        [TestMethod]
        public void TestMethod100()
        {
            RNEntero ObjRNEntero = new RNEntero();
            ObjRNEntero.Num = 100;
            Assert.IsFalse(ObjRNEntero.Primo());

        }

        [TestMethod]
        public void TestMethod0()
        {
            RNEntero ObjRNEntero = new RNEntero();
            ObjRNEntero.Num = 0;
            Assert.IsFalse(ObjRNEntero.Primo());

        }
    }
}
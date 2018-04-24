using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Numbers_test
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        [TestMethod]
        public void Add_2_to_2_eq_4()
        {
            //arrange
            MyInt dde = new MyInt(2);
            MyInt tdd = new MyInt(2);
            MyInt answer = new MyInt(4);
            //act
            MyInt lol = new MyInt();
            lol = dde.Add(tdd);

            //assert лкул

            Assert.AreEqual(lol.Value, answer.Value);
        }

        [TestMethod]
        public void Add_5_to_5_eq_10()
        {
            //arrange
            MyInt dde = new MyInt(5);
            MyInt tdd = new MyInt(5);
            MyInt answer = new MyInt(10);
            //act
            MyInt lol = new MyInt();
            lol = dde.Add(tdd);

            //assert лкул

            Assert.AreEqual(lol.Value, answer.Value);
        }

        [TestMethod]
        public void Sub_100_55_equals_45()
        {
            MyInt a = new MyInt(100);
            MyInt b = new MyInt(55);
            MyInt ans = new MyInt(45);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);
        }
        [TestMethod]
        public void Sub_100_minus55_equals_155()
        {
            MyInt a = new MyInt(100);
            MyInt b = new MyInt(-55);
            MyInt ans = new MyInt(155);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);
        }

        [TestMethod]
        public void Sub_55_100_equals_45()
        {
            MyInt a = new MyInt(55);
            MyInt b = new MyInt(100);
            MyInt ans = new MyInt(-45);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);
        }

        [TestMethod]
        public void Mul_2_2_equal_4()
        {
            MyInt a = new MyInt(2);
            MyInt b = new MyInt(2);
            MyInt answer = new MyInt(4);

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void Mul_m20_m20_equal_400()
        {
            MyInt a = new MyInt(-20);
            MyInt b = new MyInt(-20);
            MyInt answer = new MyInt("400");

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void Mul_2234_min234_equal_4()
        {
            MyInt a = new MyInt(2234);
            MyInt b = new MyInt(-234);
            MyInt answer = new MyInt("-522756");

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void check_long_123456789()
        {
            MyInt ans = new MyInt("123456789");
            long nans = 123456789;

            Assert.AreEqual(ans.longValue(), nans);
        }

        [TestMethod]
        public void check_raz() {


            MyInt so = new MyInt(10);
            MyInt so1 = new MyInt(-6);
            MyInt s = new MyInt(16);
            so = so.Sub(so1);

            Assert.AreEqual( s.Value,so.Value);
        }



        [TestMethod]
        public void check_111111111111z()
        {


            MyInt so = new MyInt(0);
            MyInt so1 = new MyInt(6);
            MyInt s = new MyInt(0);
            so = so.Multiply(so1);

            Assert.AreEqual(s.Value, so.Value);
        }
        }
    }
}

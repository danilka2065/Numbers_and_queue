using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Queue_test
    {
        [TestMethod]
        public void testFront_mast_odin_dva_tri()
        {
            Queue<string> new_ob = new Queue<string>();
            new_ob.pushBack("MarinE");
            new_ob.pushBack("mypoiyfd");
            Assert.AreEqual(new_ob.front(), "MarinE");
        }

        [TestMethod]
        public void test_popfront_a_b_c_d()
        {
            Queue<string> new_ob = new Queue<string>();
            new_ob.pushBack("q");
            new_ob.pushBack("w");
            new_ob.pushBack("e");
            new_ob.pushBack("r");
            string a = new_ob.popFront() + new_ob.popFront() + new_ob.popFront() + new_ob.popFront();
            Assert.AreEqual(a, "qwer");
        }
        [TestMethod]
        public void test_popback_d_c_b_a()
        {
            Queue<string> new_ob = new Queue<string>();
            new_ob.pushBack("q");
            new_ob.pushBack("w");
            new_ob.pushBack("e");
            new_ob.pushBack("r");
            string a = new_ob.popBack() + new_ob.popBack() + new_ob.popBack() + new_ob.popBack();
            Assert.AreEqual(a, "rewq");
        }

        [TestMethod]
        public void test_popfront_popback_a_d_b_c()
        {
            Queue<string> new_ob = new Queue<string>();
            new_ob.pushBack("q");
            new_ob.pushBack("w");
            new_ob.pushBack("e");
            new_ob.pushBack("r");
            string a = new_ob.popFront() + new_ob.popBack() + new_ob.popFront() + new_ob.popBack();
            Assert.AreEqual(a, "qrwe");
        }

        [TestMethod]
        public void test_toArray_a_d_b_c()
        {
            Queue<int> new_ob = new Queue<int>();
            new_ob.pushBack(1);
            new_ob.pushBack(2);
            new_ob.pushBack(3);
            new_ob.pushBack(4);
            int[] a = new int[4];
            a[0] = 1; a[1] = 2; a[2] = 3; a[3] = 4;
            int[] b = new_ob.toArray();
            //Assert.AreEqual(a, b);
            CollectionAssert.AreEqual(a, b);
        }
    }
}

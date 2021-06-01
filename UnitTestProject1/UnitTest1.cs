using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson0106;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Calculate_summ_12and13_act0_return25()
        {
            // arrange
            double num1 = 12;
            double num2 = 13;
            int act = 0;
            double res = 25;

            //  act

            var ex = Calculate.calculate(num1, num2, act );
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_summ_13and13_act0_return26()
        {
            // arrange
            double num1 = 13;
            double num2 = 13;
            int act = 0;
            double res = 26;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_summ_m10and10_act0_return0()
        {
            // arrange
            double num1 = -10;
            double num2 = 10;
            int act = 0;
            double res = 0;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethod_Calculate_subtraction_10and2_act1_return8()
        {
            // arrange
            double num1 = 10;
            double num2 = 2;
            int act = 1;
            double res = 8;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_subtraction_m22and2_act1_returnь24()
        {
            // arrange
            double num1 = -22;
            double num2 = 2;
            int act = 1;
            double res = -24;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_subtraction_m10andm2_act1_returnm8()
        {
            // arrange
            double num1 = -10;
            double num2 = -2;
            int act = 1;
            double res = -8;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }



        [TestMethod]
        public void TestMethod_Calculate_multi_10and2_act1_return20()
        {
            // arrange
            double num1 = 10;
            double num2 = 2;
            int act = 2;
            double res = 20;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_multi_m10and2_act1_returnm20()
        {
            // arrange
            double num1 = -10;
            double num2 = 2;
            int act = 2;
            double res = -20;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_multi_m10andm2_act1_return20()
        {
            // arrange
            double num1 = -10;
            double num2 = -2;
            int act = 2;
            double res = 20;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_div_10and2_act1_return5()
        {
            // arrange
            double num1 = 10;
            double num2 = 2;
            int act = 3;
            double res = 5;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_div_m10and2_act1_returnm5()
        {
            // arrange
            double num1 = -10;
            double num2 = 2;
            int act = 3;
            double res = -5;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_div_m10andm2_act1_return5()
        {
            // arrange
            double num1 = -10;
            double num2 = -2;
            int act = 3;
            double res = 5;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_pow_10and2_act1_return100()
        {
            // arrange
            double num1 = 10;
            double num2 = 2;
            int act = 4;
            double res = 100;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_pow_m10and2_act1_return100()
        {
            // arrange
            double num1 = -10;
            double num2 = 2;
            int act = 4;
            double res = 100;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethod_Calculate_pow_m10andm1_act1_return001()
        {
            // arrange
            double num1 = -10;
            double num2 = -2;
            int act = 4;
            double res = 0.01;

            //  act

            var ex = Calculate.calculate(num1, num2, act);
            // assert
            Assert.AreEqual(ex, res);
        }

    }
}

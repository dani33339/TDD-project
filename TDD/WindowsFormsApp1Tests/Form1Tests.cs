using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void CalcTaxTest()
        {
            Random rnd = new Random();
            var t = new Form1();
            double salary;
            double ExpecedAfterTax;
            double AfteTax;
            for (int i=0;i<1;i++)
            {
                salary = rnd.Next(0, 6450);
                ExpecedAfterTax = salary - salary * 0.1;    
                AfteTax = t.CalcTax(salary);
                Assert.AreEqual(ExpecedAfterTax, AfteTax);
            }

            for (int i = 0; i < 1; i++)
            {
                salary = rnd.Next(6450, 9240);
                ExpecedAfterTax = salary - salary * 0.14;
                AfteTax = t.CalcTax(salary);
                Assert.AreEqual(ExpecedAfterTax, AfteTax);
            }
            for (int i = 0; i < 1; i++)
            {
                salary = rnd.Next(9240, 14840);
                ExpecedAfterTax = salary - salary * 0.2;
                AfteTax = t.CalcTax(salary);
                Assert.AreEqual(ExpecedAfterTax, AfteTax);
            }
            for (int i = 0; i < 1; i++)
            {
                salary = rnd.Next(14840, 20620);
                ExpecedAfterTax = salary - salary * 0.31;
                AfteTax = t.CalcTax(salary);
                Assert.AreEqual(ExpecedAfterTax, AfteTax);
            }
            for (int i = 0; i < 1; i++)
            {
                salary = rnd.Next(20620, 42910);
                ExpecedAfterTax = salary - salary * 0.35;
                AfteTax = t.CalcTax(salary);
                Assert.AreEqual(ExpecedAfterTax, AfteTax);
            }
            for (int i = 0; i < 1; i++)
            {
                salary = rnd.Next(42911,200000);
                ExpecedAfterTax = salary - salary * 0.47;
                AfteTax = t.CalcTax(salary);
                Assert.AreEqual(ExpecedAfterTax, AfteTax);
            }
        }
    }
}
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLib;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("UnitTestProject1")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("UnitTestProject1")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("939b69f6-11ef-423b-a9f3-16a316a5da61")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcSum()
        {
            double res;
            res = Class1.CalcSum(1.0, 2.0);
            Assert.IsTrue(Math.Abs(res - 3.0) < 0.01,"Calculation result is incorrect. Expected: 3.0; actual: "+res);                       

            res = Class1.CalcSum(0.0, 0.0);
            Assert.AreEqual<double>(0.0, res);
        }

        [TestMethod]
        public void TestCalcDiv()
        {
            double res;
            res = Class1.CalcDiv(4.0, 2.0);
            Assert.IsTrue(Math.Abs(res - 2.0) < 0.01, "Calculation result is incorrect. Expected: 2.0; actual: " + res);

            res = Class1.CalcDiv(0.0, 1.0);
            Assert.AreEqual<double>(0.0, res);

            bool thrown=false;
            try { Class1.CalcDiv(1.0, 0.0); }
            catch (DivideByZeroException) { thrown = true; }
            Assert.IsTrue(thrown, "CalcDiv should throw DivideByZeroException");

            Console.WriteLine("Success");
        }


    }
}

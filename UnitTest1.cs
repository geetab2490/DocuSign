using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace DocTesting
{
    [TestClass]
    public class UnitTest1
    {

        TextWriterTraceListener myListener;
       [TestMethod]
        public void TestMethod1()
        {
            int[] val1 = { 8, 6, 4, 2, 1, 7 };
            DocTest.HotWeather hw = new DocTest.HotWeather();
            String a1 = hw.hotValue(val1);
            Console.WriteLine(a1);
            myListener = new TextWriterTraceListener("TestMethod1.log", "myListener");
            myListener.WriteLine(a1);
            myListener.Flush();
         
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] val2 = { 8, 6, 3, 4, 2, 5, 1, 7 };
            DocTest.ColdWeather hw = new DocTest.ColdWeather();
            String a2 = hw.coldValue(val2);
            Console.WriteLine(a2);
            myListener = new TextWriterTraceListener("TestMethod2.log", "myListener");
            myListener.WriteLine(a2);
            myListener.Flush();
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] val3 = { 8, 6, 6 };
            DocTest.HotWeather hw3 = new DocTest.HotWeather();
            String a3 = hw3.hotValue(val3);
            Console.WriteLine(a3);
            myListener = new TextWriterTraceListener("TestMethod3.log", "myListener");
            myListener.WriteLine(a3);
            myListener.Flush();
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] val4 = { 8, 6, 3 };
            DocTest.HotWeather hw4 = new DocTest.HotWeather();
            String a4 = hw4.hotValue(val4);
            Console.WriteLine(a4);
            myListener = new TextWriterTraceListener("TestMethod4.log", "myListener");
            myListener.WriteLine(a4);
            myListener.Flush();
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] val5 = { 8, 6, 3, 4, 2, 5, 7 };
            DocTest.ColdWeather cw5 = new DocTest.ColdWeather();
            String a5 = cw5.coldValue(val5);
            Console.WriteLine(a5);
            myListener = new TextWriterTraceListener("TestMethod5.log", "myListener");
            myListener.WriteLine(a5);
            myListener.Flush();
        }
        [TestMethod]
        public void TestMethod6()
        {
            int[] val6 = { 6 };
            DocTest.ColdWeather cw6 = new DocTest.ColdWeather();
            String a6 = cw6.coldValue(val6);
            Console.WriteLine(a6);
            myListener = new TextWriterTraceListener("TestMethod6.log", "myListener");
            myListener.WriteLine(a6);
            myListener.Flush();
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] val7 = { 8,6,1 };
            DocTest.ColdWeather cw7 = new DocTest.ColdWeather();
            String a7 = cw7.coldValue(val7);
            Console.WriteLine(a7);
            myListener = new TextWriterTraceListener("TestMethod7.log", "myListener");
            myListener.WriteLine(a7);
            myListener.Flush();
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] val8 = { 8,61 };
            DocTest.ColdWeather cw8 = new DocTest.ColdWeather();
            String a8 = cw8.coldValue(val8);
            Console.WriteLine(a8);
            myListener = new TextWriterTraceListener("TestMethod8.log", "myListener");
            myListener.WriteLine(a8);
            myListener.Flush();
        }

        [TestMethod]
        public void TestMethod9()
        {
            int[] val9 =null;
            DocTest.HotWeather  hw9 = new DocTest.HotWeather();
            String a9 = hw9.hotValue(val9);
            Console.WriteLine(a9);
            myListener = new TextWriterTraceListener("TestMethod9.log", "myListener");
            myListener.WriteLine(a9);
            myListener.Flush();
        }


        [TestMethod]
        public void TestMethod10()
        {
            int[] val10 = { 4};
            DocTest.HotWeather hw10 = new DocTest.HotWeather();
            String a10 = hw10.hotValue(val10);
            Console.WriteLine(a10);
            myListener = new TextWriterTraceListener("TestMethod10.log", "myListener");
            myListener.WriteLine(a10);
            myListener.Flush();
        }

    

    }
}


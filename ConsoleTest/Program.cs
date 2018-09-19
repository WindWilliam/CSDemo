using ForTest;
using System;
using System.Diagnostics;

namespace ConsoleTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("开始测试");

                Debugger.Break();


                #region 文件下载测试--OK
                Download.GetHttpFile();
                #endregion

                Debugger.Break();

                Console.WriteLine("完成测试");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("终止测试");
            }

            Console.ReadKey();
        }
    }
}

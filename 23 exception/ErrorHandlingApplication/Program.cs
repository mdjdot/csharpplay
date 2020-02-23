using System;

namespace ErrorHandlingApplication
{
    class Program
    {
        static int Division(int n, int m)
        {
            return n / m;
        }
        static void Main(string[] args)
        {
            try
            {
                int result = Division(10, 0);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                System.Console.WriteLine("最后执行");
                throw new Exception("自定义异常");
            }
        }
    }
}

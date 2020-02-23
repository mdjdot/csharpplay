using System;
using System.Reflection;

namespace ReflectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Func);
            Console.WriteLine(type.Name);
            #region 
            // foreach (MethodInfo m in type.GetMethods())
            // {
            //     Console.WriteLine(m.Name);
            //     foreach (Attribute a in m.GetCustomAttributes(true))
            //     {
            //         try
            //         {
            //             CusAttribute cusAttribute = (CusAttribute)a;
            //             if (cusAttribute != null)
            //             {
            //                 Console.WriteLine(cusAttribute.Level);
            //             }
            //         }
            //         catch (Exception ex)
            //         {
            //             Console.WriteLine(ex.Message);
            //             Console.WriteLine(ex.StackTrace);
            //         }

            //     }
            // }
            #endregion

            MethodInfo m = type.GetMethod("Add");
            foreach (Attribute a in m.GetCustomAttributes(true))
            {
                CusAttribute cusa = a as CusAttribute;
                Console.WriteLine(cusa.Level);
            }

        }
    }
}

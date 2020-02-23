using System;

namespace DataTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 值类型
            bool bt = true;
            bool bf = false;
            Console.WriteLine(bt); // True
            Console.WriteLine(bf); // False

            byte ba = byte.MinValue;
            byte bz = byte.MaxValue;
            Console.WriteLine(ba); // 0
            Console.WriteLine(bz); // 255

            char ca = char.MinValue;
            char cc = '\0';
            char cz = char.MaxValue;
            Console.WriteLine(ca); // ?
            Console.WriteLine(cc); // ?
            Console.WriteLine(cz); // ￿

            decimal da = decimal.MinValue;
            decimal dd = -2.0000000001m;
            decimal dz = decimal.MaxValue;
            Console.WriteLine(da); // -79228162514264337593543950335
            Console.WriteLine(dd); // -2.0000000001
            Console.WriteLine(dz); // 79228162514264337593543950335

            double doua = double.MinValue;
            double douz = double.MaxValue;
            Console.WriteLine(doua); // -1.7976931348623157E+308
            Console.WriteLine(douz); // 1.7976931348623157E+308

            float fa = float.MinValue;
            float fc = -2.0123456781f;
            float fz = float.MaxValue;
            Console.WriteLine(fa); // -3.4028235E+38
            Console.WriteLine(fc); // -2.0123458
            Console.WriteLine(fz); // 3.4028235E+38

            int ia = int.MinValue;
            int iz = int.MaxValue;
            Console.WriteLine(ia); // -2147483648
            Console.WriteLine(iz); // 2147483647

            long la = long.MinValue;
            long lz = long.MaxValue;
            Console.WriteLine(la); // -9223372036854775808
            Console.WriteLine(lz); // 9223372036854775807

            sbyte sba = sbyte.MinValue;
            sbyte sbz = sbyte.MaxValue;
            Console.WriteLine(sba); // -128
            Console.WriteLine(sbz); // 127

            short sta = short.MinValue;
            short stz = short.MaxValue;
            Console.WriteLine(sta); // -32768
            Console.WriteLine(stz); // 32767

            uint ua = uint.MinValue;
            uint uz = uint.MaxValue;
            Console.WriteLine(ua); // 0
            Console.WriteLine(uz); // 4294967295

            ulong ula = ulong.MinValue;
            ulong ulz = ulong.MaxValue;
            Console.WriteLine(ula); // 0
            Console.WriteLine(ulz); // 18446744073709551615

            ushort usa = ushort.MinValue;
            ushort usz = ushort.MaxValue;
            Console.WriteLine(usa); // 0
            Console.WriteLine(usz); // 65535

            Console.WriteLine(sizeof(int)); // 4
            Console.WriteLine(sizeof(byte)); // 1
            Console.WriteLine(sizeof(char)); // 2
            Console.WriteLine(sizeof(decimal)); // 16
            Console.WriteLine(sizeof(double)); // 8
            Console.WriteLine(sizeof(float)); // 4
            Console.WriteLine(sizeof(int)); // 4
            Console.WriteLine(sizeof(long)); // 8
            Console.WriteLine(sizeof(sbyte)); // 1
            Console.WriteLine(sizeof(short)); // 2
            Console.WriteLine(sizeof(uint)); // 4
            Console.WriteLine(sizeof(ulong)); // 8
            Console.WriteLine(sizeof(ushort)); // 2

            // 引用类型
            object obj;
            obj = 100;
            Console.WriteLine(obj); // 100

            dynamic dya = 20;
            Console.WriteLine(dya); // 20

            string str;
            str = "dotdot.com";
            string str1 = @"C:\kk\ll";
            string str2 = @"C:\kk\ll
            
            
            \mm";
            Console.WriteLine(str); // dotdot.com
            Console.WriteLine(str1); // C:\kk\11
            Console.WriteLine(str2);
            /*
            C:\kk\ll
            
            
            \mm
            */

            // 指针类型
            // char* cptr;
            // int* iptr;
        }
    }
}

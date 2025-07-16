using System;
using System.Net.Http.Headers;


namespace TypeConversion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            int i = 1;
            byte b = (byte)i; // Explicit conversion from int to byte
            Console.WriteLine(b);

            int i2 = 1000;
            byte b2 = (byte)i2; // Explicit conversion from int to byte, may lose data
            Console.WriteLine(b2);


            // Convert.ToInt32()
            string number = "123"; // same => var number = "123";
            //int i = int(number); // string to int not allowed
            int i3 = Convert.ToInt32(number); // Explicit conversion from string to int
            Console.WriteLine(i3);



            // overflow exception => byte cant handle 1000
            //var largeInt = "1234";
            //byte b3 = Convert.ToByte(largeInt);
            //Console.WriteLine(b3);

            try
            {
                var largeInt = "1234";
                byte b3 = Convert.ToByte(largeInt);
                Console.WriteLine(b3);
            }
            catch (Exception)
            {
                Console.WriteLine("number could not be converted to byte");
            }


            // works for str true false
            string str = "true";
            bool b4 = Convert.ToBoolean(str);
            Console.WriteLine(b4); // True


            try
            {
                string str2 = "aloka";
                bool name = Convert.ToBoolean(str2);
                Console.WriteLine(name);
            }
            catch (Exception)
            {
                Console.WriteLine("string could not be converted to bool");
            }




        }
    }
}

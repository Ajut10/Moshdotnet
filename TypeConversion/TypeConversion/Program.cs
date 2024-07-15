using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            //byte b = 1;
            //int c = b;
            //Console.WriteLine(c);
            //explicit conversion
            //byte d = (byte) c;
            //Console.WriteLine(d);

            //non -compatible conversion
            //string  str= " 123";
            ////int i= (int) str;
            //int i = int.Parse(str);
            //Console.WriteLine(i);
            //int j = Convert.ToInt32(str);
            //Console.WriteLine(j);

            //try catch with byte
            try
            {
                var number = "2323";
                byte demo = Convert.ToByte(number);
                Console.WriteLine(demo);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot convert to byte due to higher range");
            }

            
        }
    }
}

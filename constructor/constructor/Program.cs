using System;

namespace constructor
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            Console.WriteLine(customer.Id);
        }
    }
}

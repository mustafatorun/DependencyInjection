using System;

namespace dependencyIn
{
    class Program
    {
        static void Main(string[] args)
        {
            AndroidDeveloper androidDeveloper = new AndroidDeveloper();
            Customer customer1 = new Customer(androidDeveloper);
            customer1.CreateApp();

            IosDeveloper iosDeveloper = new IosDeveloper();
            Customer customer2 = new Customer(iosDeveloper);
            customer2.CreateApp();
        }
    }
}

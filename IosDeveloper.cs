using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyIn
{
    class IosDeveloper : IDeveloper
    {
        public void shouldDoAnApp()
        {
            Console.WriteLine("Hello IosApp!");
        }
    }
}

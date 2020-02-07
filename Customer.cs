using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyIn
{
    class Customer
    {
        private IDeveloper developer;

        public Customer(IDeveloper developer)
        {
            this.developer = developer;
        }

        public void CreateApp()
        {
            developer.shouldDoAnApp();
        }
    }
}

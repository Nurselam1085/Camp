using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
       public void Add(Customer customer)
        {
            Console.WriteLine( customer.Tc + "  Tc nolu müşteri eklenmiştir");

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine( customer.Tc + "Tc nolu müşteri silinmiştir");
        }

     

    }
}

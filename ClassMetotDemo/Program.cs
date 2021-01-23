using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Tc = 63722324;
            customer1.Name = "Mehmet";
            customer1.LastName = "BİRİNCİ";
            customer1.RowNamber = 12;

            Customer customer2 = new Customer();
            customer2.Tc = 24646564;
            customer2.Name = "Aydın";
            customer2.LastName = "İKİNCİ";
            customer2.RowNamber = 14;

            Customer customer3 = new Customer();
            customer3.Tc = 565546;
            customer3.Name = "Salih";
            customer3.LastName = "ÜÇÜNCÜ";
            customer3.RowNamber = 17;

        

            Console.WriteLine(" \nEkleme işlemi aşağıdaki gibidir");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);



            Console.WriteLine("\nSilme işlemi aşağıdaki gibidir");
            CustomerManager customerManeger = new CustomerManager();
            customerManeger.Delete(customer2);



            Console.WriteLine("\nMüşterilerin Listesi");
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri adı:" + customer.Name);
                Console.WriteLine("Müşteri Soyadı:" + customer.LastName);
            }


        }
      
    }
}

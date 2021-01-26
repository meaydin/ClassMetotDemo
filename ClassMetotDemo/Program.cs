using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 0000001;
            customer1.MusteriNo = "01";
            customer1.Name = "Emin";
            customer1.Surname = "Aydın";
            customer1.TcNo = "12345678900";

            Customer customer2 = new Customer();
            customer2.Id = 0000002;
            customer2.MusteriNo = "02";
            customer2.Name = "Anushka";
            customer2.Surname = "Sharma";
            customer2.TcNo = "12345678901";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Info(customer2);
        }

        
        
        
        
           



        
    }
}

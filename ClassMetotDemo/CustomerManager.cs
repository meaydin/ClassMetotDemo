using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.MusteriNo +" nolu "+ customer.Name +" "+ customer.Surname +" eklendi.");
        }

        public void Info(Customer customer)
        {
            Console.WriteLine("Müşteri ID : "+ customer.Id);
            Console.WriteLine("Müşteri İsim : " + customer.Name);
            Console.WriteLine("Müşteri Soyisim : " + customer.Surname);

        }
    }
}

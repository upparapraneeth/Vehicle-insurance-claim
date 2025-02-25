using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customerDA_Lib.models;
using customerDA_Lib.repositories;

namespace customerBO_Lib.BO
{
    public class CustomerBO
    {
        static customerClass cusRepo = new customerClass();
        public static void AddCustomer(customerBO_Lib.models.Customer customer)
        {
            customerDA_Lib.models.Customer cus = new customerDA_Lib.models.Customer()
            {
                //customerId=customer.customerId,
                name = customer.name,
                email = customer.email,
                phone = customer.phone,
                address = customer.address,
            };
            if (cusRepo.Add(cus))
            {
                Console.WriteLine("customer details updated");

            }
            else
            {
                Console.WriteLine("problem in entering details");
            }
        }
    }
}

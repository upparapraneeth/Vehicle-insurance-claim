using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customerBO_Lib.BO;
using customerBO_Lib.models;
namespace customerApp
{
    public  class Program
    {
        public static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("1.Enter Customer details");
                Console.WriteLine("2.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Wish to add customer deatils? Press Y");
                        string ans=Console.ReadLine();
                        while(ans.ToUpper()[0] == 'Y')
                        {
                            Console.WriteLine("Enter name, email, phone and address");
                            customerBO_Lib.models.Customer c = new customerBO_Lib.models.Customer()
                            {
                                name = Console.ReadLine(),
                                email=Console.ReadLine(),
                                phone=Console.ReadLine(),
                                address=Console.ReadLine(),
                            };
                            CustomerBO.AddCustomer(c);
                            Console.WriteLine("Wish to add customer details? Press Y");
                            ans=Console.ReadLine();
                        }


                        break;
                    case 2:
                        Console.WriteLine("Terminated");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option, Enter correct option");
                        break;

                }
            }
            
        }
    }
}

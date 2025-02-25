using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customerDA_Lib.models;

namespace customerDA_Lib.repositories
{
    public class customerClass : IRepositoryCustomer<Customer>
    {
        SqlConnection con;
        public customerClass()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }
        public string ConnectionString
        {
            get
            {
                return "Data Source=LTIN519489;Initial Catalog=PROJECT;Integrated Security=True";
            }
        }



        public bool Add(Customer entity)
        {
            bool b = false;
            try
            {
                

                SqlCommand cmd = new SqlCommand("insert into Customer values(@p1, @p2,@p3, @p4 )", con);
                cmd.Parameters.Add("@p1", entity.name);
                cmd.Parameters.Add("@p2", entity.email);
                cmd.Parameters.Add("@p3", entity.phone);
                cmd.Parameters.Add("@p4", entity.address);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    b = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Registration operation failed-"+ ex.Message);
                b = false;
            }
            return b;
            
        }
        

        public bool updateCustomerProfile(Customer entity)
        {
            throw new NotImplementedException();
        }
        public List<Customer> getCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public bool registercustomer(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool registerCustomer(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}

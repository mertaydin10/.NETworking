using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1;



class Program 
{
    public static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.Id = 1;
        customer.Name = "Furkan";
        customer.Surname = "Eroğlu";

        List<Customer> customers = new List<Customer>();
        customers.Add(customer);
        customers.Add(new Customer { Id = 2, Name = "Halit", Surname = "Bektaş" });
    }


}


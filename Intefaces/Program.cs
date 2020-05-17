using System;

namespace Intefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer {
                Id = 1,
                FirstName = "Kemal",
                LastName = " Yogurt",
                Address = "Ankara"
            };
            manager.Add(customer);
            // manager.Add(new customer{Id = 1, FirstName = "Kemal",LastName = " Yogurt", Address = "Ankara"}); şeklinde de eklenebilir ... 
            Student student = new Student {
                Id = 2,
                FirstName = "Dilanur",
                LastName = " Yogurt",
                 
            };
            manager.Add(student); 
            Console.ReadLine();
        }
    }


    interface IPerson // soyut nesne 
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson            //somut nesne (:IPerson yapilmasinin nedeni IPerson'da tanimlanana her seyi sende kullanabilmesi 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Id :" + person.Id);
            Console.WriteLine("First Name :{0} ",person.FirstName);
            Console.WriteLine("Last Name :" + person.LastName);
            
                

        }
    }
}

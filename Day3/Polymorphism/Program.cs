using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    enum role
    {
        Role1,Role2,Role3
    }
    class User
    {
        public static int count = 0;
        public string name { get; }
        static User()
        {
            int count = 10;
            Console.WriteLine("Static Constructor{0}",User.count);
        }
        public User(string name)
        {
            this.name = name;
        }
        public virtual void Enter()
        {
            Console.WriteLine("User Entered: 1");
        }
    }
    class Employee : User
    {
        public role role { get; set; }
        public Employee(string name): base(name)
        {
            this.role = role.Role2;
        }
        public new void Enter()
        {
            Console.WriteLine("Employee Entered: 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User.count = 12;
            User u1 = new User("Tony");
            u1.Enter();

            Employee e1 = new Employee("Lazar");
            e1.Enter();

            User e2 = new Employee("LT");
            e2.Enter();

            Console.WriteLine(e1.role);
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliveParametresizConstructors
{
    internal class Employee
    {
        public Employee()
        {
            //Eğer bu constructor'ı yazmazsak değerlerini girmediğimiz obje hata verecektir.
        }
        public Employee(int id, string firstName, string LastNAme)
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

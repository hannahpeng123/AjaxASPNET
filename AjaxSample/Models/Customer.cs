using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxSample.Models
{
    public class Customer
    {
        public Customer(int iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
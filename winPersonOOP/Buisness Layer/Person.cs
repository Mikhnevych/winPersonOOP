using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace winPersonOOP.Buisness_Layer
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void OutputPersonDetaools() 
        {
            Console.WriteLine("Name :" + Name + "\t Address: " + Address + "\tAge" + Age);

        }
        public Person(string n, string adrs, int a)
        {
            Name = n;
            Address = adrs;
            Age = a;
        }
        public Person() { }

        public string OutputPersonDetaools2()
        {
            return "Name :" + Name + "\t Address: " + Address + "\tAge" + Age;
        }
        
    }
}

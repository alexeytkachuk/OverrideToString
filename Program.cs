using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дан класс Customer, у которого есть строковые свойства Name, ContactPhone и свойство Revenue типа decimal. Реализовать для объектов данного класса возможность строкового представления различного вида. 
//Например, для объекта со значениями Name = "Jeffrey Richter", Revenue = 1000000, ContactPhone = "+1 (425) 555-0100", могут быть следующие варианты:

//*Customer record: Jeffrey Richter, 1,000,000.00, +1(425) 555 - 0100
//* Customer record: +1(425) 555 - 0100
//* Customer record: Jeffrey Richter, 1,000,000.00
//* Customer record: Jeffrey Richter
//*Customer record: 1000000 и т.д.


namespace ClassFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer JR = new Customer("Alex", "+375(29)855-55-12", 1000);
           
            Console.WriteLine(JR.ToString("A"));
            Console.WriteLine(JR.ToString("B"));
            Console.WriteLine(JR.ToString("C"));
            Console.WriteLine(JR.ToString("D"));
            Console.WriteLine(JR.ToString("4556"));
        }
    }

    public class Customer
    {
        string name { get; set; }
        string contactPhone { get; set; }
        decimal revenue { get; set; }

        public Customer (string name, string contactPhone, decimal revenue)
        {
            this.name = name;
            this.contactPhone = contactPhone;
            this.revenue = revenue;
        }

        public string ToString(string temp)
        {
            if (string.IsNullOrEmpty(temp)) return "A";

            switch (temp)
            {
                case "A": return string.Format("{0}, {1}, {2}", name, contactPhone, revenue);
                case "B": return string.Format("{0}, {1}", name, contactPhone);
                case "C": return string.Format("{0}, {1}", name, revenue);
                case "D": return string.Format("{0}, {1}, {2}", revenue, name, contactPhone);
                default: return string.Format("Change letter A to D");
            }
        }
    }

}

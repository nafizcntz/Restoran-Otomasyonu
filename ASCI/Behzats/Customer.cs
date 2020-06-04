using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCI
{
    class Customer2
    {
        string namee;
        string surname;
        string number;
        string address;
        string order;
        float totalprice;
        /*public Customer2(string namee, string surname, string number, string address)
        {
            this.namee = namee;
            this.surname = surname;
            this.number = number;
            this.address = address;
        }*/

        public string Namee { get => namee; set => namee = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Number { get => number; set => number = value; }
        public string Address { get => address; set => address = value; }
        public string Order { get => order; set => order = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }

        public void addorder(string name, string surnamee, string number, string address, string foodname,float pricee)
        {
            Namee = name;
            Surname = surnamee;
            Number = number;
            Address = address;
            Order = foodname;
            totalprice = pricee;
        }
    }
}

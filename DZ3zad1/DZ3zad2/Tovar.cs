using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3zad2
{
    public class Tovar
    {
        public String Name { get; set; }
        public String Opisanie { get; set; }
        public Double Prise { get; set; }

        public Tovar()
        {
            Name = Opisanie = null;
            Prise = 0;
        }

        public void Produkt(string name, string opisanie, double prise)
        {
            this.Name = name;
            this.Opisanie = opisanie;
            this.Prise = prise;
        }

        public override string ToString()
        {
            return $"Компьютер: {Name} Описание: {Opisanie}";
        }
    }
}

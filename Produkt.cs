using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Produkt
    {
        public string nazwa {  get; set; }
        public bool dsotepnosc { get; set; }
        public string kategoria { get; set; }

        public Produkt(string nazwa, string kategoria)
        {
            this.nazwa = nazwa;
            this.kategoria = kategoria;
            dsotepnosc = true;
        }
    }
}

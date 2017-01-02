using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication8
{
    public class Lokomotywa
    {
        private string model { get; set; }
        private int masa { get; set; }

        public Lokomotywa(string model_, int masa_)
        {
            this.model = model_;
            this.masa = masa_;
        }

        public int ZwrocMase()
        {
            return masa;
        }

        public string Info()
        {
            return string.Format("Lokomotywa: model {0} masa {1}", model, masa);
        }

    }
}

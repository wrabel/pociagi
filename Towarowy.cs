using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication8
{
    class Towarowy : Wagon
    {
        private string ladunek;

        public Towarowy(string model_, int masa_, string ladunek_)
        {
            this.model = model_;
            this.masa = masa_;
            this.ladunek = ladunek_;
        }

        public override string Info()
        {
            return string.Format("Wagon towarowy: model {0}, waga {1}, ladunek: {2}", model, masa, ladunek);
        }

    }
}

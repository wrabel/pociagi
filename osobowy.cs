using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication8
{
    class osobowy : Wagon
    {
        private string rodzaj;

        public osobowy(string rodzaj_, string model_, int masa_)
        {
            this.rodzaj = rodzaj_;
            this.model = model_;
            this.masa = masa_;
        }

        public override string Info()
        {
            return string.Format("Wagon osobowy: model {0} , waga {1}, rodzaj {2}.", model, masa, rodzaj);
        }

       
    }
}

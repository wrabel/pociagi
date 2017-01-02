using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication8
{
    public class Pociag : IpoprawnyPociag , IUzupelnijSklad
    {
        private List<Wagon> wagony = new List<Wagon>();
        private List<Lokomotywa> lokomotywy = new List<Lokomotywa>();

        public void DodajOsobowy(int masa, string model, string rodzaj)
        {
            wagony.Add(new osobowy(rodzaj,model,masa));
        }
        public void DodajTowarowy(int masa, string model, string ladunek)
        {
            wagony.Add(new Towarowy(model, masa, ladunek));
        }
        public void DodajLokomotywe(int masa, string model)
        {
            lokomotywy.Add(new Lokomotywa(model, masa));
        }

        public bool MozeJechac()
        {
            int masa_l = 0;
            int masa_w = 0;
            foreach (var var in wagony)
            {
                masa_w += var.ZwrocMase();

            }
            foreach (var var in lokomotywy)
            {
                masa_l += var.ZwrocMase();
            }

            return masa_l >= masa_w;
        }
        public string Info()
        {
            string tmp = "";
            foreach (var var in lokomotywy)
            {
                tmp += string.Format("{0}\n", var.Info());
            }
            foreach (var var in wagony)
            {
                tmp += string.Format("{0}\n", var.Info());
            }

            return tmp;

        }
    }
}

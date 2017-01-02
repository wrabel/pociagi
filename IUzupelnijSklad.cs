using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication8
{
    interface IUzupelnijSklad
    {
        void DodajOsobowy(int masa, string model, string rodzaj);
        void DodajTowarowy(int masa, string model, string ladunek);
        void DodajLokomotywe(int masa, string model);
    }
}

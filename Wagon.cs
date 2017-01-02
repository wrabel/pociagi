using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication8
{
    abstract class Wagon
    {
        protected string model;
        protected int masa;

        public abstract string Info();

        public int ZwrocMase()
        {
            return this.masa;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public abstract class Kaffe
    {

        public abstract int Pris();
       

        public virtual string Styrke()
        {
            return "Stærk";
        }
        /// <summary>
        /// Rabat der gives til kaffen
        /// </summary>
        public int Rabat { get; set; }

        public Kaffe()
        {
            this.Rabat = 0;
        }

        public Kaffe(int rabat)
        {
            this.Rabat = rabat;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public class Latte : Kaffe , Imælk
    {
        /// <summary>
        /// Hvor meget mælk skal der være i latte
        /// </summary>
        /// <returns></returns>
        public int M1Mælk()
        {
            return 120;
        }

        public override int Pris()
        {
            return 40;
        }
    }
}

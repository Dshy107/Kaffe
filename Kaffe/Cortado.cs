using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public class Cortado : Kaffe , Imælk
    {
        /// <summary>
        /// Hvor meget mælk skal der være i cortado
        /// </summary>
        /// <returns></returns>
        public int M1Mælk()
        {
            return 25;
        }

        /// <summary>
        /// Prisen på Cortado
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 25;
        }
    }
}

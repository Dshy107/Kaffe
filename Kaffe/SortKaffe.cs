﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public class SortKaffe : Kaffe
    {
        public override int Pris()
        {
            int prisMedRabat = 20 - Rabat;

            if (prisMedRabat <= 0)
                throw new ArgumentException("How! Du gav for meget rabat.");

            return prisMedRabat;
        }

        public SortKaffe()
        {

        }
        public SortKaffe(int rabat) : base(rabat)
        {
            
        }
    }
}

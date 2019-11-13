﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.SweepstakesName());
            manager.InsertSweepstakes(sweepstakes);

        }


    }
}

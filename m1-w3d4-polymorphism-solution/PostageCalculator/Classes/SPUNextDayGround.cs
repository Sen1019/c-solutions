﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPUNextDayGround : IDeliveryService
    {
        public string Name
        {
            get { return "SPU (next-day)"; }
        }

        public double CalculateRate(int weightInOunces, int distanceInMiles)
        {
            int weightInLbs = weightInOunces / 16;

            // round up to the nearest lb
            if (weightInOunces % 16 != 0)
            {
                weightInLbs++;
            }

            return (weightInLbs * 0.075) * distanceInMiles;
        }
    }
}

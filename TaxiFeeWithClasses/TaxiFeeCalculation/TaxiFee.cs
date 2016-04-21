using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiFeeCalculation
{
    public class TaxiFee
    {
        public double TaxiFeeCalculation(double distance, int hour, int dayShortTripFee, int dayMediumTripFee, int dayLongTripFee, int nightShortTripFee, int nightMediumTripFee, int nightLongTripFee)
        {
            double fee = 0;
            if (hour >= 8 & hour < 21)
            {
                if (distance <= 21)
                    fee = distance * dayShortTripFee;
                else
                    if (distance <= 60)
                        fee = TwoWay(distance) * dayMediumTripFee;
                    else
                        fee = TwoWay(distance) * dayLongTripFee;
            }
            else
            {
                if (distance <= 21)
                    fee = distance * nightShortTripFee;
                else
                    if (distance <= 60)
                        fee = TwoWay(distance) * nightMediumTripFee;
                    else
                        fee = TwoWay(distance) * nightLongTripFee;
            }
            return fee;
        }

        private static double TwoWay(double distance)
        {
            return distance * 2;
        }



    }
}

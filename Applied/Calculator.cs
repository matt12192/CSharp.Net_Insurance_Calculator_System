using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Applied
{
    public class Calculator
    //The starting point for the premium is £500.
    {
        public double TenPercent(double Premium, double PercentTen)
        {
         

            //If there is driver who is a Chauffeur on the policy increase the premium by 10%
            return Premium * PercentTen;
        }

        

        public double TwentyPercent(double Premium, double PercentTwenty)
        {
            
            //If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%
            return Premium * PercentTwenty;
        }

        public double CustomerOnePrice(double QuoteOneOccupation, double QuoteOneAge, double QuoteOneCustomerOneClaims)
        {

            return QuoteOneOccupation + QuoteOneAge + QuoteOneCustomerOneClaims;

        }
        

        public string CustomerOneAge(DateTime Date1, DateTime Date2, string Age) 
        {


            if (Date1.DayOfYear <= Date2.DayOfYear)
            {
                Age = (Date2.Year - Date1.Year).ToString();
                return Age;
            }
            else
            {
                Age = (Date2.Year - Date1.Year - 1).ToString();
                return Age;
            
            }
        }

        public string CustomerClaim(DateTime Date3, DateTime Date4, string ClaimLength)
        {


            if (Date3.DayOfYear <= Date4.DayOfYear)
            {
                ClaimLength = (Date4.Year - Date3.Year).ToString();
                return ClaimLength;
            }
            else
            {
                ClaimLength = (Date4.Year - Date3.Year - 1).ToString();
                return ClaimLength;

            }
        }

       


    }
}
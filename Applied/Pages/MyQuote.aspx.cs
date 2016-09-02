using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Applied.Pages
{
    public partial class MyQuote : System.Web.UI.Page
    {
        string CustomerOne;
        string CustomerTwo;
        string CustomerThree;
        string CustomerFour;
        string CustomerFive;


        string CustomerOneFname;
        string CustomerOneSname;
        string CustomerOneGender;
        string CustomerOneOccupation;
        string CustomerOneAge;

        string CustomerTwoFname;
        string CustomerTwoSname;
        string CustomerTwoGender;
        string CustomerTwoOccupation;
        string CustomerTwoAge;


        string CustomerThreeFname;
        string CustomerThreeSname;
        string CustomerThreeGender;
        string CustomerThreeOccupation;
        string CustomerThreeAge;

        string CustomerFourFname;
        string CustomerFourSname;
        string CustomerFourGender;
        string CustomerFourOccupation;
        string CustomerFourAge;


        string CustomerFiveFname;
        string CustomerFiveSname;
        string CustomerFiveGender;
        string CustomerFiveOccupation;
        string CustomerFiveAge;











        string Premium;




        protected void Page_Load(object sender, EventArgs e)
        {

            CustomerOne = Session["CustomerOne"].ToString();
            CustomerTwo = Session["CustomerTwo"].ToString();
            CustomerThree = Session["CustomerThree"].ToString();
            CustomerFour = Session["CustomerFour"].ToString();
            CustomerFive = Session["CustomerFive"].ToString();
           
           
            
            
            



            if (CustomerOne == "True")
            {

                CustomerOneFname = Session["CustomerOneFname"].ToString();
                CustomerOneSname = Session["CustomerOneSname"].ToString();
                CustomerOneGender = Session["CustomerOneGender"].ToString();
                CustomerOneOccupation = Session["CustomerOneOccupation"].ToString();
                CustomerOneAge = Session["CustomerOneAge"].ToString();


                lblCustomerOneName.Text = CustomerOneFname + " " + CustomerOneSname;
                lblCustomerOneGender.Text = CustomerOneGender;
                lblCustomerOneOccupation.Text = CustomerOneOccupation;
                lblCustomerOneAge.Text = CustomerOneAge;

            }


            if (CustomerTwo == "True")
            {

                CustomerTwoFname = Session["CustomerTwoFname"].ToString();
                CustomerTwoSname = Session["CustomerTwoSname"].ToString();
                CustomerTwoGender = Session["CustomerTwoGender"].ToString();
                CustomerTwoOccupation = Session["CustomerTwoOccupation"].ToString();
                CustomerTwoAge = Session["CustomerTwoAge"].ToString();


                lblCustomerTwoName.Text = CustomerTwoFname + " " + CustomerTwoSname;
                lblCustomerTwoGender.Text = CustomerTwoGender;
                lblCustomerTwoOccupation.Text = CustomerTwoOccupation;
                lblCustomerTwoAge.Text = CustomerTwoAge;
            }



            if (CustomerThree == "True")
            {

                CustomerThreeFname = Session["CustomerThreeFname"].ToString();
                CustomerThreeSname = Session["CustomerThreeSname"].ToString();
                CustomerThreeGender = Session["CustomerThreeGender"].ToString();
                CustomerThreeOccupation = Session["CustomerThreeOccupation"].ToString();
                CustomerThreeAge = Session["CustomerThreeAge"].ToString();



                lblCustomerThreeName.Text = CustomerThreeFname + " " + CustomerThreeSname;
                lblCustomerThreeGender.Text = CustomerThreeGender;
                lblCustomerThreeOccupation.Text = CustomerThreeOccupation;
                lblCustomerThreeAge.Text = CustomerThreeAge;
            }

            if (CustomerFour == "True")
            {
                CustomerFourFname = Session["CustomerFourFname"].ToString();
                CustomerFourSname = Session["CustomerFourSname"].ToString();
                CustomerFourGender = Session["CustomerFourGender"].ToString();
                CustomerFourOccupation = Session["CustomerFourOccupation"].ToString();
                CustomerFourAge = Session["CustomerFourAge"].ToString();


                lblCustomerFourName.Text = CustomerFourFname + " " + CustomerFourSname;
                lblCustomerFourGender.Text = CustomerFourGender;
                lblCustomerFourOccupation.Text = CustomerFourOccupation;
                lblCustomerFourAge.Text = CustomerFourAge;

            }


            if (CustomerFive == "True")
            {

                CustomerFiveFname = Session["CustomerFiveFname"].ToString();
                CustomerFiveSname = Session["CustomerFiveSname"].ToString();
                CustomerFiveGender = Session["CustomerFiveGender"].ToString();
                CustomerFiveOccupation = Session["CustomerFiveOccupation"].ToString();
                CustomerFiveAge = Session["CustomerFiveAge"].ToString();


                lblCustomerFiveName.Text = CustomerFiveFname + " " + CustomerFiveSname;
                lblCustomerFiveGender.Text = CustomerFiveGender;
                lblCustomerFiveOccupation.Text = CustomerFiveOccupation;
                lblCustomerFiveAge.Text = CustomerFiveAge;

            }
          


            

            












            Premium = Session["Premium"].ToString();



   
















            txtPremium.Value = Premium;


        }
    }
}
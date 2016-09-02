using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Applied;

namespace Applied.Pages
{
    
    public partial class GetAQuote : System.Web.UI.Page
    {
        string customerFirstName;
        string customerSurname;
        string customerGender;
        string customerOccupation;
        string customerDOB;

        double Premium = 500;
        double PercentTen = 0.10;
        double PercentTwenty = 0.20;

        
        double QuoteOneOccupation;
        double QuoteTwoOccupation;
        double QuoteThreeOccupation;
        double QuoteFourOccupation;
        double QuoteFiveOccupation;

        double QuoteOneAge;
        double QuoteTwoAge;
        double QuoteThreeAge;
        double QuoteFourAge;
        double QuoteFiveAge;


        double QuoteOneCustomerOneClaims;
        double QuoteTwoCustomerOneClaims;
        double QuoteThreeCustomerOneClaims;
        double QuoteFourCustomerOneCLaims;
        double QuoteFiveCustomerOneClaims;

        double QuoteOneCustomerTwoClaims;
        double QuoteTwoCustomerTwoClaims;
        double QuoteThreeCustomerTwoClaims;
        double QuoteFourCustomerTwoCLaims;
        double QuoteFiveCustomerTwoClaims;

        double QuoteOneCustomerThreeClaims;
        double QuoteTwoCustomerThreeClaims;
        double QuoteThreeCustomerThreeClaims;
        double QuoteFourCustomerThreeCLaims;
        double QuoteFiveCustomerThreeClaims;

        double QuoteOneCustomerFourClaims;
        double QuoteTwoCustomerFourClaims;
        double QuoteThreeCustomerFourClaims;
        double QuoteFourCustomerFourCLaims;
        double QuoteFiveCustomerFourClaims;

        double QuoteOneCustomerFiveClaims;
        double QuoteTwoCustomerFiveClaims;
        double QuoteThreeCustomerFiveClaims;
        double QuoteFourCustomerFiveCLaims;
        double QuoteFiveCustomerFiveClaims;



        double FinalQuote = 500;





        DateTime Date1;
        DateTime Date2;
        DateTime Date3;
        DateTime Date4;
      

        string Age;
        string customerAge;

        int CustomerOneAge;
        int CustomerTwoAge;
        int CustomerThreeAge;
        int CustomerFourAge;
        int CustomerFiveAge;



      
        
        string ClaimLength;
        string CustomerClaimLength;

        int CustomerOneClaimOne;
        int CustomerOneClaimTwo;
        int CustomerOneClaimThree;
        int CustomerOneClaimFour;
        int CustomerOneClaimFive;

        int CustomerTwoClaimOne;
        int CustomerTwoClaimTwo;
        int CustomerTwoClaimThree;
        int CustomerTwoClaimFour;
        int CustomerTwoClaimFive;

        int CustomerThreeClaimOne;
        int CustomerThreeClaimTwo;
        int CustomerThreeClaimThree;
        int CustomerThreeClaimFour;
        int CustomerThreeClaimFive;

        int CustomerFourClaimOne;
        int CustomerFourClaimTwo;
        int CustomerFourClaimThree;
        int CustomerFourClaimFour;
        int CustomerFourClaimFive;

        int CustomerFiveClaimOne;
        int CustomerFiveClaimTwo;
        int CustomerFiveClaimThree;
        int CustomerFiveClaimFour;
        int CustomerFiveClaimFive;
        
     

        string CustomerOneName;
        string CustomerTwoName;
        string CustomerThreeName;
        string CustomerFourName;
        string CustomerFiveName;

        Calculator myCalculator = new Calculator();
        
        protected void Page_Load(object sender, EventArgs e)
        {


            //1. If the start date of the policy is before today decline with the message "Start Date of Policy".

            RangeValidator1.MinimumValue = DateTime.Now.ToShortDateString();
            RangeValidator1.MaximumValue = DateTime.Now.AddDays(14).ToShortDateString();
            


        }

        

  
        protected void btnQuote_Click(object sender, EventArgs e)
        {

            if (ddlAmount.SelectedItem.Value == "One")
            {
                //x

                Session["CustomerOne"] = "True";
                Session["CustomerTwo"] = "False";
                Session["CustomerThree"] = "False";
                Session["CustomerFour"] = "False";
                Session["CustomerFive"] = "False";


                Session["CustomerOneFname"] = txtFnameOne.Text;
                Session["CustomerOneSname"] = txtSnameOne.Text;
                Session["CustomerOneGender"] = DDLGenderOne.SelectedItem.Value;


                ViewState["CustomerOneName"] = txtFnameOne + "" + txtSnameOne.Text;
           
            if (DDLOcuppationOne.SelectedItem.Value == "Chauffeur")
            {

                //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                FinalQuote = FinalQuote + QuoteOneOccupation;
                


                Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


            }
            else if (DDLOcuppationOne.SelectedItem.Value == "Accountant")
            {
                //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                FinalQuote = FinalQuote - QuoteOneOccupation;
               

                Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


            }

            Date2 = Convert.ToDateTime(txtselectStartDate.Text);
            Date1 = Convert.ToDateTime(txtDOBOne.Text);

            customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
            CustomerOneAge = int.Parse(customerAge);
           



            Session["CustomerOneAge"] = CustomerOneAge;



            if (CustomerOneAge >= 21 && CustomerOneAge <= 25)
            {

                //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                QuoteOneAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                FinalQuote = FinalQuote + QuoteOneAge;
               


            }
            else if (CustomerOneAge >= 26 && CustomerOneAge <= 75)
            {

                //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                QuoteOneAge = myCalculator.TenPercent(Premium, PercentTen);
                FinalQuote = FinalQuote - QuoteOneAge;
                
            }






            if (txtClaimOneFirst.Text == "")
            {
               

            }else{

           
            

            Date4 = Convert.ToDateTime(txtselectStartDate.Text);
            Date3 = Convert.ToDateTime(txtClaimOneFirst.Text);

            CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
            CustomerOneClaimOne = int.Parse(CustomerClaimLength);
           




            if (CustomerOneClaimOne <= 1)
            {

                //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                QuoteOneCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                
            }
            else if (CustomerOneClaimOne >= 2 && CustomerOneClaimOne <= 5)
            {
                //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                QuoteOneCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                

            }

            }






            if (txtClaimTwoFirst.Text == "")
            {
              

            }
            else
            {

                Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                Date3 = Convert.ToDateTime(txtClaimTwoFirst.Text);

                CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                CustomerOneClaimTwo = int.Parse(CustomerClaimLength);
             




                if (CustomerOneClaimTwo <= 1)
                {

                    //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                    QuoteTwoCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                    
                }
                else if (CustomerOneClaimTwo >= 2 && CustomerOneClaimTwo <= 5)
                {
                    //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                    QuoteTwoCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                    

                }

            }




            if (txtClaimThreeFirst.Text == "")
            {
               

            }
            else
            {

                Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                Date3 = Convert.ToDateTime(txtClaimThreeFirst.Text);

                CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                CustomerOneClaimThree = int.Parse(CustomerClaimLength);
                




                if (CustomerOneClaimThree <= 1)
                {

                    //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                    QuoteThreeCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                    
                }
                else if (CustomerOneClaimThree >= 2 && CustomerOneClaimThree <= 5)
                {
                    //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                    QuoteThreeCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                  
                }

            }



            if (txtClaimFourFirst.Text == "")
            {
               

            }
            else
            {

                Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                Date3 = Convert.ToDateTime(txtClaimFourFirst.Text);

                CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                CustomerOneClaimFour = int.Parse(CustomerClaimLength);
              




                if (CustomerOneClaimFour <= 1)
                {

                    //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                    QuoteFourCustomerOneCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
                   
                }
                else if (CustomerOneClaimFour >= 2 && CustomerOneClaimFour <= 5)
                {
                    //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                    QuoteFourCustomerOneCLaims = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
                    

                }

            }



            if (txtClaimFiveFirst.Text == "")
            {
               

            }
            else
            {


                Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                Date3 = Convert.ToDateTime(txtClaimFiveFirst.Text);

                CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                CustomerOneClaimFive = int.Parse(CustomerClaimLength);
                




                if (CustomerOneClaimFive <= 1)
                {

                    //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                    QuoteFiveCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                   
                }
                else if (CustomerOneClaimFive >= 2 && CustomerOneClaimFive <= 5)
                {
                    //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                    QuoteFiveCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                   

                }

            }

                //if ends
            }
            else
            {

            




            }





            if (ddlAmount.SelectedItem.Value == "Two")
            {
                //x

                Session["CustomerOne"] = "True";
                Session["CustomerTwo"] = "True";
                Session["CustomerThree"] = "False";
                Session["CustomerFour"] = "False";
                Session["CustomerFive"] = "False";
         


                Session["CustomerOneFname"] = txtFnameOne.Text;
                Session["CustomerOneSname"] = txtSnameOne.Text;
                Session["CustomerOneGender"] = DDLGenderOne.SelectedItem.Value;



                if (DDLOcuppationOne.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteOneOccupation;
                 


                    Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


                }
                else if (DDLOcuppationOne.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteOneOccupation;
                   

                    Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


                }

                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBOne.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerOneAge = int.Parse(customerAge);
               



                Session["CustomerOneAge"] = CustomerOneAge;


                if (CustomerOneAge >= 21 && CustomerOneAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteOneAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteOneAge;
                   



                }
                else if (CustomerOneAge >= 26 && CustomerOneAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteOneAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteOneAge;
                   
                }






                if (txtClaimOneFirst.Text == "")
                {
                   

                }
                else
                {




                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimOne = int.Parse(CustomerClaimLength);
                   




                    if (CustomerOneClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
            
                    }
                    else if (CustomerOneClaimOne >= 2 && CustomerOneClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                        

                    }

                }






                if (txtClaimTwoFirst.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimTwo = int.Parse(CustomerClaimLength);
                   




                    if (CustomerOneClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                       
                    }
                    else if (CustomerOneClaimTwo >= 2 && CustomerOneClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                       

                    }

                }




                if (txtClaimThreeFirst.Text == "")
                {
                  

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimThree = int.Parse(CustomerClaimLength);
                 




                    if (CustomerOneClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                       
                    }
                    else if (CustomerOneClaimThree >= 2 && CustomerOneClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                        

                    }

                }



                if (txtClaimFourFirst.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimFour = int.Parse(CustomerClaimLength);
                   




                    if (CustomerOneClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerOneCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
                       
                    }
                    else if (CustomerOneClaimFour >= 2 && CustomerOneClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerOneCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
                      

                    }

                }



                if (txtClaimFiveFirst.Text == "")
                {
                  
                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimFive = int.Parse(CustomerClaimLength);
                




                    if (CustomerOneClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                     
                    }
                    else if (CustomerOneClaimFive >= 2 && CustomerOneClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                     

                    }

                }



                
                Session["CustomerTwoFname"] = txtFnameTwo.Text;
                Session["CustomerTwoSname"] = txtSnameTwo.Text;
                Session["CustomerTwoGender"] = DDLGenderTwo.SelectedItem.Value; 

                if (DDLOcuppationTwo.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteTwoOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteTwoOccupation;
                    
                  
                    Session["CustomerTwoOccupation"] = DDLOcuppationTwo.SelectedItem.Value;


                }
                else if (DDLOcuppationTwo.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteTwoOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteTwoOccupation;
                   

                  
                    Session["CustomerTwoOccupation"] = DDLOcuppationTwo.SelectedItem.Value;


                }

             
                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBTwo.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerTwoAge = int.Parse(customerAge);
            


                Session["CustomerTwoAge"] = CustomerTwoAge;



                if (CustomerTwoAge >= 21 && CustomerTwoAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteTwoAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteTwoAge;
                   

                }
                else if (CustomerTwoAge >= 26 && CustomerTwoAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteTwoAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteTwoAge;
                   
                }



                if (txtClaimOneSecond.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimOne = int.Parse(CustomerClaimLength);
              

                    if (CustomerTwoClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerTwoClaims;
                    
                    }
                    else if (CustomerTwoClaimOne >= 2 && CustomerTwoClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerTwoClaims;
                       

                    }

                }



                if (txtClaimTwoSecond.Text == "")
                {
                 

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimTwo = int.Parse(CustomerClaimLength);
                   




                    if (CustomerTwoClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerTwoClaims;
                        
                    }
                    else if (CustomerTwoClaimTwo >= 2 && CustomerTwoClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerTwoClaims;
                      

                    }

                }


                if (txtClaimThreeSecond.Text == "")
                {
                  

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimThree = int.Parse(CustomerClaimLength);
                  



                    if (CustomerTwoClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerTwoClaims;
                        
                    }
                    else if (CustomerTwoClaimThree >= 2 && CustomerTwoClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerTwoClaims;
                        

                    }



                }





                if (txtClaimFourSecond.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimFour = int.Parse(CustomerClaimLength);
                    




                    if (CustomerTwoClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerTwoCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerTwoCLaims;
                      
                    }
                    else if (CustomerTwoClaimFour >= 2 && CustomerTwoClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerTwoCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerTwoCLaims;
                     

                    }

                }






                if (txtClaimFiveSecond.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimFive = int.Parse(CustomerClaimLength);
                  




                    if (CustomerTwoClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerTwoClaims;
                      
                    }
                    else if (CustomerTwoClaimFive >= 2 && CustomerTwoClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerTwoClaims;
                     

                    }

                }
            }
            else
            {
                
            }





            if (ddlAmount.SelectedItem.Value == "Three")
            {
                //x

                Session["CustomerOne"] = "True";
                Session["CustomerTwo"] = "True";
                Session["CustomerThree"] = "True";
                Session["CustomerFour"] = "False";
                Session["CustomerFive"] = "False";



                Session["CustomerOneFname"] = txtFnameOne.Text;
                Session["CustomerOneSname"] = txtSnameOne.Text;
                Session["CustomerOneGender"] = DDLGenderOne.SelectedItem.Value;



                if (DDLOcuppationOne.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteOneOccupation;
                


                    Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


                }
                else if (DDLOcuppationOne.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteOneOccupation;
               

                    Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


                }

                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBOne.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerOneAge = int.Parse(customerAge);
                



                Session["CustomerOneAge"] = CustomerOneAge;


                if (CustomerOneAge >= 21 && CustomerOneAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteOneAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteOneAge;
                



                }
                else if (CustomerOneAge >= 26 && CustomerOneAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteOneAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteOneAge;
                 
                }






                if (txtClaimOneFirst.Text == "")
                {
                   

                }
                else
                {




                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimOne = int.Parse(CustomerClaimLength);
              




                    if (CustomerOneClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                       
                    }
                    else if (CustomerOneClaimOne >= 2 && CustomerOneClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                       

                    }

                }






                if (txtClaimTwoFirst.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimTwo = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                       
                    }
                    else if (CustomerOneClaimTwo >= 2 && CustomerOneClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                       

                    }

                }




                if (txtClaimThreeFirst.Text == "")
                {
               

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimThree = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                        
                    }
                    else if (CustomerOneClaimThree >= 2 && CustomerOneClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                       

                    }

                }



                if (txtClaimFourFirst.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimFour = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerOneCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
                      
                    }
                    else if (CustomerOneClaimFour >= 2 && CustomerOneClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerOneCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
                   

                    }

                }



                if (txtClaimFiveFirst.Text == "")
                {
                    

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimFive = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                      
                    }
                    else if (CustomerOneClaimFive >= 2 && CustomerOneClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                    

                    }

                }




                Session["CustomerTwoFname"] = txtFnameTwo.Text;
                Session["CustomerTwoSname"] = txtSnameTwo.Text;
                Session["CustomerTwoGender"] = DDLGenderTwo.SelectedItem.Value;

                if (DDLOcuppationTwo.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteTwoOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteTwoOccupation;
                   


                    Session["CustomerTwoOccupation"] = DDLOcuppationTwo.SelectedItem.Value;


                }
                else if (DDLOcuppationTwo.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteTwoOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteTwoOccupation;
                    


                    Session["CustomerTwoOccupation"] = DDLOcuppationTwo.SelectedItem.Value;


                }


                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBTwo.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerTwoAge = int.Parse(customerAge);
              


                Session["CustomerTwoAge"] = CustomerTwoAge;



                if (CustomerTwoAge >= 21 && CustomerTwoAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteTwoAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteTwoAge;
                  

                }
                else if (CustomerTwoAge >= 26 && CustomerTwoAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteTwoAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteTwoAge;
             
                }



                if (txtClaimOneSecond.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimOne = int.Parse(CustomerClaimLength);
                   

                    if (CustomerTwoClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerTwoClaims;
                       
                    }
                    else if (CustomerTwoClaimOne >= 2 && CustomerTwoClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerTwoClaims;
                       

                    }

                }



                if (txtClaimTwoSecond.Text == "")
                {
                   

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimTwo = int.Parse(CustomerClaimLength);
                   




                    if (CustomerTwoClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerTwoClaims;
                     
                    }
                    else if (CustomerTwoClaimTwo >= 2 && CustomerTwoClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerTwoClaims;
                        

                    }

                }


                if (txtClaimThreeSecond.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimThree = int.Parse(CustomerClaimLength);
                   




                    if (CustomerTwoClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerTwoClaims;
                      
                    }
                    else if (CustomerTwoClaimThree >= 2 && CustomerTwoClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerTwoClaims;
                  

                    }



                }





                if (txtClaimFourSecond.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimFour = int.Parse(CustomerClaimLength);
                    




                    if (CustomerTwoClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerTwoCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerTwoCLaims;

                    }
                    else if (CustomerTwoClaimFour >= 2 && CustomerTwoClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerTwoCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerTwoCLaims;
                 

                    }

                }






                if (txtClaimFiveSecond.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimFive = int.Parse(CustomerClaimLength);
                  




                    if (CustomerTwoClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerTwoClaims;
                  
                    }
                    else if (CustomerTwoClaimFive >= 2 && CustomerTwoClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerTwoClaims;
               

                    }

                }






                Session["CustomerThreeFname"] = txtFnameThree.Text;
                Session["CustomerThreeSname"] = txtSnameThree.Text;
                Session["CustomerThreeGender"] = DDLGenderThree.SelectedItem.Value;

                if (DDLOcuppationThree.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteThreeOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteThreeOccupation;
                   

       
                    Session["CustomerThreeOccupation"] = DDLOcuppationThree.SelectedItem.Value;

                }
                else if (DDLOcuppationThree.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteThreeOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteThreeOccupation;
                 

           
                    Session["CustomerThreeOccupation"] = DDLOcuppationThree.SelectedItem.Value;

                }

                
                //age3





                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBOne.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerThreeAge = int.Parse(customerAge);

                                    
                                                            
                Session["CustomerThreeAge"] = CustomerThreeAge;



                if (CustomerThreeAge >= 21 && CustomerThreeAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteThreeAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteThreeAge;
                    

                }
                else if (CustomerThreeAge >= 26 && CustomerThreeAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteThreeAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteThreeAge;
                   
                }




                if (txtClaimOneThird.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimOne = int.Parse(CustomerClaimLength);
                

                    if (CustomerThreeClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerThreeClaims;
                     
                    }
                    else if (CustomerThreeClaimOne >= 2 && CustomerThreeClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerThreeClaims;
                 

                    }


                }



                if (txtClaimTwoThird.Text == "")
                {
                    

                }
                else
                {
                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimTwo = int.Parse(CustomerClaimLength);
            




                    if (CustomerThreeClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerThreeClaims;
                      
                    }
                    else if (CustomerThreeClaimTwo >= 2 && CustomerThreeClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerThreeClaims;
                       

                    }
                }


                if (txtClaimThreeThird.Text == "")
                {
                  

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimThree = int.Parse(CustomerClaimLength);
                   



                    if (CustomerThreeClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerThreeClaims;
                        
                    }
                    else if (CustomerThreeClaimThree >= 2 && CustomerThreeClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerThreeClaims;
                   

                    }

                }


                if (txtClaimFourThird.Text == "")
                {
                  

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimFour = int.Parse(CustomerClaimLength);
                  




                    if (CustomerThreeClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerThreeCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerThreeCLaims;
                        
                    }
                    else if (CustomerThreeClaimFour >= 2 && CustomerThreeClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerThreeCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerThreeCLaims;
                      

                    }

                }




                if (txtClaimFiveThird.Text == "")
                {
         

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimFive = int.Parse(CustomerClaimLength);
                  




                    if (CustomerThreeClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerThreeClaims;
                        
                    }
                    else if (CustomerThreeClaimFive >= 2 && CustomerThreeClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerThreeClaims;
                       

                    }

                }
            }
            else
            {
               
            }





            if (ddlAmount.SelectedItem.Value == "Four")
            {
                //x

                Session["CustomerOne"] = "True";
                Session["CustomerTwo"] = "True";
                Session["CustomerThree"] = "True";
                Session["CustomerFour"] = "True";
                Session["CustomerFive"] = "false";


                Session["CustomerOneFname"] = txtFnameOne.Text;
                Session["CustomerOneSname"] = txtSnameOne.Text;
                Session["CustomerOneGender"] = DDLGenderOne.SelectedItem.Value;



                if (DDLOcuppationOne.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteOneOccupation;
                  


                    Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


                }
                else if (DDLOcuppationOne.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteOneOccupation;
                   

                    Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


                }

                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBOne.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerOneAge = int.Parse(customerAge);
                



                Session["CustomerOneAge"] = CustomerOneAge;


                if (CustomerOneAge >= 21 && CustomerOneAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteOneAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteOneAge;
                  



                }
                else if (CustomerOneAge >= 26 && CustomerOneAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteOneAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteOneAge;
                
                }






                if (txtClaimOneFirst.Text == "")
                {
                   

                }
                else
                {




                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimOne = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                        
                    }
                    else if (CustomerOneClaimOne >= 2 && CustomerOneClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                      

                    }

                }






                if (txtClaimTwoFirst.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimTwo = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                       
                    }
                    else if (CustomerOneClaimTwo >= 2 && CustomerOneClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                       

                    }

                }




                if (txtClaimThreeFirst.Text == "")
                {
                  

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimThree = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                    
                    }
                    else if (CustomerOneClaimThree >= 2 && CustomerOneClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                  
                    }

                }



                if (txtClaimFourFirst.Text == "")
                {
          

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimFour = int.Parse(CustomerClaimLength);
                




                    if (CustomerOneClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerOneCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
    
                    }
                    else if (CustomerOneClaimFour >= 2 && CustomerOneClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerOneCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
          

                    }

                }



                if (txtClaimFiveFirst.Text == "")
                {
                   

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimFive = int.Parse(CustomerClaimLength);
     




                    if (CustomerOneClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
             
                    }
                    else if (CustomerOneClaimFive >= 2 && CustomerOneClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                    
                    }

                }




                Session["CustomerTwoFname"] = txtFnameTwo.Text;
                Session["CustomerTwoSname"] = txtSnameTwo.Text;
                Session["CustomerTwoGender"] = DDLGenderTwo.SelectedItem.Value;

                if (DDLOcuppationTwo.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteTwoOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteTwoOccupation;
             


                    Session["CustomerTwoOccupation"] = DDLOcuppationTwo.SelectedItem.Value;


                }
                else if (DDLOcuppationTwo.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteTwoOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteTwoOccupation;
                  


                    Session["CustomerTwoOccupation"] = DDLOcuppationTwo.SelectedItem.Value;


                }


                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBTwo.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerTwoAge = int.Parse(customerAge);
           


                Session["CustomerTwoAge"] = CustomerTwoAge;



                if (CustomerTwoAge >= 21 && CustomerTwoAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteTwoAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteTwoAge;
                    

                }
                else if (CustomerTwoAge >= 26 && CustomerTwoAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteTwoAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteTwoAge;
                 
                }



                if (txtClaimOneSecond.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimOne = int.Parse(CustomerClaimLength);
                   

                    if (CustomerTwoClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerTwoClaims;
                     
                    }
                    else if (CustomerTwoClaimOne >= 2 && CustomerTwoClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerTwoClaims;
                      

                    }

                }



                if (txtClaimTwoSecond.Text == "")
                {


                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimTwo = int.Parse(CustomerClaimLength);
                   




                    if (CustomerTwoClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerTwoClaims;
                      
                    }
                    else if (CustomerTwoClaimTwo >= 2 && CustomerTwoClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerTwoClaims;
                     

                    }

                }


                if (txtClaimThreeSecond.Text == "")
                {
                 

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimThree = int.Parse(CustomerClaimLength);
                    




                    if (CustomerTwoClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerTwoClaims;
                     
                    }
                    else if (CustomerTwoClaimThree >= 2 && CustomerTwoClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerTwoClaims;
                      

                    }



                }





                if (txtClaimFourSecond.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimFour = int.Parse(CustomerClaimLength);
                    




                    if (CustomerTwoClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerTwoCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerTwoCLaims;
                       
                    }
                    else if (CustomerTwoClaimFour >= 2 && CustomerTwoClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerTwoCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerTwoCLaims;
                        

                    }

                }






                if (txtClaimFiveSecond.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimFive = int.Parse(CustomerClaimLength);
                    




                    if (CustomerTwoClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerTwoClaims;
                        
                    }
                    else if (CustomerTwoClaimFive >= 2 && CustomerTwoClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerTwoClaims;
                   

                    }

                }






                Session["CustomerThreeFname"] = txtFnameThree.Text;
                Session["CustomerThreeSname"] = txtSnameThree.Text;
                Session["CustomerThreeGender"] = DDLGenderThree.SelectedItem.Value;

                if (DDLOcuppationThree.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteThreeOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteThreeOccupation;
                   


                    Session["CustomerThreeOccupation"] = DDLOcuppationThree.SelectedItem.Value;

                }
                else if (DDLOcuppationThree.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteThreeOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteThreeOccupation;
                 


                    Session["CustomerThreeOccupation"] = DDLOcuppationThree.SelectedItem.Value;

                }



                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBOne.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerThreeAge = int.Parse(customerAge);



              


                Session["CustomerThreeAge"] = CustomerThreeAge;



                if (CustomerThreeAge >= 21 && CustomerThreeAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteThreeAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteThreeAge;
                   

                }
                else if (CustomerThreeAge >= 26 && CustomerThreeAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteThreeAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteThreeAge;
                  
                }




                if (txtClaimOneThird.Text == "")
                {
                

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimOne = int.Parse(CustomerClaimLength);
                   

                    if (CustomerThreeClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerThreeClaims;
                     
                    }
                    else if (CustomerThreeClaimOne >= 2 && CustomerThreeClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerThreeClaims;
                    

                    }


                }



                if (txtClaimTwoThird.Text == "")
                {
                    

                }
                else
                {
                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimTwo = int.Parse(CustomerClaimLength);
                 




                    if (CustomerThreeClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerThreeClaims;
                       
                    }
                    else if (CustomerThreeClaimTwo >= 2 && CustomerThreeClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerThreeClaims;
                       

                    }
                }


                if (txtClaimThreeThird.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimThree = int.Parse(CustomerClaimLength);
                    




                    if (CustomerThreeClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerThreeClaims;
                       
                    }
                    else if (CustomerThreeClaimThree >= 2 && CustomerThreeClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerThreeClaims;
                    
                    }

                }


                if (txtClaimFourThird.Text == "")
                {
                  

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimFour = int.Parse(CustomerClaimLength);
                   




                    if (CustomerThreeClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerThreeCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerThreeCLaims;
                        
                    }
                    else if (CustomerThreeClaimFour >= 2 && CustomerThreeClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerThreeCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerThreeCLaims;
                        

                    }

                }




                if (txtClaimFiveThird.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimFive = int.Parse(CustomerClaimLength);
                  




                    if (CustomerThreeClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerThreeClaims;
                       
                    }
                    else if (CustomerThreeClaimFive >= 2 && CustomerThreeClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerThreeClaims;
           

                    }

                }






                Session["CustomerFourFname"] = txtFnameFour.Text;
                Session["CustomerFourSname"] = txtSnameFour.Text;
                Session["CustomerFourGender"] = DDLGenderFour.SelectedItem.Value;

                if (DDLOcuppationFour.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteFourOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteFourOccupation;
                  
                   
                    Session["CustomerFourOccupation"] = DDLOcuppationFour.SelectedItem.Value;

                }
                else if (DDLOcuppationFour.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteFourOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteFourOccupation;
                 

                    
                    Session["CustomerFourOccupation"] = DDLOcuppationFour.SelectedItem.Value;
                }

                

                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBFour.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerFourAge = int.Parse(customerAge);
              


                Session["CustomerFourAge"] = CustomerFourAge;



                if (CustomerFourAge >= 21 && CustomerFourAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteFourAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteFourAge;
                  

                }
                else if (CustomerFourAge >= 26 && CustomerFourAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteFourAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteFourAge;
                
                }


                if (txtClaimOneFourth.Text == "")
                {
                   

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimOne = int.Parse(CustomerClaimLength);
                    




                    if (CustomerFourClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerFourClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerFourClaims;
                    
                    }
                    else if (CustomerFourClaimOne >= 2 && CustomerFourClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerFourClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerFourClaims;
                       

                    }

                }





                if (txtClaimTwoFourth.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimTwo = int.Parse(CustomerClaimLength);
                   




                    if (CustomerFourClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerFourClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerFourClaims;
                  
                    }
                    else if (CustomerFourClaimTwo >= 2 && CustomerFourClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerFourClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerFourClaims;
               

                    }
                }



                if (txtClaimThreeFourth.Text == "")
                {
                    

                }
                else
                {



                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimThree = int.Parse(CustomerClaimLength);
                  



                    if (CustomerFourClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerFourClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerFourClaims;
                   
                    }
                    else if (CustomerFourClaimThree >= 2 && CustomerFourClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerFourClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerFourClaims;
                       

                    }

                }



                if (txtClaimFourFourth.Text == "")
                {
                    

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimFour = int.Parse(CustomerClaimLength);
                    




                    if (CustomerFourClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerFourCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerFourCLaims;
                        
                    }
                    else if (CustomerFourClaimFour >= 2 && CustomerFourClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerFourCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerFourCLaims;
                       

                    }

                }




                if (txtClaimFiveFourth.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimFive = int.Parse(CustomerClaimLength);
                   




                    if (CustomerFourClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerFourClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerFourClaims;
                       
                    }
                    else if (CustomerFourClaimFive >= 2 && CustomerFourClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerFourClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerFourClaims;
                        

                    }
                }

            }
            else
            {
              
            }




            if (ddlAmount.SelectedItem.Value == "Five")
            {

                //x

                Session["CustomerOne"] = "True";
                Session["CustomerTwo"] = "True";
                Session["CustomerThree"] = "True";
                Session["CustomerFour"] = "True";
                Session["CustomerFive"] = "True";


                Session["CustomerOneFname"] = txtFnameOne.Text;
                Session["CustomerOneSname"] = txtSnameOne.Text;
                Session["CustomerOneGender"] = DDLGenderOne.SelectedItem.Value;



                if (DDLOcuppationOne.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteOneOccupation;
                    


                    Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


                }
                else if (DDLOcuppationOne.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteOneOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteOneOccupation;
                   


                    Session["CustomerOneOccupation"] = DDLOcuppationOne.SelectedItem.Value;


                }

                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBOne.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerOneAge = int.Parse(customerAge);
               


                Session["CustomerOneAge"] = CustomerOneAge;


                if (CustomerOneAge >= 21 && CustomerOneAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteOneAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteOneAge;
                   




                }
                else if (CustomerOneAge >= 26 && CustomerOneAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteOneAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteOneAge;
                   
                }






                if (txtClaimOneFirst.Text == "")
                {
                    

                }
                else
                {




                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimOne = int.Parse(CustomerClaimLength);
                  



                    if (CustomerOneClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                  
                    }
                    else if (CustomerOneClaimOne >= 2 && CustomerOneClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerOneClaims;
                    

                    }

                }






                if (txtClaimTwoFirst.Text == "")
                {
                 

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimTwo = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                    
                    }
                    else if (CustomerOneClaimTwo >= 2 && CustomerOneClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerOneClaims;
                       

                    }

                }




                if (txtClaimThreeFirst.Text == "")
                {
                 

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimThree = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                        
                    }
                    else if (CustomerOneClaimThree >= 2 && CustomerOneClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerOneClaims;
                      

                    }

                }



                if (txtClaimFourFirst.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimFour = int.Parse(CustomerClaimLength);
                  




                    if (CustomerOneClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerOneCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
                       
                    }
                    else if (CustomerOneClaimFour >= 2 && CustomerOneClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerOneCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerOneCLaims;
                       

                    }

                }



                if (txtClaimFiveFirst.Text == "")
                {
                   

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveFirst.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerOneClaimFive = int.Parse(CustomerClaimLength);
                    




                    if (CustomerOneClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerOneClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                      
                    }
                    else if (CustomerOneClaimFive >= 2 && CustomerOneClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerOneClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerOneClaims;
                       

                    }

                }




                Session["CustomerTwoFname"] = txtFnameTwo.Text;
                Session["CustomerTwoSname"] = txtSnameTwo.Text;
                Session["CustomerTwoGender"] = DDLGenderTwo.SelectedItem.Value;

                if (DDLOcuppationTwo.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteTwoOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteTwoOccupation;
                    


                    Session["CustomerTwoOccupation"] = DDLOcuppationTwo.SelectedItem.Value;


                }
                else if (DDLOcuppationTwo.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteTwoOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteTwoOccupation;
               


                    Session["CustomerTwoOccupation"] = DDLOcuppationTwo.SelectedItem.Value;


                }


                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBTwo.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerTwoAge = int.Parse(customerAge);
        


                Session["CustomerTwoAge"] = CustomerTwoAge;



                if (CustomerTwoAge >= 21 && CustomerTwoAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteTwoAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteTwoAge;
                   

                }
                else if (CustomerTwoAge >= 26 && CustomerTwoAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteTwoAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteTwoAge;
                   
                }



                if (txtClaimOneSecond.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimOne = int.Parse(CustomerClaimLength);
                   

                    if (CustomerTwoClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerTwoClaims;
                        
                    }
                    else if (CustomerTwoClaimOne >= 2 && CustomerTwoClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerTwoClaims;
                        

                    }

                }



                if (txtClaimTwoSecond.Text == "")
                {
                   

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimTwo = int.Parse(CustomerClaimLength);
                  




                    if (CustomerTwoClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerTwoClaims;
                       
                    }
                    else if (CustomerTwoClaimTwo >= 2 && CustomerTwoClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerTwoClaims;
                       

                    }

                }


                if (txtClaimThreeSecond.Text == "")
                {
               

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimThree = int.Parse(CustomerClaimLength);
                    




                    if (CustomerTwoClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerTwoClaims;
                     
                    }
                    else if (CustomerTwoClaimThree >= 2 && CustomerTwoClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerTwoClaims;
                       

                    }



                }





                if (txtClaimFourSecond.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimFour = int.Parse(CustomerClaimLength);
                   




                    if (CustomerTwoClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerTwoCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerTwoCLaims;
                        
                    }
                    else if (CustomerTwoClaimFour >= 2 && CustomerTwoClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerTwoCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerTwoCLaims;
                        

                    }

                }






                if (txtClaimFiveSecond.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveSecond.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerTwoClaimFive = int.Parse(CustomerClaimLength);
           




                    if (CustomerTwoClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerTwoClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerTwoClaims;
                      
                    }
                    else if (CustomerTwoClaimFive >= 2 && CustomerTwoClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerTwoClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerTwoClaims;
                      

                    }

                }






                Session["CustomerThreeFname"] = txtFnameThree.Text;
                Session["CustomerThreeSname"] = txtSnameThree.Text;
                Session["CustomerThreeGender"] = DDLGenderThree.SelectedItem.Value;

                if (DDLOcuppationThree.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteThreeOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteThreeOccupation;
                   


                    Session["CustomerThreeOccupation"] = DDLOcuppationThree.SelectedItem.Value;

                }
                else if (DDLOcuppationThree.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteThreeOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteThreeOccupation;
                   


                    Session["CustomerThreeOccupation"] = DDLOcuppationThree.SelectedItem.Value;

                }


                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBOne.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerThreeAge = int.Parse(customerAge);



                Session["CustomerThreeAge"] = CustomerThreeAge;



                Session["CustomerThreeAge"] = CustomerThreeAge;



                if (CustomerThreeAge >= 21 && CustomerThreeAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteThreeAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteThreeAge;
                  

                }
                else if (CustomerThreeAge >= 26 && CustomerThreeAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteThreeAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteThreeAge;
                   
                }




                if (txtClaimOneThird.Text == "")
                {
                   
                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimOne = int.Parse(CustomerClaimLength);
                 

                    if (CustomerThreeClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerThreeClaims;
                        
                    }
                    else if (CustomerThreeClaimOne >= 2 && CustomerThreeClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerThreeClaims;
                      

                    }


                }



                if (txtClaimTwoThird.Text == "")
                {
                    

                }
                else
                {
                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimTwo = int.Parse(CustomerClaimLength);
                   




                    if (CustomerThreeClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerThreeClaims;
                      
                    }
                    else if (CustomerThreeClaimTwo >= 2 && CustomerThreeClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerThreeClaims;
                 

                    }
                }


                if (txtClaimThreeThird.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimThree = int.Parse(CustomerClaimLength);
                   




                    if (CustomerThreeClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerThreeClaims;

                    }
                    else if (CustomerThreeClaimThree >= 2 && CustomerThreeClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerThreeClaims;
                     

                    }

                }


                if (txtClaimFourThird.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimFour = int.Parse(CustomerClaimLength);
                    




                    if (CustomerThreeClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerThreeCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerThreeCLaims;
                        
                    }
                    else if (CustomerThreeClaimFour >= 2 && CustomerThreeClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerThreeCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerThreeCLaims;
                        
                    }

                }




                if (txtClaimFiveThird.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveThird.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerThreeClaimFive = int.Parse(CustomerClaimLength);
                   




                    if (CustomerThreeClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerThreeClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerThreeClaims;
                       
                    }
                    else if (CustomerThreeClaimFive >= 2 && CustomerThreeClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerThreeClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerThreeClaims;
                    

                    }

                }






                Session["CustomerFourFname"] = txtFnameFour.Text;
                Session["CustomerFourSname"] = txtSnameFour.Text;
                Session["CustomerFourGender"] = DDLGenderFour.SelectedItem.Value;

                if (DDLOcuppationFour.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteFourOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteFourOccupation;
                    


                    Session["CustomerFourOccupation"] = DDLOcuppationFour.SelectedItem.Value;

                }
                else if (DDLOcuppationFour.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteFourOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteFourOccupation;
                


                    Session["CustomerFourOccupation"] = DDLOcuppationFour.SelectedItem.Value;
                }



                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBFour.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerFourAge = int.Parse(customerAge);
              


                Session["CustomerFourAge"] = CustomerFourAge;



                if (CustomerFourAge >= 21 && CustomerFourAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteFourAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteFourAge;
                   

                }
                else if (CustomerFourAge >= 26 && CustomerFourAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteFourAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteFourAge;
                    
                }


                if (txtClaimOneFourth.Text == "")
                {
                  

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimOne = int.Parse(CustomerClaimLength);
                   




                    if (CustomerFourClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerFourClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerFourClaims;
                      
                    }
                    else if (CustomerFourClaimOne >= 2 && CustomerFourClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerFourClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerFourClaims;
                     

                    }

                }





                if (txtClaimTwoFourth.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimTwo = int.Parse(CustomerClaimLength);
                    




                    if (CustomerFourClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerFourClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerFourClaims;
                      
                    }
                    else if (CustomerFourClaimTwo >= 2 && CustomerFourClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerFourClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerFourClaims;
                        

                    }
                }



                if (txtClaimThreeFourth.Text == "")
                {
                  

                }
                else
                {



                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimThree = int.Parse(CustomerClaimLength);
               




                    if (CustomerFourClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerFourClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerFourClaims;
                    
                    }
                    else if (CustomerFourClaimThree >= 2 && CustomerFourClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerFourClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerFourClaims;
                       

                    }

                }



                if (txtClaimFourFourth.Text == "")
                {
                    

                }
                else
                {


                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimFour = int.Parse(CustomerClaimLength);
                




                    if (CustomerFourClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerFourCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerFourCLaims;
                     
                    }
                    else if (CustomerFourClaimFour >= 2 && CustomerFourClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerFourCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerFourCLaims;
                        

                    }

                }




                if (txtClaimFiveFourth.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveFourth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFourClaimFive = int.Parse(CustomerClaimLength);
                  




                    if (CustomerFourClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerFourClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerFourClaims;
                     
                    }
                    else if (CustomerFourClaimFive >= 2 && CustomerFourClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerFourClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerFourClaims;
                   

                    }
                }







               
                Session["CustomerFiveFname"] = txtFnameFive.Text;
                Session["CustomerFiveSname"] = txtSnameFive.Text;
                Session["CustomerFiveGender"] = DDLGenderFive.SelectedItem.Value;

                if (DDLOcuppationFive.SelectedItem.Value == "Chauffeur")
                {

                    //•	If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    QuoteFiveOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote + QuoteFiveOccupation;
                

               
                    Session["CustomerFiveOccupation"] = DDLOcuppationFive.SelectedItem.Value;


                }
                else if (DDLOcuppationFive.SelectedItem.Value == "Accountant")
                {
                    //•	If there is driver who is an Accountant on the policy decrease the premium by 10%
                    QuoteFiveOccupation = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteFiveOccupation;
                 

                   
                    Session["CustomerFiveOccupation"] = DDLOcuppationFive.SelectedItem.Value;

                }

              


                Date2 = Convert.ToDateTime(txtselectStartDate.Text);
                Date1 = Convert.ToDateTime(txtDOBFive.Text);

                customerAge = myCalculator.CustomerOneAge(Date1, Date2, Age);
                CustomerFiveAge = int.Parse(customerAge);
              



                Session["CustomerFiveAge"] = CustomerFiveAge;


                if (CustomerFiveAge >= 21 && CustomerFiveAge <= 25)
                {

                    //•	If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%

                    QuoteFiveAge = myCalculator.TwentyPercent(Premium, PercentTwenty);
                    FinalQuote = FinalQuote + QuoteFiveAge;
                   

                }
                else if (CustomerFiveAge >= 26 && CustomerFiveAge <= 75)
                {

                    //•	If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    QuoteFiveAge = myCalculator.TenPercent(Premium, PercentTen);
                    FinalQuote = FinalQuote - QuoteFiveAge;
                 
                }



                if (txtClaimOneFifth.Text == "")
                {
                    

                }
                else
                {



                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimOneFifth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFiveClaimOne = int.Parse(CustomerClaimLength);
                  




                    if (CustomerFiveClaimOne <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteOneCustomerFiveClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteOneCustomerFiveClaims;
                       
                    }
                    else if (CustomerFiveClaimOne >= 2 && CustomerFiveClaimOne <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteOneCustomerFiveClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteOneCustomerFiveClaims;
                     

                    }

                }




                if (txtClaimTwoFifth.Text == "")
                {
                    

                }
                else
                {
                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimTwoFifth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFiveClaimTwo = int.Parse(CustomerClaimLength);
                 



                    if (CustomerFiveClaimTwo <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteTwoCustomerFiveClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteTwoCustomerFiveClaims;
                       
                    }
                    else if (CustomerFiveClaimTwo >= 2 && CustomerFiveClaimTwo <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteTwoCustomerFiveClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteTwoCustomerFiveClaims;
                   

                    }

                }



                if (txtClaimThreeFifth.Text == "")
                {
                    

                }
                else
                {
                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimThreeFifth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFiveClaimThree = int.Parse(CustomerClaimLength);
                    




                    if (CustomerFiveClaimThree <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteThreeCustomerFiveClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteThreeCustomerFiveClaims;
                      
                    }
                    else if (CustomerFiveClaimThree >= 2 && CustomerFiveClaimThree <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteThreeCustomerFiveClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteThreeCustomerFiveClaims;
                      

                    }

                }




                if (txtClaimFourFifth.Text == "")
                {
                    

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFourFifth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFiveClaimFour = int.Parse(CustomerClaimLength);
                  




                    if (CustomerFiveClaimFour <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFourCustomerFiveCLaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFourCustomerFiveCLaims;
                      
                    }
                    else if (CustomerFiveClaimFour >= 2 && CustomerFiveClaimFour <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFourCustomerFiveCLaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFourCustomerFiveCLaims;
                   

                    }

                }



                if (txtClaimFiveFifth.Text == "")
                {
                   

                }
                else
                {

                    Date4 = Convert.ToDateTime(txtselectStartDate.Text);
                    Date3 = Convert.ToDateTime(txtClaimFiveFifth.Text);

                    CustomerClaimLength = myCalculator.CustomerOneAge(Date3, Date4, ClaimLength);
                    CustomerFiveClaimFive = int.Parse(CustomerClaimLength);
                   




                    if (CustomerFiveClaimFive <= 1)
                    {

                        //•	For each claim within 1 year of the start date of the policy increase the premium by 20%
                        QuoteFiveCustomerFiveClaims = myCalculator.TwentyPercent(Premium, PercentTwenty);
                        FinalQuote = FinalQuote + QuoteFiveCustomerFiveClaims;
                        
                    }
                    else if (CustomerFiveClaimFive >= 2 && CustomerFiveClaimFive <= 5)
                    {
                        //•	For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        QuoteFiveCustomerFiveClaims = myCalculator.TenPercent(Premium, PercentTen);
                        FinalQuote = FinalQuote + QuoteFiveCustomerFiveClaims;
                       

                    }

                }

            }
            else
            {
              
            }





            Session["Premium"] = FinalQuote;
            

            Response.Redirect("MyQuote.aspx");


        line1:

            ;

        }

        protected void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {






            if (ddlAmount.SelectedItem.Value == "One")
            {
                lbldriverOne.Visible = true;
                lbldriverTwo.Visible = false;
                lbldriverThree.Visible = false;
                lbldriverFour.Visible = false;
                lbldriverFive.Visible = false;

                lblFname.Visible = true;
                lblSname.Visible = true;
                lblGender.Visible = true;
                lblOccupation.Visible = true;
                lblDOB.Visible = true;

                txtFnameOne.Visible = true;
                txtSnameOne.Visible = true;
                DDLGenderOne.Visible = true;
                DDLOcuppationOne.Visible = true;
                txtDOBOne.Visible = true;

                txtFnameTwo.Visible = false;
                txtSnameTwo.Visible = false;
                DDLGenderTwo.Visible = false;
                DDLOcuppationTwo.Visible = false;
                txtDOBTwo.Visible = false;

                txtFnameThree.Visible = false;
                txtSnameThree.Visible = false;
                DDLGenderThree.Visible = false;
                DDLOcuppationThree.Visible = false;
                txtDOBThree.Visible = false;

                txtFnameFour.Visible = false;
                txtSnameFour.Visible = false;
                DDLGenderFour.Visible = false;
                DDLOcuppationFour.Visible = false;
                txtDOBFour.Visible = false;

                txtFnameFive.Visible = false;
                txtSnameFive.Visible = false;
                DDLGenderFive.Visible = false;
                DDLOcuppationFive.Visible = false;
                txtDOBFive.Visible = false;



                lblClaimOne.Visible = true;
                lblClaimTwo.Visible = true;
                lblClaimThree.Visible = true;
                lblClaimFour.Visible = true;
                lblClaimFive.Visible = true;

                txtClaimOneFirst.Visible = true;
                txtClaimTwoFirst.Visible = true;
                txtClaimThreeFirst.Visible = true;
                txtClaimFourFirst.Visible = true;
                txtClaimFiveFirst.Visible = true;

                txtClaimOneSecond.Visible = false;
                txtClaimTwoSecond.Visible = false;
                txtClaimThreeSecond.Visible = false;
                txtClaimFourSecond.Visible = false;
                txtClaimFiveSecond.Visible = false;


                txtClaimOneThird.Visible = false;
                txtClaimTwoThird.Visible = false;
                txtClaimThreeThird.Visible = false;
                txtClaimFourThird.Visible = false;
                txtClaimFiveThird.Visible = false;

                txtClaimOneFourth.Visible = false;
                txtClaimTwoFourth.Visible = false;
                txtClaimThreeFourth.Visible = false;
                txtClaimFourFourth.Visible = false;
                txtClaimFiveFourth.Visible = false;

                txtClaimOneFifth.Visible = false;
                txtClaimTwoFifth.Visible = false;
                txtClaimThreeFifth.Visible = false;
                txtClaimFourFifth.Visible = false;
                txtClaimFiveFifth.Visible = false;
              

            }else if (ddlAmount.SelectedItem.Value == "Two")
            {
                lbldriverOne.Visible = true;
                lbldriverTwo.Visible = true;
                lbldriverThree.Visible = false;
                lbldriverFour.Visible = false;
                lbldriverFive.Visible = false;

                lblFname.Visible = true;
                lblSname.Visible = true;
                lblGender.Visible = true;
                lblOccupation.Visible = true;
                lblDOB.Visible = true;

                txtFnameOne.Visible = true;
                txtSnameOne.Visible = true;
                DDLGenderOne.Visible = true;
                DDLOcuppationOne.Visible = true;
                txtDOBOne.Visible = true;

                txtFnameTwo.Visible = true;
                txtSnameTwo.Visible = true;
                DDLGenderTwo.Visible = true;
                DDLOcuppationTwo.Visible = true;
                txtDOBTwo.Visible = true;

                txtFnameThree.Visible = false;
                txtSnameThree.Visible = false;
                DDLGenderThree.Visible = false;
                DDLOcuppationThree.Visible = false;
                txtDOBThree.Visible = false;

                txtFnameFour.Visible = false;
                txtSnameFour.Visible = false;
                DDLGenderFour.Visible = false;
                DDLOcuppationFour.Visible = false;
                txtDOBFour.Visible = false;


                txtFnameFive.Visible = false;
                txtSnameFive.Visible = false;
                DDLGenderFive.Visible = false;
                DDLOcuppationFive.Visible = false;
                txtDOBFive.Visible = false;


                lblClaimOne.Visible = true;
                lblClaimTwo.Visible = true;
                lblClaimThree.Visible = true;
                lblClaimFour.Visible = true;
                lblClaimFive.Visible = true;

                txtClaimOneFirst.Visible = true;
                txtClaimTwoFirst.Visible = true;
                txtClaimThreeFirst.Visible = true;
                txtClaimFourFirst.Visible = true;
                txtClaimFiveFirst.Visible = true;

                txtClaimOneSecond.Visible = true;
                txtClaimTwoSecond.Visible = true;
                txtClaimThreeSecond.Visible = true;
                txtClaimFourSecond.Visible = true;
                txtClaimFiveSecond.Visible = true;


                txtClaimOneThird.Visible = false;
                txtClaimTwoThird.Visible = false;
                txtClaimThreeThird.Visible = false;
                txtClaimFourThird.Visible = false;
                txtClaimFiveThird.Visible = false;

                txtClaimOneFourth.Visible = false;
                txtClaimTwoFourth.Visible = false;
                txtClaimThreeFourth.Visible = false;
                txtClaimFourFourth.Visible = false;
                txtClaimFiveFourth.Visible = false;

                txtClaimOneFifth.Visible = false;
                txtClaimTwoFifth.Visible = false;
                txtClaimThreeFifth.Visible = false;
                txtClaimFourFifth.Visible = false;
                txtClaimFiveFifth.Visible = false;

            }
            else if (ddlAmount.SelectedItem.Value == "Three")
            {

                lbldriverOne.Visible = true;
                lbldriverTwo.Visible = true;
                lbldriverThree.Visible = true;
                lbldriverFour.Visible = false;
                lbldriverFive.Visible = false;

                lblFname.Visible = true;
                lblSname.Visible = true;
                lblGender.Visible = true;
                lblOccupation.Visible = true;
                lblDOB.Visible = true;

                txtFnameOne.Visible = true;
                txtSnameOne.Visible = true;
                DDLGenderOne.Visible = true;
                DDLOcuppationOne.Visible = true;
                txtDOBOne.Visible = true;

                txtFnameTwo.Visible = true;
                txtSnameTwo.Visible = true;
                DDLGenderTwo.Visible = true;
                DDLOcuppationTwo.Visible = true;
                txtDOBTwo.Visible = true;

                txtFnameThree.Visible = true;
                txtSnameThree.Visible = true;
                DDLGenderThree.Visible = true;
                DDLOcuppationThree.Visible = true;
                txtDOBThree.Visible = true;

                txtFnameFour.Visible = false;
                txtSnameFour.Visible = false;
                DDLGenderFour.Visible = false;
                DDLOcuppationFour.Visible = false;
                txtDOBFour.Visible = false;

                txtFnameFive.Visible = false;
                txtSnameFive.Visible = false;
                DDLGenderFive.Visible = false;
                DDLOcuppationFive.Visible = false;
                txtDOBFive.Visible = false;

                

                lblClaimOne.Visible = true;
                lblClaimTwo.Visible = true;
                lblClaimThree.Visible = true;
                lblClaimFour.Visible = true;
                lblClaimFive.Visible = true;

                txtClaimOneFirst.Visible = true;
                txtClaimTwoFirst.Visible = true;
                txtClaimThreeFirst.Visible = true;
                txtClaimFourFirst.Visible = true;
                txtClaimFiveFirst.Visible = true;

                txtClaimOneSecond.Visible = true;
                txtClaimTwoSecond.Visible = true;
                txtClaimThreeSecond.Visible = true;
                txtClaimFourSecond.Visible = true;
                txtClaimFiveSecond.Visible = true;


                txtClaimOneThird.Visible = true;
                txtClaimTwoThird.Visible = true;
                txtClaimThreeThird.Visible = true;
                txtClaimFourThird.Visible = true;
                txtClaimFiveThird.Visible = true;

                txtClaimOneFourth.Visible = false;
                txtClaimTwoFourth.Visible = false;
                txtClaimThreeFourth.Visible = false;
                txtClaimFourFourth.Visible = false;
                txtClaimFiveFourth.Visible = false;

                txtClaimOneFifth.Visible = false;
                txtClaimTwoFifth.Visible = false;
                txtClaimThreeFifth.Visible = false;
                txtClaimFourFifth.Visible = false;
                txtClaimFiveFifth.Visible = false;

            }
            else if (ddlAmount.SelectedItem.Value == "Four")
            {

                lbldriverOne.Visible = true;
                lbldriverTwo.Visible = true;
                lbldriverThree.Visible = true;
                lbldriverFour.Visible = true;
                lbldriverFive.Visible = false;

                lblFname.Visible = true;
                lblSname.Visible = true;
                lblGender.Visible = true;
                lblOccupation.Visible = true;
                lblDOB.Visible = true;

                txtFnameOne.Visible = true;
                txtSnameOne.Visible = true;
                DDLGenderOne.Visible = true;
                DDLOcuppationOne.Visible = true;
                txtDOBOne.Visible = true;

                txtFnameTwo.Visible = true;
                txtSnameTwo.Visible = true;
                DDLGenderTwo.Visible = true;
                DDLOcuppationTwo.Visible = true;
                txtDOBTwo.Visible = true;

                txtFnameThree.Visible = true;
                txtSnameThree.Visible = true;
                DDLGenderThree.Visible = true;
                DDLOcuppationThree.Visible = true;
                txtDOBThree.Visible = true;

                txtFnameFour.Visible = true;
                txtSnameFour.Visible = true;
                DDLGenderFour.Visible = true;
                DDLOcuppationFour.Visible = true;
                txtDOBFour.Visible = true;


                txtFnameFive.Visible = false;
                txtSnameFive.Visible = false;
                DDLGenderFive.Visible = false;
                DDLOcuppationFive.Visible = false;
                txtDOBFive.Visible = false;



                lblClaimOne.Visible = true;
                lblClaimTwo.Visible = true;
                lblClaimThree.Visible = true;
                lblClaimFour.Visible = true;
                lblClaimFive.Visible = true;

                txtClaimOneFirst.Visible = true;
                txtClaimTwoFirst.Visible = true;
                txtClaimThreeFirst.Visible = true;
                txtClaimFourFirst.Visible = true;
                txtClaimFiveFirst.Visible = true;

                txtClaimOneSecond.Visible = true;
                txtClaimTwoSecond.Visible = true;
                txtClaimThreeSecond.Visible = true;
                txtClaimFourSecond.Visible = true;
                txtClaimFiveSecond.Visible = true;


                txtClaimOneThird.Visible = true;
                txtClaimTwoThird.Visible = true;
                txtClaimThreeThird.Visible = true;
                txtClaimFourThird.Visible = true;
                txtClaimFiveThird.Visible = true;

                txtClaimOneFourth.Visible = true;
                txtClaimTwoFourth.Visible = true;
                txtClaimThreeFourth.Visible = true;
                txtClaimFourFourth.Visible = true;
                txtClaimFiveFourth.Visible = true;

                txtClaimOneFifth.Visible = false;
                txtClaimTwoFifth.Visible = false;
                txtClaimThreeFifth.Visible = false;
                txtClaimFourFifth.Visible = false;
                txtClaimFiveFifth.Visible = false;

            }
            else if (ddlAmount.SelectedItem.Value == "Five")
            {

                lbldriverOne.Visible = true;
                lbldriverTwo.Visible = true;
                lbldriverThree.Visible = true;
                lbldriverFour.Visible = true;
                lbldriverFive.Visible = true;

                lblFname.Visible = true;
                lblSname.Visible = true;
                lblGender.Visible = true;
                lblOccupation.Visible = true;
                lblDOB.Visible = true;

                txtFnameOne.Visible = true;
                txtSnameOne.Visible = true;
                DDLGenderOne.Visible = true;
                DDLOcuppationOne.Visible = true;
                txtDOBOne.Visible = true;

                txtFnameTwo.Visible = true;
                txtSnameTwo.Visible = true;
                DDLGenderTwo.Visible = true;
                DDLOcuppationTwo.Visible = true;
                txtDOBTwo.Visible = true;

                txtFnameThree.Visible = true;
                txtSnameThree.Visible = true;
                DDLGenderThree.Visible = true;
                DDLOcuppationThree.Visible = true;
                txtDOBThree.Visible = true;

                txtFnameFour.Visible = true;
                txtSnameFour.Visible = true;
                DDLGenderFour.Visible = true;
                DDLOcuppationFour.Visible = true;
                txtDOBFour.Visible = true;


                txtFnameFive.Visible = true;
                txtSnameFive.Visible = true;
                DDLGenderFive.Visible = true;
                DDLOcuppationFive.Visible = true;
                txtDOBFive.Visible = true;

                lblClaimOne.Visible = true;
                lblClaimTwo.Visible = true;
                lblClaimThree.Visible = true;
                lblClaimFour.Visible = true;
                lblClaimFive.Visible = true;

                txtClaimOneFirst.Visible = true;
                txtClaimTwoFirst.Visible = true;
                txtClaimThreeFirst.Visible = true;
                txtClaimFourFirst.Visible = true;
                txtClaimFiveFirst.Visible = true;

                txtClaimOneSecond.Visible = true;
                txtClaimTwoSecond.Visible = true;
                txtClaimThreeSecond.Visible = true;
                txtClaimFourSecond.Visible = true;
                txtClaimFiveSecond.Visible = true;


                txtClaimOneThird.Visible = true;
                txtClaimTwoThird.Visible = true;
                txtClaimThreeThird.Visible = true;
                txtClaimFourThird.Visible = true;
                txtClaimFiveThird.Visible = true;

                txtClaimOneFourth.Visible = true;
                txtClaimTwoFourth.Visible = true;
                txtClaimThreeFourth.Visible = true;
                txtClaimFourFourth.Visible = true;
                txtClaimFiveFourth.Visible = true;

                txtClaimOneFifth.Visible = true;
                txtClaimTwoFifth.Visible = true;
                txtClaimThreeFifth.Visible = true;
                txtClaimFourFifth.Visible = true;
                txtClaimFiveFifth.Visible = true;
        
            }



      


                

            







        

      


        }

     
       

       
            
     
        
    }
}
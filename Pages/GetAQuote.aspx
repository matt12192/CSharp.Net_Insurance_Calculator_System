<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/Masterpage.Master" AutoEventWireup="true" CodeBehind="GetAQuote.aspx.cs" Inherits="Applied.Pages.GetAQuote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-lg-center">Get A Quote</h1>
    <h2>Select Policy Start Date</h2>

    <div>


    </div>
     

    <table class="table-responsive ">
        <tr>
           <%--Required: Start Date of the Policy, E.g. 06/10/2015.--%>
            <td>
            <asp:Label ID="lblselectStartDate" runat="server" Text="Policy Start Date: ">
            </asp:Label>
            <asp:TextBox type="date" ID="txtselectStartDate" runat="server" Format="dd/MM/yyyy" ValidationGroup="1" CssClass="form-control-static" required></asp:TextBox></td>

            


            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                            ErrorMessage="Start Date of Policy" 
                            ControlToValidate="txtselectStartDate" ValidationGroup="1" CssClass="bg-danger alert-danger" Type="Date">*</asp:RangeValidator></td>


               </tr>

        <tr>
            <td><asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="bg-danger alert-danger" ValidationGroup="1" /></td>
        </tr>
      
        
        
    </table>
    <h2>Add Drivers</h2>
       <table class="table-responsive">
           
                <tr>
           <%--Required: Start Date of the Policy, E.g. 06/10/2015.--%>
            <td>
            <asp:Label ID="Label3" runat="server" Text="Select Amount on Policy: ">
            </asp:Label>
                <asp:DropDownList ID="ddlAmount" runat="server" AutoPostBack="True" CssClass="form-control-static" OnSelectedIndexChanged="ddlAmount_SelectedIndexChanged">
                    <asp:ListItem>Select Amount</asp:ListItem>
                    <asp:ListItem runat="server" id="ddlOne">One</asp:ListItem>
                    <asp:ListItem runat="server" id="ddlTwo">Two</asp:ListItem>
                    <asp:ListItem runat="server" id="ddlThree">Three</asp:ListItem>
                    <asp:ListItem runat="server" id="ddlFour">Four</asp:ListItem>
                    <asp:ListItem runat="server" id="ddlFive">Five</asp:ListItem>
                </asp:DropDownList>
            </td>
          
         
        </tr>

        <tr>
 <%--          	Required - Add Driver(s) 
Required - Name: E.g. Brian.
Required - Occupation: ‘Chauffeur’ or ‘Accountant’.
Required - Date of Birth: E.g. 01/01/1973.--%>

            <th>
               
            </th>
            <th>
            <asp:Label ID="lbldriverOne" runat="server" Visible="false"  Text="Driver One">
                </asp:Label></th>
         <th>
            <asp:Label ID="lbldriverTwo" runat="server" Visible="false" Text="Driver Two">
                </asp:Label></th>
              <th>
            <asp:Label ID="lbldriverThree" runat="server" Visible="false" Text="Driver Three">
                </asp:Label></th>
               
            <th>
            <asp:Label ID="lbldriverFour" runat="server" Visible="false" Text="Driver Four">
                </asp:Label></th>
              <th>
            <asp:Label ID="lbldriverFive" runat="server" Visible="false" Text="Driver Five">
                </asp:Label></th>
        </tr>
        
           <tr>
               <td><asp:Label ID="lblFname" runat="server" Visible="false"   Text="First Name:"></asp:Label></td>
               
               <td>
                 
               <asp:TextBox ID="txtFnameOne" runat="server" Visible="false" CssClass="form-control-static"   placeholder="Enter Firstname" required></asp:TextBox></td>
                 <td>
               <asp:TextBox ID="txtFnameTwo" runat="server" Visible="false" CssClass="form-control-static"    placeholder="Enter Firstname" required></asp:TextBox></td>
                 <td>
               <asp:TextBox ID="txtFnameThree" runat="server" Visible="false" CssClass="form-control-static"  placeholder="Enter Firstname" required></asp:TextBox></td>
                 <td>
               <asp:TextBox ID="txtFnameFour" runat="server" Visible="false" CssClass="form-control-static"  placeholder="Enter Firstname" required></asp:TextBox></td>
                 <td>
               <asp:TextBox ID="txtFnameFive" runat="server" Visible="false" CssClass="form-control-static"  placeholder="Enter Firstname" required></asp:TextBox></td>

               
           </tr>

            <tr>
                <td><asp:Label ID="lblSname" runat="server" Visible="false"  Text="Surname:"></asp:Label></td>


               <td>
               <asp:TextBox ID="txtSnameOne" runat="server" Visible="false" CssClass="form-control-static"  placeholder="Enter Surname" required></asp:TextBox></td>
                <td>
               <asp:TextBox ID="txtSnameTwo" runat="server" Visible="false" CssClass="form-control-static"   placeholder="Enter Surname" required></asp:TextBox></td>
                <td>
               <asp:TextBox ID="txtSnameThree" runat="server" Visible="false" CssClass="form-control-static"  placeholder="Enter Surname" required></asp:TextBox></td>
                <td>
               <asp:TextBox ID="txtSnameFour" runat="server" Visible="false" CssClass="form-control-static"  placeholder="Enter Surname" required></asp:TextBox></td>
                <td>
               <asp:TextBox ID="txtSnameFive" runat="server" Visible="false" CssClass="form-control-static"  placeholder="Enter Surname" required></asp:TextBox></td>
                 

               
           </tr>
           
           <tr>
               <td><asp:Label ID="lblGender" runat="server" Visible="false"   Text="Gender:" ></asp:Label></td>


               <td><asp:DropDownList ID="DDLGenderOne" runat="server" CssClass="form-control-static"  Visible="false" required>
                   <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                   <asp:ListItem>Male</asp:ListItem>
                   <asp:ListItem>Female</asp:ListItem>
                   </asp:DropDownList>

               </td>
                  <td><asp:DropDownList ID="DDLGenderTwo" runat="server" CssClass="form-control-static"  Visible="false"  required>
                   <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                   <asp:ListItem>Male</asp:ListItem>
                   <asp:ListItem>Female</asp:ListItem>
                   </asp:DropDownList>

               </td>
                  <td><asp:DropDownList ID="DDLGenderThree" runat="server" CssClass="form-control-static"  Visible="false" required>
                   <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                   <asp:ListItem>Male</asp:ListItem>
                   <asp:ListItem>Female</asp:ListItem>
                   </asp:DropDownList>

               </td>
                  <td><asp:DropDownList ID="DDLGenderFour" runat="server" CssClass="form-control-static"  Visible="false" required>
                   <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                   <asp:ListItem>Male</asp:ListItem>
                   <asp:ListItem>Female</asp:ListItem>
                   </asp:DropDownList>

               </td>
                  <td><asp:DropDownList ID="DDLGenderFive" runat="server" CssClass="form-control-static"  Visible="false" required>
                   <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                   <asp:ListItem>Male</asp:ListItem>
                   <asp:ListItem>Female</asp:ListItem>
                   </asp:DropDownList>

               </td>
             
           </tr>

           <tr>
               <td><asp:Label ID="lblOccupation" runat="server" Text="Occupation:" Visible="false"  ></asp:Label></td>

                   <td><asp:DropDownList ID="DDLOcuppationOne" runat="server" CssClass="form-control-static"  Visible="false" required >
                   <asp:ListItem Selected="True">Select Occupation</asp:ListItem>
                   <asp:ListItem>Chauffeur</asp:ListItem>
                   <asp:ListItem>Accountant</asp:ListItem>
                   </asp:DropDownList>

               </td>

               <td><asp:DropDownList ID="DDLOcuppationTwo" runat="server" CssClass="form-control-static"  Visible="false" required>
                   <asp:ListItem Selected="True">Select Occupation</asp:ListItem>
                   <asp:ListItem>Chauffeur</asp:ListItem>
                   <asp:ListItem>Accountant</asp:ListItem>
                   </asp:DropDownList>

               </td>

               <td><asp:DropDownList ID="DDLOcuppationThree" runat="server" CssClass="form-control-static"  Visible="false" required>
                   <asp:ListItem Selected="True">Select Occupation</asp:ListItem>
                   <asp:ListItem>Chauffeur</asp:ListItem>
                   <asp:ListItem>Accountant</asp:ListItem>
                   </asp:DropDownList>

               </td>

               <td><asp:DropDownList ID="DDLOcuppationFour" runat="server" CssClass="form-control-static"  Visible="false" required>
                   <asp:ListItem Selected="True">Select Occupation</asp:ListItem>
                   <asp:ListItem>Chauffeur</asp:ListItem>
                   <asp:ListItem>Accountant</asp:ListItem>
                   </asp:DropDownList>

               </td>

               <td><asp:DropDownList ID="DDLOcuppationFive" runat="server" CssClass="form-control-static"  Visible="false" required>
                   <asp:ListItem Selected="True">Select Occupation</asp:ListItem>
                   <asp:ListItem>Chauffeur</asp:ListItem>
                   <asp:ListItem>Accountant</asp:ListItem>
                   </asp:DropDownList>

               </td>

           </tr>

           <tr>
               <td><asp:Label ID="lblDOB" runat="server" Text="D.O.B:" Visible="false"  ></asp:Label></td>

               <td>
                   <asp:TextBox type="date" ID="txtDOBOne" runat="server" placeholder="DOB" CssClass="form-control-static"  Visible="false"  required></asp:TextBox>
               </td>
                <td>
                   <asp:TextBox type="date" ID="txtDOBTwo" runat="server" CssClass="form-control-static"  Visible="false" required></asp:TextBox>
               </td>
                <td>
                   <asp:TextBox type="date" ID="txtDOBThree" runat="server" CssClass="form-control-static"  Visible="false" required></asp:TextBox>
               </td>
                <td>
                   <asp:TextBox type="date" ID="txtDOBFour" runat="server" CssClass="form-control-static"  Visible="false" required></asp:TextBox>
               </td>
                <td>
                   <asp:TextBox type="date" ID="txtDOBFive" runat="server" CssClass="form-control-static"  Visible="false" required></asp:TextBox>
               </td>

           </tr>


            <tr>
            <td><asp:Label ID="lblClaimOne" runat="server" Text="Claim One:" Visible="false"></asp:Label></td>
            
            <td><asp:TextBox type="date" ID="txtClaimOneFirst" runat="server" CssClass="form-control-static"  Visible="false" ></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimOneSecond" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimOneThird" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimOneFourth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimOneFifth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblClaimTwo" runat="server" Text="Claim Two:" Visible="false"></asp:Label></td>
            <td><asp:TextBox type="date" ID="txtClaimTwoFirst" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimTwoSecond" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimTwoThird" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimTwoFourth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimTwoFifth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblClaimThree" runat="server" Text="Claim Three" Visible="false"></asp:Label></td>
           <td><asp:TextBox type="date" ID="txtClaimThreeFirst" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimThreeSecond" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimThreeThird" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimThreeFourth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimThreeFifth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
        </tr>

        <tr>
            <td><asp:Label ID="lblClaimFour" runat="server" Text="Claim Four" Visible="false"></asp:Label></td>
           <td><asp:TextBox type="date" ID="txtClaimFourFirst" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimFourSecond" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimFourThird" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimFourFourth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimFourFifth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
        </tr>

          <tr>
            <td><asp:Label ID="lblClaimFive" runat="server" Text="Claim Five" Visible="false"></asp:Label></td>
           <td><asp:TextBox type="date" ID="txtClaimFiveFirst" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimFiveSecond" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimFiveThird" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
            <td><asp:TextBox type="date" ID="txtClaimFiveFourth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
             <td><asp:TextBox type="date" ID="txtClaimFiveFifth" runat="server" CssClass="form-control-static"  Visible="false"></asp:TextBox></td>
        </tr>

    
    </table>

  

    
 
 
    <asp:Button ID="btnQuote" runat="server" CssClass="btn btn-primary" Text="Quote" ValidationGroup="1" OnClick="btnQuote_Click" />




    </asp:Content>

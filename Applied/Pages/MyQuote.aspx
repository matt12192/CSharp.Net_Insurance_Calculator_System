<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/Masterpage.Master" AutoEventWireup="true" CodeBehind="MyQuote.aspx.cs" Inherits="Applied.Pages.MyQuote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table-responsive">
        <tr>
            <th><asp:Label ID="lblCustomers" runat="server" Text="Customers"></asp:Label></th>
            <th><asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></th>
             <th><asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label></th>
            <th><asp:Label ID="lblOccupation" runat="server" Text="Occuppation"></asp:Label></th>
            <th><asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label></th>


        </tr>
        <tr>
            <td><asp:Label ID="lblCustomerOne" runat="server" Text="Customer One:"></asp:Label></td>
            <td><asp:Label ID="lblCustomerOneName" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerOneGender" runat="server" ></asp:Label></td>
             <td><asp:Label ID="lblCustomerOneOccupation" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerOneAge" runat="server" ></asp:Label></td>
        </tr>
        <tr>
           <td><asp:Label ID="lblCustomerTwo" runat="server" Text="Customer Two:"></asp:Label></td>
           <td><asp:Label ID="lblCustomerTwoName" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerTwoGender" runat="server" ></asp:Label></td>
             <td><asp:Label ID="lblCustomerTwoOccupation" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerTwoAge" runat="server" ></asp:Label></td>
        </tr>
       <tr>
           <td><asp:Label ID="lblCustomerThree" runat="server" Text="Customer Three:"></asp:Label></td>
               <td><asp:Label ID="lblCustomerThreeName" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerThreeGender" runat="server" ></asp:Label></td>
             <td><asp:Label ID="lblCustomerThreeOccupation" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerThreeAge" runat="server" ></asp:Label></td>
        </tr>
           <tr>
           <td><asp:Label ID="lblCustomerFour" runat="server" Text="Customer Four:"></asp:Label></td>
               <td><asp:Label ID="lblCustomerFourName" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerFourGender" runat="server" ></asp:Label></td>
             <td><asp:Label ID="lblCustomerFourOccupation" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerFourAge" runat="server" ></asp:Label></td>
        </tr>
           <tr>
           <td><asp:Label ID="lblCustomerFive" runat="server" Text="Customer Five:"></asp:Label></td>
                <td><asp:Label ID="lblCustomerFiveName" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerFiveGender" runat="server" ></asp:Label></td>
             <td><asp:Label ID="lblCustomerFiveOccupation" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblCustomerFiveAge" runat="server" ></asp:Label></td>
        </tr>

        
           <tr>
           <td><asp:Label ID="lblPremiumQuote" runat="server" Text="Premium Quote:"></asp:Label></td>
            <td>
    <div class="form-group">
    <label class="sr-only" for="exampleInputAmount">Amount (in dollars)</label>
    <div class="input-group">
      <div class="input-group-addon">£</div>
      <input type="text" class="form-control" runat="server" id="txtPremium" placeholder="Amount" readonly/>
      <div class="input-group-addon">.00</div>
    </div>
  </div></td>
            <td>&nbsp;</td>
        </tr>

        
        
           
    
    
    </table>









</asp:Content>

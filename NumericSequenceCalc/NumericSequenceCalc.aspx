<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumericSequenceCalc.aspx.cs" Inherits="NumericSequenceCalc.NumericSequenceCalc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <h2>Numeric Sequence Calculator</h2> 
           <table>
           <tr>
           <td>
           Enter number
           </td>
           <td>
             <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ControlToValidate="txtNumber" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
               <asp:CompareValidator ID="CompareValidator1" ControlToValidate="txtNumber" Type="Integer" Operator="GreaterThanEqual" ValueToCompare="1" runat="server" ErrorMessage="Positive number only" ></asp:CompareValidator>
           </td>
           </tr>
           <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                    onclick="btnSubmit_Click" />
            </td>
           </tr>
           </table>

        <asp:Panel ID="pnlOutput" Visible="false" runat="server">
        <table>
        <tr>
            <td>
              <b>  S3.1.1 = </b>
            </td>
            <td>
                <asp:Label ID="lblS311" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        <tr>
            <td>
                <b>  S3.1.2 = </b>
            </td>
            <td>
                <asp:Label ID="lblS312" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        <tr>
            <td>
           <b>  S3.1.3 = </b>
            </td>
            <td>
                <asp:Label ID="lblS313" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        <tr>
            <td>
             <b>  S3.1.4 = </b>
            </td>
            <td>
                <asp:Label ID="lblS314" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        <tr>
            <td>
              <b>  S3.1.5 = </b>
            </td>
            <td>
                <asp:Label ID="lblS315" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        </table>
        </asp:Panel>
          
    </div>
    </form>
</body>
</html>

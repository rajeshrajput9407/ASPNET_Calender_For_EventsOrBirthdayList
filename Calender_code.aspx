<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calender_code.aspx.cs" Inherits="Calender_Code.Calender_code" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title>Untitled Page</title>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
        <p style="text-align: center">  
        <b></b>  
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium"  
            ForeColor="#0066FF">Indian List of Holidays 2009</asp:Label><br /></b>  
        </p>  
        <asp:Calendar Width="100%" Height="442px" ID="Calendar1" runat="server" Font-Bold="true" BackColor="white" BorderColor="#dddddd"  
            BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="12pt"  
            ForeColor="#266088" ShowGridLines="True" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged"  
            OnVisibleMonthChanged="Calendar1_VisibleMonthChanged">  
            <SelectedDayStyle BackColor="red" Font-Bold="True" />  
            <SelectorStyle BackColor="pink" />  
            <TodayDayStyle BackColor="pink" ForeColor="White" />  
            <OtherMonthDayStyle ForeColor="green" />  
            <NextPrevStyle Font-Size="11pt" ForeColor="red" />  
            <DayHeaderStyle BackColor="#266088" ForeColor="White" Font-Bold="True" Height="40px" />  
            <TitleStyle BackColor="dodgerblue" Font-Bold="True" Font-Size="12pt" ForeColor="black" />  
        </asp:Calendar>  
        <br />  
        <b></b>  
        <asp:Label ID="LabelAction" runat="server"></asp:Label><br />  
        </b>  
    </div>  
    </form>  
</body>  
</html>
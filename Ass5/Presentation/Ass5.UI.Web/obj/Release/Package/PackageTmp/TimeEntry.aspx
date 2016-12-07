<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimeEntry.aspx.cs" Inherits="Ass5.UI.Web.TimeEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="timeEntryForm" runat="server">
    <div>
    <table>
        <tr>
            <td>UserID</td>
            <td>
                <asp:Label ID="lblUserID" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Username</td>
            <td>
                <asp:Label ID="lblUserName" runat="server" />
            </td>
        </tr>

        <tr>
            <td>Task No</td>
            <td><asp:TextBox ID="txtTaskNo" runat="server" /></td>
            <asp:Label ID="lblTaskID" runat ="server" visible="true" />
        </tr>
        <tr>
            <td>Task Name</td>
            <td>
              <asp:TextBox ID="txtTaskname" runat="server" />
              <asp:Label ID="lblguid" runat="server" Visible="false" />
              <asp:Label ID="lblTaskStatus" runat="server" Text="Pending" Visible="false" />
            </td>
        </tr>
        <tr>
            <td>Start Date</td>
            <td>
                <asp:TextBox ID="txtStartDate" runat="server" />
            </td>
        </tr>
        <tr>
            <td>EndDate</td>
            <td>
                <asp:TextBox ID="txtEndDate" runat="server" />
                <asp:Label ID="lblSubmitDate" runat="server" Visible="false" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit Task" OnClick="btnSubmit_Click"/>
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
        </tr>
    </table>
    </div>
    <div>
         <asp:GridView ID="GridViewSubmitForm" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewSubmitForm_SelectedIndexChanged"/>
    </div>
    </form>
</body>
</html>

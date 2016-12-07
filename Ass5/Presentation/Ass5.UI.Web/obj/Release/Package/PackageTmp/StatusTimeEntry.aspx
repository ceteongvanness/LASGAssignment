<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatusTimeEntry.aspx.cs" Inherits="Ass5.UI.Web.StatusTimeEntry" %>

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
            <td><asp:Label ID="lblTaskNo" runat="server" /></td>
        </tr>
        <tr>
            <td>Task ID</td>
            <td>
                <asp:Label ID="lblTaskID" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Task Name</td>
            <td>
              <asp:TextBox ID="txtTaskname" runat="server" />
              <asp:Label ID="lblguid" runat="server" Visible="false" />
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
            </td>
        </tr>
        <tr>
            <td>Submit Date</td>
            <td>
              <asp:Label ID="lblSubmitDate" runat="server"/>
            </td>
        </tr>
        <tr>
            <td>Task Status</td>
            <td>
              <asp:Label ID="lblTaskStatus" runat="server" Text="Pending" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
            <td>
                <asp:Button ID="btnApprove" runat="server" Text="Approve" OnClick="btnApprove_Click"/>
            </td>
            <td>
                <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click"/>
            </td>
        </tr>
    </table>
    </div>
    <div>
         <asp:GridView ID="GridViewSubmitStatusForm" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewSubmitStatusForm_SelectedIndexChanged"/>
    </div>
    <div>
        <asp:Button ID="btnExport" runat="server" Text="Export to CSV (Excel)" OnClick="btnExport_Click" />
    </div>
    
    </form>
</body>
</html>

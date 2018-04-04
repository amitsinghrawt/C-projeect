<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration2.aspx.cs" Inherits="amit.StudentRegistration2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h1>Student Registration</h1>
            <table>
                <tr>
                    <td>Id</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>student Id</td>
                    <td>
                        <asp:TextBox ID="txtStudentId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Student Name</td>
                    <td>
                        <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Course Name</td>
                    <td>
                        <asp:TextBox ID="txtCourseName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Semester</td>
                    <td>
                        <asp:TextBox ID="txtSemester" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
              
                        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                        <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" /></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>

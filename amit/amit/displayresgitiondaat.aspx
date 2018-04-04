<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displayresgitiondaat.aspx.cs" Inherits="amit.displayresgitiondaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Registration Data</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Student Registration Data<h1>
            <table>
                <tr>
                    <td>Id</td> 
                    <td>Student Id</td>
                     <td>Student name</td> 
                    <td>Course Name</td>
                     <td>Semester</td>
                </tr>
                <%for(int i=0;i<  objStudent.Count ; i++ ){ %>
                    <tr>
                        <td><%= objStudent[i].Id%>></td>
                         <td><%=objStudent[i].studentId %>></td>
                         <td><% =objStudent[i].StudentName %>></td>
                         <td><% = objStudent[i].courseName %>></td>
                         <td><% =objStudent[i].semester %>></td>
                        </tr>
                <%} %>>


            </table>
    
    </div>
    </form>
</body>
</html>

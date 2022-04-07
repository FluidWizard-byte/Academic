<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentassignment.aspx.cs" Inherits="BijayBharati19030824.studentassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>StudentAssignment</title>
</head>
<body class="container p-3 my-3 bg-dark text-white">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="home.aspx">Berkeley College</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item">
                    <a class="nav-link" href="address.aspx">Address</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="department.aspx">Department</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="module.aspx">Module</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="student.aspx">Student</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="teacher.aspx">Teacher</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="studentassignment.aspx">StudentAssignment</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="studentfee.aspx">StudentFee</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="teachermodule.aspx">TeacherModule</a>
                </li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="mt-5">
            <h1 class="display-1 mt-5">Student Assignment Details</h1>
            <asp:GridView class="table table-striped table-dark" ID="gvSA" runat="server">
            </asp:GridView>
        </div>

        <div class="mt-5">
            <asp:Label ID="label1" Text="Select Student: " runat="server" />
            <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="ddlStudent" runat="server" DataSourceID="SqlDataSource1" DataTextField="STUDENT_NAME" DataValueField="STUDENT_ID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;STUDENT_ID&quot;, &quot;STUDENT_NAME&quot; FROM &quot;STUDENT&quot;"></asp:SqlDataSource>
        </div>

        <div class="mt-5">
            <asp:Button class="btn btn-light" ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" Width="88px" />
        </div>

    </form>
</body>
</html>

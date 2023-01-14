﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teacher.aspx.cs" Inherits="BijayBharati19030824.teacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Teacher</title>
</head>
<body class="container p-3 my-3 bg-dark text-white">
    <form id="form1" runat="server">
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
        <div>

            <h1 class="display-1 mt-5">Teacher Details</h1>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;teacher&quot;"></asp:SqlDataSource>
            <div>
                <asp:GridView class="table table-striped table-dark" ID="gvTeacher" runat="server" DataKeyNames="teacher_id" OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit" OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added." AutoGenerateEditButton="true" AutoGenerateDeleteButton="true">
                </asp:GridView>
            </div>

            <div>

                <div class="mt-5">
                    <asp:Label ID="label1" Text="Name: " runat="server" />
                    <asp:TextBox class="form-control" placeholder="Teacher's Name" ID="txtteachername" runat="server" />
                </div>

                <div class="mt-5">
                    <asp:Label ID="label2" Text="Module Taught: " runat="server" />
                    <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="ddlModule" runat="server" DataSourceID="SqlDataSource2" DataTextField="MODULE_NAME" DataValueField="MODULE_ID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;MODULE_ID&quot;, &quot;MODULE_NAME&quot; FROM &quot;MODULE&quot;"></asp:SqlDataSource>
                </div>

                <div class="mt-5">
                    <asp:Label ID="label3" Text="Department: " runat="server" />
                    <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="ddlDepartment" runat="server" DataSourceID="SqlDataSource3" DataTextField="DEPARTMENT_NAME" DataValueField="DEPARTMENT_ID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;DEPARTMENT_ID&quot;, &quot;DEPARTMENT_NAME&quot; FROM &quot;DEPARTMENT&quot;"></asp:SqlDataSource>
                </div>

                <div class="mt-5">
                    <asp:Label ID="label4" Text="Address Zip Code: " runat="server" />
                    <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="ddlAddress" runat="server" DataSourceID="SqlDataSource4" DataTextField="ZIP" DataValueField="ADDRESS_ID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;ADDRESS_ID&quot;, &quot;ZIP&quot; FROM &quot;ADDRESS&quot;"></asp:SqlDataSource>
                </div>

                <div class="mt-5">
                    <asp:Label ID="label5" Text="Email: " runat="server" />
                    <asp:TextBox class="form-control" placeholder="something@something.com" ID="txtemail" runat="server" />
                </div>

                <div class="mt-5">
                    <asp:Label ID="label6" Text="Contact number: " runat="server" />
                    <asp:TextBox class="form-control" ID="txtphone" runat="server" />
                </div>

                <div class="mt-5">
                    <asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                    <asp:Button class="btn btn-light" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="88px" />
                </div>

            </div>
        </div>
    </form>
</body>
</html>

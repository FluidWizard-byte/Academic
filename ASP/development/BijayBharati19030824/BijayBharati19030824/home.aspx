<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="BijayBharati19030824.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Home</title>
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
            <centre>
                <h1 class="display-1 mt-25">Berkeley College</h1>
            </centre>
        </div>
    </form>
</body>
</html>

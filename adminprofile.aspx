<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminprofile.aspx.cs" Inherits="Orgiz.adminprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div>
            <nav class="navbar navbar-dark bg-dark navbar-expand-lg navbar-">
                <a class ="navbar-brand" href="a">
                <img src="images/main.png" width = "30" height = "30" />
                    Orgiz
                </a>

                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" 
                 aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
                </button>

                 <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto">
                       
  
                    </ul>

                    <ul class="navbar-nav">
                        
                        <li class="nav-item active">
                            <a  class="nav-link" href = "home.aspx">Logout</a>
                        </li>
                        
                    </ul>
                </div>
                </nav>
           </div>

    <div class="sidebar-sticky">
            <ul class="nav flex-column">

               

              <li class="nav-item">
                <a class="nav-link active" href="admincourses.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather "><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"></path><polyline points="9 22 9 12 15 12 15 22"></polyline></svg>
                  Manage Courses <span class="sr-only">(current)</span>
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="adminteachers.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file"><path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z"></path><polyline points="13 2 13 9 20 9"></polyline></svg>
                  Manage Teachers
                </a>
              </li>  

                 <li class="nav-item">
                <a class="nav-link" href="adminteachercourse.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file"><path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z"></path><polyline points="13 2 13 9 20 9"></polyline></svg>
                  Manage Teacher Courses
                </a>
              </li>  

              <li class="nav-item">
                <a class="nav-link" href="adminstudents.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file"><path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z"></path><polyline points="13 2 13 9 20 9"></polyline></svg>
                  Manage Students
                </a>
              </li>  

                <li class="nav-item">
                <a class="nav-link" href="adminmanagecourses.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file"><path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z"></path><polyline points="13 2 13 9 20 9"></polyline></svg>
                  Manage Student Courses
                </a>
              </li>  

                 <li class="nav-item">
                <a class="nav-link active" href="teacherleaves.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather "><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"></path><polyline points="9 22 9 12 15 12 15 22"></polyline></svg>
                  Teacher Leaves <span class="sr-only">(current)</span>
                </a>
                
                <li class="nav-item">
                <a class="nav-link active" href="studentleaves.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather "><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"></path><polyline points="9 22 9 12 15 12 15 22"></polyline></svg>
                  Student Leaves <span class="sr-only">(current)</span>
                </a> 
                    
                    <li class="nav-item">
                <a class="nav-link active" href="lostandfound.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather "><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"></path><polyline points="9 22 9 12 15 12 15 22"></polyline></svg>
                  Lost and Found <span class="sr-only">(current)</span>
                </a>

            </ul>
        </div>  


</asp:Content>

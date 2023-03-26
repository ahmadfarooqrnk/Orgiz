<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="studentleave.aspx.cs" Inherits="Orgiz.studentleave" %>
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
                <a class="nav-link active" href="studentcourses.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather "><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"></path><polyline points="9 22 9 12 15 12 15 22"></polyline></svg>
                  Courses <span class="sr-only">(current)</span>
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="studentattendance.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file"><path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z"></path><polyline points="13 2 13 9 20 9"></polyline></svg>
                  Attendance
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="studentprogress.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-shopping-cart"><circle cx="9" cy="21" r="1"></circle><circle cx="20" cy="21" r="1"></circle><path d="M1 1h4l2.68 13.39a2 2 0 0 0 2 1.61h9.72a2 2 0 0 0 2-1.61L23 6H6"></path></svg>
                  Progress
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="studentleave.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-users"><path d="M17 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2"></path><circle cx="9" cy="7" r="4"></circle><path d="M23 21v-2a4 4 0 0 0-3-3.87"></path><path d="M16 3.13a4 4 0 0 1 0 7.75"></path></svg>
                  Leave
                </a>
                  <div class="col-md-5">
                                        <label>Input Your Request with your ID mentioned in it!</label>
                                            <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="............"></asp:TextBox>
                                                <asp:Button class="btn btn-outline-dark" ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                                            </div>
                                    </div>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="studentlost.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-bar-chart-2"><line x1="18" y1="20" x2="18" y2="10"></line><line x1="12" y1="20" x2="12" y2="4"></line><line x1="6" y1="20" x2="6" y2="14"></line></svg>
                  Lost and Found
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="studentfeedback.aspx">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 0 0" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-layers"><polygon points="12 2 2 7 12 12 22 7 12 2"></polygon><polyline points="2 17 12 22 22 17"></polyline><polyline points="2 12 12 17 22 12"></polyline></svg>
                  Feedback
                </a>
              </li>
            </ul>

        </div>  


</asp:Content>

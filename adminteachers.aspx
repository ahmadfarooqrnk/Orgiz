<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminteachers.aspx.cs" Inherits="Orgiz.adminteachers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <script type="text/javascript">
      $(document).ready(function () {
      
          //$(document).ready(function () {
              //$('.table').DataTable();
         // });
      
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
          //$('.table1').DataTable();
      });
      </script>
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
                   <div class="container">
        <div class="row">
            <div class="col-md-5">

                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Teacher Details</h4>
                                    </center>
                            </div>
                        </div>

                        

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="col-md-8">
                                <label>Teacher Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Muhammad Yasin etc..."></asp:TextBox>

                                </div>
                            </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>Teacher ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        
                                    </div>
                                </div>
                            </div>

                            
                             <div class="col-md-4">
                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="-----"></asp:TextBox>

                                </div>
                            </div>

                            <div class="col-md-7">
                                <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="abc@xyz.com"></asp:TextBox>

                                </div>
                            </div>

                        </div>

                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-md btn-block btn-success" runat="server" Text="Add" OnClick="Button2_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button3" class="btn btn-md btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button4" class="btn btn-md btn-block btn-danger" runat="server" Text="Delete" OnClick="Button4_Click" />
                            </div>
                        </div>


                    </div>
                </div>
            </div>

            <div class="col-md-7">

                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Teacher's List</h4>
                                    </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrgizzConnectionString %>" SelectCommand="SELECT [FName], [TeacherID], [Email] FROM [Teacher] ORDER BY [TeacherID]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TeacherID" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="FName" HeaderText="FName" SortExpression="FName" />
                                        <asp:BoundField DataField="TeacherID" HeaderText="TeacherID" ReadOnly="True" SortExpression="TeacherID" />
                                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
                <a class="nav-link" href="adminmanagecourse.aspx">
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
                <a class="nav-link active" href="studentleave.aspx">
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

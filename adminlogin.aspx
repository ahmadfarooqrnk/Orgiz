<%@ Page Title="Orgiz-Admin" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="Orgiz.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>
            <nav class="navbar navbar-light navbar-expand-lg navbar-">
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
                            <a  class="nav-link" href = "teacherlogin.aspx">Teacher Login</a>
                        </li>
                        <li class="nav-item active">
                            <a  class="nav-link" href = "home.aspx">Student Login</a>
                        </li>
                    </ul>
                </div>
                </nav>
           </div>

      <div class="container">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                            <img width="100px" src="images/admin.png" />

                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h2>Admin Login</h2>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <h5>Admin ID</h5>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="--------"></asp:TextBox>
                        </div>
                        <h5>Password</h5>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="********" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                           <asp:Button class="btn btn-dark btn-block btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                        </div>
                       
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>

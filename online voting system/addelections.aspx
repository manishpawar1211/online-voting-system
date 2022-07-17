<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" Codefile="addelections.aspx.cs" Inherits="online_voting_system.addelections" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" CssClass="red-text"></asp:Label>
    <br /><br />
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150" src="images/candidate.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Candidate Details  </h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>member Id</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control"  ID="TextBox13" runat="server" Placeholder="Member Id"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>startDate</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Placeholder="date"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                             <div class="col-md-4">
                                <label for="">Enddate</label>
                                 <div class="form-group">
                                     <asp:TextBox cssClass="form-control"  ID="TextBox1" runat="server" placeholder="Endtime" TextMode="date"></asp:TextBox>
                                 </div>
                             </div>
                             <div class="col-md-4">
                                <label>Time</label>
                                 <div class="from-group">
                                     <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Time" TextMode="Time"></asp:TextBox>
                                 </div>
                             </div>
                             <div class="col-md-4">
                                <label>Title</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox14" runat="server" placeholder="title"></asp:TextBox>
                                </div>
                            </div>
                            </div>
                            </div>
                        <div class="row">
                            <div class="col-md">
                                <label>Description</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox15" runat="server" placeholder="description"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>Main Category</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="main category"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Cast<br />
                                </label>
                                &nbsp;<asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="cast"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row center">
                            <asp:Button class="btn btn-primary btn-lg" ID="Button1" runat="server" CssClass="" Text="person_add"  style="margin-left:189px" OnClick="Button1_Click"/>
                        </div>
                    <a href="Home.aspx"><< Back to Home</a><br>
                    <br />
                    <br />                          
                    </div>
                </div>
                
                <br>
            </div>
        </div>
    
</asp:Content>

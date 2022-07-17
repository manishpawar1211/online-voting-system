<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" Codefile="Home.aspx.cs" Inherits="online_voting_system.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label" CssClass=" black-text indicator text-darken-4"></asp:Label>           
    <section>
        <center>
            <img src="images/istockphoto-1299139820-1024x1024-removebg-preview.png" />
        </center>
        <br />
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h2>Election Principles </h2>
                        <p><b>Three primary principle</b></p>
                    </center>
                </div>
            </div>
            <div class="row">
                <div class="col-4">
                    <center>
                        <h4>Periodic</h4>
                        <p class="text-jesify">Elections will be held at regular intervals. Governments should not be allowed 
                            to delay elections as they should be periodic to be seen as legitimate. </p>
                    </center>
                </div>
                <div class="col-4">
                    <center>
                        <h4>Secret Vote or other Equivalent free voting procedure</h4>
                        <p> The Secrecy of the Ballot is a crucial aspect of many democracies. In order to protect against the purchasing of votes or cooercion, 
                            ballots should be cast in secret. Equivalent free voting procedure means that one's ability to vote should be unhindered by
                            others in that elections should be free to vote in line with their views rather than 
                            be forced or cooerced into voting for what others would like. </p>
                    </center>
                </div>
                <div class="col-4">
                    <center>
                        <h4>Universal & Equal Suffrage</h4>
                        <p>Every Citizen has the right to vote regardless of faith, ethnicity, gender, education or disability. The only restrictions are on being 
                            above an age limit and registration, the latter of which has been abused in the past. This has the added implication of Fair Elections, 
                            meaning that every vote has the same weighting and worth.</p>
                    </center>

                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="row">
            <div class="col-5">
                 <img src="images/istockphoto-1319946389-612x612.jpg" />
            </div>
            <div class]="col-7">
                <img src="images/istockphoto-1224495019-612x612.jpg" />
            </div>
        </div>
    </section>

</asp:Content>

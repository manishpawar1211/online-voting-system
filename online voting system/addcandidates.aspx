<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addcandidates.aspx.cs" Inherits="online_voting_system.addcandidates" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" CssClass=" red-text"></asp:Label>
    <br />
    <div class="container">
        <center>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sqlDataSource1" DataTextField="title" DataValueField="title" AutoPostBack="true">
            </asp:DropDownList>
            <label>Election Title</label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:online votingConnectionString2 %>" SelectCommand="SELECT * FROM [election]"></asp:SqlDataSource>
            <br />
            <h5>Election ID for this election:</h5>
            <asp:Label ID="Label11" runat="server"></asp:Label>
            <h5>Following candidates applied for this election:</h5>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None"  Height="348px" Width="1133px" AllowPaging="True">
             
                <AlternatingRowStyle BackColor="White" />
             
                <Columns>
                    <asp:BoundField DataField="cid" HeaderText="Candidate" SortExpression="cid" />
                    <asp:TemplateField HeaderText="">
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" ID="select" OnClick="select_Click">SELECT THIS CANDIDATE</asp:LinkButton> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:LinkButton runat="server" ID="details" OnClick="details_Click">VIEW DETAILS</asp:LinkButton>
                                </ItemTemplate>
                     </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </center>
        <div class="row">
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:online votingConnectionString %>" SelectCommand="SELECT * FROM [candidate]"></asp:SqlDataSource>
            
        </div>
    </div>



</asp:Content>

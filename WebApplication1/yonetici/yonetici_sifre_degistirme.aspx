<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici/yonetici.Master" AutoEventWireup="true" CodeBehind="yonetici_sifre_degistirme.aspx.cs" Inherits="WebApplication1.yonetici.yonetici_sifre_degistirme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <br />

    <form id="form1" runat="server">
        <div class="row" style="width: 40%">

            <asp:TextBox ID="txteskiSifre" runat="server" CssClass="form-control" TextMode="Password" MaxLength="10" placeHolder="Eski Şifre"></asp:TextBox>
            <asp:Label ID="lblmailStatus" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="txtYenisifre" runat="server" CssClass="form-control" TextMode="Password" MaxLength="10" placeHolder="Yeni Şifre"></asp:TextBox><br />
            <asp:TextBox ID="txtYenisifreTekrar" runat="server" CssClass="form-control" MaxLength="10" TextMode="Password" placeHolder="Yeni Şifre(Tekrar)"></asp:TextBox><br />
            <asp:Button ID="btnsifre" runat="server" OnClick="sifreDegistir" Text="Şifreyi Güncelle" CssClass="btn btn-default" />
            <br />
            <asp:Panel ID="Panel2" runat="server" Visible="false">
                <div class="panel-body">
                    <div class="alert alert-success">
                        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</asp:Content>

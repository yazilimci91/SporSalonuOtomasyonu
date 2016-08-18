<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici/yonetici.Master" AutoEventWireup="true" CodeBehind="yonetici_profile.aspx.cs" Inherits="WebApplication1.yonetici.yonetici_profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <form id="form2" runat="server">

        <div class="row" style="width: 50%">

            <asp:Label ID="lblSalonAdi" runat="server" Font-Bold="True" Font-Size="22px" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbladres" runat="server" Text=""></asp:Label>
            <br />
            &nbsp;<br />
            <br />
            <asp:TextBox ID="txtAdsoyad" runat="server" CssClass="form-control" placeHolder="Ad Soyad" MaxLength="70"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtMail" runat="server" CssClass="form-control" placeHolder="Email" TextMode="Email" MaxLength="100"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" CssClass="btn btn-default" OnClick="Button3_Click" Text="Bilgileri Güncelle" />
            <br />

            <asp:Panel ID="Panel2" runat="server" Visible="false">
                <div class="panel-body">
                    <div class="alert alert-success">
                        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                    </div>
                </div>
            </asp:Panel>
            <!-- /.col-lg-12 -->
        </div>


        <br />

    </form>

</asp:Content>

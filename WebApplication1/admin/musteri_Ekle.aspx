<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="musteri_Ekle.aspx.cs" Inherits="WebApplication1.admin.musteri_Ekle" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <form id="form2" runat="server">

        <div class="row" style="width: 50%">
             
             <br />
            <asp:TextBox ID="txtAdsoyad" runat="server" CssClass="form-control" placeHolder="Ad Soyad" MaxLength="70"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdsoyad" ErrorMessage="Ad kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
             <asp:TextBox ID="txtTc" runat="server" CssClass="form-control" placeHolder="Tc Kimlik" MaxLength="11" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTc" ErrorMessage="Tc Kimlik Numarası girmelisiniz" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
             <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" placeHolder="Şifre" MaxLength="10" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSifre" ErrorMessage="Şifre boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
             <asp:TextBox ID="txtMail" runat="server" CssClass="form-control" placeHolder="Email " MaxLength="100" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMail" ErrorMessage="Email kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
             <asp:TextBox ID="txtTel" runat="server" CssClass="form-control" placeHolder="Telefon" MaxLength="10" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtTel" ErrorMessage="Telefon kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
              <table>
                    <tr>
                        <td>
                            Baş. T.
                        </td>
                        <td>
                            <asp:TextBox ID="txtTarih" runat="server" CssClass="form-control" placeHolder="Kayıt Tarihi" TextMode="Date"></asp:TextBox>
                        </td>
                        <td>
                            Bitiş T.
                        </td>
                        <td>
                             <asp:TextBox ID="txtBitisTarihi" runat="server" CssClass="form-control" placeHolder="Bitiş Tarihi" TextMode="Date"></asp:TextBox>
                        </td>
                    </tr>
                </table><br /><br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="btn btn-default" Text="Kaydet" />
             <br />
             <br />
            <asp:Panel ID="Panel2" runat="server" Visible="false">
                <div class="panel-body">
                    <div class="alert alert-success">
                        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                    </div>
                </div>
            </asp:Panel>

        </div>


        <br />

    </form>

</asp:Content>

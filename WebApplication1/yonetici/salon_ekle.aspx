<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici/yonetici.Master" AutoEventWireup="true" CodeBehind="salon_ekle.aspx.cs" Inherits="WebApplication1.yonetici.salon_ekle" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <form id="form2" runat="server">

        <div class="row" style="width: 50%">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <br />
            &nbsp;<br />
            <br />
            <asp:TextBox ID="txtAdsoyad" runat="server" CssClass="form-control" placeHolder="Ad Soyad" MaxLength="70"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdsoyad" ErrorMessage="Ad kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" placeHolder="Şifre"   MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSifre" ErrorMessage="Şifre kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtsalonAdi" runat="server" CssClass="form-control" placeHolder="Spor Salonu Adı"  MaxLength="100"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtsalonAdi" ErrorMessage="Salon Adı  kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" placeHolder="Email"   MaxLength="100"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtmail" ErrorMessage="Email  kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtsalonadres" runat="server" CssClass="form-control" placeHolder="Sapor Salonu Adresi"  MaxLength="150"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtsalonadres" ErrorMessage="Adres kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <div><table><tr><td>
            <asp:TextBox ID="txtTarih" runat="server" CssClass="form-control" placeHolder="Kayıt Tarihi" Enabled="false"  ></asp:TextBox></td><td>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/calendar.png" ImageAlign="Bottom" Height="20px"   />
            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" PopupButtonID="ImageButton1" runat="server" TargetControlID="txtTarih"
    Format="dd.MM.yyyy" /></td></tr></table> </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTarih" ErrorMessage="Tarih kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtTel" runat="server" CssClass="form-control" placeHolder="Telefon" TextMode="Number" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtTel" ErrorMessage="Telefon kısmı boş" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button3" runat="server" CssClass="btn btn-default" OnClick="Button3_Click" Text="Salonu Kaydet" />
            <br />
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

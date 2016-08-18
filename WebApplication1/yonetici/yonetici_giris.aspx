<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yonetici_giris.aspx.cs" Inherits="WebApplication1.yonetici.yonetici_giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="../Dosyalar/panel/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Dosyalar/panel/bower_components/metisMenu/dist/metisMenu.min.css" rel="stylesheet" />
    <link href="../Dosyalar/panel/dist/css/sb-admin-2.css" rel="stylesheet" />
    <link href="../Dosyalar/panel/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Yönetici Girişi</h3>
                    </div>
                    <div class="panel-body">
                        <form role="form" runat="server">
                            <fieldset>
                                <div class="form-group">
                                    <asp:TextBox ID="yoneticiMailTxt" runat="server" CssClass="form-control" placeHolder="Email"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="yoneticiSifreTxt" runat="server" CssClass="form-control" placeHolder="Şifre" TextMode="Password"></asp:TextBox>
                                </div>

                                <asp:Button ID="GirisBtn" runat="server" CssClass="btn btn-lg btn-success btn-block" Text="Giriş" OnClick="GirisBtn_Click" />
                                <br />
                                <!-- Change this to a button or input when using this as a form -->
                                <asp:LinkButton ID="SifremiUnuttumLink" runat="server" OnClick="SifremiUnuttumLink_Click">Şifremi Unuttum!</asp:LinkButton>
                                <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="yoneticiMailTxt" ErrorMessage="Email tipinde değil.." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="yoneticiMailTxt" ErrorMessage="Email boş..." ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="yoneticiSifreTxt" ErrorMessage="Şifre boş..." ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />

                                <asp:Panel ID="Panel1" runat="server" Visible="false">
                                    <div class="panel-body">
                                        <div class="alert alert-success">
                                            <asp:Label ID="messageLbl" runat="server" Visible="False"></asp:Label>

                                        </div>
                                    </div>
                                </asp:Panel>

                                <br />
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>


 <!-- jQuery -->
    <script src="../Dosyalar/panel/bower_components/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap Core JavaScript -->
    <script src="../Dosyalar/panel/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- Metis Menu Plugin JavaScript -->
    <script src="../Dosyalar/panel/bower_components/metisMenu/dist/metisMenu.min.js"></script>
    <!-- Custom Theme JavaScript -->
    <script src="../Dosyalar/panel/dist/js/sb-admin-2.js"></script>
</body>
</html>

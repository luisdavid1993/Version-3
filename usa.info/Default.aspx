<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usa.info.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="pagetitle">Streaming C Panel</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>



</head>
<body>
    <form id="form1" runat="server">



        <div class="col-sm-6 col-sm-offset-3">

            <div class="panel panel-primary">
                <div class="panel-heading">


                    <h4><span class="glyphicon glyphicon-log-in"></span>Entrar </h4>
                </div>

                <div class="panel-body">

                    <div class="form-group">
                        <label for="fecha">Usuario:</label>
                        <asp:TextBox ID="UCTextBoxUser" runat="server" class="form-control" MaxLength="50"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label for="fecha">Clave:</label>
                        <asp:TextBox ID="UCTextBoxPass" runat="server" class="form-control" TextMode="Password" MaxLength="20"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="fecha">Recordarme:</label>
                        <asp:CheckBox ID="CheckBoxRemember" runat="server" class="form-control" />
                    </div>

                    <asp:LinkButton ID="LinkButtonLogin" runat="server" class="btn btn-success" OnClick="LinkButtonLogin_Click">Login</asp:LinkButton>

                    <a class="btn btn-primary" href="/registro/registrar.aspx">Registrarse, Nuevo Usuario</a>




                </div>
                <div class="panel-footer">
                    <asp:Label ID="LabelCopyright" runat="server"></asp:Label>
                </div>
            </div>

        </div>



    </form>



</body>
</html>


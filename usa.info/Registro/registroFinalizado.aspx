<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registroFinalizado.aspx.cs" Inherits="usa.info.Registro.registroFinalizado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Usuario registrado</title>
     <meta name="viewport" content="width=device-width, initial-scale=1"/>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>

    <div class="col-sm-6 col-sm-offset-3">

            <div class="panel panel-primary">
                <div class="panel-heading">


                    <h4>Usuario <asp:Label ID="LabelUser" runat="server"></asp:Label> creado exitosamente</h4>
                </div>
                <div class="panel-body" style="text-align:center;">
                       <a class="btn btn-primary" href="../Default.aspx">Volver al Login</a>
                </div>
                <div class="panel-footer">
                    <asp:Label ID="LabelCopyright" runat="server"></asp:Label>
                    <br />
                     <asp:Label ID="LabelError" runat="server"></asp:Label>
                </div>
            </div>

        </div>
</body>
</html>

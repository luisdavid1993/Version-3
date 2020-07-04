<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="usa.info.registrar" %>

<%@ Register src="PagesControls/userPersonalData.ascx" tagname="userPersonalData" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="pagetitle">Streaming C Panel</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div class="col-sm-6 col-sm-offset-3">

            <div class="panel panel-primary">
                <div class="panel-heading">


                    <h4>
                        <img class="img-rounded" src="img/login.png" />
                        - Registrarse en el sistema</h4>
                </div>
                <div class="panel-body">
                    
                    <uc1:userPersonalData ID="userPersonalData1" runat="server" />
                    <asp:LinkButton ID="LinkButtonSaveAccount" runat="server" class="btn btn-success" OnClick="LinkButtonSaveAccount_Click">Crear Usuario Nuevo</asp:LinkButton>
                    <a class="btn btn-warning" href="Default.aspx">Cancelar</a>
                </div>
                <div class="panel-footer">
                    <asp:Label ID="LabelCopyright" runat="server"></asp:Label>
                </div>
            </div>

        </div>





    </form>
</body>
</html>

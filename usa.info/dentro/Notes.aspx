<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Notes.aspx.cs" Inherits="usa.info.dentro.NotepadEditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="pagetitle">Streaming C Panel</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
    <style>
        .ShowNotes {
            width: 31%;
            padding: 41px;
            height: 10px;
            margin: 5px;
            display: inline-block;
        }

        .divBoxNotes {
           border: 1px solid #ddd;
           padding: 30px;
           margin: 10px;
        }
        .marginFromBoton {
            margin-top: 1em;
            margin-left: 2em;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div class="form-group">
            <asp:LinkButton ID="LinkButtonNewuser" runat="server" class="btn btn-default" data-toggle="tooltip" title="Guardar Los Cambios" OnClick="LinkButtonNewuser_Click"><span class="glyphicon glyphicon-plus"></span> Crear Nota</asp:LinkButton>
            <%--<asp:TextBox ID="UCTextBoxNotes" runat="server" TextMode="MultiLine" class="form-control" style="border:0px;height:300px;"   ></asp:TextBox>--%>
            <%-- <asp:PlaceHolder runat="server" ID="dinamicLabel"/>--%>
            <br />
            <asp:Label ID="LabeldinamicLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

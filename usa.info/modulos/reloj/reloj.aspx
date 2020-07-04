<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reloj.aspx.cs" Inherits="usa.info.reloj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Streaming Control Panel</title>

    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>



    <style>
        .grande {
            font-size: 300%;
        }

        body {
            background-color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <asp:Label ID="LabelMenu" runat="server"></asp:Label>


            <div id="barra">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" class="cajitapanel" runat="server">
                    <ContentTemplate>
                        <fieldset>
                            <legend></legend>
                            <asp:Label ID="Label3" runat="server"></asp:Label>
                            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                            </asp:Timer>
                        </fieldset>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>

        </div>

    </form>


</body>
</html>

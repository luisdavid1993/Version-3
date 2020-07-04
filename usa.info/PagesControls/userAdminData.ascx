<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userAdminData.ascx.cs" Inherits="usa.info.userAdminData" %>


<%--<div class="panel panel-success">
    <div class="panel-heading">
    </div>
    <div class="panel-body">
        <div class="form-group">
            <label for="fecha">Usuario:</label>
        </div>

        <div class="form-group">
            <label for="fecha">Clave:</label>
        </div>
    </div>
</div>--%>

<div class="panel panel-success">
    <div class="panel-heading">Datos de Acceso</div>
    <div class="panel-body">
        <div class="form-group">
            <label for="UCTBLogin">Usuario:</label>
            <asp:TextBox ID="UCTBLogin" class="form-control" runat="server" MaxLength="50"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="UCTBPassword">Clave:</label>
            <asp:TextBox ID="UCTBPassword" class="form-control" runat="server" MaxLength="20"></asp:TextBox>
        </div>
    </div>
</div>

<div class="panel panel-success">
    <div class="panel-heading">
        Datos Personales:
        <asp:Label ID="UCLbelLoginData" runat="server" Text=""></asp:Label>
    </div>
    <div class="panel-body">
        <div class="form-group">
            <label for="UCTBName"><span class="glyphicon glyphicon-user"></span>Nombre:</label>
            <asp:TextBox ID="UCTBName" runat="server" class="form-control" MaxLength="100"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="UCTBEmail"><span class="glyphicon glyphicon-envelope"></span>Email:</label>
            <asp:TextBox ID="UCTBEmail" runat="server" MaxLength="100" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="UCTextBoxPhone"><span class="glyphicon glyphicon-phone"></span>Telefono:</label>
            <asp:TextBox ID="UCTextBoxPhone" runat="server" MaxLength="20" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="UCTextBoxWebPage"><span class="glyphicon glyphicon-globe"></span>Pagina web:</label>
            <asp:TextBox ID="UCTextBoxWebPage" runat="server" MaxLength="240" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="UCTextBoxCompany">Empresa:</label>
            <asp:TextBox ID="UCTextBoxCompany" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="UCTextBoxAddress">Direccion:</label>
            <asp:TextBox ID="UCTextBoxAddress" runat="server" MaxLength="250" class="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>


        <div class="form-group">
            <label for="UCTextBoxCity">Ciudad:</label>
            <asp:TextBox ID="UCTextBoxCity" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
        </div>


        <div class="form-group">
            <label for="UCDropDownListCountry">Pais:</label>
            <asp:DropDownList ID="UCDropDownListCountry" runat="server" class="form-control" DataTextField="NAME" DataValueField="PK_ID"></asp:DropDownList>
        </div>

        <div class="form-group">
            <label for="UCTextBoxZip">Codigo Postal:</label>
            <asp:TextBox ID="UCTextBoxZip" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
        </div>
    </div>
</div>

<div class="panel panel-success">
    <div class="panel-heading">Datos de Administracion</div>
    <div class="panel-body">
        <div class="form-group">
            <label for="UCTextBoxAlert"><span class="glyphicon glyphicon-bell"></span>Alerta:</label>
            <asp:TextBox ID="UCTextBoxAlert" runat="server" MaxLength="200" class="form-control"></asp:TextBox>

        </div>

        <div class="form-group">
            <label for="DropDownListGratis">Es Gratis:</label>
            <asp:DropDownList ID="DropDownListGratis" runat="server" class="form-control">
                <asp:ListItem Value="1">Si</asp:ListItem>
                <asp:ListItem Value="o" Selected="True">No</asp:ListItem>
            </asp:DropDownList>
        </div>


        <%--0nada 1default 2primary 3success 4info 5warning 6danger--%>
        <div class="form-group">
            <label for="UCDropDownListColor">Color:</label>
            <asp:DropDownList ID="UCDropDownListColor" runat="server" class="form-control">
                <asp:ListItem Value="0">Nada</asp:ListItem>
                <asp:ListItem Value="1">default</asp:ListItem>
                <asp:ListItem Value="2">primary</asp:ListItem>
                <asp:ListItem Value="3">success</asp:ListItem>
                <asp:ListItem Value="4">info</asp:ListItem>
                <asp:ListItem Value="5">warning</asp:ListItem>
                <asp:ListItem Value="6">danger</asp:ListItem>
            </asp:DropDownList>

        </div>

        <div class="form-group">
            <label for="UCDropDownListUserState">Estado:</label>
            <asp:DropDownList ID="UCDropDownListUserState" runat="server" class="form-control">
                <asp:ListItem Value="1">Activo</asp:ListItem>
                <asp:ListItem Value="2">Inactivo</asp:ListItem>
            </asp:DropDownList>

        </div>

        <div class="form-group">
            <label for="DropDownListType">Tipo:</label>
            <asp:DropDownList ID="DropDownListType" runat="server" class="form-control">
                <asp:ListItem Value="2">Cliente</asp:ListItem>
                <asp:ListItem Value="3">Delegado</asp:ListItem>
                <asp:ListItem Value="1">Revendedor</asp:ListItem>
                <asp:ListItem Value="0">Administrador</asp:ListItem>
                <asp:ListItem Value="4">Mercadeo</asp:ListItem>
            </asp:DropDownList>

        </div>

        <div class="form-group">
            <label for="UCDropDownListTimeZone"><span class="glyphicon glyphicon-time"></span>Zona Horaria:</label>
            <asp:DropDownList ID="UCDropDownListTimeZone" runat="server" class="form-control" DataTextField="Name" DataValueField="ID"></asp:DropDownList>

        </div>

        <div class="form-group">
            <label for="UCTextBoxNotes">Notas Internas:</label>
            <asp:TextBox ID="UCTextBoxNotes" runat="server" TextMode="MultiLine" class="form-control"></asp:TextBox>
        </div>



    </div>
</div>





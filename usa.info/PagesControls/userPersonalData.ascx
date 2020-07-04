<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userPersonalData.ascx.cs" Inherits="usa.info.userPersonalData" %>




<div class="panel panel-success">
    <div class="panel-heading">
        <asp:Label ID="UCLbelLoginData" Font-Bold="True" runat="server">Datos de login: Por favor escriba los datos que usara para entrar al panel de control, en USUARIO escriba el nombre de su radio o de su TV</asp:Label></TD>
    </div>
    <div class="panel-body">
        <div class="form-group">

            <label for="fecha">Usuario:</label>

            <asp:TextBox ID="UCTBLogin" runat="server" class="form-control" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UCTBLogin"
                CssClass="field-validation-error" ErrorMessage="!!." Font-Bold="True" Font-Size="Medium" ForeColor="Red" />
        </div>


        <div class="form-group">
            <label for="fecha">Clave:</label>
            <asp:TextBox ID="UCTBPassword" TextMode="Password" class="form-control" runat="server" MaxLength="20"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="UCTBPassword"
                CssClass="field-validation-error" ErrorMessage="!!." Font-Bold="True" Font-Size="Medium" ForeColor="Red" />
        </div>

    </div>
</div>



<div class="panel panel-success">
    <div class="panel-heading">Datos Personales:</div>
    <div class="panel-body">

        <div class="form-group">
            <label for="fecha"><span class="glyphicon glyphicon-user"></span> Nombre:</label>
            <asp:TextBox ID="UCTBName" runat="server" class="form-control" MaxLength="100"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="UCTBName"
                CssClass="field-validation-error" ErrorMessage="!!." Font-Bold="True" Font-Size="Medium" ForeColor="Red" />
        </div>

        <div class="form-group">
            <label for="fecha"><span class="glyphicon glyphicon-envelope"></span> Email:</label>
            <asp:TextBox ID="UCTBEmail" runat="server" MaxLength="100" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="UCTBEmail"
                CssClass="field-validation-error" ErrorMessage="!!." Font-Bold="True" Font-Size="Medium" ForeColor="Red" />
        </div>

        <div class="form-group">
            <label for="fecha"><span class="glyphicon glyphicon-phone"></span> Whastapp - Importante para soporte !!! :</label>
            <asp:TextBox ID="UCTextBoxPhone" runat="server" MaxLength="20" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="fecha"><span class="glyphicon glyphicon-globe"></span> Pagina web:</label>
            <asp:TextBox ID="UCTextBoxWebPage" runat="server" MaxLength="240" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="fecha">Empresa:</label>
            <asp:TextBox ID="UCTextBoxCompany" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="fecha">Direccion:</label>
            <asp:TextBox ID="UCTextBoxAddress" runat="server" MaxLength="250" class="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="fecha">Ciudad:</label>
            <asp:TextBox ID="UCTextBoxCity" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="fecha">Pais:</label>
            <asp:DropDownList ID="UCDropDownListCountry" runat="server" class="form-control" DataTextField="NAME" DataValueField="PK_ID"></asp:DropDownList>
        </div>
    </div>
</div>





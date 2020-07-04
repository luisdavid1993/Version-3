<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userResellerData.ascx.cs" Inherits="streamingcpanel.PagesControls.userResellerData" %>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="500" border="0" class="onWTableBg4">
    <TR>
		<TD width="20%"></TD>
		<TD class="onWTableFiltrer">
			<asp:Label id="UCLbelLoginData" Font-Bold="True" runat="server">Login Data</asp:Label></TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel1" runat="server" Font-Bold="True">Login:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTBLogin" runat="server" MaxLength="20"></asp:TextBox>
			
			</TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel6" runat="server" Font-Bold="True">Password:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTBPassword" runat="server" MaxLength="10"></asp:TextBox>
			</TD>
	</TR>
	<TR>
		<TD width="20%"></TD>
		<TD class="onWTableFiltrer">
			<asp:Label id="UCLbel12" Font-Bold="True" runat="server">Personal Data</asp:Label>
            
        </TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel2" runat="server" Font-Bold="True">Name:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTBName" runat="server" Width="304px" MaxLength="100"></asp:TextBox>
			</TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel3" Font-Bold="True" runat="server">Email:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTBEmail" runat="server" MaxLength="100" Width="400px"></asp:TextBox>
			</TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel4" runat="server">Phone:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTextBoxPhone" runat="server" MaxLength="20" Width="224px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel10" runat="server">Web Page:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTextBoxWebPage" runat="server" MaxLength="240" Width="416px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel5" runat="server">Company:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTextBoxCompany" runat="server" MaxLength="50" Width="224px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel14" runat="server">Address:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTextBoxAddress" runat="server" MaxLength="250" Width="416px" TextMode="MultiLine"
				Height="48px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD width="20%">
			&nbsp;</TD>
		<TD>
			&nbsp;</TD>
	</TR>
	
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel15" runat="server">City:</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTextBoxCity" runat="server" MaxLength="50" Width="200px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel17" runat="server">Country:</asp:Label></TD>
		<TD>
			<asp:DropDownList id="UCDropDownListCountry" runat="server" Width="200px" DataTextField="NAME" DataValueField="PK_ID"></asp:DropDownList></TD>
	</TR>
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel16" runat="server"> Zip Code</asp:Label></TD>
		<TD>
			<asp:TextBox id="UCTextBoxZip" runat="server" MaxLength="50" Width="80px"></asp:TextBox></TD>
	</TR>
	
	<TR>
		<TD width="20%"></TD>
		<TD class="onWTableFiltrer">
			<asp:Label id="UCLbel13" Font-Bold="True" runat="server">Admin Data</asp:Label></TD>
	</TR>
	
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel18" runat="server" Font-Bold="True">State:</asp:Label></TD>
		<TD>
			<asp:DropDownList id="UCDropDownListUserState" runat="server" Width="120px">
				<asp:ListItem Value="1">Enabled</asp:ListItem>
				<asp:ListItem Value="2">Disable</asp:ListItem>
			</asp:DropDownList></TD>
	</TR>
	<TR>
		<TD width="20%">
			&nbsp;</TD>
		<TD>
			&nbsp;</TD>
	</TR>
	
	
    
    
	<TR>
		<TD width="20%">
			<asp:Label id="UCLbel7" Font-Bold="True" runat="server">Local Time:</asp:Label></TD>
		<TD>
			<asp:DropDownList id="UCDropDownListTimeZone" runat="server" Width="416px" DataTextField="Name" DataValueField="ID"></asp:DropDownList></TD>
	</TR>
	
	
</TABLE>
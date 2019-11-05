<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformacionJSON.aspx.cs" Inherits="RequerimientoFernelly.InformacionJSON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
</head>
<body>
     <nav class="navbar navbar-expand-sm navbar-dark bg-primary">
		<a class="navbar-brand" href="#">SENA</a>
		<button class="navbar-toggler d-lg-none" type="button" data-toggle="collapse" data-target="#collapsibleNavId" aria-controls="collapsibleNavId"
			aria-expanded="false" aria-label="Toggle navigation"></button>
		<div class="collapse navbar-collapse" id="collapsibleNavId">
			<ul class="navbar-nav mr-auto mt-2 mt-lg-0">
				<li class="nav-item active">
					<a class="nav-link" href="https://localhost:44376/Index.aspx">Principal <span class="sr-only">(current)</span></a>
				</li>
			</ul>
		</div>
	</nav>

    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row  mt-5">
                <div class="col  mt-5">
                    <div class="form-group">
                        <h1 class="text-center text-danger display-4">Cargar informacion JSON</h1>
                    </div>
                    <div class="form-group  w-50 m-auto">
                        <asp:DropDownList CssClass="form-control mb-4" ID="ddLista" runat="server"></asp:DropDownList>
                    </div>
                    <div class="form-group text-center">
                        <asp:Button CssClass="btn btn-info" ID="btnEnviar" runat="server" Text="Mostrar" OnClick="btnEnviar_Click" />
                    </div>
                    <div class="form-group">
                        <asp:GridView CssClass="m-auto" ID="gvDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div>
        </div>
    </form> 
    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <!-- Popper JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>
</html>

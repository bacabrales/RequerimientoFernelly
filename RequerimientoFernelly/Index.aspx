<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RequerimientoFernelly.Index" %>

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
            aria-expanded="false" aria-label="Toggle navigation">
        </button>
        <div class="collapse navbar-collapse" id="collapsibleNavId">
            <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="dropdownId" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Opciones</a>
                    <div class="dropdown-menu" aria-labelledby="dropdownId">
                        <a class="dropdown-item" href="https://localhost:44376/ArchivosXML.aspx">Cargar archivos XML</a>
                        <a class="dropdown-item" href="https://localhost:44376/InformacionBaseDatos.aspx">Cargar desde la base de datos</a>
                        <a class="dropdown-item" href="https://localhost:44376/CargarDirecto.aspx">Carga directa</a>
                        <a class="dropdown-item" href="https://localhost:44376/CrearJSON.aspx">Crear archivos JSON</a>
                        <a class="dropdown-item" href="https://localhost:44376/InformacionJSON.aspx">Cargar datos JSON</a>
                    </div>
                </li>
            </ul>
        </div>
    </nav>

    <div class="jumbotron jumbotron-fluid mt-5">
		<div class="container">
			<h1 class="display-3">Requerimiento WEB FORM</h1>
			<p class="lead">Trabajo a enviar</p>
			<hr class="my-2"/>
		</div>
	</div>

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <!-- Popper JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>
</html>

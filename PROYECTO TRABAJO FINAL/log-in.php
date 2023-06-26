<!DOCTYPE html>
<html lang="es">
<?php

require_once('conex/session.php');
include_once('encabezado.php'); 
include_once('pie.php');

// generar_breadcrumbs($camino_nav,0,"Inicio"); 
?>
<head>
	
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/estilos2.css">
    <link rel="stylesheet" href="css/bootstrap.css">
    
    <link rel="stylesheet" href="css/bootstrap-grid.css">
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
	<script src="js/jquery-3.4.1.js"></script>
    <script src="js/bootstrap.js"></script>
    
    <title>Aberturas Danisa</title>
  

	<script>
		// JS -- el form se chequea en el cliente
		function validar()
		{
			var dni, psw, expresion;
			
			errores=0;
			dni=document.getElementById("dni").value;
			psw=document.getElementById("psw").value;

			expresion = /\w+@\w+\.+[a-z]/; // para validar un email
				// validar datos 
				if (dni===""||psw==="") { 
					alert ('Todos los campos son obligatorios'); 
					return false;
				}
				else if (dni.length>11) { 
					alert ('El dni solo puede tener 8 dígitos como máximo');
					return false;
				}
				else if (isNaN(dni)) {
					alert ('Complete el dni solo con números');
					return false;
				}
		}
		
	</script>
	
</head>

<body>
	<?php echo crear_encabezado(); ?>

	<div class="container">
  <div class="row">
    <div class="col-3" style="background-color: #f5f5f5;">
     
    </div>
    <div class="col-6">
     
		<div class="global-container">
					<div class="card login-form" style="background-color: aliceblue; width: 20em; margin: 1.25rem">
					<div class="card-body">
						<h3 class="card-title text-center">Iniciar Sesión</h3>
						
							<form action="conex/iniciar_sesion.php" method="post" onsubmit="return validar();">
						
								<div class="form-group"  >
									<label for="">Ingrese su DNI</label>
									<input type="text" class="form-control form-control-sm" id="dni" name="dni" required >
								</div>
								<div class="form-group">
									<label for="exampleInputPassword1">Password</label>
									<a href="#" style="float:right;font-size:12px;"></a>
									<input type="password" class="form-control form-control-sm" id="psw" name="psw" required>
								</div>
								<button type="submit" class="btn btn-primary btn-block" name="iniciar" value="Iniciar Sección" style="margin-top:30px;">Ingrese</button>
								
								<div class="sign-up">
									<a href="#"></a>
								</div>
							</form>
						
					</div>
				</div>
				</div>



    </div>
    <div class="col-3" style="background-color: #f5f5f5;">
     
    </div>
  </div>
</div>
<br>
	
	<footer>
		<?php echo pie(); ?>
	</footer>

	
</body>
</html>
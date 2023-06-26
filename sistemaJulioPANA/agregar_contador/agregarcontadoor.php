<!DOCTYPE html>
<html>
<head>
	<title>Form Data</title>
</head>
<body>
	<?php
		// Check if form data has been submitted
		if ($_SERVER['REQUEST_METHOD'] == 'POST') {
			// Retrieve form data
			
			if(isset($_POST['nombre'])) {
				$nombre = $_POST['nombre'];
			}
			
			if(isset($_POST['apellido'])) {
				$apellido = $_POST['apellido'];
			}
			
			if(isset($_POST['matricula'])) {
				$matricula = $_POST['matricula'];
			}
			
			if(isset($_POST['estudio'])) {
				$estudio = $_POST['estudio'];
			}
			
			if(isset($_POST['localidad'])) {
				$localidad = $_POST['localidad'];
			}
			
			if(isset($_POST['domicilio'])) {
				$domicilio = $_POST['domicilio'];
			}
			
			if(isset($_POST['telefono'])) {
				$telefono = $_POST['telefono'];
			}
			
			if(isset($_POST['celular'])) {
				$celular = $_POST['celular'];
			}
			
			if(isset($_POST['email'])) {
				$email = $_POST['email'];
			}
			
			if(isset($_POST['password'])) {
				$password = $_POST['password'];
			}
			
			if(isset($_POST['profesion'])) {
				$profesion = $_POST['profesion'];
			}
			

			// Display form data
			echo "<h2>Form Data:</h2>";
			echo "<p><strong>Nombre:</strong> $nombre</p>";
			echo "<p><strong>Apellido:</strong> $apellido</p>";
			echo "<p><strong>Matricula:</strong> $matricula</p>";
			echo "<p><strong>Estudio:</strong> $estudio</p>";
			echo "<p><strong>Localidad:</strong> $localidad</p>";
			echo "<p><strong>Domicilio:</strong> $domicilio</p>";
			echo "<p><strong>Telefono:</strong> $telefono</p>";
			echo "<p><strong>Celular:</strong> $celular</p>";
			echo "<p><strong>E-mail:</strong> $email</p>";
			echo "<p><strong>Password:</strong> $password</p>";
			echo "<p><strong>Profesion:</strong> $profesion</p>";
		}
	?>
</body>
</html>

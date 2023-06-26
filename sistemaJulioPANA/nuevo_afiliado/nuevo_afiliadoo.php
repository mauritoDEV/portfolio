<?php
// chequear validacion de datos
if ($_SERVER["REQUEST_METHOD"] == "POST") 
{
	// retrieve form data
	if(isset($_POST["apellido"])):
		$apellido = $_POST["apellido"];
	
	if(isset($_POST["nombre"])):
		$nombre = $_POST["nombre"];
	
	if(isset($_POST["tipo_documento"])):
		$tipo_documento = $_POST["tipo_documento"];
	
	if(isset($_POST["dni"])):
		$dni = $_POST["dni"];
	
	if(isset($_POST["cuil"])):
		$cuil = $_POST["cuil"];
	
	if(isset($_POST["fecha_nacimiento"])):
		$fecha_nacimiento = $_POST["fecha_nacimiento"];
	
	if(isset($_POST["hora_entrada_manana"])):
		$hora_entrada_manana = $_POST["hora_entrada_manana"];
	
	if(isset($_POST["hora_salida_manana"])):
		$hora_salida_manana = $_POST["hora_salida_manana"];
	
	if(isset($_POST["hora_entrada_tarde"])):
		$hora_entrada_tarde = $_POST["hora_entrada_tarde"];
	
	if(isset($_POST["hora_salida_tarde"])):
		$hora_salida_tarde = $_POST["hora_salida_tarde"];
	
	if(isset($_POST["nacionalidad"])):
		$nacionalidad = $_POST["nacionalidad"];
	
	if(isset($_POST["provincia_trabajo"])):
		$provincia_trabajo = $_POST["provincia_trabajo"];
	
	if(isset($_POST["delegacion"])):
		$delegacion = $_POST["delegacion"];
	
	if(isset($_POST["localidad"])):
		$localidad = $_POST["localidad"];
	
	if(isset($_POST["direccion"])):
		$direccion = $_POST["direccion"];
	
	if(isset($_POST["telefono"])):
		$telefono = $_POST["telefono"];
	
	if(isset($_POST["cargo"])):
		$cargo = $_POST["cargo"];
	
	if(isset($_POST["fecha_alta_afip"])):
		$fecha_alta_afip = $_POST["fecha_alta_afip"];
	
	if(isset($_POST["fecha_ingreso"])):
		$fecha_ingreso = $_POST["fecha_ingreso"];
	
	if(isset($_POST["email"])):
		$email = $_POST["email"];
	
	if(isset($_POST["horas_trabajadas"])):
		$horas_trabajadas = $_POST["horas_trabajadas"];
	
	if(isset($_POST["remuneracion"])):
		$remuneracion = $_POST["remuneracion"];
	
	if(isset($_POST["sexo"])):
		$sexo = $_POST["sexo"];
	
	// display form data
	echo "<h1>Employee Information</h1>";
	echo "<p>Apellido: $apellido</p>";
	echo "<p>Nombre: $nombre</p>";
	echo "<p>Tipo de documento: $tipo_documento</p>";
	echo "<p>DNI: $dni</p>";
	echo "<p>CUIL: $cuil</p>";
	echo "<p>Fecha de Nacimiento: $fecha_nacimiento</p>";
	echo "<p>Hora de entrada a la mañana: $hora_entrada_manana</p>";
	echo "<p>Hora de salida a la mañana: $hora_salida_manana</p>";
	echo "<p>Hora de entrada a la tarde: $hora_entrada_tarde</p>";
	echo "<p>Hora de salida a la tarde: $hora_salida_tarde</p>";
	echo "<p>Nacionalidad: $nacionalidad</p>";
	echo "<p>Provincia en que trabaja: $provincia_trabajo</p>";
	echo "<p>Delegación: $delegacion</p>";
	echo "<p>Localidad: $localidad</p>";
	echo "<p>Dirección: $direccion</p>";
	echo "<p>Teléfono: $telefono</p>";
	echo "<p>Cargo: $cargo</p>";
	echo "<p>Fecha de alta (AFIP): $fecha_alta_afip</p>";
	echo "<p>Fecha de ingreso: $fecha_ingreso</p>";
	echo "<p>E-mail: $email</p>";
	echo "<p>Cantidad de horas trabajadas: $horas_trabajadas</p>";
	echo "<p>Remuneración: $remuneracion</p>";
	echo "<p>Sexo: $sexo</p>";
}

?>

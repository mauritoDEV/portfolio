<!DOCTYPE html>
<html lang="es">
<?php

# con esto evitamos que el navegador lo grabe en su caché
header("Pragma: no-cache");
header("Expires: 0");

# indica al navegador que muestre el diálogo de descarga aún sin haber descargado todo el contenido
header("Content-type: application/octet-stream");
# indica al navegador que se está devolviendo un archivo
header("Content-Disposition: attachment; filename=listado_presupuesto_con_filtros.xls");
header("Content-type: application/vnd.ms-excel");  


require 'conex/session.php';
require 'conex/conexion.php';  #crea la conexión a la BD

#echo $cliente;
	$cliente = (isset($_POST["cliente"]) && !empty($_POST["cliente"]))? $_POST["cliente"]:0;
	$fec_ingr = (isset($_POST["fec_ingr"]) && !empty($_POST["fec_ingr"]))? trim($_POST["fec_ingr"]):null; 
	$orden = (isset($_POST["orden"]) && !empty($_POST["orden"]))? $_POST["orden"]:0;
			// 1 - Apellido --  2 - Legajo
	
		
		
		
	$filtro="";
	$orden_sql="";
	$col="10";	
			
	# valido - cargo sea entero 
	#		 - orden sea entero
			 
	# filtro por una fecha ($fec_ingr)  
	

	

	#armar filtro para la consulta
	$titfilt = "Listado de Presupuestos "; 
	$titfiltro = "";
	$filtro="";	
		
	if ($cliente <> "" ){
		$titfiltro .= " Cliente: $cliente ";  
		$filtro .= " presupuestos.cliente= '$cliente' " ;
	}

	if ($fec_ingr <> "") {
		$titfiltro .= " - Ingresados desde el: ".date("d/m/Y",strtotime($fec_ingr))." en adelante.";
		
		if ($filtro!=="")  $filtro .= " 	AND " ;
		$filtro .= " 	presupuestos.fecharealizado >='$fec_ingr' ";
	}
	
	if ($orden==1) 
		$orden_sql .= "presupuestos.cliente, presupuestos.idpresupuestos";
		
	if ($orden==2) 
		$orden_sql .= "presupuestos.cliente, precio";

	if ($orden_sql=="") $orden_sql = "presupuestos.cliente, presupuestos.idpresupuestos";	
	
	
	if (trim($filtro)=="")  {
		$filtro = " 0=0 ";  
	}
	

	$sql ="	SELECT presupuestos.idpresupuestos,presupuestos.cliente, presupuestos.fecharealizado,
				    aberturas.alto, aberturas.ancho,
				    perfiles.tipo, perfiles.descripcion,
		        	IF (aberturas.accesorios=1,'SI','NO') as accesorios,
		        	vidrios.tipo as vidrio_tipo,
		        	(aberturas.kgtotal*aberturas.preciokg) as precio
			FROM presupuestos
			JOIN aberturas on presupuestos.idpresupuestos=aberturas.idpresupuestos
			LEFT JOIN perfiles on aberturas.idperfiles=perfiles.idperfiles
			LEFT JOIN vidrios on aberturas.idvidrios=vidrios.idvidrios
			WHERE $filtro
			ORDER BY $orden_sql";

	$rs = $db->query($sql);

	if (!$rs ) { 
		print_r($db->errorInfo()); # mensaje en desarrollo

		echo "<tr><td colspan='<?=$col?>'><br>&nbsp;&nbsp; - No se encuentran datos para el filtro ingresado.</td></tr>";
		exit;
	}
	
?>

<head>
	<meta http-equiv="Content-Type" content="text/html;charset=utf-8">
	<title>Sitio Trabajo Final</title>
</head>
 
<body>

		<table> 
			<caption><strong><?=$titfilt?><strong> </caption>
			<tr>
				<th>Cliente</th>
				<th>Presupuesto</th>
				<th>Fecha</th>
				<th>Tipo</th>
				<th>Descripción</th>
				<th>Alto</th>
				<th>Ancho</th>
				<th>Accesorios</th>
				<th>Vidrios</th>
				<th>Precio</th>
			</tr>
<?php 		
		$cargo = 0;
	
		if ($rs ) {      
			 
			foreach ($rs as $reg) {  
?>
				<tr class="constxt1">
					<td><?=utf8_encode($reg['cliente'])?></td>
					<td><?=$reg['idpresupuestos']?></td>
					<td><?=date("d-m-Y",strtotime($reg['fecharealizado']))?></td>
					<td><?=$reg['alto']?></td>
					<td><?=$reg['ancho']?></td>
					<td><?=utf8_encode($reg['tipo'])?></td>
					<td><?=utf8_encode($reg['descripcion'])?></td>
					<td><?=utf8_encode($reg['accesorios'])?></td>
					<td><?=utf8_encode($reg['vidrio_tipo'])?></td>
					<td><?=$reg['precio']?></td>
				</tr>
<?php
			}
		}
?>	
		</table>
		
<?php	
	$rs=null;
    $db=null;
?>
</body>
</html>
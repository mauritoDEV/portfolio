<!DOCTYPE html>
<html lang="es">
<?php
# con esto evitamos que el navegador lo grabe en su caché
header("Pragma: no-cache");
header("Expires: 0");

# indica al navegador que muestre el diálogo de descarga aún sin haber descargado todo el contenido
header("Content-type: application/octet-stream");
# indica al navegador que se está devolviendo un archivo
header("Content-Disposition: attachment; filename=listado_sin_filtro.xls");
header("Content-type: application/vnd.ms-excel");  



require 'conex/conexion.php';  #crea la conexión a la BD

			
		
	$filtro="";
	$orden_sql="";
	$col="10";	


	if (trim($filtro)=="")  {
		$filtro = " 0=0 ";  
	}
	if ($orden_sql=="") $orden_sql = "presupuestos.cliente, presupuestos.idpresupuestos";


	$sql = "SELECT presupuestos.idpresupuestos,presupuestos.cliente, presupuestos.fecharealizado,
				    aberturas.alto, aberturas.ancho,
				    perfiles.tipo, perfiles.descripcion,
		        	IF (aberturas.accesorios=1,'SI','NO') as accesorios,
		        	vidrios.tipo as vidrio_tipo,
		        	(aberturas.kgtotal*aberturas.preciokg) as precio
			FROM presupuestos
			JOIN aberturas on presupuestos.idpresupuestos=aberturas.idpresupuestos
			LEFT JOIN perfiles on aberturas.idperfiles=perfiles.idperfiles
			LEFT JOIN vidrios on aberturas.idvidrios=vidrios.idvidrios
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
			<caption><strong>Listado de Presupuestos<strong></caption>
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
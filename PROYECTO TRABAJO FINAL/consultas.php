<!DOCTYPE html>
<html lang="es">
<?php

require_once('conex/conexion.php');
include_once('encabezado.php'); 
include_once('pie.php');

require_once ('conex/session.php');


	$user = (isset($_SESSION["user"]) && !empty($_SESSION["user"]))? trim($_SESSION["user"]):""; 
	$perfil = (isset($_SESSION["perfil"]) && !empty($_SESSION["perfil"]))? trim($_SESSION["perfil"]):""; 

	if ($user=="") {
		
		# echo "sin seccion";
		# usuario invalido - si existe alguna session la destruye
		
		unset($_SESSION["user"]);
		$_SESSION = array();
		session_destroy();
		# echo "y lo envio al inicio del sitio";
		header('location:index.php');
	} 

	$filtro="";
	$orden_sql="";
	$col="10";	


	#armar filtro para la consulta
	$filtro="";
	
	/* Ejemplos de Filtros */
	/*
		$filtro .= " cargo.cargo_id=$cargo " ;
		
		if ($filtro!=="")  $filtro .= " 	AND " ;
		$filtro .= " 	fechaingreso >='$fec_ingr' ";

	*/

	$orden_sql = "";
	/* Orden  	*/	
	/*
		$orden_sql .= "cargo.cargo_desc, apellido";
		$orden_sql .= "cargo.cargo_desc, legajo ";
	*/
	
	
	
	if (trim($filtro)=="")  {
		$filtro = " 0=0 ";  
	}
	if ($orden_sql=="") $orden_sql = "cargo.cargo_desc, dni ";


	$sql = "SELECT presupuestos.idpresupuestos,presupuestos.cliente, presupuestos.fecharealizado,
				    aberturas.alto, aberturas.ancho,
				    perfiles.tipo, perfiles.descripcion,
		        	aberturas.accesorios,
		        	vidrios.tipo as vidrio_tipo,
		        	(aberturas.kgtotal*aberturas.preciokg) as precio
			FROM presupuestos
			JOIN aberturas on presupuestos.idpresupuestos=aberturas.idpresupuestos
			LEFT JOIN perfiles on aberturas.idperfiles=perfiles.idperfiles
			LEFT JOIN vidrios on aberturas.idvidrios=vidrios.idvidrios
			order by presupuestos.cliente";

	$rs = $db->query($sql);

	if (!$rs ) { 
		print_r($db->errorInfo()); # mensaje en desarrollo

		echo "<tr><td colspan='<?=$col?>'><br>&nbsp;&nbsp; - No se encuentran datos para el filtro ingresado.</td></tr>";
		exit;
	}
	
?>
<head>
	<!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">
	<link rel="stylesheet" href="css/estilos2.css">
    
    <link rel="stylesheet" href="css/bootstrap-grid.css">
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
	<script src="js/jquery-3.4.1.js"></script>
    <script src="js/bootstrap.js"></script>
    
    <title>Aberturas Danisa</title>

	<script type="text/javascript">
	
		function excel() {
						
			window.location = "a_excel.php";
		}

	</script>	
</head>
 
<body>

	<header>
		<?php echo crear_encabezado(); ?>
	<div  class="container"><h3>Consultas</h3>		</div>	
	</header>
	<div class="container" id="encabprint"> 
			<h3>Aberturas Danisa</h3>
			
			<span style="font-size:0.7em;"> Fecha de Impresión <?=date("d/m/Y H:i")?>hs. </span>
	</div>

	<div class="container">
	
	<main id="cuerpo">
		
		<div style="text-align:right;" id="imprimir_pdf">
			<a href="javascript:window.print();" title="Imprimir listado.">
				<img src='imagenes/print.png' title="Imprimir listado." alt="icono imprimir." style="border:0;width:32px;height:32px;"></a>
				&nbsp;&nbsp;
				<a href="javascript:excel()" title='Excel del listado.'>
				<img src='imagenes/excel.png' title='Excel del listado.' alt="icono Excel." style="border:0;width:28px;height:28px;"> </a>
			<!--<a href="javascript:excel()" title='Excel del listado.'>
				<img src='imagenes/excel.png' title='Excel del listado.' alt="icono Excel." style="border:0;width:28px;height:28px;"> 
			</a> -->
		</div>
			
		<br class="clear">
		
		<h2>Listado de Presupuestos </h2>

		<table width="90%" class="table table-sm"> 
			<thead class="table-info">
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
			</thead>
<?php 		
			$cliente = "";
			$sino="";
			$idpresupuestos=0;
			$fecharealizado=0;
			$sum_mismo_cliente=$total=0;
			$precio=0;
			$col="10";
			$subtotal=0;
		
			if ($rs ) 
			{      
				 
				foreach ($rs as $reg) {  
				
					if (($cliente <> $reg['cliente'])) {   
						 
						$subtotal="";
						if ($precio<>0)  {
							$subtotal="<td colspan=$col class='table-secondary text-right'> Importe total presupuestado:$ ".number_format($sum_mismo_cliente,2,',','')."</td> ";
						}
			?>
						<tr><?=$subtotal?></tr>
						<tr>
							<td colspan=<?=$col?>><b> <?php echo $reg['cliente']?> </b></td>
						</tr>
			<?php  
						$cliente = $reg['cliente'];
						$idpresupuestos=$reg['idpresupuestos'];
						#$fecharealizado=$reg['fecharealizado']; 
						$precio=0;
						$sum_mismo_cliente=0;
				}
					
					$cliente = $reg['cliente'];
					$idpresupuestos=$reg['idpresupuestos'];


					$enlace_accesorios="NO";

					if (!$reg['accesorios']=="") {
						$enlace_accesorios = $reg['accesorios'];

					}
					 
?>
						
						<tr>
							<td>&nbsp;</td>
							<td> Nro 000<?=$idpresupuestos?> </td>
							<td><?=date("d-m-Y",strtotime($reg['fecharealizado']))?></td>
							<td><?=$reg['tipo']?></td>
							<td><?=$reg['descripcion']?></td>
							<td><?=$reg['alto']?></td>
							<td><?=$reg['ancho']?></td>
							<td><?=$enlace_accesorios?></td>
							<td><?=$reg['vidrio_tipo']?></td>
							<td>$ <?=number_format($reg['precio'],2,',','')?></td>
						</tr>
<?php
					$precio=$precio+$reg['precio'];
					$total=$total+$reg['precio'];
					$sum_mismo_cliente=$precio;
				
				}
				if ($precio<>0) {
					$subtotal="<tr><td colspan=$col class='table-secondary text-right'> Importe total presupuestado:$ ".number_format($precio,2,',','')."</td></tr> ";
				}
				
				if ($total<>0) {
					$subtotal.="<tr><td colspan=$col class='table-dark'> Importe total de los presupuestos:$ ".number_format($total,2,',','')."</td></tr> ";
				} else {
					$subtotal.="<tr><td colspan=$col class='table-warning'> No se encuentran datos para el filtro ingresado</td></tr> ";
				}
				
				echo $subtotal;
			}	
			
?>	
		</table>
		<br>
		
	</main>

	
	</div>
	<footer id="pie">
		<?=pie()?>
	</footer>
</body>
</html>
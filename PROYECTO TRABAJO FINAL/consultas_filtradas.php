<!DOCTYPE html>
<html lang="es">
<?php


require_once('conex/session.php');
require_once ('conex/conexion.php');

#session_start();

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

if (!perfil_valido(3)) {
	# echo "si tiene inicio de sesion pero";
	# echo "no cumple con el nivel de usuario requerido";
	# echo "lo envio a la consulta general (sin filtros);
	# echo "
	header("location:consultas.php");
}

include("encabezado.php"); 
include("pie.php"); 


#print_r($_POST);

	$cliente = (isset($_POST["cliente"]) && !empty($_POST["cliente"]))? $_POST["cliente"]:0;

#echo $cliente;
	#$idpresupuestos = (isset($_POST["cliente"]) && !empty($_POST["cliente"]))? $_POST["cliente"]:0;
	$fec_ingr = (isset($_POST["fec_ingr"]) && !empty($_POST["fec_ingr"]))? trim($_POST["fec_ingr"]):null; 
	$orden = (isset($_POST["orden"]) && !empty($_POST["orden"]))? $_POST["orden"]:0;
			// 1 - Apellido --  2 - Legajo
	
	
	
		# busca los cargos disponibles y se presentan en una lista
		function lista_clientes(&$lista_c,&$ordenarxcliente) {	
		global $db, $ordenarxcliente, $cliente;
		
			$lista_c =  " <select id='cliente' name='cliente' style='width:17%;' >". 
						"	<option value=0 selected>&laquo;Todos&raquo;</option>";
				
			$sql  = " SELECT * FROM presupuestos GROUP BY cliente";
			$rs = $db->query($sql);
			if (!$rs) {
				// mensaje error 
			} else {
				$ordenarxcliente = "";
				#$cliente = "";
				foreach ($rs as $r) {
					$seleccionado = "";

#echo " <br> $cliente --> {$r['cliente']}";
					if ($cliente === $r['cliente']) {
#	echo " <br> $cliente = {$r['cliente']}";					
						$ordenarxcliente = $r['cliente'];
						$seleccionado = "selected";
					}
					$lista_c .= "<option value='{$r['cliente']}' $seleccionado>". utf8_encode($r['cliente'])."</option>";
				}
			}
			$lista_c .= "</select>";
			$rs=null;
		}
	
	$orden_sql="";
	$col="10";	
			
	lista_clientes ($lista_c,$ordenarxcliente);  #lista de cargos

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

	if ($orden_sql=="") $orden_sql = "presupuestos.cliente ";	
#echo " <br> $fec_ingr <--> $filtro";

	if (trim($filtro)=="")  {
		$filtro = " 0=0 ";  
	}
	
	$sql = "SELECT presupuestos.idpresupuestos,presupuestos.cliente, presupuestos.fecharealizado,
				    aberturas.alto, aberturas.ancho,
				    perfiles.tipo, perfiles.descripcion,
		        	aberturas.accesorios,
		        	vidrios.tipo as vidrio_tipo,
		        	presupuestos.preciototal as precio
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
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width,initial-scale=1"> 
	
	<title>Sitio Trabajo Final</title>
	
		
	<link rel="stylesheet" href="css/bootstrap.min.css">
	<link rel="stylesheet" href="css/estilos2.css">
	
	<!-- jQuery first, then Popper.js (incluido en .blunde.min.js), then Bootstrap JS -->
	<script src="js/jquery-3.4.1.min.js"></script>
	<script src="js/bootstrap.bundle.min.js" ></script>
	

	<script type="text/javascript">
	
		function listado() {
		var errores=0;
		
			// valida datos ingresados en el formulario
			// si datos ok -- return true  sino return false
			if (errores==0) {
				document.getElementById("datos").method = "post";
				document.getElementById("datos").action = "consultas_filtradas.php";
				document.getElementById("datos").submit(); 
				
				return true;
			} else {
				return false;
			}
		}

		function excel() {
			// validar datos .....
			
			document.getElementById("datos").method = "post";
			document.getElementById("datos").action = "a_excel_filtrado.php";
			document.getElementById("datos").submit(); 
		}


	function exportar_excel(tableID, filename = ''){
    var downloadLink;
    var dataType = 'application/vnd.ms-excel';
    var tableSelect = document.getElementById(tableID);
    var tableHTML = tableSelect.outerHTML.replace(/ /g, '%20');
    
    // especifico el nombre del archivo
    filename = filename?filename+'.xls':'listado_presupuestos.xls';
    
    // Creo el link de descarga del elemento
    downloadLink = document.createElement("a");
    
    document.body.appendChild(downloadLink);
    
    // utilizo el metodo mssaveroropenblob
    if(navigator.msSaveOrOpenBlob){
        var blob = new Blob(['ufeff', tableHTML], {
            type: dataType
        });
        navigator.msSaveOrOpenBlob( blob, filename);
    }else{
        // Creo el link del archivo
        downloadLink.href = 'data:' + dataType + ', ' + tableHTML;
    
        downloadLink.download = filename;
        
        //disparo la funcion
        downloadLink.click();
    }
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
			
		</div>
		
		<div class="card" id="opc_filtro">
					<h5 class="card-header" style="border-bottom:0px;">Opciones de filtrado</h5>			
		  
		  <div class="card-body">
		    
		    <form  name="datos" id="datos" method="post" action="consultas_filtradas.php" onsubmit="return listado();" style="margin-top: 5px;"> 
			<fieldset style="text-align: center;"> 
				
					 Por cliente:  &nbsp; <?=$lista_c?> &nbsp; - &nbsp;
				
				<label for="fec_ingr">Desde: </label> &nbsp; 
				<input type="date" name="fec_ingr" title="Fecha de ingreso">

				&nbsp; - &nbsp;<span>Ordenados por: </span> &nbsp; 
				<input type="radio" name="orden" id="orden1" value="1" <?php if ($orden==1) {?> checked="checked" <?php }?>> 
				<label for="orden1">Nro. de Presupuesto</label>
				<input type="radio" name="orden" id="orden2" value="2" <?php if ($orden==2) {?> checked="checked" <?php }?>> 
				<label for="orden2">Precio</label>
				 &nbsp; - &nbsp;
				<input type="submit" id="Mostrar" name="Mostrar" value="Mostrar Listado" class="btn btn-primary active">
			</fieldset>	
			</form>
		    <!--<a href="#" class="btn btn-primary"></a>-->
		  </div>
		</div>
				
		
		<br class="clear">
		
		<h2 class="constit"><?=$titfilt?></h2>
		<p class="constit1"><?=$titfiltro?></p>

		<table id="tblData" width="90%" class="table table-sm"> 
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
						$enlace_accesorios = "<a href='' >".$reg['accesorios']."</a>";

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
		
	</main>
</div>
	<footer id="pie">
		<?=pie()?>
	</footer>
	
	
</body>
</html>
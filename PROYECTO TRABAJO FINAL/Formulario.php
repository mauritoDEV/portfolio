<!DOCTYPE html>
<html lang="es">

<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"> 
	
	<title>ProyectoX danisa aberturas</title>	

	
	<link rel="stylesheet" href="css/bootstrap.css">
	<link rel="stylesheet" href="css/estilos2.css">
	
	<!-- jQuery first, then Popper.js (incluido en .blunde.min.js), then Bootstrap JS -->
	<script src="js/jquery-3.4.1.min.js"></script>
	<script src="js/bootstrap.bundle.min.js" ></script>
	
</head>

<?php
//session_start();


require_once('conex/conexion.php');
include_once('encabezado.php'); 
include_once('pie.php');

require_once ('conex/session.php');



echo crear_encabezado();

	$descripcion="";
	$prec_kg_mt2=0;
	
	$prestacion=isset($_POST['prestacion'])? $_POST['prestacion']:0;	
	
	echo "Prestacion ".$prestacion."<br>";

	$mec_silovatiente=isset($_POST['mec_silovatiente'])? $_POST['mec_silovatiente']:0;
	
	$ancho=isset($_POST['ancho'])&& !empty($_POST['ancho'])? $_POST['ancho']:0;
	
	
	$alto=isset($_POST["alto"])&& !empty($_POST["alto"])? $_POST["alto"]:0;
	
	$ancho1=($ancho/1000);
	$alto1=($alto/1000);

	$mts2= ($alto/1000)*($ancho/1000);
	//$mts2=isset($_POST["mts2"])&& !empty($_POST["mts2"])? $_POST["mts2"]:0; ARREGLADO!!!
	

	echo "Ancho: ". $ancho."<br>";
	echo "Alto:". $alto."<br>";
	echo "mts2: ". $mts2."<br>"; //ARREGLADO
	
	$precio_kg_mt_lineal=isset($_POST["precio_kg_mt_lineal"])&& !empty($_POST["precio_kg_mt_lineal"])? $_POST["precio_kg_mt_lineal"]:0;

	$fecha_factura=isset($_POST["fecha_factura"])&& !empty($_POST["fecha_factura"])? $_POST["fecha_factura"]:0;
	
	$vidrio=isset($_POST["tipo_vidrio"])? $_POST["tipo_vidrio"]:0;	
	
	$color_aluminio= isset($_POST["color_aluminio"])? $_POST["color_aluminio"]:0;
	
	$check_contramarco=isset($_POST["check_contramarco"])? $_POST["check_contramarco"]:0;
	
	$check_compacto=isset($_POST["check_compacto"])? $_POST["check_compacto"]:0;
	
	$check_premarco=isset($_POST["check_premarco"])? $_POST["check_premarco"]:0;

	$check_colocacion=isset($_POST["check_colocacion"])? $_POST["check_colocacion"]:0;	
	
	
	
	$check_con_cajon=isset($_POST["check_con_cajon"])? $_POST["check_con_cajon"]:0;
	
	//no es necesario , se autogenera con una consulta a la BD $id_presupuesto=isset($_POST["id_presupuesto"])? $_POST["id_presupuesto"]:0;
	
	
	$nombre_cli=isset($_POST["nom_cli"])?$_POST["nom_cli"]:"de paso";
	
	$prec_cajon=isset($_POST["prec_cajon"])? $_POST["prec_cajon"]:0;

	$prec_silovatiente=isset($_POST["prec_silovatiente"])? $_POST["prec_silovatiente"]:0;

	$porc_ganancia=isset($_POST["porc_ganancia"])? $_POST["porc_ganancia"]:1;

	/////////////////////////////////////////////////////////////
	
	
	$tipo_abertura=isset($_POST["nom_abertura"])&& !empty($_POST["nom_abertura"])? $_POST["nom_abertura"]:0;
	
	
		
	/////////////////////////////////////////////////////////
	echo" precio del mt lineal del alum". $precio_kg_mt_lineal;
  		if ($tipo_abertura=="puerta_rebatir"){
  			$descripcion_abertura="puerta";
  			$tipo_abertura="rebatir";
  		}else{
  			$descripcion_abertura="ventana";
  		}/////////diooo!!!
	$descripcion="Accesorios: ";
$filtro= "p.linea= '".$prestacion."' and p.tipo= '". $descripcion_abertura."' and p.descripcion= '". $tipo_abertura."'";

//echo $filtro;  /////////// esto sirve para depurar
$conecccion="";
$kg_accesorio="select p.kg 	
				from perfiles as p
				where ". $filtro;

//echo "<br> vidrio : ".$vidrio;
	//echo $kg_accesorio;
//echo $kg_accesorio; //////// sirve pare depurar
$rs=$db->query($kg_accesorio);
$contador_kg_accesorio=0;
if (!$rs ) { 
		
		print_r($db->errorInfo( "oseeeaaaaa, por que no funciona")); # mensaje en desarrollo

		echo "<tr><td colspan='<?=$col?>'><br>&nbsp;&nbsp; - No se encuentran datos para el filtro ingresado.</td></tr>";
		exit;
	}

if ($rs) {
	$kg_accesorio=0;
	
	//////////////////////// FOR EACH ////////////// PESO DE LA ABERTURA

	 	 foreach ($rs as $reg){
		
					$prec_kg_mt2=($reg['kg'])*$mts2;
					
					echo "<br>";
					echo "<br> precio por kg metro cuadrado:  ".$prec_kg_mt2."<br>";
				
			}//end foreach///////////// END FOR Eaach
			
					//////compacto//////////////////////
	   

					if ($check_compacto){
						$descripcion.="compacto  ";
							//echo"!!!!!!!!!!!!!compact";
	   					$consulta_acc=$db->query("select accesorios.kgaccesorios
							            from accesorios
							            where accesorios.descripcion='compacto' ");

	   					if($consulta_acc){							
							//echo"!!!!!!!!!!!!!compact222";
								
								foreach ($consulta_acc as $regi1)	{	
									//echo"!!!!!!!!!!!!!contra33";
				 					$contador_kg_accesorio=$contador_kg_accesorio +($regi1['kgaccesorios']);
								
								}

						}
					
					}///	/////////////////////////////// FIN COMPACTO
	
					/////////////// PREMARCO	

					if ($check_premarco ){
						$descripcion.="premarco  ";
						//echo"!!!!!!!!!!!!!´premarc";
								$consulta_acc=$db->query("select kgaccesorios from accesorios	where accesorios.descripcion= 'premarco' ");
								if ($consulta_acc){							//////////////////////for each????? SEE CREO Q SEEE
									//echo"!!!!!!!!!!!!!´premarc222";
									foreach ($consulta_acc as $regi2)	{	
									//echo"!!!!!!!!!!!!!cPREMARC33";
				 					$contador_kg_accesorio=$contador_kg_accesorio +($regi2['kgaccesorios']);
				 					}
										
								
								}
					}////////////////////// fin premarco

						
	  		
			//////////////////CONTRAMARCO/////////////////////
			 	 	
	  				if ($check_contramarco){
			 	 			//echo"!!!!!!!!!!!!!contramarc";
			 	 			$descripcion.="contramarco   ";
							//////////////////////for each????? SEE CREO Q SEEE
							
	  	  				 	$consulta_acc=$db->query("select kgaccesorios FROM accesorios as A where A.descripcion= 'contramarco'");
	  	  				 	
				 			if( $consulta_acc) {
									//echo"!!!!!!!!!!!!!contramarcc22";
				 					foreach ($consulta_acc as $regi3)	{	
										//	echo"!!!!!!!!!!!!!contra33";

				 					$contador_kg_accesorio=$contador_kg_accesorio +($regi3['kgaccesorios']);
									
 									} /////////endforeach


 							 							//echo"!!!!!!!!!!!!!contra44";
 							
 					}
 					}////////////////////////// fin consult CONTRAMARCO///////////////

	
				///////////busco el ultimo idpresupuestos para generar un ultimo nuevo codigo al anterior
				$id_presupuestos=0;
				$seleccion="";
				$seleccion= "SELECT MAX(idpresupuestos)as maxi FROM presupuestos";
				$buscaID=$db->query ($seleccion);
				if ($buscaID) {
				# code...
						foreach ($buscaID as $k) {

						# code...
						$id_presupuestos=$id_presupuestos+ $k['maxi']+1;
						echo "id a ingresar". $id_presupuestos."<br>";
						}//////////// CON ESTO GENERAMOS EL IDPRESUPUESTO DE LA BASE DE DATOS
				}


					
					echo "<br> precio por kg metro lineal = 1 :  (antes) ".$prec_kg_mt2."<br> y los accesorios a agregar".$contador_kg_accesorio;

				////////////AQUI SE HACE LA MULTIPLICACION DE EL PESO POR METRO LIIINEAAAAAALLLL A CUADRATICO
					
					//kg de total de la tabla ABERTURAS
					$kg_total=($prec_kg_mt2+($contador_kg_accesorio*$mts2));//////// esto va a LA TABLA DE ABERTURAS!!!!!


					$prec_kg_mt2=($prec_kg_mt2+($contador_kg_accesorio*$mts2))*$precio_kg_mt_lineal;
				////////////////////////////////////////////////////////////////////////////
					
					
					echo "<br> precio por kg metro cuadrado mas accesorios (pesaje): (DESPUES) ".$prec_kg_mt2."<br>";
					//////////// entra si esta UNCHEKED
					if ($mec_silovatiente){
						
						$prec_kg_mt2+= $prec_silovatiente;
			
						$descripcion.="mec silovatiente  ";
					}
					///////esta bien  la consulta?->>>>>>//////////// entra si esta UNCHEKED

					if ($check_con_cajon){
						$prec_kg_mt2+= $prec_cajon;
						$descripcion.="con cajonera  ";
					}
					
					///////////////////////calculo de la ganancia
					$ganancia=$prec_kg_mt2*$porc_ganancia;
					///////////////////////////////////////////////

					if(!$check_colocacion)
						{$subtotal=$prec_kg_mt2+$ganancia;}
					else
						{$subtotal=($prec_kg_mt2+$ganancia)*1.2;
						$descripcion.= "con colocacion ";}

	////////////posiblemente fuera del foreach pa arriba	
	echo "con accesorios:".$contador_kg_accesorio."<br>";
	echo $descripcion;

	

	echo "<br> costo de la abertura mas accesorios: ".$prec_kg_mt2;
	
	echo "<br> ganancia de la abertura: ".$ganancia;
		
	echo"<br> Subtotal: ". $subtotal;
	echo "<br>fecha".$fecha_factura;

//$np= "insert into presupuestos (cliente, fecharealizado, preciototal, fechaexpira)".
//	"values (  ".$nombre_cli." , ".$fecha_factura." , ".$subtotal." , ".$fecha_factura." )";
//$valores[]= array ($id_presupuestos ,$nombre_cli , $fecha_factura , $subtotal , $fecha_factura);


$np= "INSERT INTO presupuestos (idpresupuestos, cliente, fecharealizado, preciototal, fechaexpira) 
	  values ( '".$id_presupuestos. "', '".$nombre_cli ."', '".$fecha_factura ."' , '". $subtotal ."', '" .$fecha_factura."')";


//echo"<br>". $np;

		$nuevopres=$db->prepare($np);
		
	if ($nuevopres){
		
		//echo $np;
		$nuevopres->bindParam("idpresupuestos", $id_presupuestos);
		$nuevopres->bindParam("cliente", $nombre_cli);
		$nuevopres->bindParam("fecharealizado", $fecha_factura);
		$nuevopres->bindParam("preciototal", $subtotal);
		$nuevopres->bindParam("fechaexpira", $fecha_factura);
		$nuevopres->execute();
	
	}else{
		print_r($db->errorInfo( )); 
	}
	$id_vidrios_a_insert="";
	$consulta_vidrio=""			;
	$consulta_vidrio="select idvidrios from vidrios where tipo = '".$vidrio."'";
    $resp=$db->query($consulta_vidrio);
    if ($resp){


		foreach ($resp as $regis){
		
					$id_vidrios_a_insert=($regis['idvidrios']);/////////////////  ESTA VARIABLE ES LA Q VA AL INSERT COMO idvidrios en la tabla aberturas
					
		}

    }
    ////busca el id del perfil con el q se va a diseñar la abertura (insert a tabla aberturas)
    $id_perfiles="";
    $busqueda_perfil="";
    $filtro= "p.linea= '".$prestacion."' and p.tipo= '". $descripcion_abertura."' and p.descripcion= '". $tipo_abertura."'";
    $busqueda_perfil="select idperfiles 	
				from perfiles as p
				where ". $filtro;

	$resp=$db->query($busqueda_perfil);
	if ($resp){
		foreach ($resp as $reg_perf ) {
			# code...
			$id_perfiles=$reg_perf['idperfiles'];

		}

	}

				$id_aberturas=0;
				$seleccion1="";
				$seleccion1= "SELECT MAX(idaberturas)as maxim FROM aberturas";
				$buscaIDab=$db->query ($seleccion1);
				if ($buscaIDab) {
				# code...
						foreach ($buscaIDab as $k) {

						# code...
						$id_aberturas=$id_aberturas+ $k['maxim']+1;
						
						}//////////// CON ESTO GENERAMOS EL IDABERTURAS DE LA BASE DE DATOS
				}


	//$descripcion=$descripcion."'";
    $insert_abert="";
	$insert_abert="insert into aberturas (idaberturas, alto, ancho, kgtotal, preciokg, idperfiles, idvidrios, idpresupuestos, accesorios) values ('"
				.$id_aberturas."','".$alto1."','".$ancho1."','".$kg_total."','".$precio_kg_mt_lineal."','".$id_perfiles."','".$id_vidrios_a_insert."','".$id_presupuestos."','".$descripcion."')";

				//'5','1','1.5','14.85','650','1','','7','Accesorios: contramarco'
		$nuevabertura=$db->prepare($insert_abert);
		
	if ($nuevabertura){
		
		//echo $insert_abert;
		$nuevabertura->bindParam("idaberturas", $id_aberturas);
		$nuevabertura->bindParam("alto", $alto1);
		$nuevabertura->bindParam("ancho", $ancho1);
		$nuevabertura->bindParam("kgtotal", $kg_total);
		$nuevabertura->bindParam("preciokg", $precio_kg_mt_lineal);
		$nuevabertura->bindParam("idperfiles", $id_perfiles);
		$nuevabertura->bindParam("idvidrios", $id_vidrios_a_insert);
		$nuevabertura->bindParam("idpresupuestos", $id_presupuestos);
		$nuevabertura->bindParam("accesorios", $descripcion);
		$nuevabertura->execute();
	}

//values 'id abert5','alto:1','ancho:1.5','kgtotal8.28','prec el metro650','id perfiles2','1','6','Accesorios: contramarco , 




}else{

print_r($db->errorInfo()); # mensaje en desarrollo
echo "<tr><td colspan='<?=$col?>'><br>&nbsp;&nbsp; - No se encuentra la coneccion.</td></tr>";
//header('location:index.php');


}/////////////// ENDIF 


?>



	<body>

	</body>
	<footer>
	<table id= "tblData" width= "90%"  class="table table-sm"> 
			<thead class='table-info'>
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
			</thead>";
		<?=pie()?>
	</footer>
</html>
<!DOCTYPE html>
<html lang="es">

<?php


require_once('conex/conexion.php');
include_once('encabezado.php'); 
include_once('pie.php');

require_once ('conex/session.php');


?>

<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"> 
	
	<title>ProyectoX danisa aberturas</title>	

	
	<link rel="stylesheet" href="css/bootstrap.css">
	<link rel="stylesheet" href="css/estilos2.css">
	
	<!-- jQuery first, then Popper.js (incluido en .blunde.min.js), then Bootstrap JS -->
	<script src="js/jquery-3.4.1.min.js"></script>
	<script src="js/bootstrap.bundle.min.js" ></script>
	

	<script type="text/javascript">
		var codigo_fact;	
        
			function autoincrementar(){
				
				codigo_fact++;
			}

			
			function Validacion (){
					patron="/^[0-2][0-9]\/[01][0-9]\/[0-9]{4}/";
					//inicio de control por javascript
		
					if (!document.getElementsByName(prestacion).value=="") {
					prestacion=document.getElementsByName(prestacion).value;	
					}else{alert ("debe ingresar tipo de prestacion") ;
						  return validacion=false;}
					
					if (!document.getElementByID(ancho).value==0){
					ancho=document.getElementByID(ancho).value;
					}else{alert("debe ingresar ancho") ;
						  return validacion=false;}
					
					if (!document.getElementByID(alto).value==0){
					alto=document.getElementByID(alto).value;
					}else{alert( "debe ingresar alto") ;
						  return validacion=false;}					
					
					if (!document.getElementByID(mts2).value==0){
					mts2=document.getElementByID(mts2).value;
					}else{alert("error debe ingresar alto X ancho") ;
						  return validacion=false;}
					
					if (!document.getElementByID(nom_cli).value==0){
					nom_cli=document.getElementByID(nom_cli).value;
					}else{alert("error debe ingresar nombre de cliente") ;
						  return validacion=false;}
					
					if (!document.getElementsByName(tipo_vidrio).value=="") {
					tipo_vidrio=document.getElementsByName(tipo_vidrio).value;	
					}else{alert ("debe ingresar tipo de vidrio") ;
						  return validacion=false;}

					if (!document.getElementByID(precio_kg_mt_lineal).value==0){
					precio_kg_mt_lineal=document.getElementByID(precio_kg_mt_lineal).value;
					}else{alert("debe ingresar precio de aluminio") ;
						  return validacion=false;}
					
					/////////////////////////////////////////////////////////////////// CANNOT FIXX!!!!!!!!!!!!!!!!

					if (!document.getElementByID(nom_abertura).index==-1){

					tipo_abertura=document.getElementByID(nom_abertura).value;

					
					}else{
						alert("debe ingresar tipo de abertura") ;
						  return validacion=false;
					}
					

				
					if (!document.getelementByID(descripcion_abertura).value==""){
					descripcion_abertura= document.getelementByID(descripcion_abertura).value;
					}else{alert("debe ingresar tipo de prestacion") ;
						  return validacion=false;}

					
					/////////////////////////////////////////////////////////////////////CANNOT FIXX!!!!!!!!!!!!!!!!
					if (!document.getElementByID(fecha_factura).value=="" && (patron.exec(fecha_factura) ) ) { 
						fecha_factura=document.getElementByID(fecha_factura).value;
					
					}else{alert("debe ingresar tipo de prestacion") ;
						  return validacion=false;}
					
					if (!document.getElementsByName(color_aluminio).value==""){
					color_aluminio= document.getElementsByName(color_aluminio).value;
					}else{alert("debe ingresar tipo de prestacion") ;
						  return validacion=false;}
					
					if (document.getelementByID(check_contramarco)== checked){
						check_contramarco=document.getElementByID(check_contramarco).value;
					}
					if (document.getElementByID(check_compacto)== checked){
						check_compacto=document.getElementByID(check_compacto).value;
					}
					if (document.getElementByID(check_colocacion)== checked){
						check_colocacion=document.getElementByID(check_colocacion).value;	
					}
					if (document.getElementByID(check_premarco)== checked){
						check_premarco=document.getElementByID(check_premarco).value;
					}
					if (document.getElementByID(mec_silovatiente)== checked){
						prec_silovatiente=document.getElementByID(prec_silovatiente).value;
					}

					if (document.getElementByID(check_con_cajon)== checked){
						prec_cajon=document.getElementByID(prec_cajon).value;
					}

					//id presupuesto se autogenera
					idpresupuesto=document.getElementByID(id_cod).value;

					if (!document.getElementsByName(porc_ganancia).value=="") {
						porc_ganancia=document.getElementsByName(porc_ganancia).value;	
					}else{alert ("debe ingresar cuanto gana") ;
						  return validacion=false;
					}// end if
			}//end func

			


			

		
	</script>





</head>

<body>
<?php echo crear_encabezado()?>
<div class="container-fluid">
	
	<main id="cuerpo">
	<div class="container border bg-light">
		<h2>Danisa Aberturas</h2>
		
			<h3> Aberturas de aluminio DANISA</h3>
			<p>
				Generador de presupuesto: <b>EN ALPHA</b>
			</p>
	</div>	
	<form action="Formulario.php" method="post" name="formulario_valid" onsubmit="return validar_formulario();">
			<br class="clear">
			<div class="container px-lg-5">
				<div class="row mx-lg-n5"> <!-- nueva fila-->
					<div class="col-3 py-3 px-lg-5 border bg-light"><!--col izquierdo DE RADIO BUTTOMS-->
					<h4> Prestacion/Línea </h4>
						<br> 
						<input type="RADIO" value= "herrero" id=prestacion1 name=prestacion>Herrero (baja )<br>
						<input type="RADIO" value= "modena" checked="checked" id=prestacion2 name=prestacion> Modena (baja)<br>
						<input type="RADIO" value= "vesta" id=prestacion3 name=prestacion> Vesta (media)<br>
						<input type="RADIO" value= "30new" id=prestacion4 name=prestacion> 30new (alta)<br>	
					</div>
					<div class="col-6 py-3 px-lg-5 border bg-light"> <!--col centro-->
						<input type="text"  id=ancho name=ancho maxlength="7" size="8"> X
						<input type="text"  id=alto name=alto maxlength="7" size="8" >=
						<input type="text" id=mts2 name=mts2 value="0" maxlength="7" size="8" readonly="readonly" ><br>
						<p>ANCHO (EN M.MTS)              ALTO (EN M.MTS)               MTS2</p>

						<br>
						<h5>Color aluminio:</h5>
						<input type="RADIO" value= "blanco" id=color_alum name=color_aluminio checked="checked"> Blanco
						<input type="RADIO" value= "negro"  id=color_alum name=color_aluminio>  Negro
						<input type="RADIO" value= "anodizado" id=color_alum name=color_aluminio>  Anodizado
						<br>
					</div>
					<div class="col-3 py-3 px-lg-5 border bg-light"> <!--col izq-->
						<h4> Precio del aluminio: (Metro/Kg)</h4>
						<input type="text" id="prec_kg_mt_lineal" name="precio_kg_mt_lineal" value="650">
						<br>			<br>
						<h5>Fecha:</h5>
						<input type="text" value="AAAA/MM/DD" id="fecha_factura" name="fecha_factura">	<br>			<br> 
						<h4> ingrese nombre del cliente:</h4>
						<input type="text" id="nom_cli" name="nom_cli" value="cliente de paso">

					</div>
				
				</div>
			</div>
			<br>
			
			<!-- nueva row-->
			<div class="container px-lg-5">
			  <div class="row mx-lg-n5">
			    <div class="col py-3 px-lg-5 border bg-light">
					<h3>Tipo Aberturas</h3>	<br>
								<fieldset ><legend>Seleccion de tipo de abertura</legend>
									<select name= "nom_abertura"	id=nom_abertura  > <!--nom_abertura es el campo "descripcion abertura"-->
										<option selected="selected">--Seleccione una de las siguientes opciones--</option>>
										<optgroup  id= "descripcion_abertura" name="descripcion_abertura" label="Ventanas" value="ventana" >
											<option  value="corrediza" value="rs("idperfiles")" data-tipo=rs(tipo)>corredizas</option>
											<option  value="paño fijo">Paño fijo</option>
											<option  value="rebatir">De Rebatir / Banderola</option>
										</optgroup>	
										<optgroup id= "descripcion_abertura" name="descripcion_abertura" label="puertas" value="puerta">
											<option  value="puerta_rebatir"> Puerta</option>
											<option  value="patagonia"> Patagonia</option>
										</optgroup>
										<option value="portones"> Portones</option>
									</select>
								</fieldset>
								<br>
								

			    </div>
			
			    <div class="col py-3 px-lg-5 border bg-light">
					<h3 style="float: left; width:50%">Vidrios:</h3></br>
					</br></br>
					<input type="RADIO" value= "dvh1" id= dh1 name="tipo_vidrio" checked="checked"> DH 1</br>
					<input type="RADIO" value= "dvh2"  id =dh2 name="tipo_vidrio">  DH 2</br>
					<input type="RADIO" value= "dvh3" id= dh3 name="tipo_vidrio">  DH 3</br>
					<input type="RADIO" value= "dvh4" id=dh4 name="tipo_vidrio"> DH 4</br>
					<input type="RADIO" value="merilado" id=con_merilado name="tipo_vidrio"> Merilado </br>
						

			    </div>
			  </div>
			</div>
		<br>	
		<div class="container px-lg-5">
		  <div class="row mx-lg-n5">
		    <div class="col py-3 px-lg-5 border bg-light">
			   <h3 style="float: left; width:25%">Accesorios:</h3>
				   <br></br>
				   <p><br>
					 <input type ="checkbox" name="check_contramarco" checked="checked"value="contramarco"
					 id=con_contramarco name="con_contramarco">Contramarco<br>
		             <input type ="checkbox" name="check_compacto" value="compacto" id=con_compacto>Compacto<br><!--0.8 el kg lineal-->
					 <input type ="checkbox" name="check_premarco" value="premarco" id=con_premarco>Premarco<br>
					 <input type ="checkbox" name="check_colocacion" value="con colocacion" id=con_colocacion>con colocacion
				   </p>
					<br>

		    </div>


		    <div class="col py-3 px-lg-5 border bg-light">
		    	<input type ="checkbox"	name="mec_silovatiente" value=prec_silovatiente  id=silovatiente>Mecanismo Silovatiente
				<input type ="text"	name="prec_silovatiente" value="3500"id=prec_silovatiente size="8">
				<br>
				<input type ="checkbox"	name="check_con_cajon" value=prec_cajon id=con_cajon>
				Con cajon
				<input type ="text"	name="prec_cajon" value="2000" id=prec_cajon size="8"><br>
				<h4>ganancia:</h4>
					<input type="RADIO" value= "0.1" id= "id_rad10" name="porc_ganancia" checked="checked"> %10</br>
					<input type="RADIO" value= "0.2"  id ="id_rad20" name="porc_ganancia">  %20</br>
					<input type="RADIO" value= "0.3" id= "id_rad30" name="porc_ganancia">  %30</br>

		    </div>
		  </div>
		</div>

		<div class="col py-3 px-lg-5 border bg-light">
				<input type="hidden" id="id_cod" value="javascript: autoincrementar()">
				
				<input type= "submit" class="btn btn-primary active" role="button" aria-pressed="true"  name="botom_check" value="Agregar">
		</div>
	</form>
	<br>
	</main>	
	

</div>	
	<footer>
		<?=pie()?>
	</footer>
</body>
</html>
<!doctype html>
<html lang="es">
<?php
require_once('conex/session.php');
include_once("encabezado.php"); 
include_once("pie.php");
?>

  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/estilos2.css">
    <link rel="stylesheet" href="css/bootstrap-grid.css">
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
	<script src="js/jquery-3.4.1.js"></script>
    <script src="js/bootstrap.js"></script>
    
    <title>Aberturas Danisa</title>

    <script>
    // Example starter JavaScript for disabling form submissions if there are invalid fields
    (function() {
      'use strict';
      window.addEventListener('load', function() {
        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        var forms = document.getElementsByClassName('needs-validation');
        // Loop over them and prevent submission
        var validation = Array.prototype.filter.call(forms, function(form) {
          form.addEventListener('submit', function(event) {
            if (form.checkValidity() === false) {
              event.preventDefault();
              event.stopPropagation();
            }
            form.classList.add('was-validated');
          }, false);
        });
      }, false);
    })();
    </script>
  
  </head>
  
  <body>
   
  <?php echo crear_encabezado(); ?>
  
<!--<div class="container-fluid bg-secondary" align="center">
  
    <img src="imagenes/aberturas3.jpg" class="img-fluid" alt="Cocina con ventanas de alumunio"> 

     <div class="caption text-white" >
      <h1>
        Ventanas de Aluminio
      </h1>
      <h3>
        Indispensables en su casa para aportar <br>
        estilo, iluminación y diseño.
      </h3>
    </div>
-->
<div class="bd-example">
  <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
     <div class="carousel-inner">
      <div class="carousel-item active">
        <img src="imagenes/aberturas3.jpg" class="d-block w-100" alt="cocina con ventanas de aluminio">
        <div class="carousel-caption d-none d-md-block">
          <div class="h1">Ventanas de Aluminio</div>
          <div class="h4">
            Indispensables en su casa para aportar <br>
            estilo, iluminación y diseño.
          </div>
         </div>
   </div>
</div>
<div class="container-fluid" align="center">
  <img src="imagenes/pagina.png" class="img-fluid" alt="página en contrucción"> 
</div>
<div ></div>
<br>
<div class="container">
  <div class="card" id="contacto">
    <h5 class="card-header">Contactenos</h5>
    <div class="card-body">
      <div class="container px-lg-5">
        <div class="row mx-lg-n5"> <!-- nueva fila-->
          <div class="col-5 py-3 px-lg-5 bg-light">
            <h5 class="card-title">Dirección</h5>
            <p class="card-text"></p>
            
          </div>
          <div class="col-7 py-3 px-lg-5 border bg-light">


<form class="needs-validation" novalidate>
  <div class="form-row">
    <div class="col-md-10 mb-3">
      <label for="validationCustom01">Su nombre</label>
      <input type="text" class="form-control" id="validationCustom01" value="" required>
      <div class="invalid-feedback">
        Ingrese su nombre
      </div>
    </div>
  </div>


  <div class="form-row">
    <div class="col-md-8 mb-3">
      <label for="validationCustomUsername">Su correo</label>
      <div class="input-group">
        <div class="input-group-prepend">
          <span class="input-group-text" id="inputGroupPrepend">@</span>
        </div>
        <input type="text" class="form-control" id="validationCustomUsername" aria-describedby="inputGroupPrepend" required>
        <div class="invalid-feedback">
          Ingrese su correo válido.
        </div>
      </div>
    </div>
  </div>

  <div class="form-row">
    <div class="col-md-10 mb-3" >
      <label for="validationTextarea">Su mensaje</label>
      <textarea class="form-control invalid" id="validationTextarea" placeholder="" required></textarea>
    <div class="invalid-feedback">
      Favor de ingresar el mensaje.
    </div>
  </div>
  </div>

  
  <button class="btn btn-primary" type="submit">Enviar</button>
</form>







            
          </div>  
        </div>
      </div>
    </div>
  </div>
</div>
<br>
<br>
  <footer>
    <?php echo pie(); ?>
  </footer>
  

  </body>
</html>
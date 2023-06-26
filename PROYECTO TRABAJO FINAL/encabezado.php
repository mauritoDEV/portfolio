<?php
 
     
  #genera barra superior
  function crear_encabezado() {
  global $user;
  
    if ($user=="") {

      $encabezado = "<div class='p-3 mb-2 bg-secondary text-white'>
                    <div class='container'>
                      0291-4523655 // e-mail@gmail.com 
                    </div>
                  </div>

                  <div class='shadow-sm p-1 mb-2 bg-white rounded'>
                    
                    <div class='container'>
                        <ul class='nav justify-content-end'>
                            <li class='nav-item'>
                              <a class='nav-link active' href='index.php'>Inicio</a>
                            </li>
                            
                            <li class='nav-item'>
                              <a class='nav-link' href='index.php#contacto'>Contacto</a>
                            </li>
                            <li class='nav-item'>
                              <a class='nav-link' href='log-in.php'>Iniciar Sesión</a>
                            </li>
                          </ul> 
                    </div>
                  </div>";


    } else {
      $encabezado = "<div class='p-3 mb-2 bg-secondary text-white'>
                      <div class='container'>
                      <div class='row'>
                        <div class='col-4'>
                          0291-4523655 // e-mail@gmail.com   
                        </div>
                      
                        <div class='col-8' style='text-align: end'>

                          En Sesión: {$_SESSION['nombre']} &nbsp; &nbsp; 
                          <a class='btn btn-primary btn-sm' href='conex/cerrar_session.php' role='button'>Cerrar Sesión</a>
                          
                        </div>
                      </div>
                      </div>
                    </div>
        
      
                    <div class='shadow-sm p-1 mb-2 bg-white rounded'>
                    
                      <div class='container'>
                        <ul class='nav justify-content-end'>
                            <li class='nav-item'>
                              <a class='nav-link active' href='index.php'>Inicio</a>
                            </li>
                            <li class='nav-item'>
                              <a class='nav-link' href='consultas_filtradas.php'>Consultas</a>
                            </li>

                            <li class='nav-item'>
                              <a class='nav-link' href='presupuestoalpha.php'>ABM</a>
                            </li>
                            <li class='nav-item'>
                              <a class='nav-link' href='index.php#contacto'>Contacto</a>
                            </li>
                            
                          </ul> 
                    </div>
                  </div>";
  }
    return  $encabezado;
  }
  
      
  
?>
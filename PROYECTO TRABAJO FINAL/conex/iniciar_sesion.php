<?php


require_once ('conexion.php');
require ('semilla.php');


session_start();
/*
Perfiles
  A - administrador - puede ingresar cargo y personas
  E - empleado - puede ingresar cargo
*/


  #recupera los datos de usuario y contraseña
  $dni =(isset($_POST['dni']) && !empty($_POST['dni']))? trim($_POST['dni']):"";
  $psw =(isset($_POST['psw']) && !empty($_POST['psw']))? trim($_POST['psw']):"";

  #Validar datos
    // legajo - contraseña
    
  
   # generar la clave encriptada con el psw ingresado por el usuario
  $salt = SEMILLA;    # semilla - valor fijo
  $psw_encript = hash('sha512', $psw);    # $salt puede ponerse delante o detrás de $psw - sha512 (algoritmo) - devuelve 128 caracteres

  $psw=null;
  
  
  # buscar el psw guardado en la base de datos para el legajo ingresado  
  #   - el psw se generó de la misma forma que se genero la clave encriptada anteriormente
  
  $loguin=0;

  $sql = "SELECT user_psw , user_perfil , user_id , user_dni
          FROM usuarios 
          where user_dni=?";
  
  $sql = $db->prepare($sql);
  $sqlvalue=[$dni];
  $rs = $sql->execute($sqlvalue);
  
 
  if ($rs) {
    if ($rs=$sql->fetch()) {

      $psw_user=$rs['user_psw'];
      
      if ($psw_user==$psw_encript) 
      {
        $loguin=1;

        # se cargan todas las variables de session necesitadas
        $_SESSION['user'] = $dni;
        $_SESSION['perfil'] = $rs['user_perfil'];
        
        # recuperar el nombre del empleado
        $sql = "SELECT nombre, apellido
                FROM personas p , usuarios u
                where p.user_id=u.user_id
                and u.user_id=?";
        
        $sql = $db->prepare($sql);
        $sqlvalue=[$rs['user_id']];
        $rs1 = $sql->execute($sqlvalue);
        
        
        if ($rs1=$sql->fetch()) {
          $_SESSION['nombre'] = "{$rs1['apellido']}, {$rs1['nombre']}";
          
        }
        $rs1=null;  
      } 
    }
  }
  
  $rs=null;
  $db=null;


  if ($loguin==0) 
  {
    $_SESSION["user"]="";
    
  }

  header("location:../index.php"); 
?>
<?php
//require()
//require()
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    if (isset($_POST['razon-social'])):
        $razon_social = $_POST['razon-social'];
        
    if (isset($_POST['cuit'])):
        $cuit = $_POST['cuit'];
        
    if (isset($_POST['titular'])):
        $titular = $_POST['titular'];
        
    if (isset($_POST['nombre-fantasia'])):
        $nombre_fantasia = $_POST['nombre-fantasia'];
        
    if (isset($_POST['socios'])):
        $socios = $_POST['socios'];
        
    if (isset($_POST['fecha-alta'])):
        $fecha_alta = $_POST['fecha-alta'];
        
    if (isset($_POST['fecha-inicio-actividades'])):
        $fecha_inicio_actividades = $_POST['fecha-inicio-actividades'];
        
    if (isset($_POST['domicilio'])):
        $domicilio = $_POST['domicilio'];
        
    if (isset($_POST['domicilio-empresa'])):
        $domicilio_empresa = $_POST['domicilio-empresa'];
        
    if (isset($_POST['localidad'])):
        $localidad = $_POST['localidad'];
        
    if (isset($_POST['telefono'])):
        $telefono = $_POST['telefono'];
        
    if (isset($_POST['legajo'])):
        $legajo = $_POST['legajo'];
    

    // Do something with the form data, such as saving it to a database

    // vuelve

    header('Location: index.html');
    exit;
}
?>
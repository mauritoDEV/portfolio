
<?php 

$dbhost="127.0.0.1";  // localhost
$dbport =""; 
$dbname="dbaberturas";

#Usuario root NO se debe usar para conectarse a la BD desde una aplicación Web.
$usuario="Ezequiel";
$password="1234";

$strCnx = "mysql:dbname=$dbname;host=$dbhost";  // ;charset=utf8

$db ="";

try {
	$db = new PDO($strCnx, $usuario, $password);
	
	$db->setAttribute(PDO::ATTR_CASE,PDO::CASE_LOWER); # para referenciar en minuscula el nombre de las columnas
	$db->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE,PDO::FETCH_ASSOC); # Relizar el FETCh ASSOC por defecto para ahorrar memoria
	

} catch (PDOException $e) {
    print "Error: " . $e->getMessage() . "no conecta? <br/>lalalalalallaal";   # cambiar por un error personalizado 
    die();
}

?>
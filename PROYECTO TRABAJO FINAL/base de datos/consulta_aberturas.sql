SELECT presupuestos.idpresupuestos,presupuestos.cliente, presupuestos.fecharealizado,
				    aberturas.alto, aberturas.ancho,
				    perfiles.tipo, perfiles.descripcion,
		        	aberturas.accesorios,
		        	vidrios.tipo as vidrio_tipo,
		        	(aberturas.kgtotal*aberturas.preciokg) as precio
			FROM presupuestos
			JOIN aberturas on presupuestos.idpresupuestos=aberturas.idpresupuestos
			LEFT JOIN perfiles on aberturas.idperfiles=perfiles.idperfiles
			LEFT JOIN vidrios on aberturas.idvidrios=vidrios.idvidrios
			ORDER BY presupuestos.cliente
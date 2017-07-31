var partidosBsAs = ["La Matanza", "Merlo", "Tres de Febrero", "Lomas de Zamora", "Morón"];
var localidadLaMatanza = ["Ramos Mejía", "San Justo", "Lomas del Mirador", "Casanova", "Laferrere", "Rafaél Castillo", "Ciudad Evita", "Ciudadela", "Gonzalez Catán", "Virrey Del Pino"];

$(document).on('ready', function () {

	

	function validarRegistro(){
		var nombreUsuario = $("#usuario").val();
		var password1 = $("#password").val();
		var password2 = $("#password2").val();

		if(password1.length < 4){
			alert("La contraceña debe tener al menos 4 caracteres");
			return false;
		}
		else if(password1 =! password2){
			alert(nombreUsuario + " Los password no coinciden, verifique");
			return false;
		}
		else
			return true;
	}

	$('#formRegistro').submit(function () {
	    validarRegistro();
	});
    /*
	for(var i=0; i < partidosBsAs.length; i++){
		$(".partidos").append('<option>' + partidosBsAs[i] +'</option>'
			);
	}

	for(var i=0; i< localidadLaMatanza.length; i++){
		$(".zonas").append('<option>' + localidadLaMatanza[i] + '</option>'
			);
	}*/
});
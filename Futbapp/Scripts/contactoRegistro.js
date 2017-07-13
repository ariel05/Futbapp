var partidosBsAs = ["La Matanza", "Merlo", "Tres de Febrero", "Lomas de Zamora", "Morón"];
var localidadLaMatanza = ["Ramos Mejía", "San Justo", "Lomas del Mirador", "Casanova", "Laferrere", "Rafaél Castillo", "Ciudad Evita", "Ciudadela", "Gonzalez Catán", "Virrey Del Pino"];

$(document).on('ready', function () {

	var provincia = $(".provincia").val();
	

	function validarRegistro(){
		var nombreUsuario = $("#usuario").val();
		var password1 = $("#password").val();
		var password2 = $("#password2").val();

		if(password1.lenght < 4){
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

	for(var i=0; i < partidosBsAs.lenght; i++){
		$(".partidos").append('<option>' + partidosBsAs[i] +'</option>'
			);
	}

	for(var i=0; i< localidadLaMatanza.lenght; i++){
		$(".zonas").append('<option>' + localidadLaMatanza[i] + '</option>'
			);
	}
});
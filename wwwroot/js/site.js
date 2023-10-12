function MostrarInfoSerie(id){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/Index',
            data: {idserie: id},
            success:
                function(response)
                {
                    $("#titulo").html(response.nombre);
                    $("#info").html();
                }
        }
    );
}
function MostrarInfoTemporadas(id){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/Index',
            data: {idserie: id},
            success:
                function(response)
                {
                    $("#titulo").html("Temporadas");
                    $("#info").html(response.numerotemporada + " " + response.titulotemporada);
                }
        }
    );
}
function MostrarInfoActores(id){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/Index',
            data: {idserie: id},
            success:
                function(response)
                {
                    $("#titulo").html("Actores");
                    $("#info").html(response.nombre);
                }
        }
    );
}
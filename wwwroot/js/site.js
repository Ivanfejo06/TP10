function MostrarInfoSerie(id){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleSeriesAjax',
            data: {idserie: id},
            success:
                function(response)
                {
                    $("#titulo").html(response.nombre);
                    $("#subtitulo").html("Año de estreno: " + response.añoinicio);
                    $("#info").html(response.sinopsis);
                }
        }
    );
}
function MostrarInfoTemporadas(id){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleTemporadasAjax',
            data: {idserie: id},
            success:
                function(response)
                {
                    $("#titulo").html("Temporadas");
                    $("#subtitulo").html("Cuenta con " + response.length + " temporadas");
                    let infoTemporadas ="";
                    
                    response.forEach(element =>{
                        infoTemporadas += element.titulotemporada + "<br>";
                    });
                    $("#info").html(infoTemporadas);
                   
                }
        }
    );
}
function MostrarInfoActores(id){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleActoresAjax',
            data: {idserie: id},
            success:
                function(response)
                {
                    $("#titulo").html("Actores");
                    $("#subtitulo").html(null);
                    let infoActores ="";
                    
                    response.forEach(element =>{
                        infoActores += element.nombre + "<br>";
                    });
                    $("#info").html(infoActores);
                }
        }
    );
}
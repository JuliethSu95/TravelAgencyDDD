$(document).ready(function () {
    GetAll();
});

function GetAll() {
    var item = "";
    $('#listaHoteles tbody').html('');

    $.getJSON('api/hoteles', function (data) {
        $.each(data, function (key, value) {
            item +=
                "<tr><td>" +
                value.IdHotel +
                "<tr><td>" +
                "<tr><td>" +
                value.RazonSocial +
                "<tr><td>" +
                "<tr><td>" +
                value.IdTipoDocumento
                "<tr><td>" +
                "<tr><td>" +
                value.Identificacion
                "<tr><td>" +
                "<tr><td>" +
                value.Direccion
                "<tr><td>" +
                "<tr><td>" +
                value.Telefono
                "<tr><td>" +
                "<tr><td>" +
                value.FechaCreacion
                "<tr><td>" +
                "<tr><td>" +
                value.FechaModificacion
                "<tr><td>"
        });

        $('#listaHoteles tbody').append(item);
    });
}
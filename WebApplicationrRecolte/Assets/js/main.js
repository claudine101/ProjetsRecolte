$(function () 
{
    $('#ID_province').on('change', function () {
        var id = $(this).val();
        alert(id);
        $.get('/associations/getCommune', { id: id }, function (data) {
            $('#ID_commune').empty();
            $('#ID_colline').append("<option value=''>selectionnez commune</option>")
            $.each(data, function (index, row) {
                $('#ID_commune').append("<option value='" + row.ID_commune + "'>" + row.NOM_commune + "</option>")
            });
        });
    });
});

//Getting zone
$(function () {
    $('#ID_commune').on('change', function () {
        var ID = $(this).val();
        $.get('/associations/getZone', { ID: ID }, function (data) {
            $('#ID_zone').empty();
            $('#ID_colline').append("<option value=''>selectionnez zone</option>")
            $.each(data, function (index, row) {
                $('#ID_zone').append("<option value='" + row.ID_zone + "'>" + row.NOM_zone + "</option>")
            });
        });
    });
});
//Getting colline
$(function () {
    $('#ID_zone').on('change', function () {
        var ID = $(this).val();
        $.get('/associations/getColline', { ID: ID }, function (data) {
            $('#ID_colline').empty();
            $('#ID_colline').append("<option value=''>selectionnez colline</option>")
            $.each(data, function (index, row) {
                $('#ID_colline').append("<option value='" + row.ID_colline + "'>" + row.NOM_colline + "</option>")
            });
        });
    });
});
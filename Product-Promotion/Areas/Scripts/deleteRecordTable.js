function Delete(url, id) {
    $.ajax({
        url: url + id,
        type: "POST",
        success: function (result) {
            $('html,body').animate({
                scrollTop: $("#a_" + id).offset().top
            },
           'slow');
            $("#a_" + id).fadeOut();
            $('#delete-'+id).modal('hide');
        }
    })
}



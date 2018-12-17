$.reload = function () {
    location.reload();
    return false;
}
$.alterMsg = function (options) {
    var defaults = {
        bool: false,
        type: "",
        text: "",
    };
    var options = $.extend(defaults, options);
    if (options.bool) {
        if (options.type == "primary") {
            $("#myAlert").attr('class', "alert alert-primary");
            $("#myAlert-font").text(options.text);
            //   $('.alert').alert()
        }
        else if (options.type == "success") {
            $("#myAlert").attr('class', "alert alert-success");
            $("#myAlert-font").text(options.text);
        }
        else if (options.type == "danger") {
            $("#myAlert").attr('class', "alert alert-danger");
            $("#myAlert-font").text(options.text);
        }
        else if (options.type == "warning") {
            $("#myAlert").attr('class', "alert alert-warning");
            $("#myAlert-font").text(options.text);
        }
        else {
            $("#myAlert").attr('class', "alert alert-info");
            $("#myAlert-font").text(options.text);
        }
    }
    else {
        // $('.alert').alert('close');
        $("#myAlert").removeAttr('class');
        $("#myAlert-font").text('');
    }
}

$.loading = function (bool, text) {
    if (bool) {
        var index = layer.load(1, {
            shade: [0.1, '#fff'] //0.1透明度的白色背景
        });
    }
    else {
        layer.closeAll('loading');
    }
    return
}
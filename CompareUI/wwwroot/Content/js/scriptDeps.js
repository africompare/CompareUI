function InlineErrorMessage(msg, id) {
    if (id == undefined) {
        alert(msg);
    } else {
        var html = '<div class="alert alert-danger "><a href="#" class="close" data-dismiss="alert" aria-label="close">×</a><i class="fa fa-remove fa-2x"></i><strong> Error!</strong> ' + msg + '</div>';
        $("#" + id).html(html);
    }
}

function InlineSuccessMessage(msg, id) {
    if (id == undefined) {
        alert(msg);
    } else {
        var html = '<div class="alert alert-success "><a href="#" class="close" data-dismiss="alert" aria-label="close">×</a> <i class="fa fa-check fa-2x"></i><strong> Success!</strong> ' + msg + '</div>';
        $("#" + id).html(html);
    }
}

function ClearInlineError(id) {
    $("#" + id).html("");
}
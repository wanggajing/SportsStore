/// <reference path="jquery-2.1.3.js" />


$(document).ready(function () {
    var ok1 = false;
    var ok2 = false;
    var ok3 = false;
    var ok4 = false;
    $("#name").focus(function () {
        if ($(this).val().length == 0 && $(".errorMsg").text() == "") {
            $(".errorMsg").text("name is required");
        }
    });
    $("#name").blur(function () {
        if ($("#name").val().length > 0) {
            $(".errorMsg").text("");
            ok1 = ture;
        }
    });
});
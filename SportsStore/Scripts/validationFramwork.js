/// <reference path="jquery.validate.js" />
/// <reference path="jquery-2.1.3.js" />
$(document).ready(function () {
    $("#form1").validate({
        rules: {
            name: {
                required:true
            },
            line1: {
                required:true
            },
            city:{
                required:true
            },
            state: {
                required:true
            }
        },
        messages: {
            name: {
                required: "Name is required"
            }
        }
    });
});
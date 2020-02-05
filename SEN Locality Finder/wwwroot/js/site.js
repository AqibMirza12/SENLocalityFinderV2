
$(document).ready(function () {
        $('select').formSelect();
});

jQuery.noConflict();
$('#textarea').val('Your Text');
M.textareaAutoResize($('#textarea'));

jQuery.noConflict();
$(document).ready(function () {
    $('.collapsible').collapsible();
});
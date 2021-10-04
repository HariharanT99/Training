// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function ActivateBreak() {
    var btnBreak = $('#btnbreak');
    var btnOffWork = $("#btnoffwork");
    btnBreak.addClass('visible');
    btnBreak.removeClass('invisible');

    setTimeout(function () {
        btnOffWork.addClass('visible');
        btnOffWork.removeClass('invisible');
    }, 5000); //60*60*4000 for 4hrs
}

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.filter-button').click(function () {
        
        var value = $(this).attr('data-filter');
        
        if (value == 'all') {
            $('.filter').show('1000');
        } else {
            $('.filter').not('.' + value).hide('3000');
            $('.filter').filter('.' + value).show('3000');
        }
    })
});

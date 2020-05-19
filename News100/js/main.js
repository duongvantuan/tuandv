$( document ).ready(function() {
    $('.menu-toggle').on('click', function (e) {
        var menu = $('.menunav-menu');
        $('.menu-toggle').toggleClass("active");
        menu.slideToggle();
    });
});
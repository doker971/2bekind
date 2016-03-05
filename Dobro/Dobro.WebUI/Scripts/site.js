jQuery(document).ready(function ($) {
    $(".panel-heading").click(function () {
        $(this).next().collapse('toggle');
    });
    $(".cycle").click(function () {
        $(this).next().collapse('toggle');
    });
    $("#blocks").css("display", "none");
    $("#blocks").slidesjs({
        height: 700,
        pagination: {
            active: false
        },
        navigation: {
            active: false
        }
    });
    alert(@Model.ToString());
});
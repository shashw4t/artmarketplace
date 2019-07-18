$(document).ready(function () {

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying Item");
        theForm.slideToggle(500);
    });

    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("clicked one of the items: " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.slideToggle(500);
    });



});














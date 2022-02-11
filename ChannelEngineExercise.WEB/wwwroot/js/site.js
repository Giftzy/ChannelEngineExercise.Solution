// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function callProductFunc(ProductName, MerchantProductNo, StockLocationId) {
    $('#productname').val(ProductName);
    $('#merchant-productno').val(MerchantProductNo);
    $("#stockLocationId").text(StockLocationId);
    $('#exampleModal').modal({
        backdrop: 'static',
        keyboard: false,
        show: true
    });

}

function UpdateProductStock() {
    debugger;

    var stockmodel = JSON.stringify({
        'MerchantProductNo': $("#merchant-productno").val(),
        'Stock': $("#productstock").val(),
        'StockLocationId': $('#stockLocationId').html()
    });


    $.ajax({
        type: "POST",
        url: '/Home/UpdateProductStock',
        data: stockmodel,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: onSuccessCall
    });

    function onSuccessCall(data) {
        if (data.success) {
            //dismiss product detail modal
            $('#exampleModal').modal('toggle');

            //display success modal
            $("#successMsg").text(data.message);
            $('#mysuccessmodal').modal({
                backdrop: 'static',
                keyboard: false,
                show: true
            });
        }
    }

}
// Write your JavaScript code.


function callProductFunc(ProductName, MerchantProductNo, StockLocationId) {
    $('#txtproductname').val(ProductName);
    $('#txtmerchantproductno').val(MerchantProductNo);
    $("#lblstockLocationId").text(StockLocationId);
    $('#exampleModal').modal({
        backdrop: 'static',
        keyboard: false,
        show: true
    });

}

function UpdateProductStock() {
    debugger;

    var stockmodel = JSON.stringify({
        'MerchantProductNo': $("#txtmerchantproductno").val(),
        'Stock': $("#txtproductstock").val(),
        'StockLocationId': $('#lblstockLocationId').html()
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
            //Set Alert Img to Success
            $("#myAlertImg").attr("src", "assets/img/elements/success1.png");
        } else {
            //Set Alert Img to Fail
            $("#myAlertImg").attr("src", "assets/img/elements/failure.jpg");
        }

        //dismiss product detail modal
        $('#exampleModal').modal('toggle');

        //display success modal
        $("#lblAlertMsg").text(data.message);
        $('#myAlertModal').modal({
            backdrop: 'static',
            keyboard: false,
            show: true
        });
    }

}
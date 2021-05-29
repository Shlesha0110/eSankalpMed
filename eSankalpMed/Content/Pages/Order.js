var saveOrder = function () {
    //var id = $("#hdnId").val();
    //var custid = $("#txtCustId").val();
    var amount = $("#txtAmount").val();
    var discount = $("#txtDiscount").val();
    var totalamt = $("#txtTotalAmt").val();
    var vat = $("#txtVat").val();
    var time = $("#txtTime").val();
    var paymode = $("#txtPayMode").val();
    var paid = $("#txtPaid").val();
    var note = $("#txtNote").val();
    var advance = $("#txtAdvance").val();
    var point = $("#txtPoint").val();
    var person = $("#txtPerson").val();
    var date = $("#txtDate").val();


    var model = {
        //Id: id,
        //CustId: custid,
        Amount: amount,
        Discount: discount,
        TotalAmt: totalamt,
        Vat: vat,
        Time: time,
        PayMode: paymode,
        Paid: paid,
        Note: note,
        Advance: advance,
        Point: point,
        Person: person,
        Date: date

    };
    $.ajax({
        url: "/Order/SaveOrder ",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        
        success: function (response) {
            alert(" Order Successfull");

        }

    })
};

var getOrderList = function () {
    $.ajax({
        url: "/Order/GetOrderList",
        method: "post",
        // data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tbl_Order tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Id + "</td><td>"
                    //+ elementValue.Id + "</td><td>"
                    + elementValue.CustId + "</td><td>"
                    + elementValue.Amount + "</td><td>"
                    + elementValue.Discount + "</td ><td>"
                    + elementValue.TotalAmt + "</td><td>"
                    + elementValue.Vat + "</td><td>"
                    + elementValue.Time + "</td ><td>"
                    + elementValue.PayMode + "</td><td>"
                    + elementValue.Paid + "</td><td>"
                    + elementValue.Note + "</td ><td>"
                    + elementValue.Advance + "</td><td>"
                    + elementValue.Point + "</td><td>"
                    + elementValue.Person + "</td ><td>"
                    + elementValue.Date + "</td ></tr>"

            });
            $("#tbl_Order").append(html);
        }
    });
}

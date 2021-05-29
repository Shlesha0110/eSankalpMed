var saveBill = function () {
    var invoiceid = $("#txtInvoiceId").val();
    var itemid = $("#txtItemId").val();
    var itemqty = $("#txtItemQty").val();
    var itemsaleamt = $("#txtItemSaleAmt").val();
    var vat = $("#txtVat").val();
    var rate = $("#txtRate").val();
    var discount = $("#txtDiscount").val();
    var itemmodel = $("#txtModel").val();
    var size = $("#txtSize").val();
    var gst = $("#txtGST").val();
    var disc = $("#txtDisc").val();
    var taxamt = $("#txtTaxAmt").val();
    var dosetime = $("#txtDoseTime").val();
    var doseqty = $("#txtDoseQty").val();
    

    var model = {
        InvoiceId: invoiceid,
        ItemId: itemid,
        ItemQty: itemqty,
        ItemSaleAmt: itemsaleamt,
        Vat: vat,
        Rate: rate,
        Discount: discount,
        Model: itemmodel,
        Size: size,
        GST: gst,
        Disc: disc,
        TaxAmt: taxamt,
        DoseTime: dosetime,
        DoseQty: doseqty
       
    };
    
    $.ajax({
        url: "/Bill/SaveBill",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",

        success: function (response) {
            alert(" Bill Successfull");

        }

    })
};

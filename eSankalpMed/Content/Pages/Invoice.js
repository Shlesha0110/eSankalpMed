$(document).ready(function () {
    getInvoiceList();
});

var saveInvoice = function () {
    var custid = $("#txtCustId").val();
    var amount = $("#txtAmount").val();
    var discount = $("#txtDiscount").val();
    var totalamt = $("#txtTotalAmt").val();
    var invoicedate = $("#txtInvoiceDate").val();
    var vat = $("#txtVat").val();
    var time = $("#txtTime").val();
    var paymode = $("#txtPayMode").val();
    var paid = $("#txtPaid").val();
    var note = $("#txtNote").val();
    var advance = $("#txtAdvance").val();
    var point = $("#txtPoint").val();
    var person = $("#txtPerson").val();
    var invoiceid = $("#txtInvoiceId").val();
    var sgst = $("#txtSGST").val();
    var cgst = $("#txtCGST").val();
    var igst = $("#txtIGST").val();
    var igst = $("#txtIGST").val();
    var autoinvoiceid = $("#txtAutoInvoiceID").val();


    var model = {
        //Id: id,
        CustId: custid,
        Amount: amount,
        Discount: discount,
        TotalAmt: totalamt,
        InvoiceDate: invoicedate,
        Vat: vat,
        Time: time,
        PayMode: paymode,
        Paid: paid,
        Note: note,
        Advance: advance,
        Point: point,
        Person: person,
        InvoiceId: invoiceid,
        SGST: sgst,
        CGST: cgst,
        IGST: igst,
        AutoInvoiceID: autoinvoiceid
    };
    $.ajax({
        url: "/Invoice/SaveInvoice ",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",

        success: function (response) {
            alert(" Invoice Successfull");

        }

    })
};

var getInvoiceList = function () {
    $.ajax({
        url: "/Invoice/GetInvoiceList",
        method: "post",
        // data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tbl_Invoice tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Id + "</td><td>"
                    + elementValue.CustId + "</td><td>"
                    + elementValue.Amount + "</td><td>"
                    + elementValue.Discount + "</td ><td>"
                    + elementValue.TotalAmt + "</td><td>"
                    + elementValue.InvoiceDateString + "</td><td>"
                    + elementValue.Vat + "</td ><td>"
                    + elementValue.Time + "</td><td>"
                    + elementValue.PayMode + "</td><td>"
                    + elementValue.Paid + "</td ><td>"
                    + elementValue.Note + "</td><td>"
                    + elementValue.Advance + "</td><td>"
                    + elementValue.Point + "</td ><td>"
                    + elementValue.Person + "</td><td>"
                    + elementValue.InvoiceId + "</td ><td>"
                    + elementValue.SGST + "</td><td>"
                    + elementValue.CGST + "</td><td>"
                    + elementValue.IGST + "</td><td>"
                    + elementValue.AutoInvoiceID + "</td ></tr>"
                   

            });
            $("#tbl_Invoice").append(html);
        }
    });
}
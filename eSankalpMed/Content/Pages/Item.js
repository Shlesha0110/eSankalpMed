$(document).ready(function () {
    getItemList();
});


var saveItem = function () {
    var id = $("#hdnId").val();
    var itemname = $("#txtItemName").val();
    var purchaseprice = $("#txtPurchasePrice").val();
    var saleprice = $("#txtSalePrice").val();
    var catid = $("#txtCatId").val();
    var itemqty = $("#txtItemQty").val();
    var unit = $("#txtUnit").val();
    var details = $("#txtDetails").val();
    var vat = $("#txtVat").val();
    var barcode = $("#txtBarcode").val();
    var hsn = $("#txtHSN").val();
    var mfgcomapny = $("#txtMFGComapny").val();
    var expirydate = $("#txtExpiryDate").val();
    var mrp = $("#txtMRP").val();
    var wprice = $("#txtWprice").val();
    var woutsaleprice = $("#txtWoutSalePrice").val();
    var mfgdate = $("#txtMFGDate").val();


    var model = {
        Id: id,
        ItemName: itemname,
        PurchasePrice: purchaseprice,
        SalePrice: saleprice,
        CatId: catid,
        ItemQty: itemqty,
        Unit: unit,
        Details: details,
        Vat: vat,
        Barcode: barcode,
        HSN: hsn,
        MFGComapny: mfgcomapny,
        ExpiryDate: expirydate,
        MRP: mrp,
        Wprice: wprice,
        WoutSalePrice: woutsaleprice,
        MFGDate: mfgdate

    };

    $.ajax({
        url: "/Item/SaveItem ",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",

        success: function (response) {
            alert("Successfull");

        }

    })
};

var getItemList = function () {
    var itemname = $("#txtItemName").val();
    
    var model = { ItemName: itemname };
    $.ajax({
        url: "/Item/GetItemList",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tbl_Item tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" /*+ elementValue.ItemId + "</td><td>"*/
                    + elementValue.ItemName + "</td><td>"
                    + elementValue.PurchasePrice + "</td></tr>"
                    //+ elementValue.SalePrice + "</td ><td>"
                    //+ elementValue.CatId + "</td><td>"
                    //+ elementValue.ItemQty + "</td><td>"
                    //+ elementValue.Unit + "</td ><td>"
                    //+ elementValue.Details + "</td><td>"
                    //+ elementValue.Vat + "</td><td>"
                    //+ elementValue.Barcode + "</td ><td>"
                    //+ elementValue.HSN + "</td><td>"
                    //+ elementValue.MFGComapny + "</td><td>"
                    //+ elementValue.ExpiryDate + "</td ><td>"
                    //+ elementValue.MRP + "</td><td>"
                    //+ elementValue.Wprice + "</td><td>"
                    //+ elementValue.WoutSalePrice + "</td ><td>"
                    //+ elementValue.MFGDateString + "</td ></tr>"

            });
            $("#tbl_Item").append(html);
        }
    });
}


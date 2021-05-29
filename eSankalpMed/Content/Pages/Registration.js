var saveRegistration = function () {
    var custid = $("#txtCustId").val();
    var custname = $("#txtCustName").val();
    var address = $("#txtAddress").val();
    var mobile = $("#txtMobile").val();
    var email = $("#txtEmail").val();
    var details = $("#txtDetails").val();
    var date = $("#txtDate").val();
    var status = $("#txtStatus").val();
    var gst = $("#txtGST").val();
    var pan = $("#txtPAN").val();
    var password = $("#txtPassword").val();

        var model = {
            //Id: id,
            CustId: custid,
            CustName: custname,
            Address: address,
            Mobile: mobile,
            Email: email,
            Details: details,
            Date: date,
            Status: status,
            GST: gst,
            PAN: pan,
            Password: password

        };
        $.ajax({
            url: "/Registration/SaveRegistration ",
            method: "Post",
            data: JSON.stringify(model),
            contentType: "application/json;charset=utf-8",
            datatype: "json",

            success: function (response) {
                alert(" Registration Successfull");

            }

        })
    
};
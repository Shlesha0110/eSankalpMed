$(document).ready(function () {
    getPrescriptionList();
});
var getPrescriptionList = function () {
    $.ajax({
        url: "/AdminList/GetPrescriptionList",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tbl_Prescription tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Customer_Id +"</br>"+
                    elementValue.Patient_Name + "</br>" +
                    elementValue.Uploaded_DateString +"</br>"+
                    elementValue.Status + "</br>" +
                    elementValue.Delivery_dateString +

                    "</td><td><img src='../Content/images/" +
                    elementValue.Photo + "'/></td></tr>";
            });
            $("#tbl_Prescription ").append(html);
        }
    })
}
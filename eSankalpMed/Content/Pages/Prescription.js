var savePrescription = function () {
    
    var message = "";
    $formData = new FormData();
    var photo = document.getElementById('File1');;
    if (photo.files.length > 0) {
        for (var i = 0; i < photo.files.length; i++) {
            $formData.append('file-' + i, photo.files[i]);
          
        }
    }
    var patient_name = $("#txtPatient_Name").val();
   
    var date = $("#txtUploaded_Date").val();

    var status = $("#txtStatus").val();

    var delivery_date = $("#txtDelivery_date").val();

    $formData.append('Patient_Name', patient_name);
   
    $formData.append('Uploaded_Date', date);

    $formData.append('Status', status);

    $formData.append('Delivery_date', delivery_date);


    $.ajax({
        url: "/Prescription/SavePrescription",
        type: 'post',
        data: $formData,
        dataType: 'json',
        contentType: false,
        processData: false,

        success: function (response) {
            alert("Registration Succesfully");
        }
    });

}


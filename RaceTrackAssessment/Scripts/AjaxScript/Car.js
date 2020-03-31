
//Load Data function  
function loadData() {
    console.log('making get requesT!');
    $.ajax({
        url: "/RaceTrack/LoadTracks",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            console.log("Reached Success", result);
            $.each(result, function (key, item) {
                var flag = item.TowStrap == true ? "Yes" : "No";
                html += '<tr>';
                html += '<td>' + item.CarId + '</td>';
                html += '<td>' + item.CarName + '</td>';
                html += '<td>' + item.Model + '</td>';
                html += '<td>' + flag + '</td>';
                html += '<td>' + item.GroundHeight + '</td>';
                html += '<td>' + item.TireWear + '</td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
            
        },
        error: function (errormessage) {
            console.error(errormessage);
        }
    });
}
//Add Data Function   
function Add() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var empObj = {
        CarName: $('#CarName').val(),
        Model: $('#CarModel').val(),
        TowStrap: $('#TowStrap').val() == 'Yes'? true: false,
        GroundHeight: $('#GHeight').val(),
        TireWear: $('#TireWear').val(),
    };
    $.ajax({
        url: "/RaceTrack/Create",
        data: JSON.stringify(empObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            console.log(result)
            if (result.isSuccess == true) {
                alert("Success! " + result.Message);
            } else {
                alert("Failed! " + result.Message);
            }

            loadData();
            $('#myModal').modal('hide');
        },
        error: function (errormessage) {
            console.log(errormessage.responseText);
        }
    });
}  
//Function for clearing the textboxes  
function clearTextBox() {
    $('#CarId').val("");
    $('#CarName').val("");
    $('#CarModel').val("");
    $('#TowStrap').val("");
    $('#GHeight').val("");
    $('#TireWear').val("");
    $('#CarName').css('border-color', 'lightgrey');
    $('#CarModel').css('border-color', 'lightgrey');
    $('#TowStrap').css('border-color', 'lightgrey');
    $('#GHeight').css('border-color', 'lightgrey');
    $('#TireWear').css('border-color', 'lightgrey');
   
} 
//Valdidation using jquery  
function validate() {
    var isValid = true;
    if ($('#CarName').val().trim() == "") {
        $('#CarName').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#CarName').css('border-color', 'lightgrey');
    }
    if ($('#CarModel').val().trim() == "") {
        $('#CarModel').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#CarModel').css('border-color', 'lightgrey');
    }
    if ($('#TowStrap').val().trim() == "") {
        $('#TowStrap').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#TowStrap').css('border-color', 'lightgrey');
    }
    if ($('#GHeight').val().trim() == "") {
        $('#GHeight').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#GHeight').css('border-color', 'lightgrey');
    }
    if ($('#TireWear').val().trim() == "") {
        $('#TireWear').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#TireWear').css('border-color', 'lightgrey');
    }
   
    return isValid;
}  
//Load Data in Table when documents is ready  
$(document).ready(function () {
    setInterval(function () { loadData(); }, 3000);
});
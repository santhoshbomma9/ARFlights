

var btn = document.getElementById("checkAvail");
var booking = document.getElementById("bookingContent");
var from = document.getElementById("from");
var to = document.getElementById("to");
var pax = document.getElementById("pax");

btn.addEventListener("click", function () {
    //alert(from.value);
    //alert(to.value);
    //alert(pax.value);

    var request = new XMLHttpRequest();
    //request.open("POST", "http://localhost:2523/api/Avail/01-01-2018/2018-2-01/4");
    request.open("POST", "http://localhost:2523/api/Avail/" + from.value +"/" + to.value +"/" + pax.value);
    request.onload = function () {
        var Data = JSON.parse(request.responseText);
        renderHTML(Data);
    };
    request.send();
});

function renderHTML(data) {
    var table = $('#bookingTable');
    $('#bookingTable').find('tbody').empty();
    for (var i = 0; i < data.length; i++) {
        table.append("<tr><td >" + data[i].BookingDate + "</td ><td >" + data[i].HelicopterName + "</td ><td >" + data[i].Capacity + "</td ><td >" + data[i].Booked + "</td ><td >" + data[i].Available + "</td ></tr>");
    }
}
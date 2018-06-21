

var btn = document.getElementById("checkAvail");
var booking = document.getElementById("bookingContent");
var from = document.getElementById("from");
var tp = document.getElementById("to");
var pax = document.getElementById("pax");

btn.addEventListener("click", function () {
    //alert(from.value);
    //alert(to.value);
    //alert(pax.value);

    var request = new XMLHttpRequest();
    request.open("POST", "http://localhost:2523/api/Avail/01-01-2018/2018-2-01/4");
    request.onload = function () {
        var Data = JSON.parse(request.responseText);
        renderHTML(Data);
    };
    request.send();
});

function renderHTML(data) {
    booking.innerText = data;
}
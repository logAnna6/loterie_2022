
setInterval(function () {
   /* var time = document.getElementById("timeref").value;
    var jsDate = new Date(Date.parse(time));
    var timeend = document.getElementById("timerefend").value;
    var jsDateEnd = new Date(Date.parse(timeend));*/
    var d = new Date();

    //if (jsDate >= d && jsDateEnd <= d) {

    var seconds = d.getMinutes() * 60 + d.getSeconds();
    console.log(seconds);
    var fiveMin = 60 * 5;
    var timeleft = fiveMin - seconds % fiveMin;
    var result = parseInt(timeleft / 60) + ':' + timeleft % 60;

    document.getElementById('timer').innerHTML = result;
   // };

}, 500);
var time = document.getElementById("timeref").value;
var jsDate = new Date(Date.parse(time));
var timeend = document.getElementById("timerefend").value;
var jsDateEnd = new Date(Date.parse(timeend));




setInterval(function () {

    var d = new Date();

    if (d >= jsDate) {

    console.log(d, jsDate);
   
    var seconds = d.getMinutes() * 60 + d.getSeconds();
    console.log(seconds);
    var fiveMin = 60 * 5;
    var timeleft = fiveMin - seconds % fiveMin;
        var result = parseInt(timeleft / 60) + ':' + timeleft % 60;
    }

     document.getElementById('timer').innerHTML = result;
   // };

    if (d === jsDateEnd) {
        clearInterval(countdownInterval);
    }

}, 500);


/*

// Set the date we're counting down to
var time = document.getElementById("timeref").value;
var jsDate = new Date(Date.parse(time));

var timeend = document.getElementById("timerefend").value;
var jsDateEnd = new Date(Date.parse(timeend));



var distance = jsDateEnd.getTime() - jsDate.getTime();
distance = distance / 1000;

const timer = document.getElementById('timer');

// Update the count down every 1 second
setInterval(function () {

    var distance = jsDateEnd.getTime() - jsDate.getTime();
    distance = distance / 1000;
   
    var minutes = Math.floor(distance / 60);
    var seconds = Math.floor(distance) % 60;
   
    timer.innerHTML = `${minutes}:${seconds}`;

    
}, 500);*/

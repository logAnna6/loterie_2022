
setInterval(function () {
    var d = new Date();
    var seconds = d.getMinutes() * 60 + d.getSeconds();
    console.log(seconds);
    var fiveMin = 60 * 5;
    var timeleft = fiveMin - seconds % fiveMin;
    var result = parseInt(timeleft / 60) + ':' + timeleft % 60;
    document.getElementById('timer').innerHTML = result;

}, 500);
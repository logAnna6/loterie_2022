var time = document.getElementById("timeref").value;
var jsDate = new Date(Date.parse(time));
var timeend = document.getElementById("timerefend").value;
var jsDateEnd = new Date(Date.parse(timeend));



    setInterval(function () {

        const total = Date.parse(jsDateEnd) - Date.parse(new Date());
        const seconds = Math.floor((total / 1000) % 60);
        const minutes = Math.floor((total / 1000 / 60) % 60);

        if (minutes <= 1) {
            document.getElementById('play').style.display = none;
        }
        

        document.getElementById('timer').innerHTML = minutes+":"+seconds;
        // };

        if (minutes == 0) {
            clearInterval(countdownInterval);
            window.location.reload();
        }

    }, 500);




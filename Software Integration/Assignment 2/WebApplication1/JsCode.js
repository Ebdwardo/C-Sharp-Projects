var secretNum = 0;
var attempts = 0;

function SecretNumber() {
   
    document.getElementById("guessSection").hidden = false;
    let request = new XMLHttpRequest();
    request.open("Get", "http://localhost:63583/Service1.svc/SecretNumber?lower=" + document.getElementById("lower").value + "&upper=" + document.getElementById("upper").value)
    request.send();
    request.onload = () => {
        console.log(request);
        if (request.status == 200) {
            secretNum = JSON.parse(request.response)
        }
    }
}

function checkNumber() {
    attempts++
    document.getElementById("attempt").innerText = `You have made ${attempts} attempt(s)`
        let request = new XMLHttpRequest();
    request.open("Get", "http://localhost:63583/Service1.svc/checkNumber?userNum=" + document.getElementById("guess").value + "&SecretNum=" + secretNum)
    request.send();
    request.onload = () => {
        console.log(request);
        if (request.status == 200) {
            document.getElementById("correct").innerText = JSON.parse(request.response)
        }
    }
}
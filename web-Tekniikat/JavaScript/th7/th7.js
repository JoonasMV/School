//Th1
function nappi(){
    alert("Nappia painettu")
}
//-------------------------------

//Th2
const kuva = document.getElementById("kuva1")
const hidden = document.getElementById("hidden")

kuva.onmouseenter = function (){
    hidden.innerText = "On kaljaa"
};

kuva.onmouseleave = function (){
    hidden.innerText = "Oispa kaljaa"
}
//-----------------------------------------------------------------

//Th3 -Helppoo ja hauskaa :_D-
const vastaus = document.getElementById("vastaus")

function laskija(){
    let laskin = document.getElementById("laskin").value
    let lasku = []
    let ans
    let func = ["+","-","/","*"]
    let regExp = /[a-zA-z]/
    for(let i = 0;i<func.length;i++) {
        if (laskin.includes(func[i])) {
            lasku = laskin.split(func[i])
            lasku[0] = parseInt(lasku[0])
            lasku[1] = parseInt(lasku[1])
            switch (func[i]) {
                case "+":
                    ans = lasku[0] + lasku[1]
                    break;
                case "-":
                    ans = lasku[0] - lasku[1]
                    break;
                case "/":
                    ans = lasku[0] / lasku[1]
                    break;
                case "*":
                    ans = lasku[0] * lasku[1]
                    break;
            }
        }
    }
    if(regExp.test(laskin) || typeof ans === 'undefined'
        || isNaN(ans) || lasku.length > 2){
        ans = "Virhe laskukentässä"
    }
    vastaus.innerText = ans
}
//-----------------------------------------------------------
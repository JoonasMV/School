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
//Testi
//Th4
const pics = [
    {
        thumb: 'https://www.fillmurray.com/100/100',
        big: 'https://www.fillmurray.com/640/480',
    },
    {
        thumb: 'https://lorempixel.com/100/100/sports/1/',
        big: 'https://lorempixel.com//640/480/sports/1/',
    },
    {
        thumb: 'https://placeimg.com/100/100/tech',
        big: 'https://placeimg.com/640/480/tech',
    },
];

function thA() {
    const thA = document.getElementById("thAul")

    for(let i = 0;i<pics.length;i++){
        thA.innerHTML +=
            `
            <li>
                <img src='kuva.jpg'>
            </li>
            `
    }

}


function thB() {

}


//-----------------------------------------------------------
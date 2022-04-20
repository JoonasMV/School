const apiurl = "https://api.tvmaze.com/search/shows?q="

let apiKysely;

const hakunappi = document.getElementById("hakunappi");
hakunappi.addEventListener("click", teeKysely);

function teeKysely() {
    document.getElementById("sarjat").innerHTML= "";
    let hakusana = document.getElementById("hakuteksti").value;
    apiKysely = apiurl + hakusana;
    console.log(hakusana)
    //Vaihe 1
    console.log("kysely: "+apiKysely)
    teeHaku(apiKysely)
}

function teeHaku(apiKysely) {

    const proxy = 'https://api.allorigins.win/get?url=';
    const haku = apiKysely
    const url = proxy + encodeURIComponent(haku)

    fetch(url)
        .then(response => {
            if (response.ok) return response.json()
            throw new Error('Network response was not ok.')
        })
        .then(data => naytaVastaus(JSON.parse(data.contents)));
}

const head = document.querySelector("main header")

function naytaVastaus(jsonData) {
    for(let i = 0; i<jsonData.length; i++) {
        let art = document.createElement("article");
        let otsikko  = document.createElement("h3")
        let fig = document.createElement("figure")
        let link = document.createTextNode("Linkki kotisivuille")
        let a = document.createElement("a")
        let img = document.createElement("img")
        let summary = document.createElement("summary")
        let det = document.createElement("details")
        let p = document.createElement("p")

        otsikko.innerText = jsonData[i].show.name
        otsikko.setAttribute("id","otsikko")
        img.src = jsonData[i].show.image.medium
        fig.appendChild(img)

        p.innerHTML = jsonData[i].show.summary
        summary.innerText = "Yhteenveto"

        det.appendChild(summary)
        det.appendChild(p)

        a.href = jsonData[i].show.officialSite
        a.appendChild(link)

        art.appendChild(otsikko)
        art.appendChild(fig)
        art.appendChild(det)
        art.appendChild(a)

        head.appendChild(art)
    }
 }
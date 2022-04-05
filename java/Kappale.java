
public class Kappale {

    private String esittaja;
    private String nimi;
    private int pituusSekunteina;

    public Kappale(String esittaja, String nimi, int pituusSekunteina) {
        this.esittaja = esittaja;
        this.nimi = nimi;
        this.pituusSekunteina = pituusSekunteina;
    }
    
    public String getEsittaja() {
        return this.esittaja;
    }

    public String getNimi() {
        return this.nimi;
    }

    public int getPituusSekunteina() {
        return this.pituusSekunteina;
    }

    
    public boolean equals(Kappale verrattava) {
        // jos muuttujat sijaitsevat samassa paikassa, ovat ne samat
        if (this == verrattava) {
            return true;
        }

        // jos verrattava olio ei ole Paivays-tyyppinen, oliot eivät ole samat
        if (!(verrattava instanceof Kappale)) {
            return false;
        }

        // muunnetaan oli Paivays-olioksi
        Kappale verrattavaKappale = (Kappale) verrattava;

        // jos olioiden oliomuuttujien arvot ovat samat, ovat oliot samat
        if (this.esittaja.equals(verrattavaKappale.esittaja)
                && this.pituusSekunteina == verrattavaKappale.pituusSekunteina
                && this.nimi.equals(verrattavaKappale.nimi)) {
            return true;
        }

        // muulloin oliot eivät ole samat
        return false;
    }

    @Override
    public String toString() {
        return this.esittaja + ": " + this.nimi + " (" + this.pituusSekunteina + " s)";
    }


}

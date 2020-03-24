using System;

public enum Sauce{
    BBQ,
    ketchup,
    Mayo,
    Blanche,
    Biggy
}

public enum Complement{
    Poisson,
    Kebab,
    Cordon_Bleu,
    Steak,
    Poulet
}
public class Kebab {
    
    bool salade;
    bool tomate;
    bool oignons;
    int fromage;
    Sauce complementSauce;
    Complement viande;

    public Kebab(bool salade, bool tomate, bool oignons, Sauce sauce, Complement compl, int fromage){
        this.salade = salade;
        this.tomate = tomate;
        this.oignons = oignons;
        complementSauce = sauce;
        viande = compl;
        this.fromage = fromage;
    }
    public bool isVegetarien(){
            return this.salade && this.tomate && this.oignons ? true : false;
    }

    public bool isPescetarien(){
        return isVegetarien && viande == Complement.Poisson ? true: false;
    }

    public Kebab sansOignons(){
        if (this.oignons) {
            return new Kebab(this.salade,this.tomate,false, this.complementSauce,this.viande, this.fromage);  
        }
        return new Kebab(this.salade,this.tomate,this.oignons,this.complementSauce,this.viande, this.fromage);
    }

    public Kebab supplementFromage(){
        this.fromage++;
        return new Kebab(this.salade,this.tomate,this.oignons,this.complementSauce,this.viande, this.fromage);

    }

}
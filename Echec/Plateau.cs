public class Plateau {

    private IPiece piece;
    public Plateau(IPiece piece){
        this.piece = piece;
    }

    public void mouvementSurLePlateau(){
        piece.deplacement();

    }


}
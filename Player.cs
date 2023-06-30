public class Player {
    public int guess {get; set;}
    public string name {get;set;}

    public bool hasWonAGame {get; set;}

    //Constructors
    public Player() {
        guess = 0;
        name = "";
    }
    public Player (string n) {
        name = n;
    }

    //methods
}
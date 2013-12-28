package src;

public abstract class Individu extends ElementMap{
	
	//attributs
	private int pv;
	private int satiete;
	private int compteurTemps;
	private boolean herbivore;
	private boolean carnivore;
	private String tribu;
	private int puissance;
	private int resistance;
	private int vitesse;
	private int direction;
	
	//méthodes
	public Individu(){}
	
	public Individu(int posX, int posY){
		super( posX,  posY);
		direction = 0;
		satiete = 100;
		compteurTemps = 0;
		
	}

	public int getPv() {
		return pv;
	}

	public void setPv(int pv) {
		this.pv = pv;
	}

	public int getSatiete() {
		return satiete;
	}

	public void setSatiete(int satiete) {
		this.satiete = satiete;
	}

	public int getCompteurTemps() {
		return compteurTemps;
	}

	public void setCompteurTemps(int compteurTemps) {
		this.compteurTemps = compteurTemps;
	}

	public boolean isHerbivore() {
		return herbivore;
	}

	public void setHerbivore(boolean herbivore) {
		this.herbivore = herbivore;
	}

	public boolean isCarnivore() {
		return carnivore;
	}

	public void setCarnivore(boolean carnivore) {
		this.carnivore = carnivore;
	}

	public String getTribu() {
		return tribu;
	}

	public void setTribu(String tribu) {
		this.tribu = tribu;
	}

	public int getPuissance() {
		return puissance;
	}

	public void setPuissance(int puissance) {
		this.puissance = puissance;
	}

	public int getResistance() {
		return resistance;
	}

	public void setResistance(int resistance) {
		this.resistance = resistance;
	}

	public int getVitesse() {
		return vitesse;
	}

	public void setVitesse(int vitesse) {
		this.vitesse = vitesse;
	}

	public int getDirection() {
		return direction;
	}

	public void setDirection(int direction) {
		this.direction = direction;
	}
	

}

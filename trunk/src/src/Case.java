package src;
import java.util.ArrayList;


public class Case {
	
	private Individu individu;
	private Fond fond;
	private ArrayList<Pheromone> pheromones;
	private ArrayList<ObjetMap> objets;
	
	
	public Case(){ 
		
	}


	public Individu getIndividu() {
		return individu;
	}


	public void setIndividu(Individu individu) {
		this.individu = individu;
	}


	public Fond getFond() {
		return fond;
	}


	public void setFond(Fond fond) {
		this.fond = fond;
	}


	public ArrayList<Pheromone> getPheromones() {
		return pheromones;
	}


	public void setPheromones(ArrayList<Pheromone> pheromones) {
		this.pheromones = pheromones;
	}


	public ArrayList<ObjetMap> getObjet() {
		return objets;
	}


	public void setObjet(ArrayList<ObjetMap> objets) {
		this.objets = objets;
	}
	
	
}

package src;

public class Pheromone  extends ElementMap{
	
	//attributs
	protected int intensite;
	protected int direction;
	
	//méthodes
	public Pheromone(int posX, int posY, int dir, int intens){
		super( posX,  posY);
		intensite = intens;
		direction = dir;
		collision = true;
		sprite = null;
	}

	public int getIntensite() {
		return intensite;
	}

	public void setIntensite(int intensite) {
		this.intensite = intensite;
	}

	public int getDirection() {
		return direction;
	}

	public void setDirection(int direction) {
		this.direction = direction;
	}
	
	
}

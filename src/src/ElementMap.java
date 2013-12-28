package src;

public class ElementMap {
	
	
	//attributs
	protected String sprite;
	protected boolean collision;
	protected int x;
	protected int y;
	
	//méthodes
	public ElementMap(){

	}
	
	public String getSprite() {
		return sprite;
	}

	public void setSprite(String sprite) {
		this.sprite = sprite;
	}

	public boolean isCollision() {
		return collision;
	}

	public void setCollision(boolean collision) {
		this.collision = collision;
	}

	public int getX() {
		return x;
	}

	public void setX(int x) {
		this.x = x;
	}

	public int getY() {
		return y;
	}

	public void setY(int y) {
		this.y = y;
	}

	
	public ElementMap(int posX, int posY){
		x = posX;
		y = posY;
	}
	
	public void setElementToMap(){
		
	}

}

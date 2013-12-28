package src;
public class Fond extends ElementMap{
	//attributs
	private TypeFond type;
	
	//methodes
	public Fond(int posX, int posY, TypeFond t){
		super( posX,  posY);
		type = t;
	}

	public TypeFond getType() {
		return type;
	}

	public void setType(TypeFond type) {
		this.type = type;
	}
	
}

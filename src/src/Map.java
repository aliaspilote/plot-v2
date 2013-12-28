package src;
import java.util.ArrayList;
import java.util.Hashtable;


public class Map {
	
	//attribut
	private ArrayList<ArrayList<Case>> map ;
	private int size;
	private String name;
	
	//méthodes	
	private Map(int size){	
		this.size = size;
		map = new ArrayList<ArrayList<Case>>(size);
		for (ArrayList<Case> sousMap : map) {
			sousMap = new ArrayList<Case>(size);
			for (Case c : sousMap) {
				c = new Case();
			}
		}
		}
	
	public ArrayList<ArrayList<Case>> getMap() {
		return map;
	}

	public void setMap(ArrayList<ArrayList<Case>> map) {
		this.map = map;
	}

	public int getSize() {
		return size;
	}

	public void setSize(int size) {
		this.size = size;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	
	

}

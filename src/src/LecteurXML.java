package src;
import java.io.*;
import java.util.ArrayList;
import org.jdom2.*;
import org.jdom2.output.*;


public class LecteurXML {
	
	//methodes
	
	public LecteurXML(){
		
	}
	
	public void addChildTo(Element parent, String nodeName, int i){
		Element childNode = new Element(nodeName);
		childNode.setText(Integer.toString(i));
		parent.addContent(childNode);
	}
	
	public void addChildTo(Element parent, String nodeName, String s){
		Element childNode = new Element(nodeName);
		childNode.setText(s);
		parent.addContent(childNode);
	}
	
	public void addChildTo(Element parent, String nodeName, boolean b){
		Element childNode = new Element(nodeName);
		childNode.setText(Boolean.toString(b));
		parent.addContent(childNode);
	}
	
	public void addChildTo(Element parent, String nodeName, TypeFond t){
		Element childNode = new Element(nodeName);
		childNode.setText(t.name());
		parent.addContent(childNode);
	}
	
	//a tester
	public Element ecrireIndividu(Individu i){ 
		Element racine = new Element("Individu");
		
		addChildTo(racine, "PositionX", i.getX());
		addChildTo(racine, "PositionY", i.getY());
		addChildTo(racine, "Collision", i.isCollision());
		addChildTo(racine, "Sprite", i.getSprite());
		addChildTo(racine, "PV", i.getPv());
		addChildTo(racine, "Satiete", i.getSatiete());
		addChildTo(racine, "Herbivore", i.isHerbivore());
		addChildTo(racine, "Carnivore", i.isCarnivore());
		addChildTo(racine, "Puissance", i.getPuissance());
		addChildTo(racine, "Resistance", i.getResistance());
		addChildTo(racine, "Tribu", i.getTribu());
		addChildTo(racine, "Vitesse", i.getVitesse());
		addChildTo(racine, "Direction", i.getDirection());
		
		return racine;
	}
	
	public Element ecrireFond(Fond fond){ 
		Element racine = new Element("Fond");
		addChildTo(racine, "Type", fond.getType());
		addChildTo(racine, "PositionX", fond.getX());
		addChildTo(racine, "PositionY", fond.getY());
		addChildTo(racine, "Collision", fond.isCollision());
		addChildTo(racine, "Sprite", fond.getSprite());
		return racine;
	}
	
	//test ok
	public Element ecrirePheromone(ArrayList<Pheromone> pheromone){ 
		Element racine = new Element("Pheromones");
		
		for (Pheromone p : pheromone) {
			Element phero = new Element("Pheromone");
			
			addChildTo(phero, "PositionX", p.getX());
			addChildTo(phero, "PositionY", p.getY());
			addChildTo(phero, "Intensite", p.getIntensite());
			addChildTo(phero, "Direction", p.getDirection());
			addChildTo(phero, "Collision", p.isCollision());
			
			racine.addContent(phero);
		}
		
		return racine;
	}
	
	public Element ecrireObjetMap(ArrayList<ObjetMap> objets){ 
		Element racine = new Element("Pheromones");
		
		for (ObjetMap p : objets) {
			Element obj = new Element("Pheromone");
			
			addChildTo(obj, "PositionX", p.getX());
			addChildTo(obj, "PositionY", p.getY());
			addChildTo(obj, "Collision", p.isCollision());
			addChildTo(obj, "Sprite", p.getSprite());
			
			racine.addContent(obj);
		}
		
		return racine;
	}
	
	public Element ecrireCase(Case c){ 
		Element racine = new Element("Case");
		
		if (c.getPheromones()!=null){
			Element phero = ecrirePheromone(c.getPheromones());
			racine.addContent(phero);
		}
		
		if (c.getIndividu()!=null){
			Element individu = ecrireIndividu(c.getIndividu());
			racine.addContent(individu);
		}
		
		if (c.getFond()!=null){
			Element fond = ecrireFond(c.getFond());
			racine.addContent(fond);
		}
		
		if (c.getObjet()!=null){
			Element objet = ecrireObjetMap(c.getObjet());
			racine.addContent(objet);
		}
		
		return racine;
	}
	
	public Element ecrireMap(Map map){ 
		Element racine = new Element("Map");
		
		addChildTo(racine, "Size", map.getSize());
		addChildTo(racine, "Name", map.getName());
		
		for (ArrayList<Case> arrayCase : map.getMap()) {
			for (Case case1 : arrayCase) {
				ecrireCase(case1);
			}
		}
		
		return racine;
	}
	

}

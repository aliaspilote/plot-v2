package src;
import java.io.*;

import org.jdom2.*;
import org.jdom2.output.*;

import java.util.ArrayList;
import java.util.Hashtable;

public class XML {
	
	
	//attribut
	private LecteurXML l;
	private static Element racine ;
	private  static org.jdom2.Document document;
	
	//méthodes
	
	public XML(){
		l = new LecteurXML();
		racine = new Element("personne"); 
		document = new Document(racine);
	}
	
	public void ecrireXML(){
		
		ArrayList<Pheromone> tab = new ArrayList<Pheromone>();
		
		Pheromone p1 = new Pheromone(0,0,2,1);
		Pheromone p2 = new Pheromone(0,1,3,2);
		Pheromone p3 = new Pheromone(1,0,4,3);
		Pheromone p4 = new Pheromone(1,1,5,4);
		
		tab.add(p1);
		tab.add(p2);
		tab.add(p3);
		tab.add(p4);
		
		Hashtable<String,String> tab2 = new Hashtable<String,String>();
		tab2.put("e", "gggg");
					
		Element phero = l.ecrirePheromone(tab);
		racine.addContent(phero);
		
//	      Element etudiant = new Element("etudiant");
//	      racine.addContent(etudiant);
//
//	      
//	      Attribute classe = new Attribute("classe","P2");
//	      etudiant.setAttribute(classe);
//
//	      
//	      Element nom = new Element("nom");
//	      nom.setText("CynO");
//	      etudiant.addContent(nom);

	      affiche();
	      enregistre("Exercice1.xml");

	}
	
	public static void affiche()
	{
	   try
	   {
	      //On utilise ici un affichage classique avec getPrettyFormat()
	      XMLOutputter sortie = new XMLOutputter(Format.getPrettyFormat());
	      sortie.output(document, System.out);
	   }
	   catch (java.io.IOException e){}
	}

	public static void enregistre(String fichier)
	{
	   try
	   {
	      //On utilise ici un affichage classique avec getPrettyFormat()
	      XMLOutputter sortie = new XMLOutputter(Format.getPrettyFormat());
	      //Remarquez qu'il suffit simplement de créer une instance de FileOutputStream
	      //avec en argument le nom du fichier pour effectuer la sérialisation.
	      sortie.output(document, new FileOutputStream(fichier));
	   }
	   catch (java.io.IOException e){}
	}


}

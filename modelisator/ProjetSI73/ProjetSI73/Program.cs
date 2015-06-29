using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetSI73;
using ProjetSI73.AbstractFactory;
using ProjetSI73.Builder;
using ProjetSI73.Prototype;
using ProjetSI73.FactoryMethod;
using ProjetSI73.Singleton;
using ProjetSI73.Adapter;
using ProjetSI73.Bridge;
using ProjetSI73.Composite;
using ProjetSI73.Decorator;
using ProjetSI73.Observer;
using ProjetSI73.Strategy;
using ProjetSI73.Facade;
using ProjetSI73.Flyweight;
using ProjetSI73.Mementoo;
using ProjetSI73.Proxy;
using ProjetSI73.ChainOfResponsibility;
using ProjetSI73.Command;
using ProjetSI73.Interpreter;
using ProjetSI73.Iterator;
using ProjetSI73.Mediator;
using ProjetSI73.State;
using ProjetSI73.TemplateMethod;
using ProjetSI73.Visitor;


namespace ProjetSI73
{
    
    class Program
    {   public static int nbAutos = 3;
        public static int nbScooters = 2;
        void testAbstractFactory()
        {
          

        
            FabriqueVehicule fabrique;
            Automobile[] autos = new Automobile[nbAutos];
            Scooter[] scooters = new Scooter[nbScooters];
            Console.WriteLine("Voulez-vous utiliser " +
              "des véhicules électriques (1) ou à essence (2) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                fabrique = new FabriqueVehiculeElectricite();
            }
            else
            {
                fabrique = new FabriqueVehiculeEssence();
            }
            for (int index = 0; index < nbAutos; index++)
                autos[index] = fabrique.creeAutomobile("standard",
                  "jaune", 6 + index, 3.2);
            for (int index = 0; index < nbScooters; index++)
                scooters[index] = fabrique.creeScooter("classic",
                  "rouge", 2 + index);
            foreach (Automobile auto in autos)
                auto.afficheCaracteristiques();
            foreach (Scooter scooter in scooters)
                scooter.afficheCaracteristiques();

        }


        void testBuilder()
        {
            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine("Voulez-vous construire " +
              "des liasses HTML (1) ou PDF (2) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }
            ProjetSI73.Builder.Vendeur vendeur = new ProjetSI73.Builder.Vendeur(constructeur);
            ProjetSI73.Builder.Liasse liasse = vendeur.construit("Martin");
            liasse.imprime();
        }

        void testPrototype()
        {
            LiasseVierge liasseVierge = LiasseVierge.Instance();
            liasseVierge.ajoute(new BonDeCommande());
            liasseVierge.ajoute(new CertificatCession());
            liasseVierge.ajoute(new DemandeImmatriculation());
            // création d’une nouvelle liasse pour deux clients
            LiasseClient liasseClient1 = new LiasseClient(
              "Martin");
            LiasseClient liasseClient2 = new LiasseClient(
              "Durant");
            liasseClient1.affiche();
            liasseClient2.affiche();
        }

        void testFactoryMethod()
        {
            Client client;
            client = new ClientComptant();
            client.nouvelleCommande(2000.0);
            client.nouvelleCommande(10000.0);
            client = new ClientCredit();
            client.nouvelleCommande(2000.0);
            client.nouvelleCommande(10000.0);
        }

        void testSingleton()
        {
           
        // initialisation du vendeur du système
        ProjetSI73.Singleton.Vendeur leVendeur = ProjetSI73.Singleton.Vendeur.Instance();
        leVendeur.nom = "Vendeur Auto";
        leVendeur.adresse = "Paris";
        leVendeur.email = "vendeur@vendeur.com";
        // affichage du vendeur du système
        affiche();

       
        }

        void affiche()
          {
            ProjetSI73.Singleton.Vendeur leVendeur = ProjetSI73.Singleton.Vendeur.Instance();
            leVendeur.affiche();
          }
        

        void testAdapter()
        {
            
            ProjetSI73.Adapter.Document document1, document2;
            document1 = new DocumentHtml();
            document1.contenu="Hello";
            document1.dessine();
            Console.WriteLine();
            document2 = new DocumentPdf();
            document2.contenu="Bonjour";
            document2.dessine();
        }

        void testBridge()
        {
            FormImmatriculationLuxembourg formulaire1 = new
              FormImmatriculationLuxembourg(new FormHtmlImpl());
            formulaire1.affiche();
            if (formulaire1.gereSaisie())
                formulaire1.genereDocument();
            Console.WriteLine();
            FormImmatriculationFrance formulaire2 = new
              FormImmatriculationFrance(new FormAppletImpl());
            formulaire2.affiche();
            if (formulaire2.gereSaisie())
                formulaire2.genereDocument();
        }

        void testComposite()
        {
            ProjetSI73.Composite.Societe societe1 = new ProjetSI73.Composite.SocieteSansFiliale();
            societe1.ajouteVehicule();
            ProjetSI73.Composite.Societe societe2 = new ProjetSI73.Composite.SocieteSansFiliale();
            societe2.ajouteVehicule();
            societe2.ajouteVehicule();
            ProjetSI73.Composite.Societe groupe = new ProjetSI73.Composite.SocieteMere();
            groupe.ajouteFiliale(societe1);
            groupe.ajouteFiliale(societe2);
            groupe.ajouteVehicule();
            Console.WriteLine(
              " Coût d’entretien total du groupe : " +
              groupe.calculeCoutEntretien());
        }


        void testDecorator()
        {
            ProjetSI73.Decorator.VueVehicule vueVehicule = new ProjetSI73.Decorator.VueVehicule();
            ModeleDecorateur modeleDecorateur = new
              ModeleDecorateur(vueVehicule);
            MarqueDecorateur marqueDecorateur = new
              MarqueDecorateur(modeleDecorateur);
            marqueDecorateur.affiche();
        }


        void testObserver()
        {
            ProjetSI73.Observer.Vehicule vehicule = new ProjetSI73.Observer.Vehicule();
            vehicule.description = "Vehicule bon marché";
            vehicule.prix = 5000.0;
            ProjetSI73.Observer.VueVehicule vueVehicule = new ProjetSI73.Observer.VueVehicule(vehicule);
            vueVehicule.redessine();
            vehicule.prix = 4500.0;
            ProjetSI73.Observer.VueVehicule vueVehicule2 = new ProjetSI73.Observer.VueVehicule(vehicule);
            vehicule.prix = 5500.0;
           
        }


        void testStrategy()
        {
            VueCatalogue vueCatalogue1 = new VueCatalogue(new
              DessinTroisVehiculesLigne());
            vueCatalogue1.dessine();
            VueCatalogue vueCatalogue2 = new VueCatalogue(new
              DessinUnVehiculeLigne());
            vueCatalogue2.dessine();
        }

        void testFacade()
        {
            
            WebServiceAuto webServiceAuto = new
            WebServiceAutoImpl();
            Console.WriteLine(webServiceAuto.document(0));
            Console.WriteLine(webServiceAuto.document(1));
            IList<string> resultats =
              webServiceAuto.chercheVehicules(6000, 1000);
            if (resultats.Count > 0)
            {
              Console.WriteLine(
                "Véhicule(s) dont le prix est compris entre 5000 et 7000");
              foreach (string resultat in resultats)
                Console.WriteLine("   " + resultat);
            }
        }



        void testFlyweight()
        {
            FabriqueOption fabrique = new FabriqueOption();
            VehiculeCommande vehicule = new VehiculeCommande();
            vehicule.ajouteOptions("air bag", 80, fabrique);
            vehicule.ajouteOptions("direction assistée", 90,
              fabrique);
            vehicule.ajouteOptions("vitres électriques", 85,
              fabrique);
            vehicule.afficheOptions();
        }



        void testMemento()
        {
            Memento memento;
            ProjetSI73.Mementoo.OptionVehicule option1 = new ProjetSI73.Mementoo.OptionVehicule(
              "Sièges en cuir");
            ProjetSI73.Mementoo.OptionVehicule option2 = new ProjetSI73.Mementoo.OptionVehicule(
              "Accoudoirs");
            ProjetSI73.Mementoo.OptionVehicule option3 = new ProjetSI73.Mementoo.OptionVehicule(
              "Sièges sportifs");
            option1.ajouteOptionIncompatible(option3);
            option2.ajouteOptionIncompatible(option3);
            ChariotOption chariotOptions = new ChariotOption();
            chariotOptions.ajouteOption(option1);
            chariotOptions.ajouteOption(option2);
            chariotOptions.affiche();
            memento = chariotOptions.ajouteOption(option3);
            chariotOptions.affiche();
            chariotOptions.annule(memento);
            chariotOptions.affiche();
        }

        void testProxy()
        {
            Animation animation = new AnimationProxy();
            animation.dessine();
            animation.clic();
            animation.dessine();
        }

        void testChainOfResposibility()
        {
            ObjetBase vehicule1 = new ProjetSI73.ChainOfResponsibility.Vehicule(
            "Auto++ KT500 Véhicule d’occasion en bon état ");
            Console.WriteLine(vehicule1.donneDescription());
            ObjetBase modele1 = new Modele("KT400",
              "Le véhicule spacieux et confortable");
            ObjetBase vehicule2 = new ProjetSI73.ChainOfResponsibility.Vehicule(null);
            vehicule2.suivant = modele1;
            Console.WriteLine(vehicule2.donneDescription());
            ObjetBase marque1 = new Marque("Auto++",
              "La marque des autos", "de grande qualité");
            ObjetBase modele2 = new Modele("KT700", null);
            modele2.suivant = marque1;
            ObjetBase vehicule3 = new ProjetSI73.ChainOfResponsibility.Vehicule(null);
            vehicule3.suivant = modele2;
            Console.WriteLine(vehicule3.donneDescription());
            ObjetBase vehicule4 = new ProjetSI73.ChainOfResponsibility.Vehicule(null);
            Console.WriteLine(vehicule4.donneDescription());
        }


        void testCommand()
        {
            ProjetSI73.Command.Vehicule vehicule1 = new ProjetSI73.Command.Vehicule("A01", 1, 1000.0);
            ProjetSI73.Command.Vehicule vehicule2 = new ProjetSI73.Command.Vehicule("A11", 6, 2000.0);
            ProjetSI73.Command.Vehicule vehicule3 = new ProjetSI73.Command.Vehicule("Z03", 2, 3000.0);
            ProjetSI73.Command.Catalogue catalogue = new ProjetSI73.Command.Catalogue();
            catalogue.ajoute(vehicule1);
            catalogue.ajoute(vehicule2);
            catalogue.ajoute(vehicule3);
            Console.WriteLine("Affichage du catalogue initial");
            catalogue.affiche();
            Console.WriteLine();
            CommandeSolder commmandeSolder = new CommandeSolder
              (10, 5, 0.1);
            catalogue.lanceCommandeSolder(commmandeSolder);
            Console.WriteLine("Affichage du catalogue après " +
              "exécution de la première commande");
            catalogue.affiche();
            Console.WriteLine();
            CommandeSolder commmandeSolder2 = new CommandeSolder
              (10, 5, 0.5);
            catalogue.lanceCommandeSolder(commmandeSolder2);
            Console.WriteLine("Affichage du catalogue après " +
              "exécution de la seconde commande");
            catalogue.affiche();
            Console.WriteLine();
            catalogue.annuleCommandeSolder(1);
            Console.WriteLine("Affichage du catalogue après " +
              "annulation de la première commande");
            catalogue.affiche();
            Console.WriteLine();
            catalogue.retablitCommandeSolder(1);
            Console.WriteLine("Affichage du catalogue après " +
              "rétablissement de la première commande");
            catalogue.affiche();
            Console.WriteLine();
        }


        void testInterpreter()
        {
            Expression expressionRequete = null;
            Console.Write("Entrez votre requête : ");
            string requete = Console.ReadLine();
            try
            {
                expressionRequete = Expression.analyse(requete);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                expressionRequete = null;
            }
            if (expressionRequete != null)
            {
                Console.WriteLine(
                  "Entrez le texte de description d’un véhicule : ");
                string description = Console.ReadLine();
                if (expressionRequete.evalue(description))
                    Console.WriteLine(
                      "La description répond à la requête");
                else
                    Console.WriteLine(
                      "La description ne répond pas à la requête");
            }
        }

        void testIterator()
        {
            CatalogueVehicule catalogue = new CatalogueVehicule();
            IterateurVehicule iterateur = catalogue.recherche(
              "bon marché");
            ProjetSI73.Iterator.Vehicule vehicule;
            iterateur.debut();
            vehicule = iterateur.item();
            while (vehicule != null)
            {
                vehicule.affiche();
                iterateur.suivant();
                vehicule = iterateur.item();
            }
        }

        void testMediator()
        {
            Formulaire formulaire = new Formulaire();
            formulaire.ajouteControle(new ZoneSaisie("Nom"));
            formulaire.ajouteControle(new ZoneSaisie("Prénom"));
            PopupMenu menu = new PopupMenu("Coemprunteur");
            menu.ajouteOption("sans coemprunteur");
            menu.ajouteOption("avec coemprunteur");
            formulaire.ajouteControle(menu);
            formulaire.menuCoemprunteur = menu;
            Bouton bouton = new Bouton("OK");
            formulaire.ajouteControle(bouton);
            formulaire.boutonOK = bouton;
            formulaire.ajouteControleCoemprunteur(new ZoneSaisie(
              "Nom du coemprunteur"));
            formulaire.ajouteControleCoemprunteur(new ZoneSaisie(
              "Prénom du coemprunteur"));
            formulaire.saisie();
        }

        void testState()
        {
            ProjetSI73.State.Commande commande = new ProjetSI73.State.Commande();
            commande.ajouteProduit(new Produit("véhicule 1"));
            commande.ajouteProduit(new Produit("Accessoire 2"));
            commande.affiche();
            commande.etatSuivant();
            commande.ajouteProduit(new Produit("Accessoire 3"));
            commande.efface();
            commande.affiche();

            ProjetSI73.State.Commande commande2 = new ProjetSI73.State.Commande();
            commande2.ajouteProduit(new Produit("véhicule 11"));
            commande2.ajouteProduit(new Produit("Accessoire 21"));
            commande2.affiche();
            commande2.etatSuivant();
            commande2.affiche();
            commande2.etatSuivant();
            commande2.efface();
            commande2.affiche();
        }

        void testTemplateMethod()
        {

            ProjetSI73.TemplateMethod.Commande commandeFrance = new ProjetSI73.TemplateMethod.CommandeFrance();
            commandeFrance.setMontantHt(10000);
            commandeFrance.calculeMontantTtc();
            commandeFrance.affiche();


            ProjetSI73.TemplateMethod.Commande commandeLuxembourg = new ProjetSI73.TemplateMethod.CommandeLuxembourg();
            commandeLuxembourg.setMontantHt(10000);
            commandeLuxembourg.calculeMontantTtc();
            commandeLuxembourg.affiche();
        }



        void testVisitor()
        {
            ProjetSI73.Visitor.Societe societe1 = new ProjetSI73.Visitor.SocieteSansFiliale("société1",
              "info@societe1.com", "rue de la société 1");
            ProjetSI73.Visitor.Societe societe2 = new ProjetSI73.Visitor.SocieteSansFiliale("société2",
              "info@societe2.com", "rue de la société 2");
            ProjetSI73.Visitor.Societe groupe1 = new ProjetSI73.Visitor.SocieteMere("groupe1",
              "info@groupe1.com", "rue du groupe 1");
            groupe1.ajouteFiliale(societe1);
            groupe1.ajouteFiliale(societe2);
            ProjetSI73.Visitor.Societe societe3 = new ProjetSI73.Visitor.SocieteSansFiliale("société3",
              "info@societe3.com", "rue de la société 3");
            ProjetSI73.Visitor.Societe groupe2 = new ProjetSI73.Visitor.SocieteMere("groupe2",
              "info@groupe2.com", "rue du groupe 2");
            groupe2.ajouteFiliale(groupe1);
            groupe2.ajouteFiliale(societe3);
            groupe2.accepteVisiteur(new VisiteurMailingCommercial
              ());
        }

        static void Main(string[] args)
        {
            Program Prog = new Program();
            //Prog.testAbstractFactory();
            //Prog.testBuilder();
            //Prog.testPrototype();
            //Prog.testFactoryMethod();
            //Prog.testSingleton();
            //Prog.testAdapter();
            //Prog.testBridge();
            //Prog.testComposite();
            //Prog.testDecorator();
            //Prog.testObserver();
            //Prog.testStrategy();
            //Prog.testFacade();
            //Prog.testFlyweight();
            //Prog.testMemento();
            Prog.testProxy();
            //Prog.testChainOfResposibility();
            //Prog.testCommand();
            //Prog.testInterpreter();
            //Prog.testIterator();
            //Prog.testMediator();
            //Prog.testState();
            //Prog.testTemplateMethod();
            //Prog.testVisitor();
        }
    }
}

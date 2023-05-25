using PDF;

// Instanciation d'un poule Ginger
Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);
Poule fanny = new Poule("Fanny", "sussex", 0.91, Taille.XL);

// Affichage de cette poule
ginger.Afficher();

// Instanciation d'un poulailler Poulailler1
Poulailler poulailler1 = new Poulailler("Poulailler 1", 3);

// Ajout de poules dans le poulailler 1
poulailler1.AjoutPoule(ginger);
poulailler1.AjoutPoule(fanny);
poulailler1.AjoutPoule(ginger);

// Affichage du poulailler
poulailler1.Afficher();

// Suppression de la poule n°3, Ginger (doublon)
poulailler1.SupprimerPoule(3);

// Affichage du poulailler
poulailler1.Afficher();

// Vidage du poulailler
poulailler1.Vider();

// Affichage du poulailler
poulailler1.Afficher();
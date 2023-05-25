using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF
{
    /// <summary>
    /// Modélise un poulailler
    /// </summary>
    public class Poulailler
    {
        /// <summary>
        /// Nom du poulailler
        /// </summary>
        string nom;

        /// <summary>
        /// Capacité maximale du poulailler (nombre de poules)
        /// </summary>
        int capaciteMax;

        /// <summary>
        /// Liste des poules présentes dans le poulailler
        /// </summary>
        List<Poule> listePoules = new List<Poule>();

        /// <summary>
        /// Création d'une nouvelle instance d'un objet Poulailler
        /// </summary>
        /// <param name="nomPoulailler">Nom</param>
        /// <param name="capacitePoulailler">Nombre de poules maximum dans un poulailler</param>
        public Poulailler(string nomPoulailler, int capacitePoulailler)
        {
            nom = nomPoulailler;
            capaciteMax = capacitePoulailler;
        }

        /// <summary>
        /// Ajoute une poule au poulailler
        /// </summary>
        /// <param name="p1">Poule à ajouter</param>
        public void AjoutPoule(Poule p1)
        {
            if(listePoules.Count == capaciteMax)
            {
                Console.WriteLine($"Le poulailler {nom} est plein, essayez en un autre ou " +
                    $"créez en un nouveau.");
            }
            else
            {
                listePoules.Add( p1 );
            }
        }

        /// <summary>
        /// Supprime une poule au poulailler
        /// </summary>
        /// <param name="nb">Numéro de la poule à supprimer</param>
        public void SupprimerPoule(int nb)
        {
            listePoules.RemoveAt(nb - 1);
        }

        public void Vider()
        {
            listePoules.Clear();
        }

        /// <summary>
        /// Affiche les poules du poulailler ainsi que le nombre de poules
        /// </summary>
        public void Afficher()
        {
            for (int i=0; i<listePoules.Count; i++)
            {
                Console.Write($"Poule N°{i+1} : "); listePoules[i].Afficher();
            }
            if(listePoules.Count == 0)
            {
                Console.WriteLine($"Le poulailler est vide !");
            }
            Console.WriteLine($"\nNombre de poules : {listePoules.Count}\n");
        }
    }
}

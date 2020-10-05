using System;
using System.Collections.Generic;

namespace B2_Csharp_Dame_Niasse_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            // déclaration de la liste de ville
            List<Ville> listeVille = new List<Ville>();


            //boucle while ref menu utilisateur 
            while (true)
            {
                string choixUtilisateur = MenuUtilisateur();

                if (choixUtilisateur == "1")
                {
                    Ville v = CreateVille();
                    listeVille.Add(v);
                }
                else if (choixUtilisateur == "2")
                {
                    Affiche(listeVille);
                }
                else if (choixUtilisateur == "3")
                {
                   
                }
                else
                {
                    break;

                }
            }
            Console.ReadKey();
        }
        // menu utilisateur
        private static string MenuUtilisateur()
        {
            Console.WriteLine("Bienvenue dans l'appli de gestion des villes");
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. creer une nouvelle ville");
            Console.WriteLine("2. Afficher l'ensemble des villes");
            Console.WriteLine("3.Afficher le nombre total d'habitants");
            string choixUtilisateur = Console.ReadLine();
            return choixUtilisateur;
        }

        //liste ville
        public static void Affiche(List<Ville> Ville)
        {
            // pour chaque ville, on affiche un message
            foreach (Ville v in Ville)
            {
                string message;
                message = CreerMessage(v);
                Console.WriteLine(message);
                Console.WriteLine("---------------------------------");
            }
        }


        //essai de nombre habitant total ( non reussi)
      /*  public static void HbtTot()
        { 
        int NbrHbtTotal = 0;
            
            foreach()
            {
                NbrHbtTotal = NbrHbtTotal + v.NbrHbt;
            }
        } */

        //fonction create Ville
        public static Ville CreateVille()
        {
            // initialisation de la ville et ajout à la liste
            Ville v = new Ville();

            // demande du nom de la ville 
            v.Nom = DemanderNom("Nom :");

            // demande de code postale
            v.CodePostale = DemandeEntier("Code Postale :");

            //demande nombre habitant 
            v.NbrHbt = DemanderEntiers("nombre d'habitant :");


            // construction du message
            string message;
            message = CreerMessage(v);


            // affichage du message
            Console.WriteLine(message);
            return v;
        }

        //fonction creer message
        public static string CreerMessage(Ville v)
        {
            string result;

            result = "Nom : " + v.Nom + " ," + "Code postale : " + v.CodePostale + " ," + "\n" + "Nombre d'habitants : " + v.NbrHbt;


           return result;
        }

        //fonctions verif si code postale et nbr habitant sont des entier
        public static int DemandeEntier(string message)
        {
            Console.WriteLine(message);
            string CodePostale;
           
            CodePostale = Console.ReadLine();
          
            int intValue;
            while (!int.TryParse(CodePostale, out intValue) || intValue < 0)
            {
                Console.WriteLine("la saisie est invalide");
                CodePostale = Console.ReadLine();
            }
          
            return intValue;
        }

        public static int DemanderEntiers(string message)
        {
            Console.WriteLine(message);
            string NbrHbt;
            NbrHbt = Console.ReadLine();
            int intValue;
            

            while (!int.TryParse(NbrHbt, out intValue) || intValue < 0)
            {
                Console.WriteLine("la saisie est invalide");
                NbrHbt = Console.ReadLine();
            }
            return intValue;

        }


        //Fonction ajoutée pour demander le nom de la ville
        public static string DemanderNom (string message)
        {
            Console.WriteLine(message);
            string Nom;
            Nom = "";
            while (string.IsNullOrEmpty(Nom))
            {
                Console.WriteLine("la case Nom est vide veuillez bien saisir le nom de la ville");
                Nom = Console.ReadLine();
            }

            return Nom;
        }

        }
    }


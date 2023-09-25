using System;
using System.Collections.Generic;


namespace programme_console
{
    class program
    {
        static void afficherInfosPeronne(string nom, int age, float taille = 0 )
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour, Vous vous appelez " + nom + " Votre age est " + age + " ans");
            Console.WriteLine($"CONCATENTENER METH2: Bonjour, Vous vous appelez {nom } Votre age est {age} ans");
            Console.WriteLine("Bientôt vous aurez " + (age + 1) + " ans");
            if(taille != 0)
            { 
                Console.WriteLine("Bientôt faites " + taille + " m de hauteur"); 
            }
          

            // bool personneMajeur = age >= 18;
            //  if (personneMajeur)
            //if(age >= 18)
            if (age == 18)
            {
                Console.WriteLine(nom + " Vous êtes tout juste majeur");
            }


            else if (age == 17)
            {
                Console.WriteLine(nom + " vous Serez Bientôt majeur");
            }

            else if ((age >= 12) && (age < 18))
            {
                Console.WriteLine("Vous êtes adolescent");
            }

            else if ((age == 1) || (age == 2))
            {
                Console.WriteLine("Vous êtes un bébé");
            }

            else if (age > 60)
            {
                Console.WriteLine(nom + " vous êtes sénior");
            }

            else if (age > 18)
            {
                Console.WriteLine(nom + " vous êtes majeur");
            }
            else if (age < 10)
            {
                Console.WriteLine(nom + " vous êtes un enfant");
            }
            else
            {
                Console.WriteLine(nom + " vous êtes Mineur");
            }
        }
        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {

                Console.Write(nom + " Quel est ton âge ? ");
                string age_string = Console.ReadLine();


                try
                {
                    age_num = int.Parse(age_string);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'âge ne doit pas être négative");
                    }

                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur : L'âge doit-être supérieure à 0 ");
                    }

                }
                catch
                {
                    Console.WriteLine("Vous devez rentrer une âge valide");
                }
            }
            return age_num;
        }

        static string demanderNom(int numero)
        {

            string nom = "";


            while (nom == "")
            {
                try
                {
                    Console.Write("Quel est ton nom numero " + numero + " ?");
                    nom = Console.ReadLine();
                    nom = nom.Trim(); // pour effacer les espaces
                    if (nom == "")
                    {
                        Console.WriteLine("Rentrer un nom valide");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur: Entrer un nom valide");
                }

            }
            return nom;
        }

        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //// DEMANDER NOM
            //string nom1 = demanderNom(1);
            //string nom2 = demanderNom(2);

            string nom1 = "jean";
            string nom2 = "Paul";


            // DEMANDER L AGE
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);


           // float taille =  

            //// AFFICHER LES RESULTATS 

            afficherInfosPeronne(nom1, age1, 1.75f);
            afficherInfosPeronne(nom1, age1);

            //afficherInfosPeronne(nom1, age1);
            //afficherInfosPeronne(nom2, age2);

            // while => tant que

            //int i = 0;
            //// == ==> comparaison d'égalité (vrai ou faux)
            //while (i <= 10)
            //{
            //    Console.WriteLine("Valeur de i " + i);
            //   // i = i + 1; // incrémente de la valeur de la variable i
            //  //i += 1;
            //      i++;
            //}

            //Console.WriteLine("fin de la boucle, valeur de "+i);

            //const int NB_PERSONNES = 5;// Convention constante valeur qui ne changes pas MAJISCULE

            //for (int i = 0; i< NB_PERSONNES; i++)
            //{
            //    string nom = "personne" + (i+1);
            //    int age = DemanderAge(nom);
            //    afficherInfosPeronne(nom, age);

            //    Console.WriteLine("___");
            //}
        }
    }
}
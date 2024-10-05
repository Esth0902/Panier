// See https://aka.ms/new-console-template for more information

string[] panier = new string[5]; // 5 éléments dans le tableau
int count = 0;
bool continuer = true;

while (continuer) {
    Console.WriteLine("Que souhaitez-vous faire ? ");
    Console.WriteLine("1. Ajouter un fruit");
    Console.WriteLine("2. Retirer un fruit");
    Console.WriteLine("3. Afficher le panier");
    Console.WriteLine("4. Rechercher un fruit");
    Console.WriteLine("5. Quitter");
    Console.Write("Choisissez une option: ");

    string choix = Console.ReadLine();

    switch (choix) {
        case "1":
            if (count < 5) 
            {
                Console.Write("Quel fruit souhaitez-vous ajouter : ");
                string fruit = Console.ReadLine();
                
                if (Array.Exists(panier, element => element == fruit))
                {Console.WriteLine("Ce fruit est déjà dans le panier.");}
                else
                {
                    panier[count] = fruit;
                    count++;
                    Console.WriteLine($"{fruit} a été ajouté au panier.");
                }
            }
            
            else
            {
                Console.WriteLine("Votre panier contient déjà 5 fruits.");
            }
            break;
        
        case "2":
            Console.Write("Quel fruit souhaitez-vous retirer : ");
            string fruitMoins = Console.ReadLine();
                    int index = Array.IndexOf(panier, fruitMoins);

                    if (index != -1)
                    {
                        panier[index] = null;
                        count--;
                        // Réorganiser le panier
                        for (int i = index; i < count; i++)
                        {
                            panier[i] = panier[i + 1];
                        }
                        panier[count] = null; // Nettoyer le dernier élément
                        Console.WriteLine($"{fruitMoins} a été supprimé du panier.");
                    }
                    else
                    {
                        Console.WriteLine("Ce fruit n'est pas dans le panier.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Voici le contenu de votre panier :");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"- {panier[i]}");
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Il n'y a rien dans votre panier.");
                    }
                    break;

                case "4":
                    Console.Write("Quel fruit souhaitez-vous rechercher : ");
                    string fruitARechercher = Console.ReadLine();
                    if (Array.Exists(panier, element => element == fruitARechercher))
                    {
                        Console.WriteLine($"{fruitARechercher} est dans le panier.");
                    }
                    else
                    {
                        Console.WriteLine($"{fruitARechercher} n'est pas dans le panier.");
                    }
                    break;

                case "5":
                    continuer = false;
                    Console.WriteLine("Merci d'avoir joué !");
                    break;

                default:
                    Console.WriteLine("Choix invalide. Veuillez essayer à nouveau.");
                    break;
            }
        }


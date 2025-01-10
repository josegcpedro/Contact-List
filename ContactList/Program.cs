using System;

class Program
{

    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Bienvenue dans votre liste de contact!");
        Console.WriteLine("Donnez votre nom pour commencer!");
        string name = Console.ReadLine();
        Console.WriteLine($"Bonjour {name}, que voulez-vous faire");

        Console.WriteLine("1. Ajouter un contact");
        Console.WriteLine("2. Supprimer un contact");
        Console.WriteLine("3. Modifier un contact");
        Console.WriteLine("4. Quitter");

        string choix = Console.ReadLine();

        switch(choix){
            case "1":
                //ShowContacts();
                break;
            case "2":
                //DeleteAccount();
                break;
            case "3":
                //ModifyAccount();
                break;
            default:
                break;
        }
    }


















}
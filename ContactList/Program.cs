using System;
using System.Collections.Generic;

class Program
{
    static List<Contact> contacts = new List<Contact>();

    static void Main()
    {
        Console.WriteLine("Bienvenue dans votre liste de contact!");
        Console.WriteLine("Donnez votre nom pour commencer!");
        string name = Console.ReadLine();
        Console.WriteLine($"Bonjour {name}, que voulez-vous faire");

        bool quitter = false;
        while (!quitter)
        {
            quitter = Menu();
        }
    }

    static bool Menu()
    {
        Console.WriteLine("1. Ajouter un contact");
        Console.WriteLine("2. Supprimer un contact");
        Console.WriteLine("3. Modifier un contact");
        Console.WriteLine("4. Afficher les contacts");
        Console.WriteLine("5. Quitter");

        string choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                AddContacts();
                break;
            case "2":
                //DeleteAccount();
                break;
            case "3":
                //ModifyAccount();
                break;
            case "4":
                //ShowAccounts();
                break;
            case "5":
                Console.WriteLine("Au revoir !");
                return true; // Quitter la boucle
            default:
                Console.WriteLine("Choix invalide. Essayez à nouveau.");
                break;
        }
        return false;
    }
    static void AddContacts()
    {
        Console.WriteLine("Quel est son prénom?");
        string name = Console.ReadLine();
        Console.WriteLine("Quel est son nom?");
        string lastName = Console.ReadLine();
        Console.WriteLine("Quel est son numero?");
        string number = Console.ReadLine();

        Contact newContact = new Contact(name, lastName, number);

        contacts.Add(newContact);

        Console.WriteLine("Contact ajouté avec succès !");

        Menu();
    }

    static void ShowAccounts()
    {
        Console.WriteLine("Voici le compte:")
    }
}

class Contact
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Number { get; set; }


    public Contact(string name, string lastName, string number)
    {
        Name = name;
        LastName = lastName;
        Number = number;
    }
}

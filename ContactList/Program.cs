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
        Console.WriteLine("4. Retour");
    }


















}
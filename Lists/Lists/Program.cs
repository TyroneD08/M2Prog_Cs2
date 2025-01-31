namespace Lists;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        // Stap 1: Array maken
        string[] characters = {
            "Pac-Man",
            "Luigi",
            "Astro",
            "Solid Snake",
            "Master Chief",
            "Kratos",
            "Sonic the Hedgehog",
            "Link"
        };

        // Stap 2: List maken
        List<string> characterList = new List<string>();

        // Stap 3: Voeg een nieuw character toe aan de List
        characterList.Add("Link");

        // Stap 4: Voeg alle characters uit de array toe aan de List
        foreach (string character in characters)
        {
            characterList.Add(character);
        }

        // Stap 5: Toon alle characters in de List met een for loop
        Console.WriteLine("Characters in the List (using for loop):");
        for (int i = 0; i < characterList.Count; i++)
        {
            Console.WriteLine(characterList[i]);
        }

        // Stap 6: Toon alle characters in de List met een foreach loop
        Console.WriteLine("\nCharacters in the List (using foreach loop):");
        foreach (string character in characterList)
        {
            Console.WriteLine(character);
        }

        List<double> numbers = new List<double>
        {
            100.5,
            342.97,
            54.3,
            299.99,
            225.78
        };

        // Toon alle getallen op het scherm
        Console.WriteLine("Initial numbers in the List:");
        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }

        // Stap 2: Verwijder het hoogste getal (342.97) met Remove
        numbers.Remove(342.97);

        // Toon de lijst na het verwijderen van 342.97
        Console.WriteLine("\nNumbers after removing 342.97:");
        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }

        // Stap 3: Verwijder het eerste getal met RemoveAt
        numbers.RemoveAt(0); // 0 is de index van het eerste getal

        // Toon de lijst na het verwijderen van het eerste getal
        Console.WriteLine("\nNumbers after removing the first element:");
        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }

        S
    }
}
    

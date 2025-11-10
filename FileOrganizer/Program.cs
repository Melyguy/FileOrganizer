using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the folder path to organize:");
        string? folderPath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(folderPath) || !Directory.Exists(folderPath))
        {
            Console.WriteLine("Invalid folder path");
            return;
        }

        FileOrganizer.Organize(folderPath);

        Console.WriteLine("Organization complete!");
    }
}

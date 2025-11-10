using System;
using System.Collections.Generic;
using System.IO;

public static class FileOrganizer
{
    private static readonly Dictionary<string, string> fileCategories = new()
    {
        { ".jpg", "Images" }, { ".png", "Images" }, { ".gif", "Images" },
        { ".mp4", "Videos" }, { ".mov", "Videos" },
        { ".pdf", "Documents" }, { ".docx", "Documents" }, { ".txt", "Documents" },
        { ".zip", "Archives" }, { ".rar", "Archives" },
        { ".exe", "Software" }, {".pptx","Presentation" }, 
        {".xlsx","Spreadsheet" }, {".mp3","Audio" }, {".wav","Audio" }, {".html","WebFiles" }, 
        {".css","WebFiles" }, {".js","WebFiles" }, {".c","CodeFiles" }, {".cpp","CodeFiles" }, 
        {".cs","CodeFiles" }, {".java","CodeFiles" }, {".py","CodeFiles" }, {".rb","CodeFiles" }, 
        {".blend","3DModels" }, {".obj","3DModels" }, {".fbx","3DModels" }, {".glb","3DModels" }, {".gltf","3DModels" },{".blend1", "3DModels"},
        { ".msi", "Installations" }, {".dmg", "Installations" }, {".iso", "Installations"  }
    };
    public static void Organize(string folderPath)
    {
        string[] files = Directory.GetFiles(folderPath);
        foreach (var file in files)
        {
            string extension = Path.GetExtension(file).ToLower();

            if (fileCategories.TryGetValue(extension, out string category))
            {
                string targetDir = Path.Combine(folderPath, category);
                Directory.CreateDirectory(targetDir);

                string fileName = Path.GetFileName(file);
                string destPath = Path.Combine(targetDir, fileName);

                try
                {
                    if (!File.Exists(destPath))
                    {
                        File.Move(file, destPath);
                    }
                    else
                    {
                        Console.WriteLine($"File {fileName} already exists in {category}. Skipping.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error moving file {fileName}: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"No category defined for extension {extension}. Skipping file {Path.GetFileName(file)}.");
            }
        }
    }
}

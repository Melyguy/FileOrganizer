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
        { ".exe", "Software" }, { ".msi", "Software" }
    };

}

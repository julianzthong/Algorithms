using System;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string directory = Directory.GetCurrentDirectory();
        var csFiles = Directory.GetFiles(directory, "*.cs")
            .Where(f => Path.GetFileName(f) != "Program.cs")
            .ToList();

        if (!csFiles.Any())
        {
            Console.WriteLine("No algorithm files found.");
            return;
        }

        Console.WriteLine("Choose a file to run:");
        for (int i = 0; i < csFiles.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileName(csFiles[i])}");
        }

        Console.Write("Enter number: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > csFiles.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        string selectedFile = Path.GetFileNameWithoutExtension(csFiles[choice - 1]);
        Console.WriteLine($"Running {selectedFile}...\n");

        try
        {
            // look for class matching filename + "Solution"
            var typeName = selectedFile + "Solution";
            var type = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase));

            if (type == null)
            {
                Console.WriteLine($"No class named '{typeName}' found in the assembly.");
                return;
            }

            var method = type.GetMethod("Run", BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            if (method == null)
            {
                Console.WriteLine($"No 'Run' method found in {type.Name}.");
                return;
            }

            object instance = null;
            if (!method.IsStatic)
                instance = Activator.CreateInstance(type);

            method.Invoke(instance, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error running file: {ex.Message}");
        }
    }
}

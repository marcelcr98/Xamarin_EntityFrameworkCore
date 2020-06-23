using System;
using System.IO;
using Xamarin.Forms;
using Lab12.Interfaces;
using Lab12.iOS.Implementations;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace Lab12.iOS.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", databaseFileName);
        }
    }
}

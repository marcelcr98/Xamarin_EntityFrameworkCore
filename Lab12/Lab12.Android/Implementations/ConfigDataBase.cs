using System.IO;
using Xamarin.Forms;
using Lab12.Droid.Implementations;
using Lab12.Interfaces;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace Lab12.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}

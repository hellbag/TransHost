using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TransHostApi.Model.Exceptions;

namespace TransHostApi.Model
{
    /// <summary>
    /// Модель аэропорта
    /// </summary>
    public class Airport
    {
        public string Iata { get; set; }
        public Location Location { get; set; }

        public static bool IsIataValid(string iata)
        {
            Regex reg = new Regex("^[a-zA-Z]{3}$");
            return reg.IsMatch(iata);

        }
    }
}
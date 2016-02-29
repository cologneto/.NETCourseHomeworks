using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CountryStatistics
{
    public static class FileOperations
    {
        public const string FilePath = @"D:\DeveloperTrainings\DotNetCourse\.NETCourseHomeworks\CountryStatistics\CountryStatistics\App_Data\CountriesDatabase.txt";
        public static List<Country> ReadCountrysFromDatabase()
        {
            var listOfCountrys = new List<Country>();

            using (StreamReader reader = new StreamReader(FilePath))
            {
                var currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    var currentCountry = currentLine.Split('|');
                    var country = new Country(currentCountry[0].Trim(),
                        currentCountry[1].Trim(),
                        int.Parse(currentCountry[2].Trim()));
                    listOfCountrys.Add(country);

                    currentLine = reader.ReadLine();

                }
            }

            return listOfCountrys;
        }

        public static bool AddCountryToCountryDatabase(Country CountryToAdd)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine(CountryToAdd);
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
       
}
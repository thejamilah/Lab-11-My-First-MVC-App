﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC_Core.Models
{
    public class TimePerson
    {
        /// <summary>
        /// Getting and setting data from csv file placed in models different from example of wwwroot
        /// Models folder holds data
        /// </summary>
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth_Year { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {
            List<TimePerson> people = new List<TimePerson>();
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"Models\personOfTheYear.csv"));
            string[] myFile = File.ReadAllLines(newPath);

            for (int i = 1; i < myFile.Length; i++)
            {
                string[] fields = myFile[i].Split(',');
                people.Add(new TimePerson
                {
                    Year = Convert.ToInt32(fields[0]),
                    Honor = fields[1],
                    Name = fields[2],
                    Country = fields[3],
                    Birth_Year = (fields[4] == "") ? 0 : Convert.ToInt32(fields[4]),
                    DeathYear = (fields[5] == "") ? 0 : Convert.ToInt32(fields[5]),
                    Title = fields[6],
                    Category = fields[7],
                    Context = fields[8],
                });
            }

            List<TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();
            return listofPeople;

        }
    }
}

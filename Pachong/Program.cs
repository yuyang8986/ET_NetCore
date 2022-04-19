using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace Pachong
{
    class Program
    {
        static void Main(string[] args)
        {
            PaOccupationList();
            PaOccupationCategoryList();
        }

        private static void PaOccupationList()
        {
            var url = "http://www.visabureau.com/australia/skilled-occupation-list.aspx";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            List<Occupation> occupations = doc.DocumentNode.SelectNodes("//td/a")
                .Select(s => new Occupation {Name = s.InnerText.Replace("&#39;", "'"), OccupationCategoryId = 1}).ToList();

            foreach (var occupation in occupations)
            {
                //if(occupation.Name.Contains(""))
            }

            string jsons = JsonConvert.SerializeObject(occupations.ToArray());

            //write string to file
            var file = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\OccupationTypes.json";
            if (File.Exists(file))
            {
                System.IO.File.WriteAllText(file, jsons);
            }
            else
            {
                File.Create(file);
                using (System.IO.FileStream fs = System.IO.File.Open(file, System.IO.FileMode.Open))
                {
                    System.IO.File.WriteAllText(file, jsons);

                }
                
            }
        }

        private static void PaOccupationCategoryList()
        {
            var url = " https://www.ato.gov.au/Individuals/Income-and-deductions/Deductions-you-can-claim/Deductions-for-specific-industries-and-occupations/";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            List<OccupationCategory> occupationCategories = doc.DocumentNode.SelectNodes("//li/a").Skip(333).Take(33)
                .Select(s => new OccupationCategory { Name = s.InnerText.Replace(": work-related expenses", "") }).ToList();

            foreach (var occupation in occupationCategories)
            {
                //if(occupation.Name.Contains(""))
            }

            string jsons = JsonConvert.SerializeObject(occupationCategories.ToArray());

            //write string to file
            var file = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\OccupationCategories.json";
            if (File.Exists(file))
            {
                System.IO.File.WriteAllText(file, jsons);
            }
            else
            {
                File.Create(file);
                using (System.IO.FileStream fs = System.IO.File.Open(file, System.IO.FileMode.Open))
                {
                    System.IO.File.WriteAllText(file, jsons);

                }
            }
        }
    }

    class Occupation
    {
        public string Name { get; set; }
        public int OccupationCategoryId { get; set; }
    }

    class OccupationCategory
    {
        public string Name { get; set; }
    }
}

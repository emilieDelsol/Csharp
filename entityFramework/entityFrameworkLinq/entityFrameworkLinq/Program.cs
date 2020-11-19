using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace entityframeworkLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDatabase();
            AnimalDatabaseContext context = new AnimalDatabaseContext();
            foreach (Specie specie in context.Specie)
            {
                MessageBox.Show($"test {specie.SpecieName}", "Useless message box",
                                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                foreach (Specie specie in context.Specie.Include(s =>s.Animals))
            {
                MessageBox.Show($"There is: \n \t{specie.Animals.Count()}  \n\t {specie.SpecieName}", "Useless message box",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                Console.WriteLine(specie.SpecieName);
                Console.WriteLine(specie.Animals.Count());
            }

            /****************************************
             * Premiere solution proposée... Ne me satisfaisait pas.. Voir au dessus la bonne solution .
             * 
            var CougarsAnimalsCount = context.Animals.Where((a) => a.Specie.SpecieName == "Cougars blancs").Count();
            var TigresAnimalsCount = context.Animals.Where((a) => a.Specie.SpecieName == "Tigres blancs").Count();
            var TortuesAnimalsCount = context.Animals.Where((a) => a.Specie.SpecieName == "Tortues albinos").Count();

            Console.WriteLine($"There is: \n \t{CougarsAnimalsCount} cougars  \n\t{TigresAnimalsCount} tigres \n \t and {TortuesAnimalsCount}  turtles");

            MessageBox.Show($"There is: \n \t{CougarsAnimalsCount} cougars  \n\t{TigresAnimalsCount} tigres \n \t and {TortuesAnimalsCount}  turtles", "Useless message box",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            */
            /* La requete sql que je veux: 
            SELECT Count(AnimalId) , SpecieName FROM Animals INNER JOIN Specie ON Specie.SpecieID = Animals.SpecieID GROUP BY Specie.SpecieName
            ******************PAS REUSSI A LA FAIRE ET SURTOUT EN SORTIR DES DONNEES...
                */
         }

        private static void CreateDatabase()
        {
            AnimalDatabaseContext context = new AnimalDatabaseContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Specie cougar = new Specie
            {
                SpecieName = "Cougars blancs"
            };
            cougar.Animals = new List<Animal>();
            for (int i = 0; i < 3; i++)
            {
                cougar.Animals.Add(new Animal { AnimalName = $"cougar{i}" });
            }

            Specie tigre = new Specie
            {
                SpecieName = "Tigres blancs"
            };
            tigre.Animals = new List<Animal>();
            for (int i = 0; i < 100; i++)
            {
                tigre.Animals.Add(new Animal { AnimalName = $"Tigre{i}" });
            }

            Specie tortue = new Specie
            {
                SpecieName = "Tortues albinos"
            };
            tortue.Animals = new List<Animal>();
            for (int i = 0; i < 15; i++)
            {
                tortue.Animals.Add(new Animal { AnimalName = $"Tortue {i}" });
            }

            context.Add(cougar);
            context.Add(tigre);
            context.Add(tortue);

            context.SaveChanges();
        }
    }

      

        
    
}

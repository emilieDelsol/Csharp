using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace atelierEntityFramework

{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new ProcrastinationContext())
            {

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var employee = new Employee
                {
                    Name = "Corentin P"
                };
                employee.Meetings = new List<Meeting>
                {
                    new Meeting { Postponed = true },
                    new Meeting { Postponed = true },
                    new Meeting { Postponed = false }
                };

                var employee2 = new Employee
                {
                    Name = "Geoffroy P"
                };
                employee2.Meetings = new List<Meeting>
                {
                    new Meeting { Postponed = true },
                    new Meeting { Postponed = true },
                    new Meeting { Postponed = true }
                };

                context.Add(employee);
                context.Add(employee2);
                context.SaveChanges();


                //Query to get an Employee Name
                /*
                var EmployeeName = context.Employees.Where((s) => s.Name == "Corentin P");
                foreach(var objet in EmployeeName)
                {
                    Console.WriteLine(objet.Name);
                }
                }
                */

                //Get number of ALL True Postponed Meetings
                var PostponedMeeting = context.Meetings.Count((meeting) => meeting.Postponed);
                Console.WriteLine(PostponedMeeting);

                //Get all Postponed Meetings by Employee
                foreach (Employee employe in context.Employees)
                {
                    var procrastinationRate = employe.Meetings.Count((meeting) => meeting.Postponed) / (double)employe.Meetings.Count();
                    Console.WriteLine(employe.Name + " a pour taux de procrastination : " + (Math.Round(procrastinationRate, 2)) * 100 + " %");

                }

            }



        }


    }

    class ProcrastinationContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder stringBuilder)
        {
            stringBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=Procrastination;Integrated Security = True");
        }
    }

    public class Meeting
    {
        public Guid MeetingId { get; set; }
        public DateTime MeetingDate { get; set; }
        public bool Postponed { get; set; }
    }

    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public String Name { get; set; }
        public ICollection<Meeting> Meetings { get; set; }

    }
}

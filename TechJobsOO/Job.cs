using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            //---------------this doesn't work ----------------//
            //if (Id == ' ')
            //{
            //    return ($" OOPS! This job does not seem to exist");
            //}
            //else
            //{

            //return ($"\nID: {Id} \nName: {Name} \nEmployer: {EmployerName} \nLocation: {EmployerLocation} \nPosition Type: {JobType} \nCore Competency: {JobCoreCompetency} \n");
            //}

            string results = "";

            results += "\nID: " + this.Id;

            //add checks here
            results += "\nName: ";

            if (this.Name == "")
            {
                results += "Data not available.";
            }
            else
            {
                results += this.Name;
            }

            results += "\nEmployer: ";

            if (this.EmployerName.Value == "")
            {
                results += "Data not available.";
            }
            else
            {
                results += this.EmployerName;
            }

            results += "\nLocation: ";

            if (this.EmployerLocation.Value == "")
            {
                results += "Data not available.";
            }
            else
            {
                results += this.EmployerLocation;
            }

            results += "\nPosition Type: ";

            if (this.JobType.Value == "")
            {
                results += "Data not available.";
            }
            else
            {
                results += this.JobType;
            }

            results += "\nCore Competency: ";

            if (this.JobCoreCompetency.Value == "")
            {
                results += "Data not available.";
            }
            else
            {
                results += this.JobCoreCompetency;
            }

            results += "\n";
            return results;
        }
    }
}

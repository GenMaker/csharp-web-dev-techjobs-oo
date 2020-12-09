using System;
namespace TechJobsOO
{
    public class Location : JobField
    {
        public Location(string value) : base()
        {
            Value = value;
        }
        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }


    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));

            Assert.IsTrue(job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job1.EmployerName.Value == "ACME");
            Assert.IsTrue(job1.JobType.Value == "Quality control");
            Assert.IsTrue(job1.JobCoreCompetency.Value == "Persistence");
            Assert.IsTrue(job1.Name == "Product tester");

        }

        //test jobs for equality
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));


            Assert.IsFalse(job1.Id.Equals(job2.Id));

        }

        //test for ToString()
        [TestMethod]
        public void ToStringReturnsBlackLineBeforeAndAfterAJobInfo()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //act
            string data = job1.ToString();

            // assert
            Assert.AreEqual('\n', data[0]);

            // assert last place
            Assert.AreEqual('\n', data[data.Length - 1]);
        }

        [TestMethod]
        public void ToStringHasALabelForEachFieldOnOwnLine()

        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));


            //act
            string data = job1.ToString();

            // assert ID
           
            Assert.IsTrue(data.Contains($"\nID: {job1.Id}"));

            //assert Name
            Assert.IsTrue(data.Contains($"\nName: {job1.Name}"));

            //assert Employer
            Assert.IsTrue(data.Contains($"\nEmployer: {job1.EmployerName}"));

            //assert Location
            Assert.IsTrue(data.Contains($"\nLocation: {job1.EmployerLocation}"));

            //assert Position Type
            Assert.IsTrue(data.Contains($"\nPosition Type: {job1.JobType}"));

            //assert Core Competency
            Assert.IsTrue(data.Contains($"\nCore Competency: {job1.JobCoreCompetency}\n"));

            
        }

        [TestMethod]
        public void ChecksForEmptyFieldsAndDisplaysMessage()
        {
            Job job1 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            //act
            string data1 = job1.ToString();

            //assert string
            Assert.IsTrue(data1.Contains("Name: Data not available."));

            // ----create all teh asserts -------
        }
    }
    

}

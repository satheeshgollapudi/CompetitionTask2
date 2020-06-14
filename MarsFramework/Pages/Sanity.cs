using NUnit.Framework;

namespace MarsFramework.Pages
{
    class Sanity
    {




        public void SanityTest()
        {


            // Create an class and object to call the method
            Profile obj = new Profile();

            //Click on Edit button
          obj.AvailabilityTimeEdit.Click();

            //Availability Hours Edit
           obj.AvailabilityHoursEdit.Click();

            //Salary 
          obj.SalaryEdit.Click();

            //Click on Add New Language button
           //obj.LanBtn.Click();

            //Click on Skill Button
            obj.SkillBtn.Click();

            //Click on Education Tab
            obj.EduBtn.Click();

            //Click on Certificates Tab
            obj.CertiBtn.Click();


            // Create an class and object to call the method
            ManageListings obj1 = new ManageListings();
            //Click on Manage Listings
            obj1.manageListingsLink.Click();


            // Create an class and object to call the method
            ShareSkill obj2 = new ShareSkill();
            //Click on Manage Listings
            obj2.ShareSkillButton.Click();

        }
    }
}
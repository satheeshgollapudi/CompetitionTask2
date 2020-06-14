using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

         [Test]
            public void UserAccount()
            {
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest(" Profile");

                    // Create an class and object to call the method
                    Profile obj = new Profile();
                    obj.EditProfile();
                    test.Log(LogStatus.Pass, "Test Passed");
                    Console.WriteLine("Test Passed");
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.Message);
                    Console.WriteLine("Test Failed");
                }

            }

            [Test]
            public void ServiceListing()
            {
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("ShareSkill");

                    // Create an class and object to call the method
                    Pages.ShareSkill obj = new Pages.ShareSkill();

                    // obj1.EnterShareSkill();
                    obj.EnterShareSkill1();
                    Thread.Sleep(3000);
                    string ExpectedValue = GlobalDefinitions.driver.Title;
                    //Console.WriteLine(ExpectedValue);
                    string ActualValue = "ListingManagement";

                    if (ExpectedValue == ActualValue)
                    {
                        test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                        Console.WriteLine("Test Passed Added a Skill Successfully");

                    }

                    else
                    {

                        test.Log(LogStatus.Fail, "Test Failed Expected not equal");
                        Console.WriteLine("Test Failed not equal");

                    }
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
                    Console.WriteLine("Test Failed");
                }

            }
        
            [Test]
            public void UserManageListings()
            {
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Manage Listings");

                    // Create an class and object to call the method
                    ManageListings obj = new ManageListings();
                     obj.Listings();
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
                    Console.WriteLine("Test Failed");
                }


            }

            [Test]
            public void Sanity()
            {
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Sanity Tests");

                    // Create an class and object to call the method
                    Sanity obj6 = new Sanity();
                    obj6.SanityTest();
                    Console.WriteLine("Test Passed");
                    test.Log(LogStatus.Pass, "Test Passed, Sanity Tests completed Successfully");
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
                    Console.WriteLine("Test Failed");
                }


            }
        }
    }
}
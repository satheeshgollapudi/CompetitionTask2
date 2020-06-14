using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Test
{
    class ProfileTest
    {

        class U : Global.Base
        {
            [Test]
            public void UserAccount1()
            {

                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest(" Profile");

                // Create an class and object to call the method
                Profile obj = new Profile();
                obj.EditProfile();
                test.Log(LogStatus.Pass, "Test Passed");
                Console.WriteLine("Test Passed");
            }
        }
    }
}
  

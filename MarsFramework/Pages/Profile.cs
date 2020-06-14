using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarsFramework
{
    internal class Profile
    {
       
        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//i[@class='large calendar icon']/parent::span/following-sibling::div/span/i")]
        public IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']/option[3]")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour Edit
        [FindsBy(How = How.XPath, Using = "//i[@class='large clock outline check icon']/parent::span/following-sibling::div/span/i")]
        public IWebElement AvailabilityHoursEdit { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']")]
        private IWebElement AvailabilityHoursDropDown { get; set; }

        //Click on Availability Hour 
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']/option[4]")]
        private IWebElement AvailabilityHours { get; set; }



        //Click on salary Edit
        [FindsBy(How = How.XPath, Using = "//i[@class='large dollar icon']/parent::span/following-sibling::div/span/i")]
        public IWebElement SalaryEdit { get; set; }

        //Click on salary Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        private IWebElement SalaryDropdown { get; set; }

        //Click on salary option
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']/option[4]")]
        private IWebElement SalaryOpt { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //Click on Language Tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'language')]")]
        public IWebElement LanBtn { get; set; }


        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//table[@class='ui fixed table']/thead/tr/th[contains(text(),'Language')]/following-sibling::th[2]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement AddLangText { get; set; }

        //Click the ChooseLanguageLevel on text box
        [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Level on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddLang { get; set; }

        //Click on Skills Tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skills')]")]
        public IWebElement SkillBtn { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//select[@class='ui fluid dropdown']")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//select[@class='ui fluid dropdown']/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//span[@class='buttons-wrapper']/input[@value='Add']")]
        private IWebElement AddSkill { get; set; }

        //Click on Education Tab
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']/div//a[contains(text(),'Education')]")]
        public IWebElement EduBtn { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//th[text()='Graduation Year']/following-sibling::th/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']/parent::div/following-sibling::div/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the country level option
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']/parent::div/following-sibling::div/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//select[@name='title']/option[7]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']/option[8]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']/parent::div/parent::div/following-sibling::div/div/input")]
        private IWebElement AddEdu { get; set; }

        //Click on Cetificates Tab
        [FindsBy(How = How.XPath, Using = "//a[text()='Certifications']")]
        public IWebElement CertiBtn { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//th[text()='Certificate']/following-sibling::th[3]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationName']")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']/parent::div/parent::div/following-sibling::div/input[@value='Add']")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        #endregion

        internal void EditProfile()
        {
            Global.GlobalDefinitions.wait(20000);
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");


           //Click on Edit button
              AvailabilityTimeEdit.Click();
            //Select
            AvailabilityTime.Click();
            //Availability option Full Time
              AvailabilityTimeOpt.Click();
            Base.test.Log(LogStatus.Info, "Availability updated");
            Console.WriteLine("Availability updated");



            /* // Actions action = new Actions(GlobalDefinitions.driver);
             // action.MoveToElement(AvailabilityTime).Build().Perform();
              Thread.Sleep(1000);
              //IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("div"));
              IList<IWebElement> AvailableTime = GlobalDefinitions.driver.FindElements(By.XPath("//select[@name='availabiltyType']/option"));
             int count = AvailableTime.Count;
              for (int i = 0; i < count; i++)
              {
                  if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                  {
                      AvailableTime[i].Click();
                      Base.test.Log(LogStatus.Info, "Select the available time");
                      Console.WriteLine(AvailableTime[i].Text);
                      Console.WriteLine(count);

                  }
              }*/
            Thread.Sleep(2000);
              //Availability Edit
              AvailabilityHoursEdit.Click();
             // Availability Hours option
             AvailabilityHoursDropDown.Click();
            //AvailabilityHours ASNeeded
            AvailabilityHours.Click();
            Base.test.Log(LogStatus.Info, "Hours updated");
            Console.WriteLine("Hours updated");

            //Salary 
            SalaryEdit.Click();
              //Choose the option from salary dropdown
              SalaryDropdown.Click();
            //SalaryOpt-More than 1000 per month
            SalaryOpt.Click();
            Base.test.Log(LogStatus.Info, "Earn Target updated");
            Console.WriteLine("Earn Target updated");




            //---------------------------------------------------------
            //Click on Add New Language button
            AddNewLangBtn.Click();
         
            //Enter the Language
            AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

            //Choose Lang
            ChooseLang.Click();
          
            ChooseLangOpt.Click();
          
            AddLang.Click();
            Base.test.Log(LogStatus.Info, "Added Language successfully");
            Console.WriteLine("Added Language successfully");

            //-----------------------------------------------------------

            //Click on Skill Button
            SkillBtn.Click();
      
            //Click on Add New Skill Button
            AddNewSkillBtn.Click();
           
            //Enter the skill 
            AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));
          
            //Click the skill dropdown
           ChooseSkill.Click();
           
            ChooseSkilllevel.Click();
      
            AddSkill.Click();
          
            Base.test.Log(LogStatus.Info, "Added Skills successfully");
            Console.WriteLine("Added Skills successfully");
            //---------------------------------------------------------
            //Click on Education Tab
            EduBtn.Click();
            //Add Education
            AddNewEducation.Click();
            //Enter the University
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

            //Choose Country
            ChooseCountry.Click();
         
            //Choose Country Level
            ChooseCountryOpt.Click();

            //Choose Title
            ChooseTitle.Click();
          
            ChooseTitleOpt.Click();

            //Enter Degree
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

            //Year of Graduation
            DegreeYear.Click();
          
            DegreeYearOpt.Click();
            AddEdu.Click();
          
            Base.test.Log(LogStatus.Info, "Added Education successfully");
            Console.WriteLine("Added Education successfully");

            //-------------------------------------------------
            //Click on Certificates Tab
            CertiBtn.Click();
            //Add new Certificate
            AddNewCerti.Click();

            //Enter Certificate Name
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            //Enter Certified from
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

            //Enter the Year
            CertiYear.Click();
            
            CertiYearOpt.Click();
            AddCerti.Click();
          
            Base.test.Log(LogStatus.Info, "Added Certificate successfully");
            Console.WriteLine("Added Certificate successfully");

            //-----------------------------------------------------



        }
    }
}
    

using MarsProject_WithAnother.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsProject_WithAnother.Feature
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            //Click on profile tab in home page
            Driver.driver.FindElement(By.XPath("//a[text()='Certifications']")).Click();
            Thread.Sleep(2000);
        }

        [Given(@"I add a new Certification details")]
        public void GivenIAddANewCertificationDetails()
        {
            //click on add new certificate tab
            Driver.driver.FindElement(By.XPath("(//div[text()='Add New'])[4]")).Click();
            //entering certification name
            Driver.driver.FindElement(By.XPath("//input[@class='certification-award capitalize']")).SendKeys("ISTQB");
            //entering certification from
            Driver.driver.FindElement(By.XPath("//input[@class='received-from capitalize']")).SendKeys("ISTQB/ANZTB");
            //selecting year of certification
            Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']")).Click();
            SelectElement levelDDList = new SelectElement(Driver.driver.FindElement(By.Name("certificationYear")));
            Thread.Sleep(2000);
            //levelDDList.SelectByValue("2015");
            Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']//following::option[2]")).Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button ']")).Click();
            Thread.Sleep(3000);

        }

        [Then(@"that Certification Details should be displayed on my listings")]
        public void ThenThatCertificationDetailsShouldBeDisplayedOnMyListings()
        {
            Assert.IsTrue(Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]")).Displayed);
        }

        [Then(@"I Click on Edit button on certificate")]
        public void ThenIClickOnEditButtonOnCertificate()
        {
            Thread.Sleep(1500);
            //Click on profile Tab
            Driver.driver.FindElement(By.XPath("//a[text()='Certifications']")).Click();
            //Click on EditPenIcon

            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")).Click();
            //Thread.Sleep(2000);
           Driver.driver.FindElement(By.XPath("//input[@class='certification-award capitalize']")).Clear();

        }

        [Then(@"I edit details to certificate")]
        public void ThenIEditDetailsToCertificate()
        {
            Thread.Sleep(1000);
            //Edit Certificate from ISTQB to Agile
            Driver.driver.FindElement(By.XPath("//input[@class='certification-award capitalize']")).SendKeys("Agile");
            Thread.Sleep(2000);

        }

        [Then(@"I press update button")]
        public void ThenIPressUpdateButton()
        {
            // Click on update button
              Driver.driver.FindElement(By.XPath("//input[@value='Update']")).Click();
            

        }

        [Then(@"I verifiy certificate is updated correctly or not")]
        public void ThenIVerifiyCertificateIsUpdatedCorrectlyOrNot()
        {
            Assert.AreEqual("Agile has been updated to your certification", Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text);
            Thread.Sleep(2000);

        }


        [Then(@"I click on Delete option in certificate list")]
        public void ThenIClickOnDeleteOptionInCertificateList()
        {

            //Click on Delete button
         Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")).Click();

        }

        [Then(@"I check if certificate is deleted or not")]
        public void ThenICheckIfCertificateIsDeletedOrNot()
        {
            Thread.Sleep(1000);
            Assert.AreEqual("Agile has been deleted from your certification", Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text);
            Thread.Sleep(1000);
            Driver.driver.Navigate().Refresh();
            //Thread.Sleep(2000);

            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='Certifications']")));


            //Click on profile tab in home page
            Driver.driver.FindElement(By.XPath("//a[text()='Certifications']")).Click();

            

        }



        [Given(@"user clicks on the description icon under Profile page")]
        public void GivenUserClicksOnTheDescriptionIconUnderProfilePage()
        {

            Thread.Sleep(2000);
            
            //clicking descrption  button
            Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//textarea[@name='value']")).Clear();
        }
        
        [When(@"user add description and save")]
        public void WhenUserAddDescriptionAndSave()
        {
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//textarea[@name='value']")).SendKeys("Hi this is Shalan Lohar I have one year of experience in Software Testing Industry");
            //clicking save button
            Driver.driver.FindElement(By.XPath("(//button[@class='ui teal button'])[2]")).Click();
        }

        [Then(@"That Description should be displayed in Descrption tab")]
        public void ThenThatDescriptionShouldBeDisplayedInDescrptionTab()
        {
            Thread.Sleep(1000);
            Assert.AreEqual("Description has been saved successfully", Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text);
            Thread.Sleep(2000);
        }

        [Then(@"User clicks on description Edit button")]
        public void ThenUserClicksOnDescriptionEditButton()
        {
            //Click on Edit Description Button
            Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]")).Click();
            //Clear the description input box
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Name("value")).Clear();
            Thread.Sleep(2000);

        }

        [Then(@"user edit details on description box")]
        public void ThenUserEditDetailsOnDescriptionBox()
        {
            Driver.driver.FindElement(By.XPath("//textarea[@name='value']")).SendKeys("Hi This is Shalan lohar edited the description Box.");
            Thread.Sleep(2000);
        }

        [When(@"User click on update button")]
        public void WhenUserClickOnUpdateButton()
        {
            // Click on update button
            Driver.driver.FindElement(By.XPath("(//button[@class='ui teal button'])[2]")).Click();
        }


        [Then(@"User verify description is updated correctly or not")]
        public void ThenUserVerifyDescriptionIsUpdatedCorrectlyOrNot()
        {
            Thread.Sleep(1000);
            Assert.AreEqual("Description has been saved successfully", Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text);
                    }
    }
}

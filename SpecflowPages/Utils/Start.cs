using MarsProject_WithAnother.SpecflowPages.Helpers;
using MarsProject_WithAnother.SpecflowPages.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using static MarsProject_WithAnother.SpecflowPages.Helpers.CommonMethods;

namespace MarsProject_WithAnother.SpecflowPages.Utils
{
    [Binding]
    public class Start : Driver
    {
        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();

            //call the SignIn class
            SignIn.SigninStep();
        }

        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            //string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));


            // end test. (Reports)
            //CommonMethods.extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            //CommonMethods.extent.Flush();

            //Close the browser
            driver.Quit();

        }
    }
}


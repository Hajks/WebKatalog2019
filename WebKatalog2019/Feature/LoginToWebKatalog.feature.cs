// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WebKatalog2019.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LoginToWebKatalogs")]
    public partial class LoginToWebKatalogsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LoginToWebKatalog.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LoginToWebKatalogs", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating to WebKatalog login page")]
        public virtual void NavigatingToWebKatalogLoginPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to WebKatalog login page", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
testRunner.Given("the user has an open browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
testRunner.When("the user navigates to login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
testRunner.Then("the \'login\' page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Succesful user login to WebKatalog page")]
        [NUnit.Framework.TestCaseAttribute("demo11", "demo11", null)]
        [NUnit.Framework.TestCaseAttribute("demo12", "demo12", null)]
        [NUnit.Framework.TestCaseAttribute("demo13", "demo13", null)]
        public virtual void SuccesfulUserLoginToWebKatalogPage(string login, string password, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Succesful user login to WebKatalog page", null, exampleTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
testRunner.Given("the user is on the \'login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
testRunner.When(string.Format("the user enters \'{0}\' in the login field", login), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
testRunner.And(string.Format("the user enters \'{0}\' in the password field", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("the user clicks login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.Then("the \'dashboard\' page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
testRunner.And("the logout button should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not succesful user login to WebKatalog Page")]
        [NUnit.Framework.TestCaseAttribute("", "", "any", null)]
        [NUnit.Framework.TestCaseAttribute("notvalidlogin", "", "any", null)]
        [NUnit.Framework.TestCaseAttribute("", "notvalidpassword", "any", null)]
        [NUnit.Framework.TestCaseAttribute("demo12", "", "any", null)]
        [NUnit.Framework.TestCaseAttribute("", "demo12", "any", null)]
        [NUnit.Framework.TestCaseAttribute("demo12", "notvalidpassword", "any", null)]
        [NUnit.Framework.TestCaseAttribute("notvalidlogin", "demo12", "any", null)]
        [NUnit.Framework.TestCaseAttribute("notvalidlogin", "notvalidpassword", "any", null)]
        public virtual void NotSuccesfulUserLoginToWebKatalogPage(string login, string password, string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not succesful user login to WebKatalog Page", null, exampleTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
testRunner.Given("the user is on the \'login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
testRunner.When(string.Format("the user enters \'{0}\' in the login field", login), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.And(string.Format("the user enters \'{0}\' in the password field", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.And("the user clicks login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
testRunner.Then(string.Format("validation \'{0}\' error should be displayed", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Proper validation showing up")]
        [NUnit.Framework.TestCaseAttribute("", "", "emptyloginandpassword", null)]
        [NUnit.Framework.TestCaseAttribute("notvalidlogin", "", "emptypassword", null)]
        [NUnit.Framework.TestCaseAttribute("", "notvalidpassword", "emptylogin", null)]
        [NUnit.Framework.TestCaseAttribute("demo12", "", "emptypassword", null)]
        [NUnit.Framework.TestCaseAttribute("", "demo12", "emptylogin", null)]
        [NUnit.Framework.TestCaseAttribute("demo12", "notvalidpassword", "badloginandpassword", null)]
        [NUnit.Framework.TestCaseAttribute("notvalidlogin", "demo12", "badloginandpassword", null)]
        [NUnit.Framework.TestCaseAttribute("notvalidlogin", "notvalidpassword", "badloginandpassword", null)]
        public virtual void ProperValidationShowingUp(string login, string password, string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Proper validation showing up", null, exampleTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 44
testRunner.Given("the user is on the \'login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
testRunner.When(string.Format("the user enters \'{0}\' in the login field", login), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
testRunner.And(string.Format("the user enters \'{0}\' in the password field", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
testRunner.And("the user clicks login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
testRunner.Then(string.Format("validation \'{0}\' error should be displayed", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
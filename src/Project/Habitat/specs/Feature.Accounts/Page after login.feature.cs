﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PageAfterLoginFeature : Xunit.IUseFixture<PageAfterLoginFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Page after login.feature"
#line hidden
        
        public PageAfterLoginFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Page after login", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(PageAfterLoginFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC1_Define custom page")]
        public virtual void Accounts_PageAfterLogin_UC1_DefineCustomPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC1_Define custom page", new string[] {
                        "Ready"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 6
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table2.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "AfterLoginPage",
                        "/sitecore/content/Habitat/Home/Modules/Feature/Accounts"});
#line 9
 testRunner.And("Value set to item field", ((string)(null)), table2, "And ");
#line 12
 testRunner.When("Actor opens Habitat website on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table3.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 13
 testRunner.And("Actor enteres following data into fields", ((string)(null)), table3, "And ");
#line 16
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("Page URL ends on /Accounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("Accounts title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC2_Define custom page_defined page does not exists")]
        public virtual void Accounts_PageAfterLogin_UC2_DefineCustomPage_DefinedPageDoesNotExists()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC2_Define custom page_defined page does not exists", new string[] {
                        "Ready"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table4.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 24
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table5.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "AfterLoginPage",
                        "/sitecore/content/Habitat/Home/KOV"});
#line 27
 testRunner.And("Value set to item field", ((string)(null)), table5, "And ");
#line 30
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table6.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 31
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table6, "When ");
#line 34
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then("Page URL ends on /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC3_Define custom page_empty value")]
        public virtual void Accounts_PageAfterLogin_UC3_DefineCustomPage_EmptyValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC3_Define custom page_empty value", new string[] {
                        "Ready"});
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table7.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 40
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table8.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "AfterLoginPage",
                        ""});
#line 43
 testRunner.And("Value set to item field", ((string)(null)), table8, "And ");
#line 46
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table9.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 47
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table9, "When ");
#line 50
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("Page URL ends on /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC4_After login page for new registered user")]
        public virtual void Accounts_PageAfterLogin_UC4_AfterLoginPageForNewRegisteredUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC4_After login page for new registered user", new string[] {
                        "Ready"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table10.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "AfterLoginPage",
                        "/sitecore/content/Habitat/Home/Modules/Feature/Accounts"});
#line 56
 testRunner.Given("Value set to item field", ((string)(null)), table10, "Given ");
#line 59
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table11.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 60
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table11, "When ");
#line 63
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("Page URL ends on /Accounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.And("Accounts title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC5_After login behavior for login pop up")]
        public virtual void Accounts_PageAfterLogin_UC5_AfterLoginBehaviorForLoginPopUp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC5_After login behavior for login pop up", new string[] {
                        "Ready"});
#line 69
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table12.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "AfterLoginPage",
                        "/sitecore/content/Habitat/Home/Register"});
#line 70
 testRunner.Given("Value set to item field", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table13.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 73
 testRunner.And("User is registered in Habitat and logged out", ((string)(null)), table13, "And ");
#line 76
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table14.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 78
 testRunner.When("Actor enteres following data into Login form fields", ((string)(null)), table14, "When ");
#line 81
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("Page URL ends on /Register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.And("Register title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC6_Double redirect logic")]
        public virtual void Accounts_PageAfterLogin_UC6_DoubleRedirectLogic()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC6_Double redirect logic", new string[] {
                        "Ready"});
#line 86
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table15.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 87
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table16.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "AfterLoginPage",
                        "/sitecore/content/Habitat/Home/Register"});
#line 90
 testRunner.And("Value set to item field", ((string)(null)), table16, "And ");
#line 93
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table17.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 94
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table17, "When ");
#line 97
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.Then("Habitat website is opened on Main Page /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PageAfterLoginFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PageAfterLoginFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Activities.Specs.StudioTestFramework
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class StudioTestFrameworkWithDeletedResourcesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StudioTestFrameworkWithDeletedResources.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StudioTestFrameworkWithDeletedResources", "\tIn order to test workflows after I have deleted something in warewolf \r\n\tAs a us" +
                    "er\r\n\tI want to create, edit, delete and update tests in a test window", ProgrammingLanguage.CSharp, new string[] {
                        "StudioTestFrameworkWithDeletedResources"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "StudioTestFrameworkWithDeletedResources")))
            {
                Dev2.Activities.Specs.StudioTestFramework.StudioTestFrameworkWithDeletedResourcesFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 8
#line 9
  testRunner.Given("test folder is cleaned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Var Name"});
            table1.AddRow(new string[] {
                        "[[a]]"});
#line 10
  testRunner.And("I have \"Workflow 1\" with inputs as", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ouput Var Name"});
            table2.AddRow(new string[] {
                        "[[outputValue]]"});
#line 13
  testRunner.And("\"Workflow 1\" has outputs as", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Var Name"});
            table3.AddRow(new string[] {
                        "[[rec().a]]"});
            table3.AddRow(new string[] {
                        "[[rec().b]]"});
#line 16
  testRunner.Given("I have \"Workflow 2\" with inputs as", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ouput Var Name"});
            table4.AddRow(new string[] {
                        "[[returnVal]]"});
#line 20
  testRunner.And("\"Workflow 2\" has outputs as", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Var Name"});
            table5.AddRow(new string[] {
                        "[[A]]"});
            table5.AddRow(new string[] {
                        "[[B]]"});
            table5.AddRow(new string[] {
                        "[[C]]"});
#line 23
  testRunner.Given("I have \"Workflow 3\" with inputs as", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ouput Var Name"});
            table6.AddRow(new string[] {
                        "[[message]]"});
#line 28
  testRunner.And("\"Workflow 3\" has outputs as", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Var Name"});
            table7.AddRow(new string[] {
                        "[[input]]"});
#line 31
  testRunner.Given("I have \"WorkflowWithTests\" with inputs as", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ouput Var Name"});
            table8.AddRow(new string[] {
                        "[[outputValue]]"});
#line 34
  testRunner.And("\"WorkflowWithTests\" has outputs as", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error",
                        "TestFailing",
                        "TestPending",
                        "TestInvalid",
                        "TestPassed"});
            table9.AddRow(new string[] {
                        "Test1",
                        "Windows",
                        "false",
                        "false",
                        "false",
                        "false",
                        "true"});
            table9.AddRow(new string[] {
                        "Test2",
                        "Windows",
                        "false",
                        "true",
                        "false",
                        "false",
                        "false"});
            table9.AddRow(new string[] {
                        "Test3",
                        "Windows",
                        "false",
                        "false",
                        "false",
                        "true",
                        "false"});
            table9.AddRow(new string[] {
                        "Test4",
                        "Windows",
                        "false",
                        "false",
                        "true",
                        "false",
                        "false"});
#line 37
  testRunner.And("\"WorkflowWithTests\" Tests as", ((string)(null)), table9, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete an Disabled Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFrameworkWithDeletedResources")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StudioTestFrameworkWithDeletedResources")]
        public virtual void DeleteAnDisabledTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete an Disabled Test", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 45
 testRunner.Given("the test builder is open with \"Workflow 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.And("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "TestName",
                        "AuthenticationType",
                        "Error"});
            table10.AddRow(new string[] {
                        "Test1",
                        "Windows",
                        "true"});
#line 49
 testRunner.And("I set Test Values as", ((string)(null)), table10, "And ");
#line 52
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("Tab Header is \"Workflow 3 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("there are 1 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.When("I enable \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("Delete is disabled for \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.When("I disable \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("Delete is enabled for \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("I delete \"Test1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("The \"DeleteConfirmation\" popup is shown I click Ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.Then("there are 0 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete Resource with tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFrameworkWithDeletedResources")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StudioTestFrameworkWithDeletedResources")]
        public virtual void DeleteResourceWithTests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Resource with tests", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 64
 testRunner.Given("I have a resouce \"PluginSource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.And("I add \"test1,test2,test3\" as tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.Then("\"PluginSource\" has 3 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.When("I delete resource \"PluginSource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("\"PluginSource\" has 0 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete folder with resources deletes all tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFrameworkWithDeletedResources")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StudioTestFrameworkWithDeletedResources")]
        public virtual void DeleteFolderWithResourcesDeletesAllTests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete folder with resources deletes all tests", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 71
 testRunner.Given("I have a folder \"Home\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
 testRunner.And("I have a resouce workflow \"PluginSource1\" inside Home", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("I add \"test 1,test 2,test 3\" to \"PluginSource1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("I have a resouce workflow \"Hello bob\" inside Home", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("I add \"test 4,test 5,test 6\" to \"Hello bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.Then("\"PluginSource1\" has 3 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.And("\"Hello bob\" has 3 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.When("I delete folder \"Home\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("\"PluginSource1\" has 0 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.And("\"Hello bob\" has 0 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Save a New Test fails when workflow deleted")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFrameworkWithDeletedResources")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StudioTestFrameworkWithDeletedResources")]
        public virtual void SaveANewTestFailsWhenWorkflowDeleted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save a New Test fails when workflow deleted", ((string[])(null)));
#line 82
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 83
 testRunner.Given("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
 testRunner.And("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.Then("a new test is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.And("Tab Header is \"Workflow 1 - Tests *\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table11.AddRow(new string[] {
                        "a",
                        ""});
#line 90
 testRunner.And("inputs are", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table12.AddRow(new string[] {
                        "outputValue",
                        ""});
#line 93
 testRunner.And("outputs as", ((string)(null)), table12, "And ");
#line 96
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.When("\"Workflow 1\" is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("The \"Workflow Deleted\" popup is shown I click Ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.And("the tab is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Run Selected Test fails when workflow deleted")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFrameworkWithDeletedResources")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StudioTestFrameworkWithDeletedResources")]
        public virtual void RunSelectedTestFailsWhenWorkflowDeleted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Run Selected Test fails when workflow deleted", ((string[])(null)));
#line 102
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 103
 testRunner.Given("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
 testRunner.And("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.Then("a new test is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.And("Tab Header is \"Workflow 1 - Tests *\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table13.AddRow(new string[] {
                        "a",
                        ""});
#line 110
 testRunner.And("inputs are", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table14.AddRow(new string[] {
                        "outputValue",
                        ""});
#line 113
 testRunner.And("outputs as", ((string)(null)), table14, "And ");
#line 116
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.Then("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.When("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.Then("there are 1 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.And("\"Dummy Test\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("I select \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("\"Test 1\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table15.AddRow(new string[] {
                        "a",
                        ""});
#line 126
 testRunner.And("inputs are", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table16.AddRow(new string[] {
                        "outputValue",
                        ""});
#line 129
 testRunner.And("outputs as", ((string)(null)), table16, "And ");
#line 132
 testRunner.And("save is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.When("\"Workflow 1\" is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.And("I run selected test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.Then("The \"Workflow Deleted\" popup is shown I click Ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.And("the tab is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Run All Tests fails when workflow deleted")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StudioTestFrameworkWithDeletedResources")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StudioTestFrameworkWithDeletedResources")]
        public virtual void RunAllTestsFailsWhenWorkflowDeleted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Run All Tests fails when workflow deleted", ((string[])(null)));
#line 138
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 139
 testRunner.Given("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 140
 testRunner.And("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("there are no tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.And("I click New Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.Then("a new test is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.And("Tab Header is \"Workflow 1 - Tests *\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("test name starts with \"Test 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table17.AddRow(new string[] {
                        "a",
                        ""});
#line 146
 testRunner.And("inputs are", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Variable Name",
                        "Value"});
            table18.AddRow(new string[] {
                        "outputValue",
                        ""});
#line 149
 testRunner.And("outputs as", ((string)(null)), table18, "And ");
#line 152
 testRunner.And("save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.When("I save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 154
 testRunner.Then("Tab Header is \"Workflow 1 - Tests\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.And("I close the test builder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.When("the test builder is open with \"Workflow 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 157
 testRunner.Then("there are 1 tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.When("\"Workflow 1\" is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.And("I run all tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.Then("The \"Workflow Deleted\" popup is shown I click Ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 161
 testRunner.And("the tab is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
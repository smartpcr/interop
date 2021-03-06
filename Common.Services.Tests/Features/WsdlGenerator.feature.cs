﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Common.Services.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class WsdlGeneratorFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WsdlGenerator.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WsdlGenerator", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "WsdlGenerator")))
            {
                Common.Services.Tests.Features.WsdlGeneratorFeature.FeatureSetup(null);
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Should Be Able To Generate and Host Dummy Service From Interface with Data Contra" +
            "ct Serializer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WsdlGenerator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("wsdl")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("dynamic_host")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("data_contract_serializer")]
        public virtual void ShouldBeAbleToGenerateAndHostDummyServiceFromInterfaceWithDataContractSerializer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should Be Able To Generate and Host Dummy Service From Interface with Data Contra" +
                    "ct Serializer", new string[] {
                        "wsdl",
                        "dynamic_host",
                        "data_contract_serializer"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("a referenced assembly in bin folder called \'Interop.Contracts.dll\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("Pick an interface with name \'IOrderManager\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("set generated assembly namespace to \"AAMVA.Orders\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "ServiceAddress",
                        "http://localhost:54321/WsdlPublish_DataContract"});
            table1.AddRow(new string[] {
                        "BindingType",
                        "BasicHttpBinding"});
            table1.AddRow(new string[] {
                        "SecurityMode",
                        "None"});
            table1.AddRow(new string[] {
                        "ClientCredentialType",
                        "None"});
#line 8
 testRunner.When("I generate and host service with the following setting", ((string)(null)), table1, "When ");
#line 14
 testRunner.Then("I should be able to download wsdl files to folder \'~\\wsdls\\datacontract\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Should Be Able To Generate and Host Dummy Service From Interface With XML Seriali" +
            "zer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WsdlGenerator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("wsdl")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("dynamic_host")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("xml_serializer")]
        public virtual void ShouldBeAbleToGenerateAndHostDummyServiceFromInterfaceWithXMLSerializer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should Be Able To Generate and Host Dummy Service From Interface With XML Seriali" +
                    "zer", new string[] {
                        "wsdl",
                        "dynamic_host",
                        "xml_serializer"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("a referenced assembly in bin folder called \'Interop.Contracts.dll\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And("Pick an interface with name \'IRegistrationManager\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("set generated assembly namespace to \"AAMVA.Registration\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "ServiceAddress",
                        "http://localhost:54321/DynamicHost_Xml"});
            table2.AddRow(new string[] {
                        "BindingType",
                        "BasicHttpBinding"});
            table2.AddRow(new string[] {
                        "SecurityMode",
                        "None"});
            table2.AddRow(new string[] {
                        "ClientCredentialType",
                        "None"});
#line 21
 testRunner.When("I generate and host service with the following setting", ((string)(null)), table2, "When ");
#line 27
 testRunner.Then("I should be able to download wsdl files to folder \'~\\wsdls\\xml\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

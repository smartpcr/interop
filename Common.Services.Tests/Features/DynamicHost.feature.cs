﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
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
    public partial class DynamicHostFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DynamicHost.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DynamicHost", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "DynamicHost")))
            {
                Common.Services.Tests.Features.DynamicHostFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Dynamic Proxy WSDL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DynamicHost")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("wsdl")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("proxy")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("xml")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("svcutil")]
        public virtual void DynamicProxyWSDL()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dynamic Proxy WSDL", new string[] {
                        "wsdl",
                        "proxy",
                        "xml",
                        "svcutil"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("set serialization method to \'Xml\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("set generated assembly namespace to \"AAMVA.Avattar.Contracts\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("set rehost namespace to \'AAMVA.Avattar.DynamicServices\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("wsdl url \'http://localhost:2526/VehicleSystems/NMVTIS/PerformVehicleHistoryInquir" +
                    "y/Request?wsdl\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I generate wsdl assembly and save them to folder \'wsdl-generated\' with name \'NMVT" +
                    "IS.NM04.EWS.Request.dll\' using SvcUtil", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("I should discover 1 interface with name \'INmvtisPerformVehicleHistoryInquiry\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("there should be a method with name \'SubmitRequest\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "ServiceAddress",
                        "http://localhost:54321/WsdlHost_XML_NMVTIS"});
            table1.AddRow(new string[] {
                        "BindingType",
                        "BasicHttpBinding"});
            table1.AddRow(new string[] {
                        "SecurityMode",
                        "None"});
            table1.AddRow(new string[] {
                        "ClientCredentialType",
                        "None"});
#line 12
 testRunner.And("I rehost services using generated wsdl assembly", ((string)(null)), table1, "And ");
#line 18
 testRunner.And("download metadata from rehost metadata url to folder \'wsdl-gen\\xml\\NMVTIS-EWS\\svc" +
                    "util\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Host WSDL from Static Service Publication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DynamicHost")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("wsdl")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("host")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("xml")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("svcutil")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("static")]
        public virtual void HostWSDLFromStaticServicePublication()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Host WSDL from Static Service Publication", new string[] {
                        "wsdl",
                        "host",
                        "xml",
                        "svcutil",
                        "static"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("set serialization method to \'Xml\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("set generated assembly namespace to \"AAMVA.Avattar.Contracts\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("set rehost namespace to \'AAMVA.Avattar.DynamicServices\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("wsdl url \'http://localhost:54321/NMVTIS_StaticServiceHost/mex\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("I generate wsdl assembly and save them to folder \'wsdl-generated\' with name \'NMVT" +
                    "IS.NM04.EWS.Receive.dll\' using SvcUtil", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("I should discover 1 interface with name \'INmvtisReceiveResponses\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("there should be a method with name \'VehicleHistoryInquiryResponse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "ServiceAddress",
                        "http://localhost:54321/WsdlHost_XML_NMVTIS"});
            table2.AddRow(new string[] {
                        "BindingType",
                        "BasicHttpBinding"});
            table2.AddRow(new string[] {
                        "SecurityMode",
                        "None"});
            table2.AddRow(new string[] {
                        "ClientCredentialType",
                        "None"});
#line 29
 testRunner.And("I rehost services using generated wsdl assembly", ((string)(null)), table2, "And ");
#line 35
 testRunner.And("download metadata from rehost metadata url to folder \'wsdl-gen\\xml\\NMVTIS-EWS\\svc" +
                    "util\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.Then("the assembly used for wsdl host should contain non-wrapped methods", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Host WSDL from Dynamic Service Publication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DynamicHost")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("wsdl")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("host")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("xml")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("svcutil")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("dynamic")]
        public virtual void HostWSDLFromDynamicServicePublication()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Host WSDL from Dynamic Service Publication", new string[] {
                        "wsdl",
                        "host",
                        "xml",
                        "svcutil",
                        "dynamic"});
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
 testRunner.Given("set serialization method to \'Xml\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
 testRunner.And("set generated assembly namespace to \"AAMVA.Avattar.Contracts\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("set rehost namespace to \'AAMVA.Avattar.DynamicServices\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("wsdl url \'http://localhost:54321/NMVTIS_DynamicServiceHost/mex\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.When("I generate wsdl assembly and save them to folder \'wsdl-generated\' with name \'NMVT" +
                    "IS.NM04.EWS.Receive.dll\' using SvcUtil", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.And("I should discover 1 interface with name \'INmvtisReceiveResponses\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("there should be a method with name \'VehicleHistoryInquiryResponse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "ServiceAddress",
                        "http://localhost:54321/WsdlHost_XML_NMVTIS"});
            table3.AddRow(new string[] {
                        "BindingType",
                        "BasicHttpBinding"});
            table3.AddRow(new string[] {
                        "SecurityMode",
                        "None"});
            table3.AddRow(new string[] {
                        "ClientCredentialType",
                        "None"});
#line 47
 testRunner.And("I rehost services using generated wsdl assembly", ((string)(null)), table3, "And ");
#line 53
 testRunner.And("download metadata from rehost metadata url to folder \'wsdl-gen\\xml\\NMVTIS-EWS\\svc" +
                    "util\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.Then("the assembly used for wsdl host should contain non-wrapped methods", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

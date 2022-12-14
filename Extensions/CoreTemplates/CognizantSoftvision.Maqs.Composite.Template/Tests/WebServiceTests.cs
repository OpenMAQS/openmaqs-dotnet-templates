using Maqs.BaseWebServiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.WebService;
using System;
using System.Net.Http;

namespace Tests
{
    /// <summary>
    /// Sample test class
    /// </summary>
    [TestClass]
    public class WebServiceTests : BaseWebServiceTest
    {
        /// <summary>
        /// Get a simple resouce
        /// </summary>
        [TestMethod]
        public void GetResource()
        {
            string result = this.WebServiceDriver.Get("maqs-dotnet-templates/README.md", "text/markdown");

            Assert.IsTrue(result.Contains("MAQS"), "Expected readme to contain the name 'MAQS'");
        }

        /// <summary>
        /// Get single product as XML - Will throw a format exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetXmlDeserialized()
        {
            ProductXml result = this.WebServiceDriver.Get<ProductXml>("/api/XML_JSON/GetProduct/1", MediaType.AppXml, false);

            Assert.AreEqual(1, result.Id, "Expected to get product 1");
        }

        /// <summary>
        /// Get single product as Json - Will throw a request exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void GetJsonDeserialized()
        {
            ProductJson result = this.WebServiceDriver.Get<ProductJson>("/api/XML_JSON/GetProduct/1", MediaType.AppJson, true);

            Assert.AreEqual(1, result.Id, "Expected to get product 1");
        }
    }
}

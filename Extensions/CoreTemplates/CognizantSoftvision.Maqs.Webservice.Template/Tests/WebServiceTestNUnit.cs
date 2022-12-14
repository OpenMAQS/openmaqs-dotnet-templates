using Maqs.BaseWebServiceTest;
using NUnit.Framework;
using System;
using System.Net.Http;
using WebServiceModel;

namespace Tests
{
    /// <summary>
    /// Simple web service test class using NUnit
    /// </summary>
    [TestFixture]
    public class WebServiceTestNUnit : BaseWebServiceTest
    {
        /// <summary>
        /// Get a simple resouce
        /// </summary>
        [Test]
        public void GetResource()
        {
            string result = this.WebServiceDriver.Get("maqs-dotnet-templates/README.md", "text/markdown");

            Assert.IsTrue(result.Contains("MAQS"), "Expected readme to contain the name 'MAQS'");
        }

        /// <summary>
        /// Get single product as XML
        /// </summary>
        [Test]
        public void GetXmlDeserializedNUnit()
        {
            Assert.Throws<InvalidOperationException>(() => this.WebServiceDriver.Get<ProductXml>("/api/XML_JSON/GetProduct/1", "application/xml", false));
        }

        /// <summary>
        /// Get single product as Json
        /// </summary>
        [Test]
        public void GetJsonDeserializedNUnit()
        {
            Assert.Throws<HttpRequestException>(() => this.WebServiceDriver.Get<ProductJson>("/api/XML_JSON/GetProduct/1", "application/json", true));
        }
    }
}

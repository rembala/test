using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1
{
    [TestClass]
    public class Class1
    {
        static TestContext m_tetContext { get; set; }

        [ClassInitialize]
        public static void ClassInit(TestContext con)
        {
            m_tetContext = con;
        }

        [TestMethod]
        //[DeploymentItem("XMLFile1.xml")]
        public void testMethod()
        {
            Assert.IsTrue(File.Exists("XMLFile1.xml"));
            //var codeBaseUrl = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            //var codeBasePath = Uri.UnescapeDataString(codeBaseUrl.AbsolutePath);
            //var dirPath = Path.GetDirectoryName(codeBasePath);
        }
    }
}
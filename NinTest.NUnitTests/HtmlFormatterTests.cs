using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinTest.Basic;

namespace NinTest.NUnitTests
{
    
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEnclosedWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("AbC");

            // Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            // More General
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.Contain("AbC"));
            Assert.That(result, Does.EndWith("</strong>")); 
        }
    }
}

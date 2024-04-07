using NinTest.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.xUnitTests
{
    public class HtmlFormatterTests  
    {
        [Fact]
        public void FormatAsBold_WhenCalled_ShouldEnclosedWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("AbC");

            // Specific
            Assert.Equal("<strong>abc</strong>", result, ignoreCase:true);

            // More General
            Assert.StartsWith("<strong>", result, StringComparison.OrdinalIgnoreCase);
            Assert.Contains("AbC", result, StringComparison.OrdinalIgnoreCase);
            Assert.EndsWith("</strong>", result, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}

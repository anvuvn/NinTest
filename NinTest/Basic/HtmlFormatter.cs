using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.Basic
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string text)
        {
            return $"<strong>{text}</strong>";
        }
    }
}

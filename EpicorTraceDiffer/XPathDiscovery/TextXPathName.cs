using System.Collections.Generic;
using System.Xml.Linq;

namespace EpicorTraceDiffer.XPathDiscovery
{
    internal class TextXPathName : IObjectXpathName
    {
        public string GetXpathName(XObject node, IDictionary<string, string> namespacePrefixes)
        {
            return "text()";
        }
    }
}

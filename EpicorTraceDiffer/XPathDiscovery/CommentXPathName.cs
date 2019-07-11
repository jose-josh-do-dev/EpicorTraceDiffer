using System.Collections.Generic;
using System.Xml.Linq;

namespace EpicorTraceDiffer.XPathDiscovery
{
    internal class CommentXPathName : IObjectXpathName
    {
        public string GetXpathName(XObject node, IDictionary<string, string> namespacePrefixes)
        {
            return "comment()";
        }
    }
}

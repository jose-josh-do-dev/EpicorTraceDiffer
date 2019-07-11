using System.Collections.Generic;
using System.Xml.Linq;

namespace EpicorTraceDiffer.XPathDiscovery
{
    internal class AttributeXPathName : IObjectXpathName
    {
        public string GetXpathName(XObject node, IDictionary<string, string> namespacePrefixes)
        {
            var xAttr = (XAttribute)node;
            string preffix;
            namespacePrefixes.TryGetValue(xAttr.Name.NamespaceName, out preffix);

            return "@" + XpathExtension.BuildXpathName(preffix,
                xAttr.Name.LocalName);
        }
    }
}

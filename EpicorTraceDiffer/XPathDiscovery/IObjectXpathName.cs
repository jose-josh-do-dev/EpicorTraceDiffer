//Eli Algranti Copyright �  2013
using System.Collections.Generic;
using System.Xml.Linq;

namespace EpicorTraceDiffer.XPathDiscovery
{
    internal interface IObjectXpathName
    {
        string GetXpathName(XObject node, IDictionary<string, string> namespacePrefixes);
    }
}

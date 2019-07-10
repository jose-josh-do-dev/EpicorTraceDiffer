using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EpicorTraceDiffer
{
    public class Methods
    {
        public string BO { get; set; }
        public string Method { get; set; }
        public XElement ReturnValue { get; set; }
        public XElement Parameters { get; set; }

        public override string ToString()
        {
            return $"{BO}.{Method}()";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EpicorTraceDiffer
{
    public class Methods: IComparable, IEquatable<Methods>
    {
        public string BO { get; set; }
        public string Method { get; set; }
        public XElement ReturnValue { get; set; }
        public XElement Parameters { get; set; }

        public int CompareTo(object obj)
        {
            Methods o = obj as Methods;

            return $"{this.ToString()}".CompareTo($"{this.ToString()}");
        }

        public override string ToString()
        {
            return $"{BO}.{Method}()";
        }

        bool IEquatable<Methods>.Equals(Methods other)
        {
            return this.Method.CompareTo(other) == 0;
        }
    }
}

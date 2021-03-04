using System.Collections.Generic;
namespace System
{
    public class ReferenceEqualityComparer : EqualityComparer<Object>
    {
        public override bool Equals(object x, object y)
        {
            return ReferenceEquals(x, y);
        }
        public override int GetHashCode(object obj)
        {
            return obj == null 
                ? 0 
                : obj.GetHashCode();
        }
    }

}

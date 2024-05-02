using System.Drawing;

namespace Rose.Resources
{
    public class Utility
    {
        public static Icon BytesToIcon(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b);
            return new Icon(ms);
        }
    }
}

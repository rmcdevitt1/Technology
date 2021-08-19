using System;
namespace Technology
{
    public abstract class AbstractEntity
    {
        internal static int objectIDnumber = -1;

        public abstract int GetObjectId();
    }
}

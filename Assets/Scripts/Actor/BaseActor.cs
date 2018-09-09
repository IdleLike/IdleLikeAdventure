using System;

namespace Actor
{
    public abstract class BaseActor
    {
        private int id;

        public int Id
        {
            get
            {
                return id;
            }

            protected set
            {
                id = value;
            }
        }
    }
}


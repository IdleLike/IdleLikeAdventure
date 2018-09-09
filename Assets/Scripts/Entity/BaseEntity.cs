using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity
{
    [Serializable]
    public class BaseEntity
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



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StaticData.Data
{
    [Serializable]
    public class MultilingualData
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID;
        /// <summary>
        /// 中文
        /// </summary>
        public string CN;
        /// <summary>
        /// 英文
        /// </summary>
        public string EN;
    }
}

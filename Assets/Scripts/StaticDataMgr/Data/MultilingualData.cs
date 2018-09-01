using StaticData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StaticDataMgr.Data
{
    public class MultilingualData : BaseDataObject
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

        public override void ReadFromStream(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}

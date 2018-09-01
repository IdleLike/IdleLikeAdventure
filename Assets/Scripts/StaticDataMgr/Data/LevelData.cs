using StaticData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StaticDataMgr.Data
{
    public class LevelData : BaseDataObject
    {
        /// <summary>
        /// 等级
        /// </summary>
        public ushort Level;
        /// <summary>
        /// 升到下一级所需经验
        /// </summary>
        public uint NextLevelNeedExp;
        /// <summary>
        /// 升到本级所需的总经验
        /// </summary>
        public uint CurrentLevelNeedExp;

        public override void ReadFromStream(BinaryReader br)
        {
            
        }
    }
}

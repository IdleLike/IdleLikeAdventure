using StaticData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StaticData.Data
{
    [Serializable]
    public class CareerData : BaseDataObject
    {
        /// <summary>
        /// 职业ID
        /// </summary>
        public uint CareerID;
        /// <summary>
        /// 职业最大等级
        /// </summary>
        public byte MaxLevel;
        /// <summary>
        /// 职业名称
        /// </summary>
        public string Name;
        /// <summary>
        /// 职业描述
        /// </summary>
        public string Describe;
        /// <summary>
        /// 职业血量成长
        /// </summary>
        public ushort HPGrowth;
        /// <summary>
        /// 职业力量成长
        /// </summary>
        public ushort PowGrowth;
        /// <summary>
        /// 职业敏捷成长
        /// </summary>
        public ushort DexGrowth;
        /// <summary>
        /// 职业体质成长
        /// </summary>
        public ushort ConGrowth;
        /// <summary>
        /// 职业技能集合
        /// </summary>
        public List<uint> AbilityList;

        public override void ReadFromStream(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}

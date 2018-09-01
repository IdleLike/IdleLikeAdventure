using StaticData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StaticData.Data
{
    [Serializable]
    public class RaceData : BaseDataObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name;
        /// <summary>
        /// 描述
        /// </summary>
        public string Describe;
        /// <summary>
        /// 初始血量
        /// </summary>
        public byte InitHP;
        /// <summary>
        /// 初始力量
        /// </summary>
        public byte InitPow;
        /// <summary>
        /// 初始敏捷
        /// </summary>
        public byte InitDex;
        /// <summary>
        /// 初始体质
        /// </summary>
        public byte InitCon;
        /// <summary>
        /// 种族血量成长
        /// </summary>
        public ushort HPGrowth;
        /// <summary>
        /// 种族力量成长
        /// </summary>
        public ushort PowGrowth;
        /// <summary>
        /// 种族敏捷成长
        /// </summary>
        public ushort DexGrowth;
        /// <summary>
        /// 种族体质成长
        /// </summary>
        public ushort ConGrowth;
        /// <summary>
        /// 种族技能一ID
        /// </summary>
        public byte AbilityOneID;
        /// <summary>
        /// 种族技能二ID
        /// </summary>
        public byte AbilityTwoID;



        public override void ReadFromStream(BinaryReader br)
        {
            
        }
    }
}

using StaticData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StaticData.Data
{
    [Serializable]
    public class RaceAbilityData : BaseDataObject
    {
        /// <summary>
        /// 种族技能ID
        /// </summary>
        public uint AbilityID;
        /// <summary>
        /// 种族技能名称
        /// </summary>
        public string AbilityName;
        /// <summary>
        /// 种族技能描述
        /// </summary>
        public string AbilityDescribe;


        public override void ReadFromStream(BinaryReader br)
        {
            
        }
    }
}

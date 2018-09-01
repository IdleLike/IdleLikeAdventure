using StaticData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StaticData.Data
{
    [Serializable]
    public class CareerAbilityData:BaseDataObject
    {
        public override void ReadFromStream(BinaryReader br)
        {
            
        }
        /// <summary>
        /// 职业技能ID
        /// </summary>
        public uint AbilityID;
        /// <summary>
        /// 职业技能描述
        /// </summary>
        public string AbilityDescribe;
        /// <summary>
        /// 职业技能名称
        /// </summary>
        public string AbilityName;
        /// <summary>
        /// 技能类型(被动、主动)
        /// </summary>
        public byte AbilityType;

    }
}

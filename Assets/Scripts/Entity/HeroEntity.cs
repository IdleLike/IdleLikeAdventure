using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StaticData.Data;

namespace Entity
{
    public class HeroEntity : BaseEntity
    {
        //  战斗属性
        private int maxHP;
        private int maxMP;
        private uint exp;
        private uint pow;
        private uint dex;
        private uint con;

        //  配置信息
        private CareerData careerData;
        private RaceData raceData;
        //  技能数据
        private List<RaceAbilityData> raceAbilitys;
        private List<CareerAbilityData> careerAbilities;

        public int MaxHP
        {
            get
            {
                return maxHP;
            }

            set
            {
                maxHP = value;
            }
        }

        public int MaxMP
        {
            get
            {
                return maxMP;
            }

            set
            {
                maxMP = value;
            }
        }

        public uint Exp
        {
            get
            {
                return exp;
            }

            set
            {
                exp = value;
            }
        }

        public uint Pow
        {
            get
            {
                return pow;
            }

            set
            {
                pow = value;
            }
        }

        public uint Dex
        {
            get
            {
                return dex;
            }

            set
            {
                dex = value;
            }
        }

        public uint Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public CareerData CareerData
        {
            get
            {
                return careerData;
            }

            set
            {
                careerData = value;
            }
        }

        public RaceData RaceData
        {
            get
            {
                return raceData;
            }

            set
            {
                raceData = value;
            }
        }

        public List<RaceAbilityData> RaceAbilitys
        {
            get
            {
                return raceAbilitys;
            }

            set
            {
                raceAbilitys = value;
            }
        }

        public List<CareerAbilityData> CareerAbilities
        {
            get
            {
                return careerAbilities;
            }

            set
            {
                careerAbilities = value;
            }
        }


        public int Level
        {
            get
            {
                //TODO 实现根据总经验，计算等级
                return 0;
            }
        }
    }
}


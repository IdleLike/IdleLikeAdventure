using Actor;
using StaticData;
using StaticData.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : BaseActor
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
            LevelData LevelData = new LevelData();
            LevelData LevelDataNext = new LevelData();
            for (uint i = 0; i < StaticDataMgr.mInstance.mLevelDataMap.Count; i++)
            {
                if(Exp > StaticDataMgr.mInstance.mLevelDataMap[i].NextLevelNeedExp + StaticDataMgr.mInstance.mLevelDataMap[i].CurrentLevelNeedExp 
                    && Exp < StaticDataMgr.mInstance.mLevelDataMap[i+1].NextLevelNeedExp + StaticDataMgr.mInstance.mLevelDataMap[i+1].CurrentLevelNeedExp
                    && StaticDataMgr.mInstance.mLevelDataMap[i + 1].NextLevelNeedExp != 0)
                StaticDataMgr.mInstance.mLevelDataMap.TryGetValue(i, out LevelData);
                StaticDataMgr.mInstance.mLevelDataMap.TryGetValue(i + 1, out LevelData);
                if (Exp > LevelData.NextLevelNeedExp + LevelData.CurrentLevelNeedExp && Exp < LevelDataNext.NextLevelNeedExp + LevelDataNext.CurrentLevelNeedExp)
                {
                    return (int)i;
                }
            }
     
            return 0;
        }
    }
}

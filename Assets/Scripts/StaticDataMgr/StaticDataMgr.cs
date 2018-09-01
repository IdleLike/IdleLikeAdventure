using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System;
using StaticData;
using System.Reflection;
using GlobalDefine;
using StaticData.Data;
using UnityEngine;
using StaticDataTool;

namespace StaticData
{
    public class StaticDataMgr
    {
        private static StaticDataMgr instance = null;
        public static StaticDataMgr mInstance
        {
            get
            {
                if (instance == null)
                    instance = new StaticDataMgr();
                return instance;
            }
            protected set { instance = value; }
        }

        // *************				data	 	***************
		//public Dictionary<ushort, AbilityData> mAbilityDataMap = new Dictionary<ushort, AbilityData>(); //Ability Data
        public Dictionary<uint, CareerData> mCareerDataMap = new Dictionary<uint, CareerData>();
        public Dictionary<uint, CareerAbilityData> mCareerAbilityDataMap = new Dictionary<uint, CareerAbilityData>();
        public Dictionary<uint, LevelData> mLevelDataMap = new Dictionary<uint, LevelData>();
        public Dictionary<string, MultilingualData> mMultilingualDataMap = new Dictionary<string, MultilingualData>();
        public Dictionary<uint, RaceAbilityData> mRaceAbilityDataMap = new Dictionary<uint, RaceAbilityData>();
        public Dictionary<uint, RaceData> mRaceDataMap = new Dictionary<uint, RaceData>();


        //加载数据
        public void LoadData()
        {
            #region 测试数据
            foreach (var item in TestStaticData.Instance.CareerAbilityDatas)
            {
                mCareerAbilityDataMap.Add(item.ID, item);
            }
            foreach (var item in TestStaticData.Instance.CareerDatas)
            {
                mCareerDataMap.Add(item.ID, item);
            }
            foreach (var item in TestStaticData.Instance.LevelDatas)
            {
                mLevelDataMap.Add(item.ID, item);
            }
            foreach (var item in TestStaticData.Instance.MultilingualDatas)
            {
                mMultilingualDataMap.Add(item.ID, item);
            }
            foreach (var item in TestStaticData.Instance.RaceAbilityDatas)
            {
                mRaceAbilityDataMap.Add(item.ID, item);
            }
            foreach (var item in TestStaticData.Instance.RaceDatas)
            {
                mRaceDataMap.Add(item.ID, item);
            }
            #endregion






            //定义如型： void SheetNameDataProcess(ClassType data) 的函数, 会被自动调用

            //设置进度
            Console.WriteLine("Read All Data Done!");
        }

        //根据指定的数据文件名，创建流。 参数格式：“Strings.bytes”
        private Stream OpenBinDataFile(string filename)
        {//
			TextAsset binDataAsset = Resources.Load(FolderCfg.BinFolder() + filename.Substring(0, filename.Length - 6)) as TextAsset;
            return FileDes.DecryptDataToStream(binDataAsset.bytes);
        }

        void LoadDataBinWorker<ClassType>(string filename, object dic, Action<ClassType> process = null) where ClassType : BaseDataObject, new()
        {
            Dictionary<uint, ClassType> dataMap = dic as Dictionary<uint, ClassType>;

            BinaryReader br = null;
            Stream ds = OpenBinDataFile(filename);
            br = new BinaryReader(ds);
            try
            {
                while (true)
                {
                    ClassType tNewData = new ClassType();
                    tNewData.ReadFromStream(br);
                    dataMap.Add(tNewData.ID, tNewData);
                    if (process != null)
                    {
                        process(tNewData);
                    }
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine(filename + "Load Data Done");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                br.Close();
                FileDes.CloseStream();
            }
            return;
        }
    }//class
    //数据结构基类
    public abstract class BaseDataObject
    {
        public uint ID = 0; // ID
        public abstract void ReadFromStream(BinaryReader br);
    }
    
  /*  public class StringMgr
    {
        enum ELanguage
        {
            English,
            S_Chinese,
            T_Chinese
        }
        static bool mInitialized = false;
        static ELanguage mLanguage = ELanguage.English;
        static void Initialize()
        {
            mInitialized = true;
            if(Application.systemLanguage == SystemLanguage.ChineseSimplified)
                mLanguage = ELanguage.S_Chinese;
            else if(Application.systemLanguage == SystemLanguage.ChineseTraditional)
                mLanguage = ELanguage.T_Chinese;
            else
                mLanguage = ELanguage.English;
        }
        //查找字符串数据
        public static string Get(ushort strID)
        {
            if(mInitialized == false)
                Initialize();
            if(StaticDataMgr.mInstance.mStringsDataMap.ContainsKey(strID) == false)
                return "";
            return StaticDataMgr.mInstance.mStringsDataMap[strID].mStrings[(int)mLanguage];
        }
        public static bool IsChinese
        {
            get{
                if(mInitialized == false)
                    Initialize();
                return (mLanguage == ELanguage.S_Chinese || mLanguage == ELanguage.T_Chinese);
            }
        }
    }
*/
}



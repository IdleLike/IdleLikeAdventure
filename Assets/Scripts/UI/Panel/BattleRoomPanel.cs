using SUIFW;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panel
{
    public class BattleRoomModel
    {
        public struct BattleCharacterModel
        {
            /// <summary>
            /// 角色ID
            /// </summary>
            public byte ID;
            /// <summary>
            /// 角色名称
            /// </summary>
            public string Name;
            /// <summary>
            /// 角色种族
            /// </summary>
            public string RocaName;
            /// <summary>
            /// 角色职业
            /// </summary>
            public string Career;
            /// <summary>
            /// 角色等级
            /// </summary>
            public byte Level;
            /// <summary>
            /// 角色血量
            /// </summary>
            public ushort CurrentHP;
            /// <summary>
            /// 角色最大血量
            /// </summary>
            public ushort MaxHP;
        }
        public struct BattleEnemyModel
        {
            /// <summary>
            /// 敌人ID
            /// </summary>
            public byte ID;
            /// <summary>
            /// 敌人名称
            /// </summary>
            public string Name;
            /// <summary>
            /// 敌人等级
            /// </summary>
            public ushort Level;
            /// <summary>
            /// 敌人血量
            /// </summary>
            public ushort HP;
            /// <summary>
            /// 敌人技能悬停显示
            /// </summary>
            public Image Ability_Img;
            /// <summary>
            /// 技能回调
            /// </summary>
            public Action<string> AbilityCallback;
        }
        public struct BattleReportModel
        {
            public ushort damage;
            public byte Attacker;
            public byte AnAttacker;
            public uint AbilityID;
            public string ReportType;
            public ushort ReportID;
        }

        /// <summary>
        /// 地图名称
        /// </summary>
        public string MapName;
        /// <summary>
        /// 房间名称
        /// </summary>
        public string RoomName;


        /// <summary>
        /// 角色集合
        /// </summary>
        public List<BattleCharacterModel> characterList { get; set; }
        /// <summary>
        /// 敌人集合
        /// </summary>
        public List<BattleEnemyModel> enemyList { get; set; }
        /// <summary>
        /// 战报集合
        /// </summary>
        public Stack<BattleReportModel> reportStack { get; set; }
    }
    public class BattleRoomPanel : BaseUIForm
    {
        #region
        ///// <summary>
        ///// 角色一名称
        ///// </summary>
        //public Text CharacterOneName_Txt;
        ///// <summary>
        ///// 角色一种族
        ///// </summary>
        //public Text CharacterOneRocaName_Txt;
        ///// <summary>
        ///// 角色一职业
        ///// </summary>
        //public Text CharacterOneCareer_Txt;
        ///// <summary>
        ///// 角色一等级
        ///// </summary>
        //public Text CharacterOneLevel_Txt;
        ///// <summary>
        ///// 角色一血量
        ///// </summary>
        //public Text CharacterOneHP_Txt;
        ///// <summary>
        ///// 角色一血条
        ///// </summary>
        //public Slider CharacterOneHP_Sli;
        ///// <summary>
        ///// 角色一蓝条
        ///// </summary>
        //public Slider CharacterOneMP_Sli;

        ///// <summary>
        ///// 角色二名称
        ///// </summary>
        //public Text CharacterTwoName_Txt;
        ///// <summary>
        ///// 角色二种族
        ///// </summary>
        //public Text CharacterTwoRocaName_Txt;
        ///// <summary>
        ///// 角色二职业
        ///// </summary>
        //public Text CharacterTwoCareer_Txt;
        ///// <summary>
        ///// 角色二等级
        ///// </summary>
        //public Text CharacterTwoLevel_Txt;
        ///// <summary>
        ///// 角色二血量
        ///// </summary>
        //public Text CharacterTwoHP_Txt;
        ///// <summary>
        ///// 角色二血条
        ///// </summary>
        //public Slider CharacterTwoHP_Sli;
        ///// <summary>
        ///// 角色二蓝条
        ///// </summary>
        //public Slider CharacterTwoMP_Sli;

        ///// <summary>
        ///// 角色三名称
        ///// </summary>
        //public Text CharacterThreeName_Txt;
        ///// <summary>
        ///// 角色三种族
        ///// </summary>
        //public Text CharacterThreeRocaName_Txt;
        ///// <summary>
        ///// 角色三职业
        ///// </summary>
        //public Text CharacterThreeCareer_Txt;
        ///// <summary>
        ///// 角色三等级
        ///// </summary>
        //public Text CharacterThreeLevel_Txt;
        ///// <summary>
        ///// 角色三血量
        ///// </summary>
        //public Text CharacterThreeHP_Txt;
        ///// <summary>
        ///// 角色三血条
        ///// </summary>
        //public Slider CharacterThreeHP_Sli;
        ///// <summary>
        ///// 角色三蓝条
        ///// </summary>
        //public Slider CharacterThreeMP_Sli;

        ///// <summary>
        ///// 敌人一名称
        ///// </summary>
        //public Text EnemyOneName_Txt;
        ///// <summary>
        ///// 敌人一等级
        ///// </summary>
        //public Text EnemyOneLevel_Txt;
        ///// <summary>
        ///// 敌人一血量
        ///// </summary>
        //public Text EnemyOneHP_Txt;
        ///// <summary>
        ///// 敌人一血条
        ///// </summary>
        //public Slider EnemyOneHP_Sli;
        ///// <summary>
        ///// 敌人一技能悬停显示
        ///// </summary>
        //public Image EnemyOneAbility_Img;

        ///// <summary>
        ///// 敌人二名称
        ///// </summary>
        //public Text EnemyTwoName_Txt;
        ///// <summary>
        ///// 敌人二等级
        ///// </summary>
        //public Text EnemyTwoLevel_Txt;
        ///// <summary>
        ///// 敌人二血量
        ///// </summary>
        //public Text EnemyTwoHP_Txt;
        ///// <summary>
        ///// 敌人二血条
        ///// </summary>
        //public Slider EnemyTwoHP_Sli;
        ///// <summary>
        ///// 敌人二技能悬停显示
        ///// </summary>
        //public Image EnemyTwoAbility_Img;

        ///// <summary>
        ///// 敌人三名称
        ///// </summary>
        //public Text EnemyThreeName_Txt;
        ///// <summary>
        ///// 敌人三等级
        ///// </summary>
        //public Text EnemyThreeLevel_Txt;
        ///// <summary>
        ///// 敌人三血量
        ///// </summary>
        //public Text EnemyThreeHP_Txt;
        ///// <summary>
        ///// 敌人三血条
        ///// </summary>
        //public Slider EnemyThreeHP_Sli;
        ///// <summary>
        ///// 敌人三技能悬停显示
        ///// </summary>
        //public Image EnemyThreeAbility_Img;
        #endregion

        /// <summary>
        /// 地图名称
        /// </summary>
        public Text MapName_Txt;
        /// <summary>
        /// 房间名称
        /// </summary>
        public Text RoomName_Txt;
        /// <summary>
        /// 战报容器(父物体)
        /// </summary>
        public Transform Content_Tra;

        public List<CharacterUIInfo> CharacterUIInfoList;
        [Serializable]
        public class CharacterUIInfo
        {
            /// <summary>
            /// 角色ID
            /// </summary>
            public byte ID;
            /// <summary>
            /// 角色名称
            /// </summary>
            public Text Name_Txt;
            /// <summary>
            /// 角色种族
            /// </summary>
            public Text RocaName_Txt;
            /// <summary>
            /// 角色职业
            /// </summary>
            public Text Career_Txt;
            /// <summary>
            /// 角色等级
            /// </summary>
            public Text Level_Txt;
            /// <summary>
            /// 角色血量
            /// </summary>
            public Text HP_Txt;
            /// <summary>
            /// 角色血量
            /// </summary>
            public Text CurrentHP_Txt;
            /// <summary>
            /// 角色血条
            /// </summary>
            public Slider HP_Sli;
            /// <summary>
            /// 角色蓝条
            /// </summary>
            public Slider MP_Sli;
        }

        public List<EnemyUIInfo> EnemyUIInfoList;
        [Serializable]
        public class EnemyUIInfo
        {
            /// <summary>
            /// 敌人ID
            /// </summary>
            public byte ID;
            /// <summary>
            /// 敌人名称
            /// </summary>
            public Text Name_Txt;
            /// <summary>
            /// 敌人等级
            /// </summary>
            public Text Level_Txt;
            /// <summary>
            /// 敌人血量
            /// </summary>
            public Text HP_Txt;
            /// <summary>
            /// 敌人血条
            /// </summary>
            public Slider HP_Sli;
            ///// <summary>
            ///// 敌人技能悬停显示
            ///// </summary>
            public Image Ability_Img;
        }

        private bool IsInit = false;

        private string m_InfoTemplete = "{0}.{1}攻击了{2}，造成了{4}伤害。";

        /// <summary>
        /// 初始化战斗信息
        /// </summary>
        /// <param name="viewModel"></param>
        private void InitBattleInfo(object viewModel)
        {
            if (viewModel == null)
            {
                return;
            }
            BattleRoomModel BattleModel = (BattleRoomModel)viewModel;
            BattleRoomModel.BattleReportModel CurrentBattleReport;

            if (IsInit)
            {
                if (BattleModel.reportStack != null)
                {
                    CurrentBattleReport = BattleModel.reportStack.Pop();
                    InitReportInfo(BattleModel, CurrentBattleReport);
                }
                //for (int i = 0; i < BattleModel.characterList.Count; i++)
                //{
                //    CharacterUIInfoList[i].HP_Sli.value = 1;
                //    CharacterUIInfoList[i].MP_Sli.value = 1;
                //    CharacterUIInfoList[i].CurrentHP = 1;
                //    CharacterUIInfoList[i].HP_Txt.text = BattleModel.characterList[i].HP.ToString() + "/" + BattleModel.characterList[i].HP.ToString();
                //}
            }
            else
            {
                MapName_Txt.text = BattleModel.MapName;
                RoomName_Txt.text = BattleModel.RoomName;

                InitCharcterInfo(BattleModel);
                InitEnemyInfo(BattleModel);
            }
        }

        private void InitReportInfo(BattleRoomModel battleModel, BattleRoomModel.BattleReportModel CurrentBattleReport)
        {
            Text ReportGo;
            Text Report;
            switch (CurrentBattleReport.ReportType)
            {
                case "Attack":
                    if (Content_Tra != null)
                    {
                        ReportGo = Resources.Load("UI/Battle/AttackReport") as Text;
                        //ReportGo.text = CurrentBattleReport.ReportID.ToString() + ":" + GetAttacker(battleModel, CurrentBattleReport) + "攻击了" + GetAnAttacker(battleModel, CurrentBattleReport);
                        ReportGo.text = string.Format(  m_InfoTemplete, CurrentBattleReport.ReportID, 
                                                        GetAttacker(battleModel, CurrentBattleReport), 
                                                        GetAnAttacker(battleModel, CurrentBattleReport), 
                                                        CurrentBattleReport.damage);
                        //扣血
                        Report = Instantiate(ReportGo);
                        Report.transform.parent = Content_Tra.transform;
                        Report.transform.SetAsFirstSibling();
                    }
                    break;
                case "Result":
                    if (Content_Tra != null)
                    {
                        ReportGo = Resources.Load("UI/Battle/RestReport") as Text;
                        ReportGo.text = CurrentBattleReport.ReportID.ToString() + ":" + GetAttacker(battleModel, CurrentBattleReport) + "攻击了" + GetAnAttacker(battleModel, CurrentBattleReport);
                        Report = Instantiate(ReportGo);
                        Report.transform.parent = Content_Tra.transform;
                    }
                    break;
                case "Rest":
                    if (Content_Tra != null)
                    {
                        ReportGo = Resources.Load("UI/Battle/ResultReport") as Text;
                        ReportGo.text = CurrentBattleReport.ReportID.ToString() + ":" + GetAttacker(battleModel, CurrentBattleReport) + "攻击了" + GetAnAttacker(battleModel, CurrentBattleReport);
                        Report = Instantiate(ReportGo);
                        Report.transform.parent = Content_Tra.transform;
                    }
                    break;
                default:
                    Debug.LogError("战报类型错误:" + CurrentBattleReport.ReportType);
                    break;
            }
        }

        private string GetAnAttacker(BattleRoomModel battleModel, BattleRoomModel.BattleReportModel CurrentBattleReport)
        {
            //BattleRoomModel.BattleCharacterModel CharacterAttacker = battleModel.characterList.Find(c => c.ID == CurrentBattleReport.Attacker);
            //BattleRoomModel.BattleEnemyModel EnemyAttacker = battleModel.enemyList.Find(c => c.ID == CurrentBattleReport.Attacker);
            //return CharacterAttacker.Name ?? EnemyAttacker.Name;

            foreach (var item in battleModel.characterList)
            {
                if (item.ID == CurrentBattleReport.AnAttacker)
                {
                    return item.Name;
                }
            }
            foreach (var item in battleModel.enemyList)
            {
                if (item.ID == CurrentBattleReport.AnAttacker)
                {
                    return item.Name;
                }
            }
            return String.Empty;
        }

        private string GetAttacker(BattleRoomModel battleModel, BattleRoomModel.BattleReportModel CurrentBattleReport)
        {
            foreach (var item in battleModel.characterList)
            {
                if (item.ID == CurrentBattleReport.Attacker)
                {
                    return item.Name;
                }
            }
            foreach (var item in battleModel.enemyList)
            {
                if (item.ID == CurrentBattleReport.Attacker)
                {
                    return item.Name;
                }
            }
            return String.Empty;
        }



        /// <summary>
        /// 角色初始化
        /// </summary>
        /// <param name="model"></param>
        private void InitCharcterInfo(BattleRoomModel model)
        {
            #region
            //CharacterOneName_Txt.text = model.characterList[0].Name;
            //CharacterOneRocaName_Txt.text = model.characterList[0].RocaName;
            //CharacterOneCareer_Txt.text = model.characterList[0].Career;
            //CharacterOneLevel_Txt.text = model.characterList[0].Level.ToString();
            //CharacterOneHP_Txt.text = model.characterList[0].HP.ToString();
            //CharacterOneHP_Sli.value = 1;
            //CharacterOneMP_Sli.value = 1;

            //CharacterTwoName_Txt.text = model.characterList[1].Name;
            //CharacterTwoRocaName_Txt.text = model.characterList[1].RocaName;
            //CharacterTwoCareer_Txt.text = model.characterList[1].Career;
            //CharacterTwoLevel_Txt.text = model.characterList[1].Level.ToString();
            //CharacterTwoHP_Txt.text = model.characterList[1].HP.ToString();
            //CharacterTwoHP_Sli.value = 1;
            //CharacterTwoMP_Sli.value = 1;

            //CharacterThreeName_Txt.text = model.characterList[2].Name;
            //CharacterThreeRocaName_Txt.text = model.characterList[2].RocaName;
            //CharacterThreeCareer_Txt.text = model.characterList[2].Career;
            //CharacterThreeLevel_Txt.text = model.characterList[2].Level.ToString();
            //CharacterThreeHP_Txt.text = model.characterList[2].HP.ToString();
            //CharacterThreeHP_Sli.value = 1;
            //CharacterThreeMP_Sli.value = 1;
            #endregion
            if (model == null || model.characterList.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < model.characterList.Count; i++)
            {
                CharacterUIInfoList[i].Name_Txt.text = model.characterList[i].Name;
                CharacterUIInfoList[i].RocaName_Txt.text = model.characterList[i].RocaName;
                CharacterUIInfoList[i].Career_Txt.text = model.characterList[i].Career;
                CharacterUIInfoList[i].Level_Txt.text = model.characterList[i].Level.ToString();
                CharacterUIInfoList[i].HP_Sli.value = 1;
                CharacterUIInfoList[i].MP_Sli.value = 1;
                CharacterUIInfoList[i].HP_Txt.text = model.characterList[i].CurrentHP.ToString() + "/" + model.characterList[i].MaxHP.ToString();
            }
            IsInit = true;
        }
        /// <summary>
        /// 敌人初始化
        /// </summary>
        /// <param name="model"></param>
        private void InitEnemyInfo(BattleRoomModel model)
        {
            if (model == null || model.enemyList.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < model.enemyList.Count; i++)
            {
                EnemyUIInfoList[i].Name_Txt.text = model.enemyList[i].Name;
                EnemyUIInfoList[i].Level_Txt.text = model.enemyList[i].Level.ToString();
                EnemyUIInfoList[i].HP_Sli.value = 1;
                EnemyUIInfoList[i].HP_Txt.text = model.enemyList[i].HP.ToString() + "/" + model.enemyList[i].HP.ToString();
                EnemyUIInfoList[i].Ability_Img.sprite = model.enemyList[i].Ability_Img.sprite;
            }
            IsInit = true;
        }


        public override void UpdatePanel(object viewModel)
        {
            InitBattleInfo(viewModel);
        }

        public void Test()
        {
            BattleRoomModel battleRoomModel = new BattleRoomModel();

            //赋值数据

            UpdatePanel(battleRoomModel);
        }
    }
}

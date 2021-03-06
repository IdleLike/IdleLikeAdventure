﻿using System;
using System.Collections.Generic;
using UI.Model;
using UnityEngine;
using UnityEngine.SceneManagement;
using Entity;
using UI.Panel;

namespace Service
{
    
    public class UserService : BaseService
    {
        //ViewModel
        private CreateCharacterModel createCharacterModel;
        private BattleRoomModel battleRoomModel;

        internal void Login()
        {
            //是否已经登陆过
            if(GameGlobal.LocalData.UserID == 0)
            {
                //TODO 创建新用户
                //跳转主场景， 显示创建用户界面
                //SceneManager.LoadScene(GameGlobal.SCENE_MAIN);
                //SetCreateCharacterModel();
                //OpenUIForm(GameGlobal.PANEL_CREATECHARACTER, createCharacterModel);
                InitBattle();
                OpenUIForm(GameGlobal.PANEL_BATTLEROOM, battleRoomModel);
            }
            else
            {
                //TODO 登陆老用户
                //加载玩家数据， 跳转主场景， 显示战斗界面
            }
        }

        //  创建角色界面数据
        private void SetCreateCharacterModel()
        {
            if (createCharacterModel == null) createCharacterModel = new CreateCharacterModel();

            if (createCharacterModel.createCharacterViewModels == null) createCharacterModel.createCharacterViewModels = new List<CreateCharacterModel.CreateCharacterViewModel>();

            //初始化所有职业数据
            for (int i = 0; i < TestStaticData.Instance.RaceDatas.Count; i++)
            {
                // 数据赋值
                CreateCharacterModel.CreateCharacterViewModel rocal = new CreateCharacterModel.CreateCharacterViewModel();
                rocal.raceID =  TestStaticData.Instance.RaceDatas[i].ID;
                rocal.raceName = TestStaticData.Instance.RaceDatas[i].Name;
                rocal.raceDes = TestStaticData.Instance.RaceDatas[i].Describe;
                rocal.initCon = TestStaticData.Instance.RaceDatas[i].InitCon;
                rocal.initDex = TestStaticData.Instance.RaceDatas[i].InitDex;
                rocal.initPow = TestStaticData.Instance.RaceDatas[i].InitPow;
                rocal.initHP = TestStaticData.Instance.RaceDatas[i].InitHP;
                rocal.growthCon = TestStaticData.Instance.RaceDatas[i].ConGrowth;
                rocal.growthDex = TestStaticData.Instance.RaceDatas[i].DexGrowth;
                rocal.growthPow = TestStaticData.Instance.RaceDatas[i].PowGrowth;
                rocal.growthHP = TestStaticData.Instance.RaceDatas[i].HPGrowth;
                rocal.raceAbilityOne = TestStaticData.Instance.RaceDatas[i].AbilityOneID;
                rocal.raceAbilityTwo = TestStaticData.Instance.RaceDatas[i].AbilityTwoID;
                createCharacterModel.createCharacterViewModels.Add(rocal);
            }

            //初始化所有委托
            createCharacterModel.CreateCharacterCallback = Create;
            createCharacterModel.NameIsRepeatCallback = CheckNameRepeat;
        }

        //  创建用户
        private void Create(CreateCharacterPanel.CreateData obj)
        {
            //创建用户， 想数据库填入用户数据

            //为用户创建英雄

            //跳转页面

        }


        // 检测用户名是否重复
        private bool CheckNameRepeat(string name)
        {
            return TestDB.Instance.Users.Find(p=>p.Name == name) == null;
        }


        private void InitBattle()
        {
            if (battleRoomModel == null) battleRoomModel = new BattleRoomModel();

            if (battleRoomModel.characterList == null) battleRoomModel.characterList = new List<BattleRoomModel.BattleCharacterModel>();
            if (battleRoomModel.enemyList == null) battleRoomModel.enemyList = new List<BattleRoomModel.BattleEnemyModel>();
            if (battleRoomModel.ReportQueue == null) battleRoomModel.ReportQueue = new Queue<BattleRoomModel.BattleReportModel>();

            for (int i = 0; i < TestStaticData.Instance.BattleCharacterModel.Count; i++)
            {
                BattleRoomModel.BattleCharacterModel model = new BattleRoomModel.BattleCharacterModel();
                model.ID = TestStaticData.Instance.BattleCharacterModel[i].ID;
                model.Name = TestStaticData.Instance.BattleCharacterModel[i].Name;
                model.RocaName = TestStaticData.Instance.BattleCharacterModel[i].RocaName;
                model.Career = TestStaticData.Instance.BattleCharacterModel[i].Career;
                model.Level = TestStaticData.Instance.BattleCharacterModel[i].Level;
                model.CurrentHP = TestStaticData.Instance.BattleCharacterModel[i].CurrentHP;
                model.MaxHP = TestStaticData.Instance.BattleCharacterModel[i].MaxHP;
                model.MaxMP_Txt = TestStaticData.Instance.BattleCharacterModel[i].MaxMP_Txt;
                model.CurrentMP_Txt = TestStaticData.Instance.BattleCharacterModel[i].CurrentMP_Txt;
                battleRoomModel.characterList.Add(model);
            }
            for (int i = 0; i < TestStaticData.Instance.BattleEnemyModel.Count; i++)
            {
                BattleRoomModel.BattleEnemyModel model = new BattleRoomModel.BattleEnemyModel();
                model.ID = TestStaticData.Instance.BattleEnemyModel[i].ID;
                model.Name = TestStaticData.Instance.BattleEnemyModel[i].Name;
                model.Level = TestStaticData.Instance.BattleEnemyModel[i].Level;
                model.CurrentHP = TestStaticData.Instance.BattleEnemyModel[i].CurrentHP;
                model.MaxHP = TestStaticData.Instance.BattleEnemyModel[i].MaxHP;
                model.Ability_sprite = TestStaticData.Instance.BattleEnemyModel[i].Ability_sprite;
                battleRoomModel.enemyList.Add(model);
            }
            for (int i = 0; i < TestStaticData.Instance.BattleReportModel.Count; i++)
            {
                BattleRoomModel.BattleReportModel model = new BattleRoomModel.BattleReportModel();
                model.DerateDamage = TestStaticData.Instance.BattleReportModel[i].DerateDamage;
                model.Attacker = TestStaticData.Instance.BattleReportModel[i].Attacker;
                model.AnAttacker = TestStaticData.Instance.BattleReportModel[i].AnAttacker;
                model.AbilityName = TestStaticData.Instance.BattleReportModel[i].AbilityName;
                model.ReportType = TestStaticData.Instance.BattleReportModel[i].ReportType;
                model.ReportNum = TestStaticData.Instance.BattleReportModel[i].ReportNum;
                model.IsAOE = TestStaticData.Instance.BattleReportModel[i].IsAOE;
                model.Gold = TestStaticData.Instance.BattleReportModel[i].Gold;
                model.Damage = TestStaticData.Instance.BattleReportModel[i].Damage;
                model.RestCountdown = TestStaticData.Instance.BattleReportModel[i].RestCountdown;

                model.TeamName = TestStaticData.Instance.BattleReportModel[i].TeamName;
                //model.AdditionalEntry = TestStaticData.Instance.BattleReportModel[i].AdditionalEntry;
                model.AttackHandleType = TestStaticData.Instance.BattleReportModel[i].AttackHandleType;
                model.AOEType = TestStaticData.Instance.BattleReportModel[i].AOEType;
                model.IsSussces = TestStaticData.Instance.BattleReportModel[i].IsSussces;
                model.BuffList = TestStaticData.Instance.BattleReportModel[i].BuffList;
                model.EquipmentList = TestStaticData.Instance.BattleReportModel[i].EquipmentList;
                model.Recovery = TestStaticData.Instance.BattleReportModel[i].Recovery;
                model.EXP = TestStaticData.Instance.BattleReportModel[i].EXP;
                model.IsDerateDamage = TestStaticData.Instance.BattleReportModel[i].IsDerateDamage;
                model.IsGroupAttack = TestStaticData.Instance.BattleReportModel[i].IsGroupAttack;
                battleRoomModel.ReportQueue.Enqueue(model);
            }

        }
    }
}


using System;
using System.Collections.Generic;
using UI.Model;
using UnityEngine;
using UnityEngine.SceneManagement;
using Entity;

namespace Service
{
    
    public class UserService : BaseService
    {
        //ViewModel
        private CreateCharacterModel createCharacterModel;

        internal void Login()
        {
            //是否已经登陆过
            if(GameGlobal.LocalData.UserID == 0)
            {
                //TODO 创建新用户
                //跳转主场景， 显示创建用户界面
                //SceneManager.LoadScene(GameGlobal.SCENE_MAIN);
                SetCreateCharacterModel();
                OpenUIForm(GameGlobal.PANEL_CREATECHARACTER, createCharacterModel);
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
            //创建用户
            //初始化数据
            //跳转页面
        }


        // 检测用户名是否重复
        private bool CheckNameRepeat(string name)
        {
            return TestDB.Instance.Users.Find(p=>p.Name == name) == null;
        }
    }
}


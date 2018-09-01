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
                SceneManager.LoadScene(GameGlobal.SCENE_MAIN);
                SetCreateCharacterModel();
                OpenUIForm(GameGlobal.PANEL_CREATECHARACTER, createCharacterModel);
            }
            else
            {
                //TODO 登陆老用户
                //加载玩家数据， 跳转主场景， 显示战斗界面
            }
        }

        private void SetCreateCharacterModel()
        {
            if (createCharacterModel == null) createCharacterModel = new CreateCharacterModel();

            if (createCharacterModel.createCharacterViewModels == null) createCharacterModel.createCharacterViewModels = new List<CreateCharacterModel.CreateCharacterViewModel>();

            for (int i = 0; i < TestStaticData.Instance.RaceDatas.Count; i++)
            {
                CreateCharacterModel.CreateCharacterViewModel rocal = new CreateCharacterModel.CreateCharacterViewModel();
                rocal.raceID = TestStaticData.Instance.RaceDatas[i].ID;
                rocal.raceName = TestStaticData.Instance.RaceDatas[i].Name;
                rocal.raceDes = TestStaticData.Instance.RaceDatas[i].Describe;



            }
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        private void Create()
        {
            
        }

        /// <summary>
        /// 检测用户名是否重复
        /// </summary>
        /// <returns><c>true</c>, if name repeat was checked, <c>false</c> otherwise.</returns>
        /// <param name="name">Name.</param>
        private bool CheckNameRepeat(string name)
        {
            return TestDB.Instance.Users.Find(p=>p.Name == name) == null;
        }
    }
}


using System;
using UI.Model;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                OpenUIForm("", createCharacterModel);
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


        }
    }
}


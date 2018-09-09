﻿using System.Collections;
using System.Collections.Generic;
using Entity;
using UnityEngine;

namespace Service
{
    public class ActorService : BaseService
    {
        /// <summary>
        /// 创建英雄
        /// </summary>
        /// <param name="userID">User identifier.</param>
        /// <param name="heroConfigID">Hero config identifier.</param>
        /// <param name="heroName">Hero name.</param>
        public HeroEntity CreateHero(int userID, uint rocaID, uint careerID, string heroName)
        {
            //TODO 为玩家创建英雄
            return null;   
        }
    }
}


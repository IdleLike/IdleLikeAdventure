using System;

namespace Service
{
    public class GameService : ClassSingleton<GameService>
    {
        private BaseService userService;                //用户服务
        private BaseService actorService;               //角色服务

        public void Initialize()
        {
            //初始化所有服务类
            userService = new UserService();
            actorService = new ActorService();
        }
    }
}


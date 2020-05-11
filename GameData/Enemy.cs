using System;

namespace RPGGame.GameData
{
    public sealed class Enemy
    {
        private static Enemy instance = null;
        private static readonly object enemylock = new object();
        
        public string EnemyName { get; set; }

        Enemy()
        {
            EnemyName = "none";
        }

        public static Enemy Instance
        {
            get
            {
                lock (enemylock)
                {
                    if (instance == null)
                    {
                        instance = new Enemy();
                    }
                    return instance;
                }

            }
        }
    }
}

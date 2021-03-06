﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.GameData
{
    public sealed class PlayerData
    {
        private static PlayerData instance = null;
        private static readonly object playerlock = new object();

        public int PlayerStrength { get; set; }
        public int PlayerWisdom { get; set; }
        public int PlayerIntelligence { get; set; }
        public int PlayerSpeed { get; set; }
        public int PlayerMaxHp { get; set; }
        public int PlayerCurrentHp { get; set; }
        public string RightHandEquipment { get; set; }
        public string LeftHandEquipment { get; set; }
        public string HeadEquipment { get; set; }
        public int StatPoints { get; set; }

        PlayerData()
        {
            PlayerStrength = 1;
            PlayerWisdom = 1;
            PlayerIntelligence = 1;
            PlayerSpeed = 1;
            PlayerMaxHp = 20;
            PlayerCurrentHp = 20;
            RightHandEquipment = "Unequipped";
            LeftHandEquipment = "Unequipped";
            HeadEquipment = "Unequipped";
            StatPoints = 4;
        }

        public static PlayerData Instance
        {
            get
            {
                lock (playerlock)
                {
                    if (instance == null)
                    {
                        instance = new PlayerData();
                    }
                    return instance;
                }

            }
        }
    }
}

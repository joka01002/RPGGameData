using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RPGGame.GameData
{
    public class FoundItem
    {
        public FoundItem(string name, ItemTypes.ItemType type)
        {
            Name = name;
            Type = type;
        }
        public string Name { get; set; }
        public ItemTypes.ItemType Type { get; set; }
    }

    public sealed class Inventory
    {
        private static Inventory instance = null;
        private static readonly object inventorylock = new object();

        public List<FoundItem> MyInventory = new List<FoundItem> { new FoundItem("Unequipped", ItemTypes.ItemType.RightHand), 
                                                                   new FoundItem("Unequipped", ItemTypes.ItemType.LeftHand),
                                                                   new FoundItem("Unequipped", ItemTypes.ItemType.Head) };

        Inventory()
        {

        }

        public static Inventory Instance
        {
            get
            {
                lock (inventorylock)
                {
                    if (instance == null)
                    {
                        instance = new Inventory();
                    }
                    return instance;
                }

            }
        }
    }
}

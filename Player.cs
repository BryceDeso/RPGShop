using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;

        public Player()
        {
            _gold = 100;
            _inventory = new Item[3];
        }

        //Returns player gold amount
        public int GetGold()
        {
            return _gold;
        }

        //Returns player inventory.
        public Item[] GetInventory()
        {
            return _inventory;
        }

        public bool Buy(Item item, int inventoryIndex)
        {
            if(_gold >= item.cost)
            {
                _gold -= item.cost;
                _inventory[inventoryIndex] = item;
                return true;
            }
            return false;
        }
    }
}

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
            _gold = 255;
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

        public bool Buy(Item item, int index)
        {
            if(_gold > item.cost)
            {

            }
        }
    }
}

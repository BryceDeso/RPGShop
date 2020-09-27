using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int _gold;
        private Item[] _inventory;

        public Shop()
        {
            _gold = 100;
            _inventory = new Item[3];
        }

        public Shop(Item[] items)
        {
            _gold = 100;
            _inventory = new Item[3];
            _inventory = items;          
        }

        public bool Sell(Player player, int itemIndex, int playerIndex)
        {
            Item itemToBuy = _inventory[itemIndex];
            if(player.Buy(itemToBuy, playerIndex))
            {
                _gold += itemToBuy.cost;
                return true;
            }
            return false;
        }

    }
}

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
            _gold = 0;
            _inventory = new Item[3];
        }

        public Shop(Item[] item)
        {
            _gold = 0;
            _inventory = new Item[3];           
        }

        public void CheckPlayerFunds(Player player)
        {
            if(player.GetGold > cost)
            {

            }
        }

        public bool Sell(Player player, int shopindex, int playerindex)
        {
            return player.Buy(_inventory[shopindex], playerindex);
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }

    }
}

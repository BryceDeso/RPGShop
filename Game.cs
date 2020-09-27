using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Item
    {
        public int cost;
        public string name;
    }

    class Game
    {
        private Player _player;
        private Shop _shop;
        private bool _gameOver;
        private Item[] _shopInventory;
        private Item _arrow;
        private Item _shield;
        private Item _gem;

        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            _gameOver = false;
            _player = new Player();
            InitItems();
            _shopInventory = new Item[] { _arrow, _shield, _gem };
            _shop = new Shop(_shopInventory);
        }

        //Repeated until the game ends
        public void Update()
        {
            OpenShopMenu();
        }
        
        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thank you for your business!");
        }

        public void PrintInventory(Item[] inventory)
        {
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + "\nCost: " + inventory[i].cost);
            }
        }

        private void OpenShopMenu()
        {
            Console.WriteLine("Welcome to my shop! What can I offer you today?");
            PrintInventory(_shopInventory);

            char input = ' ';
            input = Console.ReadKey().KeyChar;

            int itemIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        itemIndex = 0;
                        break;
                    }
                case '2':
                    {
                        itemIndex = 1;
                        break;
                    }
                case '3':
                    {
                        itemIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            if(_player.GetGold() < _shopInventory[itemIndex].cost)
            {
                Console.WriteLine("You cannot afford this item.");
                return;
            }

            Console.WriteLine("Choose a slot to replace.");
            PrintInventory(_player.GetInventory());

            input = Console.ReadKey().KeyChar;

            int playerIndex = -1;
            switch(input)
            {
                case '1':
                    {
                        playerIndex = 0;
                        break;
                    }
                case '2':
                    {
                        playerIndex = 1;
                        break;
                    }
                case '3':
                    {
                        playerIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            _shop.Sell(_player, itemIndex, playerIndex);

        }

        private void InitItems()
        {
            _arrow.name = "Arrow";
            _shield.name = "Shield";
            _gem.name = "Mana Gem";
            _arrow.cost = 5;
            _shield.cost = 50;
            _gem.cost = 100;
        }
        
    }
}

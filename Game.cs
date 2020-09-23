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
        private Player _player = new Player();
        private Shop _shop = new Shop();
        private bool _gameOver = false;
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
            InitItems();
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
                Console.WriteLine(i + ". " + inventory[i].name + "\nCost: " + inventory[i].cost);
            }
        }

        private void OpenShopMenu()
        {
            PrintInventory(_shop.GetInventory());
            
            char input = ' ';
            input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    {
                        _shop.Sell(_player, 0, 0);
                        break;
                    }
                case '2':
                    {
                        _shop.Sell(_player, 1, 1);
                        break;
                    }
                case '3':
                    {
                        _shop.Sell(_player, 2, 2);
                        break;
                    }
            }

            PrintInventory(_player.GetInventory());

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

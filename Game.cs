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

        public Item PrintInventory(Item[])
        {
            Item[] inventory = { _arrow, _shield, _gem };

            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine(i + ". " + inventory[i].name + "\nCost: " + inventory[i].cost);
            }
        }

        private void OpenShopMenu()
        {
            PrintInventory();
            
            char input = ' ';
            input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    {

                        break;
                    }
                case '2':
                    {

                        break;
                    }
                case '3':
                    {

                        break;
                    }
            }
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

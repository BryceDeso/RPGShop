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
        private Shop _shop = new Shop();
        private Player _player = new Player();
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

        public Item PrintInventory(Item[] player)
        {
            for(int i = 0; i < 3; i++)
            {

            }
        }

        private void OpenShopMenu()
        {

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

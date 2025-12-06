using System;

namespace ConsoleApp5
{
    internal class Money
    {
        /*3 завдання*/
        private int _money;
        private int _coins;

        private void SetValue(int money, int coins)
        {
            _money = money;
            _coins = coins;
            Diapazon();
        }

        public Money(int money = 0, int coins = 0)
        {
            SetValue(money, coins);
        }

        private void Diapazon()
        {
            if (_coins >= 100)
            {
                
                _money = _money + (_coins / 100);

               
                _coins = _coins - (_coins / 100 * 100);

            }
            else if (_coins < 0)
            {
                _money -= 1;
                _coins = _coins + 100;
            }
        }

        public void Decrease(int w, int c)
        {
            _money = _money - w;
            _coins = _coins - c;
            Diapazon();
        }

        public void Print()
        {
            Console.WriteLine($"{_money} грн {_coins:D2} коп");
        }

        public override string ToString()
        {
            return $"{_money} грн {_coins:D2} коп";
        }
    }
}
